using System;
using System.Globalization;

namespace NotasAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Aluno;
            Aluno = new Aluno();

            Console.Write("Informe o nome do Aluno: ");
            Aluno.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Informe a primeira nota do Aluno: ");
            Aluno.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (Aluno.Nota1 > 30)
            {
                while (Aluno.Nota1 > 30)
                {
                    Console.Write("A nota maxima é 30. Informe a nota novamente: ");
                    Aluno.Nota1 = double.Parse(Console.ReadLine());
                }
            }

            Console.Write("Informe a segunda nota do Aluno: ");
            Aluno.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (Aluno.Nota2 > 35)
            {
                while (Aluno.Nota2 > 35)
                {
                    Console.Write("A nota maxima é 35. Informe a nota novamente: ");
                    Aluno.Nota2 = double.Parse(Console.ReadLine());
                }
            }

            Console.Write("Informe a terceira nota do Aluno: ");
            Aluno.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (Aluno.Nota3 > 35)
            {
                while (Aluno.Nota3 > 35)
                {
                    Console.Write("A nota maxima é 35. Informe a nota novamente: ");
                    Aluno.Nota3 = double.Parse(Console.ReadLine());
                }
            }
            double soma = Aluno.soma();
            if (soma > 60)
            {
                Console.WriteLine("APROVADO");
                Console.WriteLine("A NOTA FINAL FOI: " + soma);
            }
            else
            {
                Console.WriteLine("A NOTA FINAL FOI: " + soma);




                Console.WriteLine("REPROVADO, FALTARAM  " + (60 - soma) + " PONTOS ");
            }
        }
    }
}