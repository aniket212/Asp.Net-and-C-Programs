﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Response.Write("Welcome"+Session["uname"]);

        Response.Write("Welcome" + Request.Cookies["uname"].Value);
    }
}