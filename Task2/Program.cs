using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int accPer = DateTime.Now.Month;
            DateTime d1 = new DateTime(DateTime.Now.Year, accPer, 1);
            DateTime d2 = d1.AddMonths(1).AddDays(-1);

            Company company = new Company("Пекарня пышки", 0.4, 20, true, 3);
            Worker worker = new Worker("Толя", 30000, 25, new DateTime(2020, 2, 4));
            worker.WorkDays = GenerateWorkDays(DateTime.Now.Year, accPer);

            try
            {
                var prepaid = CalculatePrepaidExpense(company, worker, d1, d2);
                Console.WriteLine($"Сотрудник {worker.Name} получает аванс в размере {prepaid}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static double CalculatePrepaidExpense(Company company, Worker worker, DateTime d1, DateTime d2)
        {
            if (company.AdvPrc == 0)
                throw new Exception("Процентная ставка равна 0");

            if (company.UseAdvDay == true)
                d2 = new DateTime(d2.Year, d2.Month, company.DE);

            if (worker.DateEnd <= d2 && worker.DateEnd != DateTime.MinValue)
                throw new Exception("Сотрудник уволен");

            if (worker.WorkDays < company.MinWDays)
            {
                throw new Exception("Сотрудник не отработал положенное время");
            }

            return worker.Salary / worker.PlanDays * worker.WorkDays * company.AdvPrc;
        }

        static int GenerateWorkDays(int year, int month)
        {
            Random rng = new Random();
            return rng.Next(15, DateTime.DaysInMonth(year, month) + 1);
        }
    }
}
