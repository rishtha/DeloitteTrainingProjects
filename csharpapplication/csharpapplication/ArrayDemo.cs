using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpapplication
{
    internal class ArrayDemo
    {
        public void GetTotalTickets()
        {
            //jagged array

            string[] data = { "val1", "val2" };

            string[][] counter = new string[3][];

            
            counter[0] = new string[3];
            counter[1] = new string[2];
            counter[2] = new string[4];

            counter[0][0] = "P1";
            counter[0][1] = "P1";
            counter[0][2] = "P1";

            counter[1][0] = "P4";
            counter[1][1] = "P5";

            counter[2][0] = "P6";



            for (int i = 0; i < counter.Length; i++)
            {
                for (int j = 0; j < counter[i].Length; j++) 
                { 
                    //condition
                }
            }
        }
    }
}
