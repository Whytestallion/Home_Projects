using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = 100.00;

            double hundredBills = 0.00;

            while (change > 0)
            {
                if (change >= 100)
                {
                    hundredBills = Math.Floor(change / 100);
                    change = change % 100;
                }
                else if(change >= 50)
                {
                    hundredBills = Math.Floor(change / 50);
                    change = change % 50;
                }
                else if (change >= 20)
                {
                    hundredBills = Math.Floor(change / 20);
                    change = change % 20;
                }
                else if (change >= 10)
                {
                    hundredBills = Math.Floor(change / 10);
                    change = change % 10;
                }
                else if (change >= 5)
                {
                    hundredBills = Math.Floor(change / 5);
                    change = change % 5;
                }
                else if (change >= 1)
                {
                    hundredBills = Math.Floor(change / 1);
                    change = change % 1;
                }
                else if (change >= 0.25)
                {
                    hundredBills = Math.Floor(change / 0.25);
                    change = change % 0.25;
                }
                else if (change >= 0.10)
                {
                    hundredBills = Math.Floor(change / 0.10);
                    change = change % 0.10;
                }
                else if (change >= 0.05)
                {
                    hundredBills = Math.Floor(change / 0.10);
                    change = change % 0.10;
                }
                else
                {
                    hundredBills = Math.Floor(change / 0.01);
                    change = change % 0.01;
                }
            }
        }
    }
}
