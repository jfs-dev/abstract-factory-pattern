using abstract_factory_pattern.Interfaces;

namespace abstract_factory_pattern.Entities;

public class IronMan : ISuperHero
{
    public void UseSuperPower()
    {
        Console.WriteLine("Homem de Ferro dispara seus feixes repulsores!");
    }
}
