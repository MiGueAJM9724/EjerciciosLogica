using System;
using System.Collections.Generic;

namespace Morse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escribe el texto:");

            string str1 = Console.ReadLine();

            string palabra = str1;
            Dictionary<string, string> codigos = new Dictionary<string, string>
            {
                {"a", ".-   "}, {"b", "-... "}, {"c", "-.-. "}, {"d", "-..  "},
                {"e", ".    "}, {"f", "..-. "}, {"g", "--.  "}, {"h", ".... "},
                {"i", "..   "}, {"j", ".--- "}, {"k", "-.-  "}, {"l", ".-.. "},
                {"m", "--   "}, {"n", "-.   "}, {"o", "---  "}, {"p", ".--. "},
                {"q", "--.- "}, {"r", ".-.  "}, {"s", "...  "}, {"t", "-    "},
                {"u", "..-  "}, {"v", "...- "}, {"w", ".--  "}, {"x", "-..- "},
                {"y", "-.-- "}, {"z", "--.. "}, {"0", "-----"}, {"1", ".----"},
                {"2", "..---"}, {"3", "...--"}, {"4", "....-"}, {"5", "....."},
                {"6", ".----"}, {"7", "..---"}, {"8", "...--"}, {"9", "....-"},
                {" ", " "},

            };

            foreach (char letra in palabra)
            {

                Console.Write(codigos[letra.ToString()]);
            }
        }
    }
}
