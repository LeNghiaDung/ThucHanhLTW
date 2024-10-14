using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tuần5.Bai11
{
    public partial class Xuly : System.Web.UI.Page
    {
        private string inputMaNV;
        private string inputTenNV;
        private int inputNamSinh;
        private string inputGioitinh;
        private string inputDiaChi;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                inputMaNV = Request.Form["iMaNV"];
                inputTenNV = Request.Form["iTenNV"];
                inputNamSinh = int.Parse(Request.Form["inamSinh"]);
                inputGioitinh = Request.Form["iGt"];
                inputDiaChi = Request.Form["iDiaChi"];

                Nhanvien[] dsNhanVien = Application["danhsach"] as Nhanvien[];
                if (dsNhanVien == null)
                {
                    dsNhanVien = new Nhanvien[1];
                }
                else
                {
                    Array.Resize(ref dsNhanVien, dsNhanVien.Length + 1);
                }

                dsNhanVien[dsNhanVien.Length - 1] = new Nhanvien(inputMaNV, inputTenNV, inputNamSinh, inputGioitinh, inputDiaChi);
                Application["danhsach"] = dsNhanVien;

                Session["renderNhanVien"] = renderNhanVien();
                Response.Write("Danh sách nhân viên");
                form1.InnerHtml = Session["renderNhanVien"].ToString();
            }
        }

        private string renderNhanVien()
        {
            string res = "";

            Nhanvien[] dsNhanVien = Application["danhsach"] as Nhanvien[];

            res += "<table border='1'>";
            for (int i = 0; i < dsNhanVien.Length; i++)
            {
                if (dsNhanVien[i] != null)
                {
                    res += "<tr>";
                    res += "<th>" + "Mã NV" + "</th>";
                    res += "<th>" + "Họ Tên" + "</th>";
                    res += "<th>" + "Năm Sinh" + "</th>";
                    res += "<th>" + "Giới Tính" + "</th>";
                    res += "<th>" + "Địa Chỉ" + "</th>";
                    res += "</tr>";
                    res += "<tr>";
                    res += "<th>" + dsNhanVien[i].MaNV + "</th>";
                    res += "<th>" + dsNhanVien[i].HoTen + "</th>";
                    res += "<th>" + dsNhanVien[i].NamSinh + "</th>";
                    res += "<th>" + dsNhanVien[i].GioiTinh + "</th>";
                    res += "<th>" + dsNhanVien[i].DiaChi + "</th>";
                    res += "</tr>";
                }

            }
            res += "</table>";

            return res;
        }
    }
}

