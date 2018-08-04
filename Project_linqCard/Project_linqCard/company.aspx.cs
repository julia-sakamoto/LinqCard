using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_linqcard
{

    public partial class company : System.Web.UI.Page
    {
        public List<Company> companyList =new List<Company>();
        protected void Page_Load(object sender, EventArgs e)
        {
            String companyType = Request.QueryString["companyType"];

            companyList = AccessLayer.getCompanies(companyType);

            /*
            Company c1 = new Company();
            c1.companyName = "avc";
            Company c3 = new Company();
            c3.companyName = "avc";
            Company c4 = new Company();
            c4.companyName = "avc";
            Company c2 = new Company();
            c2.companyName = "sss";
            Company c5 = new Company();
            c5.companyName = "avc";

            companyList.Add(c1);
            companyList.Add(c2);
            companyList.Add(c3);
            companyList.Add(c4);
            companyList.Add(c5);
            */



            //Button[] buttons = new Button[companyList.Count];
            for (int i = 0; i < companyList.Count; i++)
            {
               
                System.Web.UI.HtmlControls.HtmlGenericControl cardDiv =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                cardDiv.ID = "card"+i;
                cardDiv.Attributes["style"] = "margin:0 10px 0 10px";
                cardDiv.Attributes.Add("onclick", "window.location='businessCard.aspx?companyID=" + companyList[i].companyID + "'");

                cardDiv.InnerHtml = "<div class='companyContain'><div class='card front'><div class='blue'></div><div class='yellow'>" +
                    "</div><div class='pink'></div><div class='dots'></div><div class='personal-intro'>" +
                    "<p>"+ companyList[i].companyName + "</p></div></div></div>";


                  div1.Controls.Add(cardDiv);

            }


        }

        public void button_click(object sender, CommandEventArgs e)
        {
            string v = e.CommandArgument.ToString();

            //Response.Redirect("businessCard.aspx?companyID="+v, false);
        }

    }
}