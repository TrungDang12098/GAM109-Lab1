using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bai1
            Console.WriteLine("ID: " + UserData.ID);
            Console.WriteLine("UserName: " + UserData.UserName);
            Console.WriteLine("Health: " + UserData.Health);
            Console.WriteLine("Point: " + UserData.Point);


            //bai2
            var maps1 = new Maps("2024", "URF");
            Console.WriteLine(maps1.ShowData());

            var maps2 = new Maps("2024", "URF")
            {
                ID = "2024",
                Name = "URF"
            };
            Console.WriteLine(maps2.ShowData());


            //bai3
            Calculator cal = new Calculator(10, 5);

            Console.WriteLine("A = " + cal.A);
            Console.WriteLine("B = " + cal.B);
            Console.WriteLine("Cong: " + cal.Cong());
            Console.WriteLine("Tru: " + cal.Tru());
            Console.WriteLine("Nhan: " + cal.Nhan());
            Console.WriteLine("Chia: " + cal.Chia());

            Console.ReadLine();

        }
    }
}
