using System;

namespace Lesson10
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //ввод от клиента, пол и имя
            Step1(false, "Иванова Ольга");
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
        

    }
}
