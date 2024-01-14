using Ninject;

namespace DiNinject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new MyModule());
            ICocktail cocktail = kernel.Get<ICocktail>();
            IUnit unit = kernel.Get<IUnit>();
            Console.WriteLine(cocktail.ToStringLong());
            Console.WriteLine();
            Console.WriteLine(unit.Info());
        }
    }
}
