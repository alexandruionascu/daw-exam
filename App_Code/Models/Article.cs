using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Article
/// </summary>
public class Article {
    [PrimaryKey]
    public int id { get; set; }
    public string title { get; set; }
    public string text { get; set; }
    public string author { get; set; }
    public string category { get; set; }
    public int date { get; set; }
    public string picture { get; set; }
}