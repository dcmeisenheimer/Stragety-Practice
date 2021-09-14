using System;

namespace StragetyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pitcher standardPitcher = new Pitcher(){Name = "Base Player", Team = "Braves", Throws = "Right"};
            // standardPitcher.pitchBehavior.Pitch();

            // Pitcher craftyLefty = new Lefty(){Name = "Krafty", Team = "Mets"};
            // craftyLefty.pitchBehavior.Pitch();

            // craftyLefty.SetPitchBehavior(new Slider());
            // craftyLefty.pitchBehavior.Pitch();

            IPitch fastball = new Fastball();
            IPitch curveball = new Curveball();
            IPitch slider = new Slider();

            Pitcher craftyLefty = new Lefty(){Name = "Krafty", Team = "Mets"};

            craftyLefty.pitchBehavior.Pitch();
            System.Console.WriteLine("That was a strike");

            craftyLefty.SetPitchBehavior(fastball);
            craftyLefty.pitchBehavior.Pitch();
            System.Console.WriteLine("That was a strike");

            craftyLefty.SetPitchBehavior(slider);
            craftyLefty.pitchBehavior.Pitch();
            System.Console.WriteLine("That was a ball");

            craftyLefty.SetPitchBehavior(curveball);
            craftyLefty.pitchBehavior.Pitch();
            System.Console.WriteLine("3 strikes, batters out");







            
        }
    }
}
