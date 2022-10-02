using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_NorthWind
{
    public class ProductWiseMonthalyReport
    {
        public static void MonthlyReport()
        {
            using (var db = new NorthwindEntities())
            {
                Console.Write("Enter product name: ");
                string productName = Console.ReadLine();

                Console.Write("Enter month: ");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter year: ");
                int year = int.Parse(Console.ReadLine());

                Console.Clear();
                if (productName == null || month == 0 || month == null || year == 0 || year == null)
                {
                    Console.WriteLine("Invalid Input....!");
                    Console.WriteLine("Press enter to try again......");
                    Console.ReadLine();
                    Console.Clear();
                    MonthlyReport();

                }
                else
                {
                    var productReport = db.ProductReport(productName, month, year).ToList();

                    foreach (var report in productReport)
                    {
                        Console.WriteLine($"Employee Name: {report.ProductName} \nOrder Id: {report.Month} \nTotal order Count: {report.Column1}");
                        Console.WriteLine("===================================");
                    }
                }



            }

        }
    }
}
