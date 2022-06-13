using System;

namespace DadosRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Solicitar ao usuario que informe a quantidade desejada
            Console.Write("Informe a quantidade de retangulos que deseja calcular: ");
            int qtd_ret = int.Parse(Console.ReadLine());//Declaração e atribuição do valor digitado a quantidade de retangulos
            Retangulo[] vet_retangulo = new Retangulo[qtd_ret];//Declaraçãõ e instanciação do vetor da classe retangulo, conforme quanditade informada pelo usuario 

            for (int i = 0; i < qtd_ret; i++)//For para navegação/manipulação dos indices do vetor da classe retangulo
            {

                Console.WriteLine("Informe a largura do retangulo: ");
                double larg = double.Parse(Console.ReadLine());//Declaração de variavel e atribuição do valor digitado a largura do retangulo
                Console.WriteLine("Informe a altura do retangulo: ");
                double alt = double.Parse(Console.ReadLine());//Declaraçãõ de variavel e atribuição do valor digitado altura do retangulo

                vet_retangulo[i] = new Retangulo(larg, alt);//Declaração e instanciação dos valores do retangulo(largura e altura) conforme indice do vetor
            }

            for (int i = 0; i < qtd_ret; i++)
            {
                Console.WriteLine(vet_retangulo[i]);//Imprime dados padrão conforme o indice do vetor
            }
        }
    }
}
