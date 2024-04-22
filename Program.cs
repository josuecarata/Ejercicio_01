using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            int numeroIngresado;
            int numeroMayor = int.MinValue;
            int numeroMenor = int.MaxValue;
            int numeroTotal = 0;
            float promedio = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese numero");
                numeroIngresado =   int.Parse(Console.ReadLine());
                if(numeroIngresado > numeroMayor)
                {
                    numeroMayor = numeroIngresado;
                }
                else if(numeroIngresado < numeroMenor)
                {
                    numeroMenor = numeroIngresado;
                }
                numeroTotal = numeroTotal + numeroIngresado;
            }
            promedio = (float)(numeroTotal / 5d);
            Console.WriteLine("Numero mayor:{0}", numeroMayor);
            Console.WriteLine("Numero menor:{0}", numeroMenor);
            Console.WriteLine("Numero total: {0}", numeroTotal);
            Console.WriteLine("Promedio: {0:#.###,00}", promedio);
            Console.ReadKey();
        }
    }
}
