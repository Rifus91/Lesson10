using System;

namespace Lesson10
{
    class Program
    {
        public static bool isMan = true;
        public static bool isWomen = false;
        static void Main(string[] args)
        {
            //ввод от клиента, пол и имя
            Step2(false, "Иванова Ольга");
            //Step1(true, "Петров Иван");
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


    }
}
