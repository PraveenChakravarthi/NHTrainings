using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_using_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputCharacter = 'i';

            switch(inputCharacter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':

                    Console.WriteLine("the input Character is a Vowel");
                    break;
                    default:
                    Console.WriteLine("the input character is a consonant");
                    break;
            }
            Console.ReadLine();

        }
    }
}
