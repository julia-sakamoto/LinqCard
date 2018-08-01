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
        public List<Company> companyList;
        protected void Page_Load(object sender, EventArgs e)
        {
            String companyType = Request.QueryString["companyType"];

            companyList = AccessLayer.getCompanies(companyType);


            Label[] dynamic = new Label[companyList.Count];
            Button[] buttons = new Button[companyList.Count];
            for (int i = 0; i < companyList.Count; i++)
            {
                dynamic[i] = new Label();
                dynamic[i].Visible = true;
                dynamic[i].Text = companyList[i].companyName;
                div1.Controls.Add(dynamic[i]);
                buttons[i].Click += new System.EventHandler(button_click);
            }


        }

        public void button_click(object sender, EventArgs e)
        {

        }

    }
}