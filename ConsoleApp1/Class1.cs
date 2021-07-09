using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public static void Ex2(string[] args)
        {
            Console.Write("Digite seu nome  ");
            string nome = Console.ReadLine();
            Console.Write($"Olá, {nome}. Qual o sua idade? ");
            int idade = 0;
            while (idade == 0)
           {
                try
                {
                    idade = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Dado inválido! Digite novamente");
                }
            }
            Console.WriteLine($"Olá, {nome} sua idade é: {idade}");
            Console.ReadLine();
        }
    }
}
