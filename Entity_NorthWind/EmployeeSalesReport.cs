using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entity_NorthWind
{
    public class EmployeeSalesReport
    {
        public static void SalesReport()
        {
            using (var db = new NorthwindEntities())
            {
                Console.Write("Enter From Date: ");
                DateTime fromDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter To Date: ");
                DateTime ToDate = DateTime.Parse(Console.ReadLine());
                Console.Clear();

                if (fromDate == null || ToDate == null)
                {
                    Console.WriteLine("Empty String.....!");
                    Console.WriteLine("Press enter to try again......");
                    Console.ReadLine();
                    Console.Clear();
                    SalesReport();
                }
                else
                {
                    var salesReport = db.EmployeeSalesReport(fromDate, ToDate).ToList();

                    foreach (var report in salesReport)
                    {
                        Console.WriteLine($"Employee Name: {report.Employee_Name} \nOrder Id: {report.OrderID} \nTotal order Count: {report.Total_Order_Count}");
                        Console.WriteLine("===================================");
                    }
                }

                

            }

        }
    }
}
