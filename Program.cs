using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siesa_punto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE EL VALOR NUMERICO");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE EL NUMERO BASE");
            int newBase = int.Parse(Console.ReadLine());

            string result = ConvertToBase(number, newBase);

            Console.WriteLine("El Numero ingresado es : " + number+ "\n");
            Console.WriteLine("La Base Ingresado es : " + newBase + "\n");
            Console.WriteLine("El Resultado es : {0}", result);
            Console.ReadLine();
            
        }

        /// <summary>
        /// Convierte un número de base 10 a otra base.
        /// </summary>
        /// <param name="number">El número a convertir, en base 10.</param>
        /// <param name="newBase">La base a la que convertir el número.</param>
        /// <returns>Una representación de cadena del número en la nueva base.</returns>
        /// <example>
        /// ConvertToBase(287, 4) devuelve "10133"
        /// </example>
        public static string ConvertToBase(int number, int newBase)
        {
            string result = "";
            Console.WriteLine(" Cociente | Residuo");
            Console.WriteLine("------------ ------------");
            while (number > 0)
            {
                int remainder = number % newBase;
                result = remainder + result;

                Console.WriteLine(" {0,8} | {1,12}", number, remainder);
                number = number / newBase;
            }

            return result;
        }
    }
}
