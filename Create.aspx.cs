using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            return;
        }

        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        var osList = monkey.retrieve<OS>("OS");
        foreach (var osItem in osList)
        {
            os.Items.Add(new ListItem(String.Format("{0} - {1}", osItem.name, osItem.version)));
        }
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        var smartphone = new Smartphone
        {
            name = name.Value,
            IDos = os.SelectedIndex,
            launchDate = Convert.ToDateTime(launchDate.Value),
            brand = brand.Value,
            description = description.Value
        };

        var monkey = new SQLMonkey(Constants.CONNECTION_STRING);
        monkey.insert<Smartphone>(smartphone, "smartphone");
        submitButton.InnerText = "Success!";
    }
}