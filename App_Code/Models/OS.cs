using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OS
/// </summary>
public class OS
{
    [PrimaryKey]
    public int ID { get; set; }
    public string name { get; set; }
    public string version { get; set; }
}