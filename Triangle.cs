namespace DiNinject;

internal class Triangle : IFigure
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
        return "In Geometry, a triangle is a three-sided polygon that consists of three edges and three vertices. The most important property of a triangle is that the sum of the internal angles of a triangle is equal to 180 degrees.";
    }
    public string ToStr()
    {
        return "This is Triangle";
    }
}
