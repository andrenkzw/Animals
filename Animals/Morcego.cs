using System;

namespace Animals;
class Morcego : Mamifero, IVoador
{
    public int AltitudeMaximaEmMetros { get; set; }
    public double VelocidadeDoVoo { get; set; }
    
    public override void Comunicar()
    {
        Console.WriteLine("Ti-ti-ti-ti");
    }
}
