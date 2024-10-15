<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangki.aspx.cs" Inherits="Tuần5.Bai12.Dangki" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .Dangki {
            display: flex;
            margin-left: 10px;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
    </style>
</head>
<body>
    <form class="Dangki" id="form1" runat="server" method ="post" action ="Dangki.aspx">
        <label>Tên đăng nhập:</label>
        <input type="text" name="inputTen" id="inputTen" />
        <br />
        <label>Màu:</label>
        <input type="color" name="inputMau" />
        <br />
        <br />
        <input type="submit" value="ĐĂNG KÝ" id="inputSubmit" />
    </form>
    <script>
        const inputTen = document.querySelector("#inputTen");
        const inputSubmit = document.querySelector("#inputSubmit");

        inputSubmit.addEventListener("click", function (e) {
            if (inputTen.value.trim() == "") {
                alert("Tên đăng nhập không được trống!"); 
                e.preventDefault();
            }
        })
    </script>
</body>
</html>
