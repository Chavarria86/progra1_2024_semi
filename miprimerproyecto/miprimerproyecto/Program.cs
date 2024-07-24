using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miprimerproyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prioridad de los operadores aritmeticos.
            // ejercicio de obtener la nota final de la materia programacion 1.
            Console.Write("lab1:");
            double lab1 = double.Parse(Console.ReadLine());

            Console.Write("lab2:");
            double lab2 = double.Parse(Console.ReadLine());

            Console.Write("parcial1:");
            double parcial1 = double.Parse(Console.ReadLine());
            //8*30%=2.4
            //9*30%=2.7
            //7*40%=2.8
            //C1   =7.9 

            double C1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C1 es : {0}", C1);

            Console.Write("lab3:");
            double lab3 = double.Parse(Console.ReadLine());

            Console.Write("lab4:");
            double lab4 = double.Parse(Console.ReadLine());

            Console.Write("parcial2:");
            double parcial2 = double.Parse(Console.ReadLine());
           

            double C2 = lab3 * 30 / 100 + lab4 * 30 / 100 + parcial2 * 40 / 100;
            Console.WriteLine("La nota de C2 es : {0}", C2);
           
            Console.Write("lab5:");
            double lab5 = double.Parse(Console.ReadLine());

            Console.Write("lab6:");
            double lab6 = double.Parse(Console.ReadLine());


            Console.Write("parcial3:");
            double parcial3 = double.Parse(Console.ReadLine());
            

            double C3 = lab5 * 30 / 100 + lab6 * 30 / 100 + parcial3 * 40 / 100;
            Console.WriteLine("La nota de C3 es : {0}", C3);
          
            
            double NF = C1 + C2 + C3 / 3;
            Console.WriteLine("La nota Final de la materia es :{0}" ,NF);

            //pausa
            Console.ReadLine();
        }
    }
}
