using System;
using System.Collections.Generic;
using System.Linq;

namespace VisualTickflow
{
    // hoo boy messy code time
    public class Cue
    {
        public string cue { get; set; }
        public List<string> parameters = new List<string>();
        public float beat { get; set; }
        public string game { get; set; }
        public Cue(string game, string cue, string[] parameters, float beat)
        {
            this.beat = beat;
            // nested switch statements? how??!?!??!
            switch (game)
            {
                case "spaceball":
                    this.game = game;
                    switch (cue)
                    {
                        case "ball":
                            if (!MiscStuff.CheckLen(parameters, 2))
                            {
                                Console.WriteLine("Is");
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
            }
        }
    }
}