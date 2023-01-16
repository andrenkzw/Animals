using System;

namespace Animals;
abstract class Mamifero : Animal
{
    public int QtdMamas { get; set; }
    public bool Peludo { get; set; }
    public string? CorPelos { get; set; }
    
    public void Amamentar()
    {
        Console.WriteLine("Dando de mamar");
    }

    public override string ToString()
    {
        return base.ToString() +
            $"\nQuantidade de Mamas: {this.QtdMamas}" +
            "\nPeludo? " + (this.Peludo ? "Sim" : "Não") +
            (this.Peludo ? $"\nCor dos Pelos: {this.CorPelos}" : "")
        ;
    }
}
