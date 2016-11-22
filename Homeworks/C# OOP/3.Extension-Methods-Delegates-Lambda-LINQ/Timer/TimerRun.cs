namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TimerRun
    {
        public static void Testing()
        {
            Timer timer = new Timer(Timer.Print, 4, 2000);
            timer.TimerExecute();
        }
    }
}
