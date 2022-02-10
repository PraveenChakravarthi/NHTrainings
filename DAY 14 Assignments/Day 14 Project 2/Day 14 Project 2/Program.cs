using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Project_2
{
    // Author : Praveen Chakravarthi
    // Purpose : Normal Properties

    class SimpleInterest
    {
        private int principle;
        private int time;
        private int rate;
        private int si;

        public int Principle
        {
            set
            {
                principle = value;
            }
        }
        public int Time 
        { 
            set
            {
                time = value;
            } 
        }
        public int Rate
        {
            set
            {
                rate = value;
            }
        }
        public int SI
        { 
            get
            {
                si = (principle*time*rate)/ 100;
                return si;
            }
        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleInterest sit = new SimpleInterest();
            sit.Principle = 20;
            sit.Time = 3;
            sit.Rate = 30;

            Console.WriteLine("Simple Interest is : {0}",sit.SI);
            Console.ReadLine();
        }
    }
}
