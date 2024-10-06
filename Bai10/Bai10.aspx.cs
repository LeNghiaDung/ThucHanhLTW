namespace Tuần5.Bai10
{
    using System;
    using System.IO;

    /// <summary>
    /// Defines the <see cref="Bai10" />
    /// </summary>
    public partial class Bai10 : System.Web.UI.Page
    {
        /// <summary>
        /// The Page_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string noidung = Request.Form["txtNoidung"];
                if (!string.IsNullOrEmpty(noidung))
                {
                    Response.Write("<h3>Nội dung đã nhập:</h3>");
                    Response.Write("<p>" + Server.HtmlEncode(noidung) + "</p>");
                }
                if (Request.Files["txtFile"] != null && Request.Files["txtFile"].ContentLength > 0)
                {

                    var uploadedFile = Request.Files["txtFile"];
                    string filePath = Server.MapPath("~/App_Data/") + Path.GetFileName(uploadedFile.FileName);
                    // luu file
                    uploadedFile.SaveAs(filePath);
                    Response.Write("<p>Tệp đã được lưu thành công với tên: " + Path.GetFileName(uploadedFile.FileName) + "</p>");
                }
            }
        }
    }
}
