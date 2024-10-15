using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tuần5.Bai12
{
    public partial class SendMsg : System.Web.UI.Page
    {
        private string nickname;
        private string message;
        private string color;
        private DateTime time;
        protected void Page_Load(object sender, EventArgs e)
        {
            nickname = Request.Cookies["userCookie"].Value;
            message = Server.HtmlEncode(Request.Form["txtMessage"].ToString());
            time = DateTime.Now;
            color = Request.Cookies["colorCookie"].Value;

            List<Msg> listMessage = Application["listMessage"] as List<Msg>;
            listMessage.Add(new Msg(nickname, message, time, color));
            Application["listMessage"] = listMessage;
            Response.Redirect("PostMsg.html");
        }
    }
}