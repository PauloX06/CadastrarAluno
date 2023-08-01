public class Aluno
{
    public int Matricula { get; set; }

    public string Nome { get; set; }

    public string Cpf { get; set; }

    public DateOnly DataNascimento { get; set; }

    public Aluno()
    {

    }

    public Aluno(int matricula, string nome, string Cpf, DateOnly DataNascimento)
    {
        this.Matricula = matricula;
        this.Nome = nome;
        this.Cpf = Cpf;
        this.DataNascimento = DataNascimento;
    }

}
