using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_MaterialTable : System.Web.UI.UserControl
{
    public static readonly string TABLE_NAME = "Smartphone";
    public bool Editable { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        // lookup by brand / name
        var brandQuery = Request.QueryString["brand"];
        var nameQuery = Request.QueryString["name"];
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var smartphones = monkey.retrieve<Smartphone>(TABLE_NAME);

        if (brandQuery != null)
        {
            smartphones = smartphones.Where(x => x.brand == brandQuery);
        }
        else if (nameQuery != null)
        {
            smartphones = smartphones.Where(x => x.name == nameQuery);
        }

        LoadData(smartphones);
    }

    public void LoadData(IEnumerable<Smartphone> entries)
    {
        foreach (var smartphone in entries)
        {
            var row = (Controls_MaterialRow)Page.LoadControl("Controls/MaterialRow.ascx");
            row.Instance = smartphone;
            row.TableName = TABLE_NAME;
            row.Editable = Editable;
            tableBody.Controls.Add(row);
        }
    }
}