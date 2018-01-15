using System;
using System.IO;

/// <summary>
/// Summary description for Constants
/// </summary>
public class Constants
{   
    public static readonly string CONNECTION_STRING = @"
        Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=|DataDirectory|Database.mdf;
        Integrated Security=True;
        Connect Timeout=30";   
}