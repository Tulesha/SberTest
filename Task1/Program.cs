using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пункт А
            Console.WriteLine("Первый пункт");

            int month = 9;
            int year = 2020;
            List<Worker> workers = new List<Worker>
            {
                new Worker("Сергей"),
                new Worker("Толя"),
                new Worker("Мария")
            };

            GenerateWorkingDays(workers, year, month);
            FoodCalculation(workers, month);

            workers.ForEach(value => Console.WriteLine($"\t{value.Name} за {month} месяц: {value.PaymentForMeals[month]}"));


            // Пункт Б
            Console.WriteLine("\nВторой пункт");

            month = 4;
            year = 2020;
            workers = new List<Worker>
            {
                new Worker("Михаил")
            };

            GenerateWorkingDaysSecondTask(workers, year, month);
            FoodCalculation(workers, month);

            workers.ForEach(value => Console.WriteLine($"\t{value.Name} за {month} месяц: {value.PaymentForMeals[month]}"));

        }

        /// <summary>
        /// Расчет платы за еду
        /// </summary>
        /// <param name="workers">Рабочие</param>
        /// <param name="month">Месяц расчета</param>
        static void FoodCalculation(List<Worker> workers, int month)
        {
            foreach (var worker in workers)
            {
                double result = 0;
                for (int i = 0; i < worker.PresenceAtWork[month].Count; i++)
                {
                    if (i < 19 && worker.PresenceAtWork[month][i] == true)
                    {
                        result += 200;
                    }
                    else if (i >= 19 && worker.PresenceAtWork[month][i] == true)
                    {
                        result += 300;
                    }
                }
                worker.PaymentForMeals.Add(month, result);
            }
        }


        /// <summary>
        /// Случайная генерация рабочих дней
        /// </summary>
        /// <param name="workers">Рабочие</param>
        /// <param name="year">Год случайное генерации</param>
        /// <param name="month">Месяц случайной генерации</param>
        static void GenerateWorkingDays (List<Worker> workers, int year, int month)
        {
            foreach (var worker in workers)
            {
                List<bool> workingDays = new List<bool>();

                Random rng = new Random();
                foreach (var day in Enumerable.Range(1, DateTime.DaysInMonth(year, month)))
                {
                    DateTime currnetDate = new DateTime(year, month, day);
                    if (rng.Next(0, 2) == 1 && currnetDate.DayOfWeek != DayOfWeek.Saturday && currnetDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        workingDays.Add(true);
                    }
                    else
                    {
                        workingDays.Add(false);
                    }
                }
                worker.PresenceAtWork.Add(month, workingDays);
            }
        }

        /// <summary>
        /// Генерация данных для пункта Б
        /// </summary>
        /// <param name="workers">Рабочие</param>
        /// <param name="year">Год генерации</param>
        /// <param name="month">Месяц генерации</param>
        static void GenerateWorkingDaysSecondTask (List<Worker> workers, int year, int month)
        {
            foreach (var worker in workers)
            {
                List<bool> workingDays = new List<bool>();

                foreach (var day in Enumerable.Range(1, DateTime.DaysInMonth(year, month)))
                {
                    DateTime currnetDate = new DateTime(year, month, day);
                    if (currnetDate.DayOfWeek != DayOfWeek.Saturday && currnetDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        workingDays.Add(true);
                    }
                    else
                    {
                        workingDays.Add(false);
                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    workingDays[i] = false;
                }
                for (int i = 5; i < 11; i++)
                {
                    workingDays[i] = false;
                }

                worker.PresenceAtWork.Add(month, workingDays);
            }
            
        }
    }
}
