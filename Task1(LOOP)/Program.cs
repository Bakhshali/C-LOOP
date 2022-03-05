using System;

namespace Task1_LOOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] brand = new string[] {"Mercedes" , "BMW" , "Audi", "Nissan", "Porche", "Lambo", "GMC" };
            for (int i = 0; i < brand.Length; i++)
                if (brand[i].Length > 5)
                {
                Console.WriteLine(brand[i]);
                    
            }
        }
    }
}
