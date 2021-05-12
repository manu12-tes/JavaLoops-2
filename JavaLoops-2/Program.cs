using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaLoops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dame un numero de repeticiones : ");
            int seq = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < seq; i++)
            {
                int aux = 1;
                Console.WriteLine("dame tres numeros : ");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                int n = Int32.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    a = a + (b * aux);
                    Console.WriteLine(a);
                    aux = aux * 2;
                }
            }
        }
    }
}
