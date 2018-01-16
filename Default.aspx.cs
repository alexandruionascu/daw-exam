using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submitButton_ServerClick(object sender, EventArgs e)
    {
        if (name.Value != String.Empty)
        {
            Response.Redirect(String.Format("Default.aspx?name={0}", name.Value));
        } 

        if (brand.Value != String.Empty)
        {
            Response.Redirect(String.Format("Default.aspx?brand={0}", brand.Value));
        }
    }
}