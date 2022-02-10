using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Project_1
{
    // Author : Praveen Chakravarthi
    // Purpose : Sealed Class

    sealed class Cricket
    {
        public string TeamName;
        public int TeamCount;
    }

    class Football : Cricket
    {
        public int Score;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cricket ct = new Cricket();
            ct.TeamName = "SRH";
            Football fb = new Football();
            fb.TeamName = "CSK";

            Console.WriteLine(ct.TeamName);

            Console.ReadLine();
        }
    }
}
