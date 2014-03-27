using System;

namespace snake
{
    /// <summary>
    /// Réprésente un joueur
    /// </summary>
    public class Joueur
    {
        private String nom;

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        /// <summary>
        /// Constructeur par défaut
        /// Initialise le nom du joueur
        /// Initialise le score du joueur à 0
        /// </summary>
        /// <param name="nom">Le nom du joueur</param>
        public Joueur(String nom)
        {
            this.nom = nom;
            this.score = 0;
        }
    }
}
