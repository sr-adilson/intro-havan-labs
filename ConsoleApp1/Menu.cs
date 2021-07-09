using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp1
{
    class Menu
    {
        public static void MontaMenu()
        {
            //Cabecalho
            Cabecalho();
            //opcoes
            Opcoes();
            //rodape
            Rodape();
            //escolha
            Escolha();

        }

        private static void Rodape()
        {
            Console.WriteLine("Escolha uma opção do menu: ");
        }

        private static void Opcoes()
        {
            Console.WriteLine("1-Cadastrar Usuario");
            Console.WriteLine("2-Cadastrar Produto");
            Console.WriteLine("0-Sair");
        }

        private static void Cabecalho()
        {
            Console.WriteLine("****************** Havan Labs *******************");
            Console.WriteLine("******************* Bem Vindo *******************");
        }
        private static void Escolha()
        {
            int opcao = 0;
            do
            {
                opcao = Validacao.ValidaInteiro();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("tchau");
                        break;
                    case 1:
                        Usuario user = new Usuario();

                        user.Cadastro();

                        break;
                    case 2:
                        Console.WriteLine("Em implementação (falta dev)");
                        break;
                    default:
                        Console.WriteLine("Digite 1 2 ou 3");
                        break;
                }
            }
            while (opcao < 0 || opcao > 2);
        }
    }
}
            
           
            
        

