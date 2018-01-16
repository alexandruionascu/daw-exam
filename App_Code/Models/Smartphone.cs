using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Smartphone
/// </summary>
public class Smartphone
{
    [PrimaryKey]
    public int IDphone { get; set; } 
    public int IDos { get; set; }
    public string name { get; set; }
    public string launchDate { get; set; }
    public string brand { get; set; }
    public string description { get; set; }
}