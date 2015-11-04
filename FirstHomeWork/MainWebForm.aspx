<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainWebForm.aspx.cs" Inherits="FirstHomeWork.MainWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server" method="post">
    <div>
       <asp:Literal ID="lrlLogin" runat="server">Логин</asp:Literal>
         <asp:TextBox ID="txtLogin" type="text" runat="server"/>
        <br />
        <asp:Literal ID="lrlPassword" runat="server">Пароль</asp:Literal>
        <asp:TextBox ID="txtPassword" type="text" runat="server"/>
          <br />
        <asp:Button ID="btnRunTest" runat="server"  Text="Send" Width="85px" OnClick="btnRunTest_Click" PostBackUrl="~/SecondWebForm.aspx" />   
       
    </div>
    </form>
</body>
</html>
