using System;
using System.Drawing;
using System.Windows.Forms;

namespace snake
{
    public partial class FenetrePrincipale : Form
    {
        private Controleur controleur;
        private String titreJeu =      "SNAKE";
        private String titrePause =    "PAUSE";
        private String titreMenu =     " MENU";
        private String titreGameOver = "PERDU";
        private Graphics dessinateur;

        /// <summary>
        /// Constructeur par défaut, initialise les composants
        /// Instancie le dessinateur (Composant Graphics)
        /// </summary>
        public FenetrePrincipale()
        {
            InitializeComponent();
            dessinateur = this.panneauJeu.CreateGraphics();
            this.panneauJeu.Visible = true;
        }

        /// <summary>
        /// Surcharge du constructeur
        /// Affecte un controleur à la fenetre
        /// </summary>
        /// <param name="controleur">Le controleur de l'application</param>
        public FenetrePrincipale(Controleur controleur)
            : this()
        {
            this.controleur = controleur;
        }

        /// <summary>
        /// Affiche l'écran de titre et raffraichit la fenetre
        /// </summary>
        public void afficherEcranTitre()
        {
            this.labelTitreSnake.Text = titreMenu;
            this.labelTitreSnake.Visible = true;
            this.panneauTitre.Visible = true;
            this.panneauDifficulte.Visible = true;
            this.panneauPause.Visible = false;
            panneauGameOver.Visible = false;
            //this.panneauJeu.Visible = true;
            this.Refresh();
        }

        /// <summary>
        /// Affiche l'écran de jeu, raffraichit la fenetre et donne le focus à la fenetre
        /// </summary>
        public void afficherEcranJeu()
        {
            this.labelTitreSnake.Text = titreJeu;
            this.labelJoueur.Text = this.zoneTexteNomJoueur.Text;
            this.labelTitreSnake.Visible = false;
            this.panneauTitre.Visible = false;
            this.panneauPause.Visible = false;
            this.panneauDifficulte.Visible = false;
            panneauGameOver.Visible = false;
            this.Refresh();
            //force le focus.
            //Permet de capturer les touches enfoncées au clavier
            bool a = this.Focused;
            a = this.Focus();
        }

        /// <summary>
        /// Affiche l'écran de pause et raffraichit la fenetre
        /// </summary>
        public void afficherEcranPause()
        {
            this.labelTitreSnake.Text = titrePause;
            this.labelTitreSnake.Visible = true;
            this.panneauPause.Visible = true;
            this.panneauDifficulte.Visible = true;
            panneauGameOver.Visible = false;
            this.Refresh();
        }

        /// <summary>
        /// Affiche l'écran GameOver et raffraichit la fenetre.
        /// Initialise le label de score du Joueur
        /// </summary>
        /// <param name="score">Le score final du joueur</param>
        public void afficherPanneauGameOver(int score)
        {
            //POURQUOI EST CE QUE IL N'EXECUTE QUE LES 2 PREMIERES INSTRUCTIONS ?????????????
            //Ok, ça fonctionne quand je le lance en dehors de Visual Studio ... ><
            this.labelPerduScore.Text = score.ToString();
            //panneauGameOver.Visible = true; //Cette ligne génère une exception!
            //à remplacer par
            setGameOverVisible();
            //this.labelTitreSnake.Text = titreGameOver;
            //this.labelTitreSnake.Visible = true;
            setlabelTitreSnake();
            //panneauGameOver.Refresh();
            setGameOverRefresh();
        }

        public delegate void AccessTopanneauGameOver1();
        public delegate void AccessTopanneauTitre1();

        public void setGameOverVisible()// le thread qui accède à un contrôle doit être le thread qui a créé le contrôle
        {
            if (panneauGameOver.InvokeRequired == true)
            {
                panneauGameOver.Invoke(new AccessTopanneauGameOver1(setGameOverVisible));  // on change le thread qui appelle
            }
            else
                panneauGameOver.Visible = true;

        }

        public void setlabelTitreSnake()// le thread qui accède à un contrôle doit être le thread qui a créé le contrôle
        {
            if (panneauTitre.InvokeRequired == true)
            {
                panneauTitre.Invoke(new AccessTopanneauTitre1(setlabelTitreSnake));  // on change le thread qui appelle
            }
            else
            {
                this.labelTitreSnake.Text = titreGameOver;
                this.labelTitreSnake.Visible = true;
            }

        }

        public void setGameOverRefresh()// le thread qui accède à un contrôle doit être le thread qui a créé le contrôle
        {
            if (panneauGameOver.InvokeRequired == true)
            {
                panneauGameOver.Invoke(new AccessTopanneauGameOver1(setGameOverVisible));  // on change le thread qui appelle
            }
            else
                panneauGameOver.Refresh();

        }

