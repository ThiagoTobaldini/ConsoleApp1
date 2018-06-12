using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //var interpreter = new Interpreter();
            //double visor = 1;

            //visor = visor + double.Parse(Console.ReadKey().KeyChar.ToString());
            //Console.Clear();
            //Console.WriteLine(visor.ToString("c2"));
            //visor = visor + double.Parse(Console.ReadKey().KeyChar.ToString());
            //Console.Clear();

            DateTime TM1 = System.DateTime.Now;

            TM1.ToShortDateString();





            //var resultformatado = result.ToString("c2");
            Console.WriteLine(TM1.ToShortDateString());
            Console.ReadKey();
        }
    }
}
