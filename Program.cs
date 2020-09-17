using System;
using System.Collections.Generic;

namespace AnimalStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Är det dag eller natt? (D/N): ");
            string key = Console.ReadLine().ToUpper();
            switch (key)
            {
                case "D":
                    Console.WriteLine(CreateAnimalStory.DayTime());
                    break;
                case "N":
                    Console.WriteLine(CreateAnimalStory.NightTime());
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }

    class CreateAnimalStory
    {
        public static List<Animal> BuildAnimal()
        {
            Animal animal1 = new Animal();
            animal1.Kind = "Häst";
            animal1.Nocturnal = false;

            Animal animal2 = new Animal();
            animal2.Kind = "Delfin";
            animal2.Nocturnal = false;

            Animal animal3 = new Animal();
            animal3.Kind = "Fladdermus";
            animal3.Nocturnal = true;

            Animal animal4 = new Animal();
            animal4.Kind = "Varg";
            animal4.Nocturnal = true;

            Animal animal5 = new Animal();
            animal5.Kind = "Örn";
            animal5.Nocturnal = true;

            List<Animal> forest = new List<Animal>
            {
                animal1,
                animal2,
                animal3,
                animal4,
                animal5
            };
            return forest;
        }
        public static string NightTime()
        {
            string story = "";
            foreach (Animal animal in BuildAnimal())
            {
                if (animal.Nocturnal)
                {
                    story += $"{animal.Kind} smyger runt i natten och letar efter något att äta. \n";
                }
                else
                {
                    story += $"{animal.Kind} sover lugnt i natten. \n";
                }
            }
            
            return story;
        }
        public static string DayTime()
        {
            string story = "";
            foreach (Animal animal in BuildAnimal())
            {
                if (!animal.Nocturnal)
                {
                    story += $"{animal.Kind} strosar runt i lugnan ro och letar efter mat. \n";
                }
                else
                {
                    story += $"{animal.Kind} sover gott så som nattaktiva djur gör på dagen. \n";
                }
            }
            return story;
        }
    }

    class Animal
    {
        public string Kind { get; set; }
        public bool Nocturnal { get; set; }
    }
}
