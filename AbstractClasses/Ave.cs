using System;

namespace Animals;
abstract class Ave : Animal
{
    public bool Rapina { get; set; }
    public string CorPenas { get; set; }
    
    public void Ciscar()
    {
        Console.WriteLine("Ciscando");
    }

    public override string ToString()
    {
        return base.ToString() +
            "\nAve de rapina? " + (this.Rapina ? "Sim" : "Não") +
            $"\nCor das Penas: {this.CorPenas}"
        ;
    }
}
