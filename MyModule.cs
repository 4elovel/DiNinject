using Ninject.Modules;

namespace DiNinject;

public class MyModule : NinjectModule
{
    public override void Load()
    {
        Bind<ICocktail>().To<PinaColada>().InSingletonScope();
        Bind<IUnit>().To<Archer>().InSingletonScope();
        Bind<IFigure>().To<Triangle>().InSingletonScope();
        Bind<Imachine>().To<CoffeeMachine>().InSingletonScope();
    }
}
