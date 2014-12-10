namespace _01_HelloPage
{
    using System;

    public partial class HelloPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonPrintName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextBoxNameInput.Text))
            {
                this.LabelNameOutput.Text = "You must enter a name";
            }
            else
            {
                this.LabelNameOutput.Text = "Hello " + this.TextBoxNameInput.Text;
            }
        }
    }
}