        /// <summary>
        /// Méthode de réaction au click sur le bouton jouer dans l'écran de titre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boutonJouer_Click(object sender, EventArgs e)
        {
            controleur.boutonJouer();
        }

        /// <summary>
        /// Rend le nom du joueur
        /// </summary>
        /// <returns>Nom du joueur actuel</returns>
        public String getNomJoueur()
        {
            return this.zoneTexteNomJoueur.Text;
        }

        /// <summary>
        /// Affiche une fenetre modale d'erreur
        /// </summary>
        /// <param name="titreFenetre">Le titre de la fenetre à afficher</param>
        /// <param name="messageErreur">le message à afficher dans la fenetre</param>
        public void afficherFenetreModaleErreur(String titreFenetre, String messageErreur)
        {
            MessageBox.Show(this, messageErreur, titreFenetre, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Méthode de réaction lorsque la fenetre est fermée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FenetrePrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            controleur.quitter();
        }

        /// <summary>
        /// Methode de réaction à une pression d'une touche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FenetrePrincipale_KeyDown(object sender, KeyEventArgs e)
        {
            controleur.keyPressed(e);
        }

        /// <summary>
        /// Méthode de réaction au bouton reprendre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bouttonReprendre_Click(object sender, EventArgs e)
        {
            this.FenetrePrincipale_KeyDown(sender, new KeyEventArgs(Keys.Escape));
        }

        /// <summary>
        /// Retourne la valeur du curseur de difficulté
        /// </summary>
        /// <returns>La valeur du curseur de difficulté</returns>
        public int getDifficulte()
        {
            int difficulte = this.curseurDifficulte.Value;
            return difficulte;
        }

        /// <summary>
        /// méthode de réaction appelée lorsque la valeur du curseur de difficulté est modifiée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void curseurDifficulte_ValueChanged(object sender, EventArgs e)
        {
            controleur.difficulteModifiee();
        }

        /// <summary>
        /// Dessine une image Bitmap aux coordonnées fournies sur le panneau Jeu
        /// </summary>
        /// <param name="img">Image à dessiner</param>
        /// <param name="coordonnées">Coordonnées de l'image</param>
        private void dessinerImage (Bitmap img, Point coordonnées)
        {
            try 
            { 
                dessinateur.DrawImage(img, coordonnées);
            }
            catch
            {
                
            }
        }

        /// <summary>
        /// Dessine un morceau du corps du serpent fourni en paramètre
        /// </summary>
        /// <param name="p">Le morceau de corps à dessiner</param>
        public void dessinerPartieSerpent(PartieSerpent p)
        {
            dessinerImage(p.Img, p.Coordonnees);
        }

        /// <summary>
        /// Force le panneau Jeu à se redessiner
        /// </summary>
        public void rafraichirPanneauJeu()
        {
            panneauJeu.Invalidate();
        }

        public delegate void AccessToFruitsManges1();

        public void setFruitsManges()// le thread qui accède à un contrôle doit être le thread qui a créé le contrôle
        {
            if (panneauScore.InvokeRequired == true)
            {
                panneauScore.Invoke(new AccessToFruitsManges1(setFruitsManges));  // on change le thread qui appelle
            }
            else
                this.labelFruits.Text = controleur.getNbrFruitsManges().ToString();

        }

        /// <summary>
        /// Initialise la valeur du label de Fruits Manges
        /// </summary>
        /// <param name="nbrFruitsManges">Nombre de fruits mangés à afficher</param>
        //public void setFruitsManges(int nbrFruitsManges)
        //{
        //    this.labelFruits.Text = nbrFruitsManges.ToString();
        //}

        public delegate void AccessToScoreJoueur1();

        public void setScoreJoueur()// le thread qui accède à un contrôle doit être le thread qui a créé le contrôle
        {
            if (panneauScore.InvokeRequired == true)
            {
                panneauScore.Invoke(new AccessToScoreJoueur1(setScoreJoueur));  // on change le thread qui appelle
            }
            else
                this.labelScore.Text = controleur.getscoreJoueur().ToString();

        }

        /// <summary>
        /// Initliase la valeur du label Score Joueur
        /// </summary>
        /// <param name="scoreJoueur">Le score du joueur à afficher</param>
        //public void setScoreJoueur(int scoreJoueur)
        //{
        //    this.labelScore.Text = scoreJoueur.ToString();
        //}

        /// <summary>
        /// Initliase la valeur du label de Difficulté
        /// </summary>
        /// <param name="nouvelleDifficulte">La difficulté à afficher</param>
        public void setDifficulte(int nouvelleDifficulte)
        {
            this.labelDifficulteAffiche.Text = nouvelleDifficulte.ToString();
        }
    }
}
