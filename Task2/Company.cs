using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Company
    {
        public string Name { get; }
        public double AdvPrc { get; }
        public int MinWDays { get; }
        public bool UseAdvDay { get; }
        public int DE { get; }
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
