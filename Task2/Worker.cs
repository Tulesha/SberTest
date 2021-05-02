using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Worker
    {
        public string Name { get; }
        public double Salary { get; }
        public int WorkDays { get; set; }
        public int PlanDays { get; }
        public DateTime DateBegin { get; }
        public DateTime DateEnd { get; set; }

        public Worker(string name, double salary, int planDays, DateTime dateBegin)
        {
            this.Name = name;
            this.Salary = salary;
            this.DateBegin = dateBegin;
            this.PlanDays = planDays;
        }
    }
}
