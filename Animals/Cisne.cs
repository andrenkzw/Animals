using System;

namespace Animals;
class Cisne : Ave, IAquatico, IOviparo, IVoador
{
    public bool ViveEmTerra { get; set; }
    public bool Mergulha { get; set; }
    public bool ViveEmAguaDoce { get; set; }
    public int AltitudeMaximaEmMetros { get; set; }
    public double VelocidadeDoVoo { get; set; }

    public override void Comunicar()
    {
        Console.WriteLine("Ahn-ahn-ahn");
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
