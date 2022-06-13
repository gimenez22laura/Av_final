using System;

namespace QuartoDeAluguel
{
    class Program
    {

        static void Main(string[] args)
        {
            DadosDoHospede Hospede = new DadosDoHospede();

            Quarto aluguel = new Quarto();

            Console.WriteLine("**********DADOS PESSOAIS DO HÓSPEDE**********");
            Console.WriteLine();

            Console.Write("Nome: ");
            Hospede.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            Hospede.Idade = Console.ReadLine();
            Console.Write("Endereço: ");
            Hospede.Endereco = Console.ReadLine();
            Console.Write("Telefone: ");
            Hospede.Telefone = Console.ReadLine();
            Console.Write("CPF: ");
            Hospede.CPF = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            Hospede.DataNascimento = Console.ReadLine();
            Console.Write("Email: ");
            Hospede.Email = Console.ReadLine(); 

            Console.WriteLine();

            Console.WriteLine("**********CASOS DE EMERGÊNCIA**********");
            Console.WriteLine();

            Console.Write("Nome da Pessoa de Confiança: ");
            Hospede.PessoaDeConfianca = Console.ReadLine();
            Console.Write("Telefone: ");
            Hospede.PessoaConfTelefone = Console.ReadLine();
            Console.Write("Endereço: ");
            Hospede.PessoaConfEndereco = Console.ReadLine();
            Console.Write("Email: ");
            Hospede.PessoaConfEmail = Console.ReadLine();
            Console.Write("Parentesco: ");
            Hospede.PessoaConfParentesco = Console.ReadLine();

            Console.WriteLine();
            
            Console.WriteLine("**********DADOS DO ALUGUEL**********");
            Console.WriteLine();

            Console.Write("Valor da Diaria: ");
            aluguel.ValorDaDiaria = double.Parse(Console.ReadLine());
            Console.Write("Periodo da hospedagem: ");
            aluguel.PeriodoDaHospedagem = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("O VALOR TOTAL DO SEU ALUGUEL FOI: " + aluguel.Valor());
            Console.WriteLine();
        }
    }
}