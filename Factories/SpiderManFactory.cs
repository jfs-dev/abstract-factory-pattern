using abstract_factory_pattern.Entities;
using abstract_factory_pattern.Interfaces;

namespace abstract_factory_pattern.Factories;

public class SpiderManFactory : ISuperHeroFactory
{
    public ISuperHero CreateSuperHero() => new SpiderMan();
}
