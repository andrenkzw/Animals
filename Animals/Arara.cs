using System;

namespace Animals;
class Arara : Ave, IOviparo, IVoador
{
    public int AltitudeMaximaEmMetros { get; set; }
    public double VelocidadeDoVoo { get; set; }

    public override void Comunicar()
    {
        Console.WriteLine("Reco-reco");
    }
    public void Botar()
    {
        Console.WriteLine("Botando ovos");
    }
    public void Chocar()
    {
        Console.WriteLine("Chocando ovos");
    }
}
