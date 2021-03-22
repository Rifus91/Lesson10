using System;

namespace Lesson10
{
    class Program
    {           

        public const string ProgramName = "Календарь";

        static void Main(string[] args)
        {
            //ввод от клиента, пол и имя
             //Step1(GenderEnum.Women, "Иванова Ольга");
            
            StepWeek1((DayOfWeekEnum)5);
        }

       
        static void Step1(GenderEnum gender, string name)
        {
            if (gender == GenderEnum.Man)
            {
                Console.WriteLine($"Уважаемый, {name}!");
            }
            else
            {
                Console.WriteLine($"Уважаемая, {name}!");
            }
            Console.WriteLine("Приветствуем на нашем сайте!");
        }

        static void StepWeek1(DayOfWeekEnum dayOfWeek)
        {
            if (dayOfWeek == DayOfWeekEnum.Saturday || dayOfWeek == DayOfWeekEnum.Sanday)
            { Console.WriteLine($"{dayOfWeek} - Выходной день"); }
            else
            { Console.WriteLine($"{dayOfWeek} - Рабочий день"); }
        }

       
        


    }
}
