using System;

namespace Lesson10
{
    class Program
    {           

        public const string ProgramName = "Календарь";

        static void Main(string[] args)
        {
            //ввод от клиента, пол и имя
             Step1(GenderEnum.Women, "Иванова Ольга");
            
            StepWeek1(DayOfWeekEnum.Monday);
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
            { Console.WriteLine($"{DayToRussian(dayOfWeek)} - Выходной день"); }
            else
            { Console.WriteLine($"{DayToRussian(dayOfWeek)} - Рабочий день"); }
        }

        static string DayToRussian(DayOfWeekEnum dayOfWeek)
        {
            string output = "";
            switch (dayOfWeek)
            {
                case DayOfWeekEnum.Monday:
                    output = "Понедельник";
                    break;
                case DayOfWeekEnum.Tuesday:
                    output = "Вторник";
                    break;
                case DayOfWeekEnum.Wednesday:
                    output = "Среда";
                    break;
                case DayOfWeekEnum.Thursday:
                    output = "Четверг";
                    break;
                case DayOfWeekEnum.Fridey:
                    output = "Пятница";
                    break;
                case DayOfWeekEnum.Saturday:
                    output = "Суббота";
                    break;
                case DayOfWeekEnum.Sanday:
                    output = "Воскресенье";
                    break;
                default:
                    break;
            }
            return output;
        }






    }
}
