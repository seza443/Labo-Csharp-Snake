using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace snake
{
    /// <summary>
    /// Classe gérant la logique du jeu
    /// </summary>
    public class Jeu
    {
        private Joueur joueur;
        private bool running = false;
        private bool perdu = false;
        private int difficulte = 1;
        private List<PartieSerpent> corpsSerpent;
        private Nourriture nourriture;
        private int fruitsManges;
        private Minuteur timerGenererNourriture;
        private int deplacement = 0; //0 = droite; 1 = gauche; 2 = haut; 3 = bas
        private Minuteur timerRafraichissement;

        public Nourriture Nourriture
        {
            get { return nourriture; }
            set { nourriture = value; }
        }
        

        public List<PartieSerpent> CorpsSerpent
        {
            get { return corpsSerpent; }
        }

        public Minuteur Timer
        {
            get { return timerRafraichissement; }
            set { timerRafraichissement = value; }
        }

        public int Difficulte
        {
            get { return difficulte; }
            set 
            { 
                difficulte = value;
                timerRafraichissement.Timer = (21 - 2 * difficulte) * 10;
                timerGenererNourriture.Timer = timerRafraichissement.Timer * 50;
            }
        }

        /// <summary>
        /// Constructeur par défaut
        /// Instancie un Joueur avec le nom par défaut Joueur1
        /// Instancie et initialise un objet Timer pour le raffraichissement du fruit
        /// </summary>
        public Jeu()
        {
            joueur = new Joueur("Joueur1");
            timerGenererNourriture = new Minuteur(new ElapsedEventHandler(genererNourriture));
        }

        /// <summary>
        /// Instancie un nouveau joueur avec le nom reçu en paramètre
        /// </summary>
        /// <param name="nomJoueur">Nom du joueur</param>
        /// <returns>True si le nom est valide
        /// False sinon</returns>
        public bool initialiserNom(String nomJoueur)
        {
            nomJoueur = nomJoueur.Trim();
            if (nomJoueur == null || nomJoueur.Equals(""))
            {
                return false;
            }
            else
            {
                joueur = new Joueur(nomJoueur);
                return true;
            }
        }

        /// <summary>
        /// Initialise le timer de raffraichissement de la fenetre.
        /// Cette méthode doit être appelée avant la méthode start()
        /// </summary>
        /// <param name="c">Le controleur doit etre fourni en paramètre et doit contenir une méthode appelée timerEcoule
        /// permettant de réagir lorsque le Timer de raffraichissement atteindra 0</param>
        public void initialiserTimerRafraichissement(Controleur c)
        {
            timerRafraichissement = new Minuteur(new ElapsedEventHandler(c.timerEcoule));
        }

        /// <summary>
        /// Méthode appelée lorsqu'un raffraichissement de la fenetre doit etre effectué.
        /// Cette méthode déplace le serpent et valide la nouvelle position et fais grandir le serpent si un fruit est rencontré
        /// </summary>
        /// <returns>True si la nouvelle position du serpent est valide
        /// False sinon</returns>
        public bool update()
        {
            mettreEnPause();
            deplacerSerpent();

            if (sePrendUnMur())
            {
                gameOver();
                return false;
            }
            if (seMangeLuiMeme())
            {
                gameOver();
                return false;
            }
            if (mangeUnFruit())
            {
                genererNourriture(null, null);
                serpentGrandit();
                joueurGagneDesPoints();
                fruitsManges++;
            }
            reprendre();
            return true;
        }

        /// <summary>
        /// Méthode de démarrage d'un nouveau jeu.
        /// Cette méthode initialise le corps du serpent avec un seul élément par défault (placé au centre de la fenêtre).
        /// Cette méthode initialise le nombre de fruits mangés, le score du joueur et démarre les Timer's
        /// Cette méthode n'initialise pas un nouveau joueur.
        /// </summary>
        public void start()
        {
            corpsSerpent = new List<PartieSerpent>();
            corpsSerpent.Add(new PartieSerpent(254, 190));
            this.running = true;
            this.perdu = false;
            timerRafraichissement.start();
            timerGenererNourriture.start();
            genererNourriture(null, null);
            fruitsManges = 0;
            joueur.Score = 0;
        }

        /// <summary>
        /// Permet de savoir si le jeu est en cours ou s'il est en pause
        /// </summary>
        /// <returns>True si le jeu est en cours
        /// False si le jeu est en pause</returns>
        private bool isRunning()
        {
            return this.running;
        }

        /// <summary>
        /// Met le jeu en pause en stoppant les Timer's
        /// </summary>
        private void mettreEnPause()
        { 
            this.timerRafraichissement.stop();
            timerGenererNourriture.stop();
            this.running = false;
        }

        /// <summary>
        /// Redémarre les Timer's
        /// </summary>
        private void reprendre()
        {
            this.running = true;
            this.timerRafraichissement.start();
            timerGenererNourriture.start();
        }

        /// <summary>
        /// Méthode de réaction à l'appui sur une touche
        /// </summary>
        /// <param name="e">La touche pressée</param>
        /// <param name="c">Le controleur (nécessaire ici car on risque de devoir mettre le jeu en pause, de redessiner la fenetre,...</param>
        public void keyPressed(KeyEventArgs e, Controleur c)
        {
            switch (e.KeyValue)
            {
                case 27: //touche ESC
                    if (isRunning() && !perdu)
                    {
                        mettreEnPause();
                        c.mettreEnPause();
                    }
                    else if (!perdu)
                    {
                        reprendre();
                        c.reprendre();
                    }
                    break;
                case 38: //touche UP
                    if (deplacement != 3)
                        deplacement = 2;
                    break;
                case 40: //touche DOWN
                    if (deplacement != 2)
                        deplacement = 3;
                    break;
                case 37: //touche LEFT
                    if (deplacement != 0)
                        deplacement = 1;
                    break;
                case 39: //touche RIGHT
                    if (deplacement != 1)
                        deplacement = 0;
                    break;
            }
        }

        /// <summary>
        /// Déplace le serpent en supprimant l'élément de queue et en ajoutant un élément de tête.
        /// </summary>
        public void deplacerSerpent()
        {
            int indice_queue = corpsSerpent.Count - 1;
            PartieSerpent partieBougee = new PartieSerpent(corpsSerpent[0]);
            corpsSerpent.RemoveAt(indice_queue);
            corpsSerpent.Insert(0, partieBougee);
            
            switch (deplacement) 
            {
                case 0: //droite
                    corpsSerpent[0].deplacer(12, 0);
                    break;
                case 1: //gauche
                    corpsSerpent[0].deplacer(-12, 0);
                    break;
                case 2: //haut
                    corpsSerpent[0].deplacer(0, -12); //en principe c'est +12 MAIS je ne sais pas pourquoi, le haut et le bas semble inversé ><
                    break;
                case 3: //bas
                    corpsSerpent[0].deplacer(0, 12);
                    break;
            }
        }

        /// <summary>
        /// Incrémente le score du joueur selon la difficulté actuelle du jeu.
        /// </summary>
        private void joueurGagneDesPoints()
        {
            joueur.Score += difficulte; //le score dépend de la difficulté
        }

        /// <summary>
        /// Ajoute un élément en queue du serpent
        /// </summary>
        private void serpentGrandit()
        {
            PartieSerpent queue = new PartieSerpent(corpsSerpent[corpsSerpent.Count - 1]);
            corpsSerpent.Add(queue);
        }

        /// <summary>
        /// Stoppe le jeu
        /// </summary>
        private void gameOver()
        {
            mettreEnPause();
            this.perdu = true;
        }

        /// <summary>
        /// Permet de vérifier si le serpent rencontre un fruit ou pas
        /// </summary>
        /// <returns>True si un fruit est rencontré
        /// False sinon</returns>
        private bool mangeUnFruit()
        {
            int xSerpent = corpsSerpent[0].Coordonnees.X;
            int ySerpent = corpsSerpent[0].Coordonnees.Y;
            int tailleZoneCollision = 10;

            int xFruit = nourriture.Coordonnees.X;
            int yFruit = nourriture.Coordonnees.Y;

            if ((xSerpent + tailleZoneCollision) >= xFruit && xSerpent <= (xFruit + tailleZoneCollision))
            {
                //axe des X ok
                if ((ySerpent + tailleZoneCollision) >= yFruit && ySerpent <= (yFruit + tailleZoneCollision))
                {
                    //axe des Y OK
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Permet de vérifier si le serpent rencontre un mur ou pas
        /// </summary>
        /// <returns>True si le serpent rencontre un mur
        /// False sinon</returns>
        private bool sePrendUnMur() 
        {
            int x = corpsSerpent[0].Coordonnees.X;
            int y = corpsSerpent[0].Coordonnees.Y;

            if (x < 0 || y < 0 || x > 512 || y > 384)
                return true;
            else return false;
        }

        /// <summary>
        /// Permet de vérifier si le serpent se mange lui même ou pas
        /// </summary>
        /// <returns>True si le serpent se mange lui même
        /// False sinon</returns>
        private bool seMangeLuiMeme()
        {
            PartieSerpent tete = corpsSerpent[0];
            foreach (PartieSerpent item in corpsSerpent)
            {
                if (item != tete)
                {
                    if (item.Coordonnees.X == tete.Coordonnees.X && item.Coordonnees.Y == tete.Coordonnees.Y)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Affecte une position aléatoire à la nourriture et la crée si elle n'existe pas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genererNourriture(object sender, ElapsedEventArgs e)
        {
            if (nourriture == null)
            {
                nourriture = new Nourriture();
            }
            nourriture.randomPosition(500,370);
        }

        /// <summary>
        /// Retourne le nombre de fruits mangés pendant la partie
        /// </summary>
        /// <returns></returns>
        public int getFruitsManges() {
            return fruitsManges;
        }

        /// <summary>
        /// Retourne le score du joueur
        /// </summary>
        /// <returns></returns>
        public int getScoreJoueur()
        {
            return joueur.Score;
        }
    }
}
