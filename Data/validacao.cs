using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Validacao
    {
        public static string ValidaString()
        {
            string dado = string.Empty;
            dado = Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(dado))
            {
                Console.WriteLine("Valor Invalido");
                dado = Console.ReadLine().Trim();

            }
            return dado;
        }


        public static int ValidaInteiro()
        {
            do
            {
                try
                {
                    int dado = Convert.ToInt32(Console.ReadLine());
                    return dado;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dado inválido! Digite novamente");
                }

            } while (true);
        }
    }
}
