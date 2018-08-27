using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcsCourse_edX_ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine();
            myMachine._location = "Kitchen";
            myMachine._model = "DM1000";

            

            Console.WriteLine(myMachine._location);
            myMachine.MakeCapuccino();



            // Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
