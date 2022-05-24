using System;

namespace clase_de_consulta
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 0; 
            
            while (valor2 == 0)
            {
                Console.Write("ingrese valor 1: ");
                valor1 = int.Parse(Console.ReadLine());

                Console.Write("ingrese valor 2: ");
                valor2 = int.Parse(Console.ReadLine());

                try
                {
                    int rta = valor1/valor2;                    
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine("error, no se puede dividir por cero");
                }                
                
            }
            int div = valor1 / valor2;
            Console.WriteLine("resultado:", div);

        }
    }
}
