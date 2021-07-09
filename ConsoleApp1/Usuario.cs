using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp1
{
    class Usuario
    {
        public string nome = String.Empty;
        public string sobrenome = String.Empty;
        public int idade = 0;
        public string email = String.Empty;
        public string endereco = String.Empty;
        public void Cadastro()
        {
            Console.Write("Digite seu primeiro nome: ");
            this.nome = Validacao.ValidaString();
            Console.Write("Digite seu sobrenome: ");
            this.sobrenome = Validacao.ValidaString();
            Console.Write("Digite sua Idade: ");
            this.idade = Validacao.ValidaInteiro();          
            Console.Write("Digite seu Email: ");
            this.email = Validacao.ValidaString();
            Console.Write("Digite seu endereço: ");
            this.endereco = Validacao.ValidaString();
            Console.Write($"Olá {this.nome} {this.sobrenome}, sua idade é {this.idade}, você mora nesse endereço {this.endereco}, e seu email é {this.email}");
            Console.ReadLine();

        }       
        
    }
}
