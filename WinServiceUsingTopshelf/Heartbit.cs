using System;
using System.IO;
using System.Timers;

namespace WinServiceUsingTopshelf
{
    class Heartbit
    {
        private readonly Timer _timer;

        public Heartbit()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            string[] lines = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"C:\Users\pushkar.jaju\source\repos\WinServiceUsingTopshelf\Heartbit.txt", lines);
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
