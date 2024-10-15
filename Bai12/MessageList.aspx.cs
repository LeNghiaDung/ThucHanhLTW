using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tuần5.Bai12
{
    public partial class MessageList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["listMessage"] == null)
            {
                Application["listMessage"] = new List<Msg>();
            }

            List<Msg> listMessage = Application["listMessage"] as List<Msg>;
            string res = "";
            for (int i = 0; i < listMessage.Count; i++)
            {
                if (listMessage[i] != null)
                {
                    res += "<section style='color: " + listMessage[i].Color + "; border: 1px solid black border-radius: 20px; padding: 1px 18px; margin-bottom: 10px'>" +
                        "<h3>" + listMessage[i].Nickname + "</h3>" +
                        "<p>" + listMessage[i].Message + "</p>" +
                        "<p>" + listMessage[i].Time.ToString() + "</p>" +
                        "</section>";
                }
                Session["messagelist"] = res;

            }
        }
    }
}