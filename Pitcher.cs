using System;

namespace StragetyPractice
{
    public class Pitcher
    {
        public string Name{get; set;}
        public string Team{get;set;}
        public string Throws{get; set;}

        public IPitch pitchBehavior {get; set;}

        public void SetPitchBehavior(IPitch pitchBehavior)
        {
            this.pitchBehavior = pitchBehavior;
        }
        public Pitcher()
        {
            pitchBehavior = new Fastball();
        }
    }
}
