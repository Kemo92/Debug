using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 10000;
            int interval = 5;
            int tranNumber = 0;
            int i;


            for (i = 0; tranNumber <= interval; tranNumber++ )
            {
                Console.WriteLine("Enter amout to add to Account ");
                string userDep = Console.ReadLine();
                int deposit = Convert.ToInt32(userDep);

                sum += deposit;

                Console.WriteLine("Your new balance is {0}.", sum);
                Console.ReadLine();


            }
            




                

           

            

            

       

          

           


        }
    }
}
