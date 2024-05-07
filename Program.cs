using abstract_factory_pattern.Factories;
using abstract_factory_pattern.Interfaces;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("Abstract Factory Pattern");
Console.WriteLine("------------------------");
Console.ForegroundColor = ConsoleColor.Magenta;

ISuperHeroFactory spiderManFactory = new SpiderManFactory();

ISuperHero spiderMan = spiderManFactory.CreateSuperHero();
spiderMan.UseSuperPower();

ISuperHeroFactory ironManFactory = new IronManFactory();

ISuperHero ironMan = ironManFactory.CreateSuperHero();
ironMan.UseSuperPower();
