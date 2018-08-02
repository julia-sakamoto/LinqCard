using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {

            BusinessCard c1 = new BusinessCard();
            c1.address = "123 duval drive";
            c1.name = "John";
            c1.email = "john@google.ca";
            c1.phoneNumber = "1234567891";
            c1.jobTitle = "Developer";

            BusinessCard c3 = new BusinessCard();
            c3.address = "456 duval drive";
            c3.name = "Rose";
            c3.email = "Rose@google.ca";
            c3.phoneNumber = "1234567891";
            c3.jobTitle = "Manager";
            BusinessCard c4 = new BusinessCard();
            c4.address = "789 duval drive";
            c4.name = "John";
            c4.email = "john@google.ca";
            c4.phoneNumber = "1234567891";
            c4.jobTitle = "Developer";
            BusinessCard c2 = new BusinessCard();
            c2.address = "222 duval drive";
            c2.name = "Ion";
            c2.email = "Ion@google.ca";
            c2.phoneNumber = "1234567891";
            c2.jobTitle = "Sales";
            BusinessCard c5 = new BusinessCard();
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



            for (int i = 0; i < businessCards.Count; i++)
            {

                System.Web.UI.HtmlControls.HtmlGenericControl cardDiv =
                new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                cardDiv.ID = "card" + i;
                cardDiv.Attributes["style"] = "margin:0 10px 0 10px";

                cardDiv.InnerHtml = "<div class='card back'><div class='yellow'></div><div class='top dots'>" +
                    "</div><div class='personal-info'><p>"+ businessCards[i].name + "</p><p>" + businessCards[i].jobTitle + "</p>" +
                    "<p>" + businessCards[i].address + "</p><p>Sacramento, CA 14234</p><p>" + businessCards[i].phoneNumber + "</p>" +
                    "<p>" + businessCards[i].email + "</p><p>@kristastone</p></div><div class='bottom dots'>" +
                    "</div><div class='pink'></div></div>";


                div2.Controls.Add(cardDiv);

            }
        }
    }
}