using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
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
        /// Словарь расчетов питания. 
        /// Ключ - номер месяца.
        /// Значение - расчет питания за месяц.
        /// </summary>
        public Dictionary<int, double> PaymentForMeals;

        /// <summary>
        /// Словарь рабочих дней.
        /// Ключ - номер месяца.
        /// Значение - список дней, где true - работал, false - не работал.
        /// </summary>
        public Dictionary<int, List<bool>> PresenceAtWork;

        /// <summary>
        /// Констуктор
        /// </summary>
        /// <param name="Name">Имя рабочего</param>
        public Worker(string Name)
        {
            this.Name = Name;
            PresenceAtWork = new Dictionary<int, List<bool>>();
            PaymentForMeals = new Dictionary<int, double>();
        }
    }
}
