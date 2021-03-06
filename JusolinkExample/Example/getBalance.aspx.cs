﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Jusolink.Example.Example
{
    public partial class getBalance : System.Web.UI.Page
    {
        public String code;
        public String message;
        public double remainPoint;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                remainPoint = Global.jusolinkService.GetBalance();
            }
            catch (JusolinkException ex)
            {
                code = ex.code.ToString();
                message = ex.Message;
            }
        }
    }
}
