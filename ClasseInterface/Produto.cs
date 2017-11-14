using System;
using System.Text;
namespace ClasseInterface
{
    public class Produto: IAcao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
            
        }

        public Produto(int Id, string Nome, string Descricao, double Preco)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.Preco = Preco;
        }

        public string Cadastro(){
            string composicao = "Id do Produto: "+ Id +
                                "\nNome do Produto: "+ Nome.ToUpper() +
                                "\nDescrição do Produto: " + Descricao +
                                "\nPreço do Produto: " + string.Format("{0:C2}", Preco);
            return "Produto cadastrado\n" + composicao;
        }

        public string Consulta(){
            throw new System.NotImplementedException();
        }
    }
}