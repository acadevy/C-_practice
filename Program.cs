using System;
using System.Collections.Generic;

namespace C__practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] grid1 = new[,]{
                {"Rasheed","Yusuf","Femi"},
                {"Tope","Adeola","Tunde"},
                {"Adeniji","oluwafemi","suliyat"}
            };

            Console.WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
            Console.WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}");
            Console.WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}");
            Console.WriteLine($"Upper bound of the second dimension is: {grid1.GetUpperBound(1)}");

        }
          
        }
        
         


}


