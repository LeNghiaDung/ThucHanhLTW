<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrameSet.aspx.cs" Inherits="Tuần5.Bai12.FrameSet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        *{
            margin: 0;
            padding: 0
        }
        .top{
            width: 100vw;
            height: 70vh;
        }
        #members{
            width: 30%;
            height: 100%;
        }
        #msglist{
            width: 69%;
            height: 100%;
        }
        #postmsg{
            width: 99%;
            height: 29vh;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section class="top">
            <iframe id="members" src="Members.aspx"></iframe>
            <iframe id="msglist" src="MessageList.aspx"></iframe>
        </section>
        <section class="bottom">
            <iframe id="postmsg" src="PostMsg.html"></iframe>
        </section>
    </form>
</body>
</html>
