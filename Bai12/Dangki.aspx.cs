using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tuần5.Bai12
{
    public partial class Dangki : System.Web.UI.Page
    {
        private string inputTen;
        private string inputMau;
        protected void Page_Load(object sender, EventArgs e)
        {
            inputTen = Request.Form["inputTen"];
            inputMau = Request.Form["inputMau"];
            if (inputTen != null && inputMau != null)
            {
                List<Member> listMember = Application["listMember"] as List<Member>;
                if (listMember == null)
                {
                    listMember = new List<Member>();
                    Application["listMember"] = listMember;
                }
                listMember.Add(new Member(listMember.Count + 1, inputTen, inputMau));
                Application["listMember"] = listMember;

                HttpCookie cookie = new HttpCookie("userCookie");
                cookie.Value = inputTen;
                cookie.Expires = DateTime.Now.AddMinutes(5);
                HttpContext.Current.Response.Cookies.Add(cookie);

                HttpCookie cookie1 = new HttpCookie("colorCookie");
                cookie1.Value = inputMau;
                cookie1.Expires = DateTime.Now.AddMinutes(5);
                HttpContext.Current.Response.Cookies.Add(cookie1);

                Response.Redirect("FrameSet.aspx");
            }
        }
    }
}