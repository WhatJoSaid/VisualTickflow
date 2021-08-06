using System;
using System.Collections.Generic;
using System.IO;

namespace VT
{
    public static class Exporter
    {
        static List<Cue> cues = new List<Cue>();
                public static void AskLoop()
                {
                    string LeEpicInput = Console.ReadLine();
                    switch (LeEpicInput)
                    {
                        case "help":
                        case "h":
                            Console.WriteLine("cue - placing a specified cue on a specified beat\nExporting cue on specified beat");
                            break;
                        case "cue":
                            Console.WriteLine("Enter the game you want to use (list below)\nspaceball\nglobal");
                            string epicinput1 = Console.ReadLine();
                            switch (epicinput1)
                            {
                                case "global":
                                    Console.WriteLine("Enter the cue you want and the beat it's on (in that order)\nglobal cues: rest");
                                    break;
                                case "spaceball":
                                    Console.WriteLine("Enter the cue you want and the beat it's on (in that order)\nSpaceball cues: ball");
                                    break;
                            }
                            string[] epicinput2 = Console.ReadLine().Split();
                            Console.WriteLine("Enter the paramaters: ");
                            switch (epicinput2[0])
                            {
                                case "ball":
                                    Console.WriteLine("\n1st paramater: Length\nshort\nlong\n2nd parameter: Ball type\nball\nrice\nalien");
                                    break;
                                case "rest":
                                    Console.WriteLine("\nParameter: beats (in number)");
                                    break;
                            }
                            string[] epicinput3 = Console.ReadLine().Split();
                            try
                            {
                                cues.Add(new Cue(epicinput1, epicinput2[0], epicinput3, Convert.ToSingle(epicinput2[1])));
                                Console.WriteLine("Done!");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Uh oh, something went wrong! (Did you forget to enter a parameter?)\n" + e);
                            }
                            break;
                        case "export":
                            Console.WriteLine("Are you sure you want to remove all your progress and export? (y/n)");
                            string yn = Console.ReadLine();
                            if (yn == "y")
                            {
                                Console.WriteLine("Enter the file path where you want to export");
                                ExportCues(@Console.ReadLine());
                            }
                            break;
                        default:
                            Console.WriteLine("That's not a valid command!");
                            break;
                    }
                    // recursion moment
                    AskLoop();
                }

                static void ExportCues(string filelocation)
                {
                    filelocation += @"\tf.tickflow";
                    List<string> lines = new List<string>();
                    lines.Add("thissub:");
                    foreach (Cue cue in cues)
                    {
                        string tempstring = "";

                        tempstring += cue.cue + " ";
                        // hacky code in 3 2 1 (i've been coding for so long i'm so tired help)
                        bool loop = false;
                        foreach (string parameter in cue.parameters)
                        {
                            if (loop)
                            {
                                tempstring += ", ";
                            }

                            tempstring += parameter;
                            loop = true;
                        }

                        lines.Add(tempstring);
                    }
                    lines.Add("stop");
                    File.WriteAllLines(filelocation, lines);
                    Console.WriteLine("Done!");
                }
    }
}