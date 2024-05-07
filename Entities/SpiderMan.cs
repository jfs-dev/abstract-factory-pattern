using abstract_factory_pattern.Interfaces;

namespace abstract_factory_pattern.Entities;

public class SpiderMan : ISuperHero
{
    public void UseSuperPower()
    {
        Console.WriteLine("Homem-Aranha usa seu sentido de aranha que o avisa sobre o perigo!");
    }
}
