using System;

namespace Animals;
class DragaoDeKomodo : Reptil, IOviparo
{
    public override void Comunicar()
    {
        Console.WriteLine("Hisssssss");
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
