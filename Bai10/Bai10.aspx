<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai10.aspx.cs" Inherits="Tuần5.Bai10.Bai10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bai 10</title>
</head>
<body>
    <form id="form1" runat="server" method="post" enctype="multipart/form-data">
         <div>
            <label for="txtNoiDung">Nội dung:</label><br />
            <textarea id="txtNoiDung" name="txtNoiDung" rows="5" cols="30"></textarea><br /><br />

            <label for="txtFile">Chọn tệp tin:</label><br />
            <input type="file" id="txtFile" name="txtFile" /><br /><br />

            <input type="submit" value="Gửi" />
             
        </div>
    </form>
</body>
</html>
