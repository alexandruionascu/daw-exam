using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Comment
/// </summary>
public class Comment
{
    [PrimaryKey]
    public int id { get; set; }
    public string text { get; set; }
    public int articleID { get; set; }
    public string author { get; set; }
}