﻿using System;
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
                    s.ConstructUsing(heartbit => new Heartbit());
                    s.WhenStarted(heartbit => heartbit.Start());
                    s.WhenStopped(heartbit => heartbit.Stop());
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
