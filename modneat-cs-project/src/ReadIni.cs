using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public class IniFile
{
    [DllImport("kernel32.dll")]
    public static extern uint GetPrivateProfileString(
        string lpAppName, string lpKeyName, string lpDefault,
        StringBuilder lpReturnedString, uint nSize, string lpFileName);

    private readonly StringBuilder _builder = new StringBuilder(255);
    public string FullName { get; set; }

    public IniFile(string filePath)
    {
        FullName = Path.GetFullPath(filePath);
    }

    public string Read(string section, string key, string defaultValue = null)
    {
        _builder.Clear();
        GetPrivateProfileString(section, key, defaultValue, _builder, 255, FullName);
        return _builder.ToString();
    }

    public float ReadFloat(string section, string key, string defaultValue = null)
    {
        _builder.Clear();
        GetPrivateProfileString(section, key, defaultValue, _builder, 255, FullName);
        return float.Parse(_builder.ToString());
    }

    public int ReadInt(string section, string key, string defaultValue = null)
    {
        _builder.Clear();
        GetPrivateProfileString(section, key, defaultValue, _builder, 255, FullName);
        return int.Parse(_builder.ToString());
    }
}
