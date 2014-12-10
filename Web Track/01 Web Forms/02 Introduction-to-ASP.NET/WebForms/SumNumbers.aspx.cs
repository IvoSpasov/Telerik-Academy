using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class SumNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sum_Click(object sender, EventArgs e)
        {
            var firstNumber = double.Parse(First.Text);
            var secondNumber = double.Parse(Second.Text);
            Result.Text = (firstNumber + secondNumber).ToString();
        }
    }
}