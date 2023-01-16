using System;

namespace Animals;
abstract class Animal
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public char Sexo { get; set; }
    public bool Carnivoro { get; set; }
    public bool Peconhento { get; set; }
    
    public int Idade()
    {
        var agora = DateTime.Now;
        int idade = agora.Year - this.DataNascimento.Year;
        if (this.DataNascimento.AddYears(idade) > agora) { idade--; }
        return idade;
    }

    public void Movimentar()
    {
        if (this is IVoador) { ((IVoador)this).Voar(); }
        else if (this is IAquatico) { Console.WriteLine("Nadando"); }
        else { Console.WriteLine("Andando"); }
    }

    public abstract void Comunicar();

    public void Alimentar()
    {
        string mensagem = "Comendo " + (this.Carnivoro ? "carne" : "comida vegetariana");
        Console.WriteLine(mensagem);
    }

    public override string ToString()
    {
        return
            $"Nome: {this.Nome}" +
            $"\nData de Nascimento: {this.DataNascimento}" +
            $"\nSexo: {this.Sexo}" +
            $"\nIdade: {this.Idade}" +
            "\nCarnívoro? " + (this.Carnivoro ? "Sim" : "Não") +
            "\nPeçonhento? " + (this.Peconhento ? "Sim" : "Não")
        ;
    }
}
