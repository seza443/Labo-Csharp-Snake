using System.Timers;

namespace snake
{
    /// <summary>
    /// Cette classe instancie un Timer et déclenche des évenements à chaque fois que le Timer atteint 0
    /// </summary>
    public class Minuteur
    {
        private Timer timer;

        /// <summary>
        /// Propriété permettant d'accéder non pas à l'objet timer mais bien directement à la valeur de son interval. ;)
        /// </summary>
        public double Timer
        {
            get { return timer.Interval; }
            set
            {
                if (value > 0.0)
                {
                    timer.Interval = value;
                } 
            }
        }

        /// <summary>
        /// Constructeur par défault
        /// Instancie un nouveau Timer et lui affecte une méthode de réaction
        /// </summary>
        /// <param name="eventManager">Méthode de réaction à appeler lorsque le Timer atteint 0</param>
        public Minuteur(ElapsedEventHandler eventManager)
        {
            timer = new Timer();
            timer.Elapsed += eventManager; //affecte la méthode de réaction à l'évènement Elapsed
            timer.AutoReset = true; //permet de recommencer le compte à rebours une fois fini
        }

        /// <summary>
        /// Constructeur surchargé initalisant un Timer, lui affectant une méthode de réaction et un interval de temps
        /// </summary>
        /// <param name="interval">Interval avant que la méthode de réaction ne soit appelée</param>
        /// <param name="eventManager">Méthode de réaction à appeler lorsque le Timer attaint 0</param>
        public Minuteur(double interval, ElapsedEventHandler eventManager)
            : this(eventManager)
        {
            this.Timer = interval;
        }

        /// <summary>
        /// Démarre le Timer
        /// </summary>
        public void start()
        {
            this.timer.Start();
        }

        /// <summary>
        /// Arrete le Timer
        /// </summary>
        public void stop()
        {
            this.timer.Stop();
        }
    }
}
