using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace snake
{
    /// <summary>
    /// Controleur du jeu
    /// </summary>
    public class Controleur
    {
        private FenetrePrincipale fenetre;
        Jeu snake;
        
        /// <summary>
        /// Constructeur par défaut chargé d'instancier la fenetre principale et d'instancier un jeu
        /// </summary>
        public Controleur()
        {
            fenetre = new FenetrePrincipale(this);
            snake = new Jeu();
            snake.initialiserTimerRafraichissement(this);
        }

        /// <summary>
        /// Méthode appelée au démarrage du jeu.
        /// Affiche la fenetre avec l'écran de titre
        /// </summary>
        public void start()
        {
            fenetre.afficherEcranTitre();
            fenetre.ShowDialog();
        }

        /// <summary>
        /// Méthode appelée lors du click sur le bouton jouer dans l'écran de titre
        /// Initialise le nom du joueur et démarre un nouveau jeu
        /// </summary>
        public void boutonJouer()
        {
            if (!snake.initialiserNom(fenetre.getNomJoueur()))
            {
                fenetre.afficherFenetreModaleErreur("Nom invalide", "Entrez un nom de joueur");
            }
            else
            {
                //démarrer le jeu
                fenetre.afficherEcranJeu();
                difficulteModifiee();
                snake.start();
                timerEcoule(null, null);
            }
        }

        /// <summary>
        /// Met le jeu en pause.
        /// </summary>
        public void mettreEnPause()
        {
            fenetre.afficherEcranPause();
        }

        /// <summary>
        /// Reprend le jeu
        /// </summary>
        public void reprendre()
        {
            fenetre.afficherEcranJeu();
            timerEcoule(null, null);
        }

        /// <summary>
        /// Méthode appelée lors de la fermeture de la fenetre
        /// </summary>
        public void quitter()
        {

        }

        /// <summary>
        /// Méthode appelée lorsqu'une touche est enfoncée
        /// </summary>
        /// <param name="e">La touche enfoncée</param>
        public void keyPressed(KeyEventArgs e)
        {
            snake.keyPressed(e, this);
        }

        /// <summary>
        /// Méthode de réaction appelée quand le minuteur de raffraichissement atteint 0
        /// </summary>
        /// <param name="sender">Objet envoyant l'évènement</param>
        /// <param name="e">Détails de l'évènement</param>
        public void timerEcoule(object sender, ElapsedEventArgs e)
        {
            fenetre.rafraichirPanneauJeu();
            if (snake.update())
            {
                dessinerNourriture();
                dessinerSerpent();
                fenetre.setFruitsManges();
                fenetre.setScoreJoueur();
            }
            else
            {
                //gameOver
                fenetre.afficherPanneauGameOver(snake.getScoreJoueur());
            }
        }

        public int getscoreJoueur()
        {
            return snake.getScoreJoueur();
        }

        public int getNbrFruitsManges()
        {
            return snake.getFruitsManges();
        }

        /// <summary>
        /// Dessine la nourriture à l'écran
        /// </summary>
        public void dessinerNourriture()
        {
            fenetre.dessinerPartieSerpent(snake.Nourriture);
        }

        /// <summary>
        /// Dessine le serpent à l'écran
        /// </summary>
        public void dessinerSerpent() 
        {
            List<PartieSerpent> corps = snake.CorpsSerpent;
            foreach (var item in corps)
            {
                fenetre.dessinerPartieSerpent(item);
            }
        }

        /// <summary>
        /// Méthode appelée lorsque la valeur du curseur de difficulté est modifiée
        /// </summary>
        public void difficulteModifiee()
        {
            int nouvelleDifficulte = fenetre.getDifficulte();
            fenetre.setDifficulte(nouvelleDifficulte);
            snake.Difficulte = nouvelleDifficulte;
        }
    }
}
