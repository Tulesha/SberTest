using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    /// <summary>
    /// Класс компании
    /// </summary>
    class Company
    {
        /// <summary>
        /// Название компании
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Процент аванса
        /// </summary>
        public double AdvPrc { get; }

        /// <summary>
        /// Минимальное количество отработанных дней
        /// </summary>
        public int MinWDays { get; }
        public bool UseAdvDay { get; }

        /// <summary>
        /// День выплаты аванса
        /// </summary>
        public int DE { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название компании</param>
        /// <param name="advPrc">Процент аванса</param>
        /// <param name="minWDays">Минимальное количество отработанных дней</param>
        /// <param name="useAdvDay"></param>
        /// <param name="de">День выплаты аванса</param>
        public Company(string name, double advPrc, int minWDays, bool useAdvDay, int de)
        {
            this.Name = name;
            this.AdvPrc = advPrc;
            this.MinWDays = minWDays;
            this.UseAdvDay = useAdvDay;
            this.DE = de;
        }
    }
}
