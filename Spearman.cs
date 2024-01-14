namespace DiNinject;

internal class Spearman : IUnit
{
    public void Atack()
    {
        Console.WriteLine("Spearman atacks");
    }

    public void FileInfo(string path)
    {
        File.AppendAllText(path, this.Info());
    }

    public string Info()
    {
        return "A spearman is an ancient infantry or cavalry combat unit which was armed with a spear, and in some cases, a shield. In popular culture a 'spearman' is an early melee unit found in Civilization games.";
    }
}
