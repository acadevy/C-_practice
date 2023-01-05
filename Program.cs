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


            for(int row = 0; row<=grid1.GetUpperBound(0);row++){
                for(int col = 0; col <= grid1.GetUpperBound(1); col++){
                    Console.WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
                }
            }
        }
          
        }
        
         


}


