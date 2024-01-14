namespace DiNinject;

internal class Archer : IUnit
{
    public void Atack()
    {
        Console.WriteLine("Archer atacks");
    }

    public void FileInfo(string path)
    {
        File.AppendAllText(path, this.Info());
    }

    public string Info()
    {
        return "Archers were a widespread if supplemental part of the military in the classical period, and bowmen fought on foot, in chariots or mounted on horses. ";
    }
}
