using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string aString = "";
            int b = 0;
            string bString = "";

            Console.WriteLine("Introduce a");
            aString = Console.ReadLine();
            Console.ReadLine();
            a = Convert.ToInt16(aString);



            Console.WriteLine("Introduce b");
            bString = Console.ReadLine();
            b = Convert.ToInt16(bString);


            Operacion Oper = new Operacion();

            Oper.Seta(a);
            Oper.Setb(b);


            Console.WriteLine("El resultado es = {0}", Oper.GetResultado());
            Console.ReadKey();

        }
    }
}
