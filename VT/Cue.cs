using System;
using System.Collections.Generic;
using System.Linq;

namespace VT
{
    // hoo boy messy code time
    public class Cue
    {
        public string cue { get; set; }
        public List<string> parameters = new List<string>();
        public float beat { get; set; }
        public Cue(string game, string cue, string[] parameters, float beat)
        {
            this.beat = beat;
            // nested switch statements? how??!?!??!
            switch (game)
            {
                case "spaceball":
                    switch (cue)
                    {
                        case "ball":
                            if (!MiscStuff.CheckLen(parameters, 2))
                            {
                                Console.WriteLine("You didn't enter the right amount of parameters!");
                                break;
                            }
                            this.cue = "0x100";
                            if (parameters[0] == "short")
                            {
                                this.parameters.Add("0x30");
                            } else if (parameters[0] == "long")
                            {
                                this.parameters.Add("0x60");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Parameters!");
                                break;
                            }
                            switch (parameters[1])
                            {
                                case "ball":
                                    this.parameters.Add("0");
                                    break;
                                case "rice":
                                    this.parameters.Add("1");
                                    break;
                                case "alien":
                                    this.parameters.Add("2");
                                    break;
                                default:
                                    Console.WriteLine("Invalid Parameters!");
                                    break;
                            }
                            break;
                    }
                    break;
                case "global":
                    switch (cue)
                    {
                        case "rest":
                            if (!MiscStuff.CheckLen(parameters, 1))
                            {
                                Console.WriteLine("You didn't enter the right amount of parameters!");
                                break;
                            }
                            this.cue = "rest";
                            int thisbeat = Convert.ToInt32(beat) * 48;
                            string isnonstop = "0x" + thisbeat.ToString("X");
                            this.parameters.Add(isnonstop);
                            break;
                    }
                    
                    break;
                default:
                    Console.WriteLine("Invalid game!");
                    break;
            }
        }
    }
}