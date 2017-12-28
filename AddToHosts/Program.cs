using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace AddToHosts
{
    class Program
    {
        //private static string choice = Console.ReadLine();
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("I am assuming you want to add something to your hosts file...");
            Console.WriteLine("1. 'Photoshop'");
            Console.WriteLine("2. 'CCleaner'");
            Console.WriteLine("3. 'MalwareBytes'");
            Console.WriteLine("Pick a number...");
            Console.WriteLine("---------------------");
            string choice = Console.ReadLine();

            switch (choice)

            {
                case "1": // Do Something
                    AddPhotoshopHost();
                    break;

                case "2": //Do that
                    AddCCleanerHost();
                    break;
                case "3": //Do that
                    AddMalwareHost();
                    break;
            }
        }

        private static void AddCCleanerHost()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Adding to hosts file...");
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            //Console.WriteLine(systemPath);
            var path = Path.Combine(systemPath, @"drivers\etc\hosts");
            using (var stream = new StreamWriter(path, true, Encoding.Default))
            {
                stream.WriteLine(" ");
                stream.WriteLine("###--CCleaner Host Addition--###");
                stream.WriteLine("###--By: JBob--###");
                stream.WriteLine("127.0.0.1 license.piriform.com");
                stream.WriteLine("###----------------------###");
                Console.WriteLine("---------------------");
                Console.WriteLine("DONE!!");
            }
            Console.WriteLine("---------------------");
            Done();
        }

        private static void AddPhotoshopHost()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Adding to hosts file...");
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            //Console.WriteLine(systemPath);
            var path = Path.Combine(systemPath, @"drivers\etc\hosts");
            using (var stream = new StreamWriter(path, true, Encoding.Default))
            {
                stream.WriteLine(" ");
                stream.WriteLine("###--Photoshop Host Addition--###");
                stream.WriteLine("###--By: JBob--###");
                stream.WriteLine("127.0.0.1 lmlicenses.wip4.adobe.com");
                stream.WriteLine("127.0.0.1 lm.licenses.adobe.com");
                stream.WriteLine("127.0.0.1 na1r.services.adobe.com");
                stream.WriteLine("127.0.0.1 hlrcv.stage.adobe.com");
                stream.WriteLine("127.0.0.1 practivate.adobe.com");
                stream.WriteLine("127.0.0.1 activate.adobe.com");
                stream.WriteLine("127.0.0.1 license.piriform.com");
                stream.WriteLine("###----------------------###");
                Console.WriteLine("---------------------");
                Console.WriteLine("DONE!!");
            }
            Console.WriteLine("---------------------");
            Done();
        }

        private static void AddMalwareHost()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Adding to hosts file...");
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            //Console.WriteLine(systemPath);
            var path = Path.Combine(systemPath, @"drivers\etc\hosts");
            using (var stream = new StreamWriter(path, true, Encoding.Default))
            {
                stream.WriteLine(" ");
                stream.WriteLine("###--MalwareBytes Host Addition--###");
                stream.WriteLine("###--By: JBob--###");
                stream.WriteLine("0.0.0.0 keystone.mwbsys.com");
                stream.WriteLine("###----------------------###");
                Console.WriteLine("---------------------");
                Console.WriteLine("DONE!!");
            }
            Console.WriteLine("---------------------");
            Done();
        }


        private static void Done()
        {
            Console.WriteLine("Are you done adding to your hosts file...");
            Console.WriteLine("1. Yes ");
            Console.WriteLine("2. No ");
            Console.WriteLine("Pick a number...");
            Console.WriteLine("---------------------");
            string choice = Console.ReadLine();

            switch (choice)

            {

                case "1": // Do Something

                    break;

                case "2": //Do that
                    Console.WriteLine("What else would you like to add to your hosts?");
                    Console.WriteLine("1. 'Photoshop'");
                    Console.WriteLine("2. 'CCleaner'");
                    Console.WriteLine("3. 'MalwareBytes'");
                    Console.WriteLine("Pick a number...");
                    Console.WriteLine("---------------------");
                    string choice2 = Console.ReadLine();

                    switch (choice2)

                    {
                        case "1": // Do Something
                            AddPhotoshopHost();
                            break;

                        case "2": //Do that
                            AddCCleanerHost();
                            break;
                        case "3": //Do that
                            AddMalwareHost();
                            break;
                    }
                    break;
            }
        }

    }
}
