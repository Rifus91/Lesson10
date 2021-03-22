﻿using System;

namespace Lesson10
{
    class Program
    {

        public const byte Monday = 1;
        public const byte Tuesday = 2;
        public const byte Wednesday = 3;
        public const byte Thursday = 4;
        public const byte Fridey = 5;
        public const byte Saturday = 6;
        public const byte Sanday = 7;

        public const string ProgramName = "Календарь";

        static void Main(string[] args)
        {
            //ввод от клиента, пол и имя
            // Step1(false, "Иванова Ольга");
            //Step2(true, "Петров Иван");
            StepWeek1(8);
        }

       
        static void Step1(bool gender, string name)
        {
            if (gender == Gender.isMan)
            {
                Console.WriteLine($"Уважаемый, {name}!");
            }
            else
            {
                Console.WriteLine($"Уважаемая, {name}!");
            }
            Console.WriteLine("Приветствуем на нашем сайте!");
        }

        static void StepWeek1(byte dayOfWeek)
        {
            if (dayOfWeek == Saturday || dayOfWeek == Sanday)
            { Console.WriteLine("Выходной день"); }
            else
            { Console.WriteLine("Рабочий день"); }
        }

       
        


    }
}
