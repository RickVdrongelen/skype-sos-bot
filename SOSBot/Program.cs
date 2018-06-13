using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKYPE4COMLib;

namespace SOSBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Skype _skype = new Skype();

            try
            {
                _skype.Attach(5, false);
                Console.Write("Connectie succesvol");
                if (!_skype.Client.IsRunning)
                {
                    _skype.Client.Start(false, true);
                }

                System.Threading.Thread.Sleep(5000);

                if (_skype.Client.IsRunning == true)
                {
                    string line;

                    string path = string.Join(Directory.GetCurrentDirectory(), "./config.txt");

                    StreamReader file =
                        new StreamReader(path);

                    line = file.ReadLine();
                  
                    Call call = _skype.PlaceCall(line);
                }
                }
                catch
                {
                    Console.Write("Connectie onsuccesvol");
                }
            }
        }
    }

