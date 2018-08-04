using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_linqCard
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fieldContainer1.Attributes.Add("onclick", "window.location='businessCard.aspx?companyID=IT'");
            fieldContainer2.Attributes.Add("onclick", "window.location='businessCard.aspx?companyID=medical'");
            fieldContainer3.Attributes.Add("onclick", "window.location='businessCard.aspx?companyID=finance'");
            fieldContainer4.Attributes.Add("onclick", "window.location='businessCard.aspx?companyID=sales'");
            fieldContainer5.Attributes.Add("onclick", "window.location='businessCard.aspx?companyID=consult'");

        }
    }
}