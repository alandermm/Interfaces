namespace ClasseInterface
{
    public class PF : Cliente, IAcao
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public PF()
        {
            
        }

        public PF(int id, string nome, string cpf, string email, string telefone, Endereco endereco)
        {
            base.Id = id;
            this.Nome = nome;
            this.CPF = cpf;
            base.Email = email;
            base.Telefone = telefone;
            base.End = endereco;
        }

        public string Cadastro()
        {
            string composicao = "Id do Cliente: " + Id +
                                "\nNome do Cliente: " + Nome +
                                "\nEndereço: " + End.Logradouro + ", " + End.Numero + " - " + End.Bairro +
                                "\nTelefone: " + Telefone +
                                "\nCPF: " + CPF +
                                "\nEmail: " + Email;
            return "Dados do Cliente\n\n" + composicao;
        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}