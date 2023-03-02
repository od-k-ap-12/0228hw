using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0228hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>
                {
                    {"France", "Париж"},
                    {"Germany", "Германия"},
                    {"Poland", "Польша"},
                    {"Slovakia", "Словакия"},
                    {"Canada", "Канада"},
                    {"Italy", "Италия"}
                };

            foreach (var pair in countries)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            int choice;
            do
            {
                Console.WriteLine("1.eng to ru \n2.ru to eng \n3.exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the word: ");
                        string translate = Console.ReadLine();
                        if (countries.ContainsKey(translate))
                        {
                            Console.WriteLine(countries[translate]);
                        }
                        else
                        {
                            Console.WriteLine("No such word found");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the word: ");
                        translate = Console.ReadLine();
                        if (countries.ContainsValue(translate))
                        {
                            foreach (var pair in countries)
                            {
                                if (pair.Value == translate)
                                {
                                    Console.WriteLine(pair.Key);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No such word found");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        break;
                }
            }
            while (choice != 3);
        }
    }
}
