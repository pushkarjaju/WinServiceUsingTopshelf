using System;
using Topshelf;

namespace WinServiceUsingTopshelf
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<Heartbit>(s =>
                {
                    s.ConstructUsing(heartbit => new Heartbit()); // Create heartbit obj
                    s.WhenStarted(heartbit => heartbit.Start());  // call start method to start service
                    s.WhenStopped(heartbit => heartbit.Stop());   // Call Stop method to stop service
                });

                x.RunAsLocalSystem();

                x.SetServiceName("HeartbitService");
                x.SetDisplayName("Heartbit Service");
                x.SetDescription("This is sample heartbit service");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetType());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
