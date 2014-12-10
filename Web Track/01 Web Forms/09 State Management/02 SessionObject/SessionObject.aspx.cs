using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_SessionObject
{
    public partial class SessionObject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
	        {
		         return;
	        }

            List<string> inputs = new List<string>();
            Session.Add("textBoxInput", inputs);
            //Session["textBoxInput"] = new List<string>();
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var a = Session["textBoxInput"] as List<string>;
            a.Add(this.TextBoxInput.Text);
            this.LabelOutput.Text = "Current session: <br />" + string.Join(", ", a);
        }
    }
}