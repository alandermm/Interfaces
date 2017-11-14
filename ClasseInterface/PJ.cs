namespace ClasseInterface
{
    public class PJ : Cliente, IAcao
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        public PJ()
        {
            
        }

        public PJ(int Id, string RazaoSocial, string CNPJ, string Email, string Telefone, Endereco endereco )
        {
            base.Id = Id;
            this.RazaoSocial = RazaoSocial;
            this.CNPJ = CNPJ;
            base.Email = Email;
            base.Telefone = Telefone;
            base.End = endereco;
        }
        public string Cadastro()
        {
            string composicao = "Id: " + Id +
                                "Razão Social: " + RazaoSocial +
                                "CNPJ: " + CNPJ +
                                "E-mail: " + Email +
                                "Telefone: " + Telefone +
                                "Endereço: " + End.Logradouro + ", " + End.Numero + " - " + End.Bairro;
            return "Dados do Cliente\n\n" + composicao;
        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}