namespace DiNinject;

internal class PinaColada : ICocktail
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
        return "The pina colada is a popular classic cocktail invented in Puerto Rico made with pineapple juice, rum, and coconut, served blended or with crushed ice.The name means “strained pineapple” in Spanish.";
    }
    public string ToStr()
    {
        return "This is Pina Colada";
    }
}
