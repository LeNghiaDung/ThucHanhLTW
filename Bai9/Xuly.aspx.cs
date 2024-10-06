namespace Tuần5
{
    using System;

    /// <summary>
    /// Defines the <see cref="Xuly" />
    /// </summary>
    public partial class Xuly : System.Web.UI.Page
    {
        /// <summary>
        /// The Page_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string inputName = Request.Form["name"];
                //string inputBrands = Request.Form["brands"];
                //string inputDate = Request.Form["date"];
                //string inputPrice = Request.Form["price"];

                string inputName = Request.QueryString["name"];
                string inputBrands = Request.QueryString["brands"];
                string inputDate = Request.QueryString["date"];
                string inputPrice = Request.QueryString["price"];

                string resXML = "<table>" +
                "<tr>" +
                "<td>" +
                inputName +
                "</td>" +
                "<td>" +
                inputBrands +
                "</td>" +
                "<td>" +
                inputDate +
                "</td>" +
                "<td>" +
                inputPrice +
                "</td>" +
                "</tr>" +
                "</table>";
                Response.Clear();
                Response.ContentType = "text/xml";
                Response.Write(resXML);
                Response.End();
            }
        }
    }
}
