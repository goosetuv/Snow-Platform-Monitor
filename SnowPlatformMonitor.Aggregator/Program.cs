using System;
using SnowPlatformMonitor.Aggregator.Classes;
using SnowPlatformMonitor.Core.Configuration;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace SnowPlatformMonitor.Aggregator
{
    public partial class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            try
            {

#if DEBUG
                Console.WriteLine("DEVELOPMENT BUILD");
#endif

                bool Run = false;
                bool Test = false;
                bool ShowHelp = false;

                //Console.WriteLine($"Count = {args.Length}");

                if(args.Length > 1)
                {
                    Console.WriteLine($"Too many arguments passed.  Please try again.");
                    log.Error($"Too many arguments passed.  Please try again.");
                    return;
                }

                for (int i = 0; i < args.Length; i++)
                {
                    //Console.WriteLine($"Args[{i}] = [{args[i]}]");

                    if (args[i].ToLower() == "-run")
                    {
                        Run = true;
                    }
                    else if (args[i].ToLower() == "-h" || args[i].ToLower() == "-help" || args[i] == "-?")
                    {
                        ShowHelp = true;
                    }
                    else if (args[i].ToLower() == "-test")
                    {
                        Test = true;
                    } else
                    {
                        Console.WriteLine($"Unrecognized command-line parameter '{args[i]}'. Try '-h' for help.");
                    }

                }

                if(Run)
                {
                    Classes.Aggregator aggregator = new Classes.Aggregator();
                    aggregator.Run(RunMode.NORMAL);
                }

                if(Test)
                {
                    Classes.Aggregator aggregator = new Classes.Aggregator();
                    aggregator.Run(RunMode.TEST);

                }

                if(ShowHelp)
                {
                    Console.WriteLine("Usage: SnowPlatformMonitor.Aggregator.exe -command");
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("List of Commands:");
                    Console.WriteLine("-?, -help, -h        Shows application help");
                    Console.WriteLine("-Run                 Runs the application in NORMAL mode");
                    Console.WriteLine("-Test                 Runs the application in TEST mode");
                }

            } catch (Exception ex)
            {
                log.Fatal(ex);
            }

        }

    }
}
