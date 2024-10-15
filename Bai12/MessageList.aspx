<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MessageList.aspx.cs" Inherits="Tuần5.Bai12.MessageList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Message List</h1>
            <section class="messagelist"></section>
        </div>
    </form>
    <script>
        const messagelist = document.querySelector(".messagelist");
        messagelist.innerHTML = "<%= Session["messagelist"]%>";
    </script>
</body>
</html>
