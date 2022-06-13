namespace DadosFuncionario
{
   class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBrt { get; set; } 
        public double Imposto { get; set; }

        public Funcionario(string nome, double salarioBrt, double imposto)
        {
            Nome = nome;
            SalarioBrt = salarioBrt;
            Imposto = imposto;
        }

          public double CalcSalarioLiqui()
        {
            return SalarioBrt - Imposto;   
        }

        public void AumetarSalario(double percentAumento)
        {
            SalarioBrt += SalarioBrt * (1 * percentAumento);
        }

        public override string ToString()
        {
            return "\n Nome do funcionario: " + Nome + "\n "
                + "Salario Bruto: R$ " + SalarioBrt + "\n "       
                + "Valor do imposto: R$ " + Imposto + "\n "
                + "Salario Liquido: R$ " + CalcSalarioLiqui();
        }
    }
}
