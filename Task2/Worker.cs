using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    /// <summary>
    /// Класс рабочего
    /// </summary>
    class Worker
    {
        /// <summary>
        /// Имя рабочего
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Оклад рабочего
        /// </summary>
        public double Salary { get; }

        /// <summary>
        /// Отработанные дни
        /// </summary>
        public int WorkDays { get; set; }

        /// <summary>
        /// Плановые отработанные дни
        /// </summary>
        public int PlanDays { get; }

        /// <summary>
        /// Дата приема на работу
        /// </summary>
        public DateTime DateBegin { get; }

        /// <summary>
        /// Дата увольнения
        /// </summary>
        public DateTime DateEnd { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя рабочего</param>
        /// <param name="salary">Оклад</param>
        /// <param name="planDays">Плановые отработанные дни</param>
        /// <param name="dateBegin">Дата приема на работу</param>
        public Worker(string name, double salary, int planDays, DateTime dateBegin)
        {
            this.Name = name;
            this.Salary = salary;
            this.DateBegin = dateBegin;
            this.PlanDays = planDays;
        }
    }
}
