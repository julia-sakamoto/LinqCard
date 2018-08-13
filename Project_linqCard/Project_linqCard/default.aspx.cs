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
            fieldContainer1.Attributes.Add("onclick", "window.location='company.aspx?companyType=IT'");
            fieldContainer2.Attributes.Add("onclick", "window.location='company.aspx?companyType=medical'");
            fieldContainer3.Attributes.Add("onclick", "window.location='company.aspx?companyType=finance'");
            fieldContainer4.Attributes.Add("onclick", "window.location='company.aspx?companyType=sales'");
            fieldContainer5.Attributes.Add("onclick", "window.location='company.aspx?companyType=consult'");

        }
    }
}