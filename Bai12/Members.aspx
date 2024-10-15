<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="Tuần5.Bai12.Members" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Members</h1>
            <section class="memberlist"></section>
        </div>
    </form>
    <script>
        const memberlist = document.querySelector(".memberlist");
        memberlist.innerHTML = "<%= Session["memberlist"] %>";
    </script>
</body>
</html>
