using System;

namespace EJERCICIO_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PASO 0: DECLARACION DE VARIABLES
            //TIPO DE DATO: INT, FLOAT, CHAR, BOOL
            int N1, N2, resultado;

            //PASO 1: PEDIR VALORES
            Console.WriteLine("INGRESE UN NUMERO: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE OTRO NUMUERO: ");
            N2 = int.Parse(Console.ReadLine());
            
            //PASO 2: REALIZAR CALCULO
            resultado = N1 + N2;

            //PASO 3: EMITIR RESULTADO
            Console.WriteLine("EL RESULTADO ES: " + resultado);
        }
    }
}
