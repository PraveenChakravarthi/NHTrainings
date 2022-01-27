using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score =0, ans;
            string name;

            // read from user

            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine("Hi {0}, Welcome to Praveen's Quiz", name);
            Console.WriteLine("*****************************************");

            Console.WriteLine("Q1. Who is the prime minister of india");
            Console.WriteLine("1.jk advani 2.Narendra Modi 3.Ramnath Kovind 4.KCR");
            Console.WriteLine("choose your option:") ;
            ans =Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
            score += 20;

            Console.WriteLine("Q2. Who is the president of india");
            Console.WriteLine("1.sachin Tendulkar 2.Narendra Modi 3.Ramnath Kovind 4.KCR");
            Console.WriteLine("choose your option:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
            score += 20;

            Console.WriteLine("Q3. Who has the record of highest test indivdual score");
            Console.WriteLine("1.sachin Tendulkar 2.V kohli 3.Don Bradman 4.Brain Lara");
            Console.WriteLine("choose your option:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 4)
            score += 20;

            Console.WriteLine("Q4. Who is the chief Minister of New Delhi");
            Console.WriteLine("1.Arvind kejriwal 2.Narendra Modi 3.Ramnath Kovind 4.Amit Shah");
            Console.WriteLine("choose your option:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
            score += 20;

            Console.WriteLine("Q1 Which city is called the city of lakes in india");
            Console.WriteLine("1.jaipur 2.bangalore 3.Udaipur 4.Hyderabad");
            Console.WriteLine("choose your option:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
            score += 20;

            if (score >= 60)

            Console.WriteLine("CONGRATULATIONS {0}, You have got {1}%",name,score);
            else
                Console.WriteLine("Sorry {0}, you got only {1}%",name,score);

            Console.ReadLine();
        }
    }
}
