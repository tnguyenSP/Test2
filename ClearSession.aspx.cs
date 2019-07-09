using Superior.Web.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClearSession : System.Web.UI.Page
{
    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    string logoutURL = SessionManager.GetLogoutLink();
    //    Session.Clear();
    //    Session.Abandon();
    //    Session.RemoveAll();
    //    FormsAuthentication.SignOut();

    //    if (Request.Cookies["ASP.NET_SessionId"] != null)
    //    {
    //        Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
    //        Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
    //    }

    //    if (Request.Cookies["AuthToken"] != null)
    //    {
    //        Response.Cookies["AuthToken"].Value = string.Empty;
    //        Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
    //    }

    //    Response.Redirect(logoutURL);
    //}
}