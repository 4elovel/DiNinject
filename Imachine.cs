namespace DiNinject;

internal interface Imachine
{
    public string ToStr();
    public string ToStringLong();
    public void ToFile(string path);
    public void ToFileLong(string path);
}
