using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_sem7_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    cont++;
                    Console.WriteLine("Divisor de  " + "Alejandro Ledesma" + ": " + i);
                    Console.ReadKey();
                }
            }
            
        }
    }
}
