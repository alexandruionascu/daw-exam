using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_MaterialTable : System.Web.UI.UserControl
{
    public static readonly string TABLE_NAME = "Smartphone";

    protected void Page_Load(object sender, EventArgs e)
    {
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var smartphones = monkey.retrieve<Smartphone>(TABLE_NAME);
        foreach (var smartphone in smartphones)
        {
            var row = (Controls_MaterialRow)Page.LoadControl("Controls/MaterialRow.ascx");
            row.Instance = smartphone;
            row.TableName = TABLE_NAME;
            tableBody.Controls.Add(row);
        }

    }
}