using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//output of this program is 


/*
   *****
   ****
   ***
   **
   *
   
   
   */
namespace Pattern54321
{
     class Pattern
    {
        public static void Main(String[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j=i; j <= 5; j++)
                {
                    Console.Write("*");

                }
               
                         
                Console.WriteLine();
            }
        }
    }
}
