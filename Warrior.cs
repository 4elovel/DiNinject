namespace DiNinject;

internal class Warrior : IUnit
{
    public void Atack()
    {
        Console.WriteLine("Warrior atacks");
    }

    public void FileInfo(string path)
    {
        File.AppendAllText(path, this.Info());
    }

    public string Info()
    {
        return "A warrior is a fighter or soldier, especially one in former times who was very brave and experienced in fighting.";
    }
}
