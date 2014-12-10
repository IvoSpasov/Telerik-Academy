using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_WebRandomNumbers
{
    public partial class RandomNumbers : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                var lowRange = int.Parse(this.TextBoxLowRange.Text);
                var highRange = int.Parse(this.TextBoxHighRange.Text);
                var result = random.Next(lowRange, highRange);
                this.LabelResult.Text = "The generated number is: " + result;
            }
            catch (Exception)
            {
                this.LabelResult.Text = "Invalid range!";
            }
        }
    }
}