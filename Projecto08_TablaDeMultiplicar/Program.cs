using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projecto08_TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM,RESUL;
            RESUL = 0;
            int I;
            I = 1;
            Console.WriteLine("DIGITE EL NUMERO : ");
            NUM = Convert.ToInt32(Console.ReadLine());
            //NUM = int.parse(Console.ReadLine());
            while (I<=12)
            {
                RESUL = NUM * I;

                //Console.WriteLine(NUM + " * " + I + " = " + RESUL);
                Console.WriteLine("{0} * {1} = {2}", NUM, I, RESUL);


                I = I + 1;
            }
            Console.ReadKey();

        }
    }
}
