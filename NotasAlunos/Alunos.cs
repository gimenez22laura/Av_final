namespace NotasAlunos
{
    class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double soma()
        {
            return Nota1 + Nota2 + Nota3;
        }
    }
}