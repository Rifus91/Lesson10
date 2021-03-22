using System;

namespace Lesson10
{
    class Program
    {
        public const bool isMan = true;
        public const bool isWomen = false;
        static void Main(string[] args)
        {
            //ввод от клиента, пол и имя
            // Step1(false, "Иванова Ольга");
            //Step2(true, "Петров Иван");
            StepWeek1(8);
        }

        static void Step1(bool gender, string name)
        {
            if (gender == true) // муж. - true, жен. - false
            {
                Console.WriteLine($"Уважаемый, {name}!");
            }
            else
            {
                Console.WriteLine($"Уважаемая, {name}!");
            }
            Console.WriteLine("Приветствуем на нашем сайте!");
        }

        static void Step2(bool gender, string name)
        {
            if (gender == isMan)
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
            if (dayOfWeek == 6 || dayOfWeek == 7) // дни недели 6-7 выходные, 1...5 рабочие
            { Console.WriteLine("Выходной день"); }
            else
            { Console.WriteLine("Рабочий день"); }
        }


    }
}
