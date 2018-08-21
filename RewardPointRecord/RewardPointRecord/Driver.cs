using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RewardPointRecord
{
    class Driver
    {
        static void Main(string[] args)
        {
           
            
            //instantiate the Customers and their transactions
            Customer Customer1 = new Customer(1);
            int[] customer1month1 = new int[3] { 59, 127, 205 };
            int[] customer1month2 = new int[3] { 294, 26, 137 };
            int[] customer1month3 = new int[3] { 164, 100, 204 };
            Customer1.setArrays(customer1month1, customer1month2, customer1month3);
            int customer1Month1Points = Customer1.CalculateMonth1Points();
            int customer1Month2Points = Customer1.CalculateMonth2Points();
            int customer1Month3Points = Customer1.CalculateMonth3Points();
            int customer1TotalPoints = Customer1.CalculateTotalPoints();

            Customer Customer2 = new Customer(2);
            int[] customer2month1 = new int[3] { 193, 105, 216 };
            int[] customer2month2 = new int[3] { 85, 65, 151 };
            int[] customer2month3 = new int[3] {103, 100, 196 };
            Customer2.setArrays(customer2month1, customer2month2, customer2month3);
            int customer2Month1Points = Customer2.CalculateMonth1Points();
            int customer2Month2Points = Customer2.CalculateMonth2Points();
            int customer2Month3Points = Customer2.CalculateMonth3Points();
            int customer2TotalPoints = Customer2.CalculateTotalPoints();

            Customer Customer3 = new Customer(3);
            int[] customer3month1 = new int[3] { 174, 172, 117 };
            int[] customer3month2 = new int[3] { 245, 55, 199 };
            int[] customer3month3 = new int[3] { 239, 201, 101 };
            Customer3.setArrays(customer3month1, customer3month2, customer3month3);
            int customer3Month1Points = Customer3.CalculateMonth1Points();
            int customer3Month2Points = Customer3.CalculateMonth2Points();
            int customer3Month3Points = Customer3.CalculateMonth3Points();
            int customer3TotalPoints = Customer3.CalculateTotalPoints();

            //dispaly info
            Console.WriteLine("        Customer Reward Points");
            Console.WriteLine("Points are calculated as Follows: Every dollar spent above 50 is worth 1 point, and every dollar spent over 100 is 2 points");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("        Customer 1");
            Console.WriteLine("Customer ID: " + Customer1.GetCustomerID());
            Console.WriteLine("-----------------------------------------");
            //get customer1 records
            
            Console.WriteLine("Month 1");
            for(int i = 0; i < customer1month1.Length; ++i)
            {
                Console.WriteLine("$" + customer1month1[i]);
            }
            Console.WriteLine("Monthly Points: " + customer1Month1Points);
            Console.WriteLine("");
            Console.WriteLine("Month 2");
            for (int i = 0; i < customer1month2.Length; ++i)
            {
                Console.WriteLine("$" + customer1month2[i]);
            }
            Console.WriteLine("Monthly Points: " + customer1Month2Points);
            Console.WriteLine("");
            Console.WriteLine("Month 3");
            for (int i = 0; i < customer1month3.Length; ++i)
            {
                Console.WriteLine("$" + customer1month3[i]);
            }
            Console.WriteLine("Monthly Points: " + customer1Month3Points);
            Console.WriteLine("");
            Console.WriteLine("TOTAL POINTS: " + customer1TotalPoints);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("        Customer 2");
            Console.WriteLine("Customer ID: " + Customer2.GetCustomerID());
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Month 1");
            for (int i = 0; i < customer2month1.Length; ++i)
            {
                Console.WriteLine("$" + customer2month1[i]);
            }
            Console.WriteLine("Monthly Points: " + customer2Month1Points);
            Console.WriteLine("");
            Console.WriteLine("Month 2");
            for (int i = 0; i < customer2month2.Length; ++i)
            {
                Console.WriteLine("$" + customer2month2[i]);
            }
            Console.WriteLine("Monthly Points: " + customer2Month2Points);
            Console.WriteLine("");
            Console.WriteLine("Month 3");
            for (int i = 0; i < customer2month3.Length; ++i)
            {
                Console.WriteLine("$" + customer2month3[i]);
            }
            Console.WriteLine("Monthly Points: " + customer2Month3Points);
            Console.WriteLine("");
            Console.WriteLine("TOTAL POINTS: " + customer2TotalPoints);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("        Customer 3");
            Console.WriteLine("Customer ID: " + Customer3.GetCustomerID());
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Month 1");
            for (int i = 0; i < customer3month1.Length; ++i)
            {
                Console.WriteLine("$" + customer3month1[i]);
            }
            Console.WriteLine("Monthly Points: " + customer3Month1Points);
            Console.WriteLine("");
            Console.WriteLine("Month 2");
            for (int i = 0; i < customer3month2.Length; ++i)
            {
                Console.WriteLine("$" + customer3month2[i]);
            }
            Console.WriteLine("Monthly Points: " + customer3Month2Points);
            Console.WriteLine("");
            Console.WriteLine("Month 3");
            for (int i = 0; i < customer3month3.Length; ++i)
            {
                Console.WriteLine("$" + customer3month3[i]);
            }
            Console.WriteLine("Monthly Points: " + customer3Month3Points);
            Console.WriteLine("");
            Console.WriteLine("TOTAL POINTS: " + customer3TotalPoints);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Press Enter to quit");
            Console.ReadLine();
        }
    }
}
