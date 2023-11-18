using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_one_c_sharp
{


    internal class emp
    {
        public float a;
        public int b;
        public float descound = 10;
        public void name()
        {


           String a=Console.ReadLine();

            b = int.Parse(a);

            if(b <=5000)
            {
                Console.WriteLine($"Buy more than 5000 to get a 10% discount ... You purchased for a sum of money {b}");


            }
            else
            {
                Console.WriteLine($"{b - (b * descound) / 100}");
                Console.WriteLine($"The salary {b} $ congratolation Sale 10%...");

                // b - (b * descound) / 100;
            }


        }   
        static void Main(string[] args)
        {

            emp c1 = new emp();

            c1.name();




            


        

        }
    }
}
