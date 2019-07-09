using cmscommon;
using Superior.Web.Common.BL;
using Superior.Web.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperiorWeb.CSL
{
    public partial class CompanyInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.CacheControl = "private";
            Response.Expires = -1;
            Response.AddHeader("pragma", "no-cache");
            Response.AddHeader("X-Frame-Options", "SAMEORIGIN");
            CommonHelper.RequireSecurePage();
            if (!IsPostBack)
            {
                if (SessionManager.CurrentCompany == null)
                {
                    Response.Redirect("/Home.aspx");
                }

                int action =  CommonLogic.QueryStringNativeInt("action");
                if (action == 0)
                {
                    action = 1;
                }

                switch (action)
                {
                    case 1:
                        ltTitle.Text = "About Us";
                        ltContent.Text = CommonHelper.HtmlEncode(SessionManager.CurrentCompany.PortfolioSettings.RDCAboutUsText);
                        break;
                    case 2:
                        ltTitle.Text = "Support";
                        ltContent.Text = CommonHelper.HtmlEncode(SessionManager.CurrentCompany.PortfolioSettings.RDCSupportText);
                        break;
                    case 3:
                        ltTitle.Text = "Contact Us";
                        ltContent.Text = CommonHelper.HtmlEncode(SessionManager.CurrentCompany.PortfolioSettings.RDCContactUsText);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}