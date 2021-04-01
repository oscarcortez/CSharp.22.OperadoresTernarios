using System;

namespace ConsoleApp4OperadoresTernarios
{
    class Program
    {

        /// <summary>
        /// is like if but in one statement
        /// first boolean expression, (true) sentence 1, (false) sentence 2
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            int mayoriaEdad = 21, edadActual= 35;
            string resultado = default;
            if (mayoriaEdad <= edadActual)
            {
                resultado = "El usuario es mayor de edad";
            }
            else
            {
                resultado = "El usuario es menor de edad";
            }

            Console.WriteLine(resultado);

            Console.WriteLine(mayoriaEdad <= edadActual ? "si es mayor de edad" : "no es mayor de edad");
            string res2 = mayoriaEdad <= edadActual ? "si es mayor de edad" : "no es mayor de edad";

            Console.WriteLine(res2);
        }
    }
}
