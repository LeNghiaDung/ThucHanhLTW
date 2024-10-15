using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tuần5.Bai12
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Member> listMember = Application["listMember"] as List<Member>;
            string res = "";
            for (int i = 0; i < listMember.Count; i++)
            {
                if (listMember[i] != null)
                {
                    res += "<h2 style ='color:" + listMember[i].Color + "; height: 50px; display: flex; align-items: center; padding-left: 18px; border-radius: 11px'>" + 
                        listMember[i].ID + 
                        "_" + 
                        listMember[i].Nickname + 
                        "</h2>";
                }
            }
            Session["memberlist"] = res;
        }
    }
}