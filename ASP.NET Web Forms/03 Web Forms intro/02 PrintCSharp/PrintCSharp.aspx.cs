using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_WebForms
{
    public partial class PrintCSharp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LabelAll.Text = ("Hello, ASP.NET (from C# code)" +
                                  "<br/>" +
                                  "<br/>" +
                                  "ExecutingAssembly Location" + 
                                  "<br/>" +
                                  Assembly.GetExecutingAssembly().Location);
        }
    }
}