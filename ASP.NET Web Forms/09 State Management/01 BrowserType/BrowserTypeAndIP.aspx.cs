using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_BrowserType
{
    public partial class BrowserTypeAndIP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string browserType = "Browser type is: " + Request.Browser.Type + "<br />";
            var ipAddress = "Client IP address is: " + Request.UserHostAddress;
            this.LiteralOutput.Text = browserType;
            this.LiteralOutput.Text += ipAddress;
        }
    }
}