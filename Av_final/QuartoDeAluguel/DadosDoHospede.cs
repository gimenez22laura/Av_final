namespace QuartoDeAluguel
{
    class DadosDoHospede
    {
        public string Nome;
        public string Idade;
        public string Endereco;
        public string Telefone;
        public string CPF;
        public string DataNascimento;
        public string Email;

        public string PessoaDeConfianca;
        public string PessoaConfTelefone;
        public string PessoaConfEndereco;
        public string PessoaConfEmail;
        public string PessoaConfParentesco;

        public override string ToString()
        {
            return " ====================== \n"
                + " DADOS DO HOSPEDE \n"
                + " O Hospede "
                + "Nome: " + Nome.ToUpper()
                + "Idade " + Idade.ToUpper()
                + "Endereço: " + Endereco.ToUpper()
                + "Telefone: " + Telefone.ToUpper()
                + "CPF: " + CPF.ToUpper()
                + "Data de Nascimento: " + DataNascimento.ToUpper()
                + "Email: " + Email.ToUpper();
        }
    }
}


