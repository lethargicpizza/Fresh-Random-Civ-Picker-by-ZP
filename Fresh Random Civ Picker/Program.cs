using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Fresh_Random_Civ_Picker
{
    internal class Program
    {
		static string[] civ_names =
		{
			"Armenians",
            "Aztecs",
            "Bengalis",
            "Berbers",
            "Bohemians",
            "Britons",
            "Bulgarians",
            "Burgundians",
            "Burmese",
            "Byzantines",
            "Celts",
            "Chinese",
            "Cumans",
            "Dravidians",
            "Ethiopians",
            "Franks",
            "Georgians",
            "Goths",
            "Gurjaras",
            "Hindustanis",
            "Huns",
            "Incas",
            "Italians",
            "Japanese",
            "Khmer",
            "Koreans",
            "Lithuanians",
            "Magyars",
            "Malay",
            "Malians",
            "Mayans",
            "Mongols",
            "Persians",
            "Poles",
            "Portuguese",
            "Romans",
            "Saracens",
            "Sicilians",
            "Slavs",
            "Spanish",
            "Tatars",
            "Teutons",
            "Turks",
            "Vietnamese",
            "Vikings",
		};

        static bool ValidRange(ref int value, int minRange, int maxRange)
        {
            return (value >= minRange && value <= maxRange);
        }

        static void Main(string[] args)
        {
            int input = 0;
            int given_index = -1;

            string civilization = "";

            Random r = new Random();

            Console.WriteLine("Welcome to the Fresh Random Civ Picker for AoE2DE!\nThis free program was made by Zumba-Pelle.");

            int iterator = 0;

            do
            {
                Console.Write("\nEnter 1 to receive a fresh random civ, 0 to reset or -1 to quit: ");
                bool validInput = int.TryParse(Console.ReadLine(), out input);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                if (!(ValidRange(ref iterator, 0, 44)))
                {
                    iterator = 0;
                    Console.WriteLine("\nProgram has been reset!");
                }

                switch (input)
                {
                    case -1:
                        break;
                    case 0:
                        iterator = 0;
                        Console.WriteLine("\nProgram has been reset!");
                        break;
                    case 1:
                        given_index = r.Next(0, 45);
                        civilization = civ_names[given_index];

                        Console.WriteLine("\n{0} (current set: {1}/45)", civilization, iterator+1);

                        iterator += 1;

                        break;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
                

            } while (input != -1);
        }

    }
}
