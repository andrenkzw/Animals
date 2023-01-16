using System;

namespace Animals;
interface IVoador
{
    int AltitudeMaximaEmMetros { get; set; }
    double VelocidadeDoVoo { get; set; }

    void Voar()
    {
        Console.WriteLine("Voando");
    }
}