using System;

namespace Animals;
class Lontra : Mamifero, IAquatico
{
    public bool ViveEmTerra { get; set; }
    public bool Mergulha { get; set; }
    public bool ViveEmAguaDoce { get; set; }

    public override void Comunicar()
    {
        Console.WriteLine("Ih-ih-iriri");
    }
}
