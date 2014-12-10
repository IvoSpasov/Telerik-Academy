using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_Cookies
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.TextBoxUsername.Text) && !string.IsNullOrEmpty(this.TextBoxPassword.Text))
            {
                HttpCookie cookie = Request.Cookies["UserInfo"];
                if (cookie == null)
                {
                    cookie = new HttpCookie("UserInfo", this.TextBoxUsername.Text + " " + this.TextBoxPassword.Text);
                    //cookie.Value = this.TextBoxPassword.Text;
                    cookie.Expires = DateTime.Now.AddMinutes(1);

                    Response.Cookies.Add(cookie);
                    Response.Redirect("UserInfo.aspx");
                }
                else
                {
                    Response.Redirect("UserInfo.aspx");
                }
            }            
        }
    }
}