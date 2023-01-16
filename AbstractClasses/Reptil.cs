namespace Animals;
abstract class Reptil : Animal
{
    public bool TemEscamas { get; set; }
    public bool TemCasco { get; set; }

    public override string ToString()
    {
        return base.ToString() +
            "\nTem escamas? " + (this.TemEscamas ? "Sim" : "Não") +
            "\nTem casco? " + (this.TemCasco ? "Sim" : "Não")
        ;
    }
}
