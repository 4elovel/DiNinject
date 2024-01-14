namespace DiNinject;

internal interface ICocktail
{
    public string ToStr();
    public string ToStringLong();
    public void ToFile(string path);
    public void ToFileLong(string path);
}
