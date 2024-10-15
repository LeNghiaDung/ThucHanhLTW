namespace Tuần5.Bai12
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Global" />
    /// </summary>
    public class Global : System.Web.HttpApplication
    {
        /// <summary>
        /// The Application_Start
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void Application_Start(object sender, EventArgs e)
        {
            List<Member> listMembers = new List<Member>();
            Application["listMembers"] = listMembers;
        }

        /// <summary>
        /// The Session_Start
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void Session_Start(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The Application_BeginRequest
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
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
