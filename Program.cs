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
            //Console.WriteLine("Hola mundo");
            int num1 = 5;
            int num2 = 6;
            double num3 = 2.57;
            double suma;
            suma = num1 + num3;

            Console.WriteLine(suma);
            string valor1 = Console.ReadLine();
            Console.WriteLine("el numero introducido es: " + valor1);
            int valorint = Convert.ToInt32(valor1);

            Console.ReadKey();

        }
    }
}