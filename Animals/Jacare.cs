using System;

namespace Animals;
class Jacare : Reptil, IAquatico, IOviparo
{
    public bool ViveEmTerra { get; set; }
    public bool Mergulha { get; set; }
    public bool ViveEmAguaDoce { get; set; }

    public override void Comunicar()
    {
        Console.WriteLine("Roooor");
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
