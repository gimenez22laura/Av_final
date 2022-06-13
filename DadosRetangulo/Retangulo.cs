namespace DadosRetangulo
{
    class Retangulo
    {
        //Declaração dos atributos da classe
        public double Largura { get; set; }
        public double Altura { get; set; }  

        //Declarção do metado de construção do objeto composto
        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        //Declração do metado de calculo da área
        public double CalcArea()
        {
            return Largura * Altura;
        }

        //Declaração do metado de calculo do perimetro
        public double CalcPerimetro()
        {
            return 2.00 * (Largura + Altura);
        }

        //Declaração do metado de calculo da Diagonal
        public double CalcDiag()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

        //Declação do metado override para impressão padrão
        public override string ToString()
        {
            return "Dados do Retangulo \n"
                + "Largura: " + Largura
                + "\nAltura: " + Altura
                + "\n Area: " + CalcArea()
                + "\n Perimetro: " + CalcPerimetro()
                + "\n Diagonal: " + CalcDiag();
        }
    }
}
