namespace DiNinject;

internal class CoffeeMachine : Imachine
{
    public void ToFile(string path)
    {
        File.AppendAllText(path, this.ToStr());
    }

    public void ToFileLong(string path)
    {
        File.AppendAllText(path, this.ToStringLong());
    }

    public string ToStringLong()
    {
        return "A coffeemaker, coffee maker or coffee machine is a cooking appliance used to brew coffee. While there are many different types of coffeemakers, the two most common brewing principles use gravity or pressure to move hot water through coffee grounds.";
    }
    public string ToStr()
    {
        return "This is coffee machine";
    }
}
