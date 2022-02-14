using System;

namespace Exercico_POO_EstruturadeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro para base: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um numero inteiro para o expoente: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O Resultado da Exponenciação é: " + Matematica.Exponeciacao(valor1, valor2));

            Console.ReadKey();
        }
    }
}
