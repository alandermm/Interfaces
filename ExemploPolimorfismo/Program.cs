using System;
using ClasseInterface;

namespace ExemploPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Produto pr = new Produto(){
                Id = 30,
                Nome = "Sabão",
                Descricao = "Em pó",
                Preco = 30.00                
            };
            Console.WriteLine(pr.Cadastro());*/

            Endereco endereco = new Endereco();
            endereco.Logradouro = "Rua Nova Esperança";
            endereco.Numero = "56";
            endereco.Bairro = "Jardim Alegria";

            PF pf = new PF(10, "Helena", "2356", "helena@email.com", "4545", endereco);
            Console.WriteLine(pf.Cadastro());
        }
    }
}