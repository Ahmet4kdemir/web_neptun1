﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_venus_2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginId"] ==null){
                Response.Redirect("login.aspx");
            }
            else
            {
                Response.Write(Session["LoginID"]);
            }
        }
    }
}