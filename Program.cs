﻿using System;
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
                    CreateAnimal.DayTime();
                    break;
                case "N":
                    CreateAnimal.NightTime();
                    break;
                default:
                    break;
            }
        }
    }

    class CreateAnimal
    {
        public static void BuildAnimal()
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

        }
        public static string NightTime()
        {
            foreach (var animal in )
            {

            }
            string story = "";
            return story;
        }
        public static string DayTime()
        {
            string story = "";
            return story;
        }
    }

    class Animal
    {
        public string Kind { get; set; }
        public bool Nocturnal { get; set; }
    }

    public class Story
    {
    }
}
