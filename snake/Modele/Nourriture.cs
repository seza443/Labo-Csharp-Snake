using System;
using System.Drawing;
using snake.Properties;

namespace snake
{
    /// <summary>
    /// Représente un fruit
    /// </summary>
    public class Nourriture : PartieSerpent
    {
        /// <summary>
        /// Constructeur par défaut
        /// Initialise l'image à utiliser
        /// </summary>
        public Nourriture()
        {
            base.Img = new Bitmap(Resources.nourriture1);
        }

        /// <summary>
        /// Affecte des valeurs aléatoires aux coordonnées de la Nourriture comprises entre 0 et la valeur max
        /// </summary>
        /// <param name="maxX">Valeur max pour l'axe des X</param>
        /// <param name="maxY">Valeur max pour l'axe des Y</param>
        public void randomPosition(int maxX, int maxY)
        {
            Random random = new Random();
            this.X = (random.Next(10, maxX) /4)*4; ///4 *4 permet d'avoir un multiple de 4
            this.Y = (random.Next(10, maxY) /4)*4;
        }
    }
}
