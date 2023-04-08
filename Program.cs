using System;

namespace teste_de_num_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            //variável inteira chamada "numero" e atribui o valor 5 a ela
            int numero = 5;
            //cria um loop while que continua enquanto o valor da variáel "numero" for menor ou igual a 125.
            while(numero <= 125)
            {
                //imprime o valor atual da variável "numero" no console
                Console.WriteLine(numero);
                //adiciona 2 ao valor atual da variável "numero"
                numero += 2;
            }
            //espera que o usuário pressione uma tecla antes de fechar a janela do console
            Console.ReadKey();
        }
    }
}