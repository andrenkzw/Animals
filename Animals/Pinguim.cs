using System;

namespace Animals;
class Pinguim : Ave, IAquatico, IOviparo
{
    public bool ViveEmTerra { get; set; }
    public bool Mergulha { get; set; }
    public bool ViveEmAguaDoce { get; set; }

    public override void Comunicar()
    {
        Console.WriteLine("Hhhhonk-hhhhonk");
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
