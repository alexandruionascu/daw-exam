using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Controls_MaterialRow : System.Web.UI.UserControl
{
   
    public Smartphone Instance { get; set; }
    public string TableName { get; set; }         

    protected void Page_Load(object sender, EventArgs e)
    {
        DataBind();
        
        if (Instance == null)
        {
            throw new Exception("No instance object attached to row!");
        }

        if (viewPanel.Visible)
        {
            editPanel.Visible = false;
        }
    }

    public void Edit_Click(object sender, EventArgs e)
    {
        editPanel.Visible = true;
        viewPanel.Visible = false;
    }

    public void Update_Click(object sender, EventArgs e)
    {
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        Instance.brand = edit_brand.Value;
        Instance.name = edit_name.Value;
        Instance.launchDate = Convert.ToDateTime(edit_date.Value);
        Instance.description = edit_description.Value;
        monkey.update<Smartphone>(Instance, TableName);
        Response.Redirect(Request.RawUrl);
    }


    public void Delete_Click(object sender, EventArgs e)
    {
        this.Visible = false;
        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        monkey.delete<Smartphone>(Instance, TableName);
    }

}