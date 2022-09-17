using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa yerlesdireceyiniz meblegi daxil edin:");
            try
            {
                decimal mebleg = Convert.ToDecimal(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Zehmet olmasa reqem daxil edin:");
            }

            Console.WriteLine("Zehmet olmasa ili daxil edin:");
            //int il = int.Parse(Console.ReadLine());
           // decimal netice = ((mebleg + ((mebleg * 6) / 100))*il);



           // Console.WriteLine(netice);
        }
    }
}
