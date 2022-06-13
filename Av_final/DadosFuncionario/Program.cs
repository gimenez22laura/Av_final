using System;

namespace DadosFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe a quantidade de funcionarios desejada: ");
            int quantidadeFunci = int.Parse(Console.ReadLine());

            Funcionario[] vetorFunc = new Funcionario[quantidadeFunci];//Declaracao e instanciacao do vetor conforme quantidade definida pelo usuario

            for (int i = 0; i < quantidadeFunci; i++)
            {
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("**********Informe os dados do funcionario********** ");
                Console.WriteLine();
                Console.Write("Nome: ");
                string func = Console.ReadLine();
                Console.Write("Salário Bruto: ");
                double salarioBrt = double.Parse(Console.ReadLine());
                Console.Write("Imposto: ");
                double imposto = double.Parse(Console.ReadLine());

                vetorFunc[i] = new Funcionario(func, salarioBrt, imposto);

                Console.WriteLine(vetorFunc[i]);

                Console.WriteLine("Informe o percentual de aumento desejado: ");
                double percent = double.Parse(Console.ReadLine());
                vetorFunc[i].AumetarSalario(percent);

                Console.WriteLine("**********Dados atualizados**********");
                Console.WriteLine(vetorFunc[i]);
            }
        }
    }
}