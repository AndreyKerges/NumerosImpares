using System;

namespace teste_de_num_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            while(numero <= 125)
            {
                Console.WriteLine(numero);
                numero += 2;
            }
            Console.ReadKey();
        }
    }
}