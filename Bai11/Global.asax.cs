namespace Tuần5.Bai11
{
    using System;

    /// <summary>
    /// Defines the <see cref="Global" />
    /// </summary>
    public class Global : System.Web.HttpApplication
    {
        
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        
        protected void Session_Start(object sender, EventArgs e)
        {
            Nhanvien[] nhanviens = new Nhanvien[1];
            Application["danhsach"] = nhanviens;
            Session["renderNhanVien"] = "";
        }

        
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The Application_AuthenticateRequest
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The Application_Error
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void Application_Error(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The Session_End
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void Session_End(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The Application_End
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void Application_End(object sender, EventArgs e)
        {
        }
    }
}
