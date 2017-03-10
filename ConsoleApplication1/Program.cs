using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHockeyPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            HockeyPlayer hockeyPlayer = new HockeyPlayer();
            hockeyPlayer.Name = "John";
            hockeyPlayer.JerseyNumber = 5;
            hockeyPlayer.GoalScored = 10;

            HockeyPlayer wayne = new HockeyPlayer();
            wayne.Name = "wayne";
            wayne.JerseyNumber = 8;
            wayne.GoalScored = 15;

            WriteLine("Name: {0}", hockeyPlayer.Name);
            WriteLine("Jersey Number: {0}", hockeyPlayer.JerseyNumber);
            WriteLine("Goals Scored: {0}", hockeyPlayer.GoalScored);



        }
    }
}
namespace TestHockeyPlayer
{
    class HockeyPlayer
    {
        public string Name { get; set; }
        public int JerseyNumber { get; set; }
        public int GoalScored { get; set; }

    }
}
