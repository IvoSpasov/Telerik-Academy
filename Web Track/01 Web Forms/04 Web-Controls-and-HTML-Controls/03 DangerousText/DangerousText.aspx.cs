using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_DangerousText
{
    public partial class DangerousText : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonShowResult_Click(object sender, EventArgs e)
        {
            var input = this.TextBoxInput.Text;
            this.TextBoxOutput.Text = input;
            this.LabelOutput.Text = Server.HtmlEncode(input);
        }
    }
}