using System;

namespace Animals;
class Program
{
    static void Main(string[] args)
    {
        var ornitorrinco = new Ornitorrinco(){
            Nome = "Perry",
            DataNascimento = new DateTime(2022, 1, 15),
            Sexo = 'M',
            Carnivoro = true,
            Peconhento = true,
            QtdMamas = 0,
            Peludo = true,
            CorPelos = "Castanho",
            ViveEmTerra = true,
            Mergulha = true,
            ViveEmAguaDoce = true
        };

        Console.WriteLine(ornitorrinco);
        Console.WriteLine("Idade: " + ornitorrinco.Idade());
        ornitorrinco.Movimentar();
        ornitorrinco.Comunicar();
        ornitorrinco.Alimentar();
        ornitorrinco.Amamentar();
        ornitorrinco.Botar();
        ornitorrinco.Chocar();
    }
}
