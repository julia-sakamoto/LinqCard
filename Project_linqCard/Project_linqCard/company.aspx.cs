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
            //String companyType = Request.QueryString["companyType"];

            //companyList = AccessLayer.getCompanies(companyType);

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
            





            Button[] buttons = new Button[companyList.Count];
            for (int i = 0; i < companyList.Count; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = "Select";
                buttons[i].Visible = true;
                buttons[i].Attributes["style"] = "border-radius:5px;background-color:darkgray;margin:auto;box-shadow: 1px 3px 8px #888888;";
                buttons[i].CommandArgument = companyList[i].companyName;
                buttons[i].Command += button_click;

                System.Web.UI.HtmlControls.HtmlGenericControl buttonDiv =
               new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                buttonDiv.ID = "button" + i;
                buttonDiv.Attributes["style"] = "display:flex";



                System.Web.UI.HtmlControls.HtmlGenericControl wrapper =
               new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                wrapper.ID = "wrapper" + i;
                wrapper.Attributes["style"] = "margin:0 10px 0 10px";

                System.Web.UI.HtmlControls.HtmlGenericControl cardDiv =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                cardDiv.ID = "card"+i;

                cardDiv.InnerHtml = "<div class='card front'><div class='blue'></div><div class='yellow'>" +
                    "</div><div class='pink'></div><div class='dots'></div><div class='personal-intro'>" +
                    "<p>"+ companyList[i].companyName +"</p></div></div>";


                buttonDiv.Controls.Add(buttons[i]);
                wrapper.Controls.Add(cardDiv);
                wrapper.Controls.Add(buttonDiv);


                
                div1.Controls.Add(wrapper);

            }


        }

        public void button_click(object sender, CommandEventArgs e)
        {
            string v = e.CommandArgument.ToString();

            Response.Redirect("businessCard.aspx?companyName="+v, false);
        }

    }
}