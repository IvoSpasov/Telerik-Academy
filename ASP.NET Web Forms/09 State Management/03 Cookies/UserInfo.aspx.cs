﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_Cookies
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                this.LiteralUserInfo.Text = "User info: " + cookie.Value;
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}