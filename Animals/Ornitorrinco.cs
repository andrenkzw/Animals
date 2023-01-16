using System;

namespace Animals;
class Ornitorrinco : Mamifero, IAquatico, IOviparo
{
    public bool ViveEmTerra { get; set; }
    public bool Mergulha { get; set; }
    public bool ViveEmAguaDoce { get; set; }

    public override void Comunicar()
    {
        Console.WriteLine("Kprrrrr");
    }
    public void Botar()
    {
        Console.WriteLine("Botando ovos");
    }
    public void Chocar()
    {
        Console.WriteLine("Chocando ovos");
    }
    public new void Alimentar()
    {
        Console.WriteLine("Comendo camarões");
    }
}
