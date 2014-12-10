using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_HTMLRandomNumbers
{
    public partial class RandomNumbers : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGenerate_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var lowRange = int.Parse(this.TextLowRange.Value);
                var highRange = int.Parse(this.TextHighRange.Value);
                var result = random.Next(lowRange, highRange);
                this.LabelResult.InnerText = "The generated number is: " + result;
            }
            catch (Exception)
            {
                this.LabelResult.InnerText = "Invalid range!";
            }
        }
    }
}