namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;

    public delegate void SampleDelegate();

    public class Timer
    {
        private int timeOfExecute;
        private int intervalOfMiliseconds;
        private SampleDelegate timerDelegate;

        public Timer(SampleDelegate timerDelegate, int timesOfExecute, int intervalOfMiliseconds)
        {
            this.timerDelegate = timerDelegate;
            this.timeOfExecute = timesOfExecute;
            this.intervalOfMiliseconds = intervalOfMiliseconds;
        }

        public int TimesOfExecute
        {
            get
            { return this.timeOfExecute; }
            set
            { this.timeOfExecute = value; }
        }

        public int IntervalOfMiliseconds
        {
            get { return this.intervalOfMiliseconds; }
            set { this.intervalOfMiliseconds = value; }
        }

        public SampleDelegate TimerDelegate
        {
            get { return this.timerDelegate; }
            set { this.timerDelegate = value; }
        }
        
        public void TimerExecute()
        {
            for (int i = 0; i < TimesOfExecute; i++)
            {
                Thread.Sleep(IntervalOfMiliseconds);
                TimerDelegate();
            }
        }

        public static void Print()
        {
            Console.WriteLine("Pesho!");
        }
    }
}
