using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using snake.Properties;

namespace snake
{
    /// <summary>
    /// Représente la plus petite partie du corps du serpent
    /// </summary>
    public class PartieSerpent
    {
        protected int X;
        protected int Y;
        private Bitmap img;

        public Bitmap Img
        {
            get { return img; }
            set { img = value; }
        }

        public Point Coordonnees
        {
            get { return new Point(X, Y); }
        }

        /// <summary>
        /// Le constructeur par défaut initialise la position de départ.
        /// Initialise également l'image utilisée à l'affichage
        /// </summary>
        /// <param name="x">Valeur par rapport à l'axe des X</param>
        /// <param name="y">Valeur par rapport à l'axe des Y</param>
        public PartieSerpent(int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
            img = new Bitmap(Resources.snake_part2);
        }

        /// <summary>
        /// Constructeur par recopie
        /// </summary>
        /// <param name="original">La partie à copier</param>
        public PartieSerpent(PartieSerpent original): this(original.X, original.Y)
        {
            
        }

        /// <summary>
        /// Déplace la partie du serpent en ajouter x et y aux valeurs X et Y de la partie
        /// </summary>
        /// <param name="x">Le déplacement par rapport à l'axe X</param>
        /// <param name="y">Le déplacement par rapport à l'axe Y</param>
        public void deplacer(int x, int y)
        {
            this.X += x;
            this.Y += y;
        }
    }
}
