﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_linqcard
{
    public partial class businessCard : System.Web.UI.Page
    {

        public List<BusinessCard> businessCards = new List<BusinessCard>();

        public BusinessCard b;
        protected void Page_Load(object sender, EventArgs e)
        {

           /* BusinessCard c1 = new BusinessCard();
            c1.employerID = 1;
            c1.address = "123 duval drive";
            c1.name = "John";
            c1.email = "john@google.ca";
            c1.phoneNumber = "1234567891";
            c1.jobTitle = "Developer";

            BusinessCard c3 = new BusinessCard();
            c3.employerID = 1;
            c3.address = "456 duval drive";
            c3.name = "Rose";
            c3.email = "Rose@google.ca";
            c3.phoneNumber = "1234567891";
            c3.jobTitle = "Manager";
            BusinessCard c4 = new BusinessCard();
            c4.employerID = 1;
            c4.address = "789 duval drive";
            c4.name = "John";
            c4.email = "john@google.ca";
            c4.phoneNumber = "1234567891";
            c4.jobTitle = "Developer";
            BusinessCard c2 = new BusinessCard();
            c2.employerID = 1;
            c2.address = "222 duval drive";
            c2.name = "Ion";
            c2.email = "Ion@google.ca";
            c2.phoneNumber = "1234567891";
            c2.jobTitle = "Sales";
            BusinessCard c5 = new BusinessCard();
            c5.employerID = 1;
            c5.address = "786 duval drive";
            c5.name = "Sam";
            c5.email = "Sam@google.ca";
            c5.phoneNumber = "1234567891";
            c5.jobTitle = "CEO";

            businessCards.Add(c1);
            businessCards.Add(c2);
            businessCards.Add(c3);
            businessCards.Add(c4);
            businessCards.Add(c5);
            */
            businessCards = AccessLayer.getBusinessCards("");

            Button[] buttons = new Button[businessCards.Count];

            for (int i = 0; i < businessCards.Count; i++)
            {

                System.Web.UI.HtmlControls.HtmlGenericControl cardDiv =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                cardDiv.ID = "card" + i;
                cardDiv.Attributes["style"] = "margin:0 10px 0 10px";

                cardDiv.InnerHtml = "<div class='card back'><div class='yellow'></div><div class='top dots'>" +
                    "</div><div class='personal-info'><p>" + businessCards[i].name + "</p><p>" + businessCards[i].jobTitle + "</p>" +
                    "<p>" + businessCards[i].address + "</p><p>Sacramento, CA 14234</p><p>" + businessCards[i].phoneNumber + "</p>" +
                    "<p>" + businessCards[i].email + "</p><p>@kristastone</p></div><div class='bottom dots'>" +
                    "</div><div class='pink'></div></div>";

                System.Web.UI.HtmlControls.HtmlGenericControl buttonContainer =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                buttonContainer.ID = "buttonContain" + i;
                buttonContainer.Attributes["style"] = "display:flex";


                System.Web.UI.HtmlControls.HtmlGenericControl cardWrapper =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                cardWrapper.ID = "cardWrapper" + i;


                 b= businessCards[i];
                
               


                buttons[i] = new Button();
                buttons[i].Text= "Edit/Delete";
                buttons[i].Visible = true;
                buttons[i].Attributes["style"] = "margin:auto";
                buttons[i].Click += new EventHandler((s, ev) =>
                {
                    ShowModal(sender, e, b);
                }); 
                
                buttonContainer.Controls.Add(buttons[i]);
                cardWrapper.Controls.Add(cardDiv);
                cardWrapper.Controls.Add(buttonContainer);
                div2.Controls.Add(cardWrapper);
                
                
            }
        }



        public void ShowModal(object sender, EventArgs e, BusinessCard b)
        {
            name.Text=b.name;
            title.Text = b.jobTitle;
            phone.Text = b.phoneNumber;
            email.Text = b.email;
            address.Text = b.address;
            myModal.Attributes["style"]="display:block";
        }

        protected void close_Click(object sender, EventArgs e)
        {
            myModal.Attributes["style"] = "display:none";
        }

        protected void delete_Click(object sender, EventArgs e)
        {

            AccessLayer.deleteRecord(b);

            myModal.Attributes["style"] = "display:none";

            Response.Redirect(Request.RawUrl);

        }

        protected void update_Click(object sender, EventArgs e)
        {
            String ename = name.Text;
            String eaddress = address.Text;
            String ephone = phone.Text;
            String eTitle = title.Text;
            String eemail = email.Text;

            b.email = eemail;
            b.name = ename;
            b.phoneNumber = ephone;
            b.address = eaddress;
            b.jobTitle = eTitle;

            AccessLayer.updateRecord(b);


            myModal.Attributes["style"] = "display:none";

            Response.Redirect(Request.RawUrl);

        }
    }
}