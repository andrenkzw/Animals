using System;

namespace Animals;
class Coruja : Ave, IOviparo, IVoador
{
    public int AltitudeMaximaEmMetros { get; set; }
    public double VelocidadeDoVoo { get; set; }

    public override void Comunicar()
    {
        Console.WriteLine("Uuh-uuh");
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
