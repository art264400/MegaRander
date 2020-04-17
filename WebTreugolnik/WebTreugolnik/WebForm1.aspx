<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebTreugolnik.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 58px;
            width: 282px;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:TextBox ID="a" runat="server"></asp:TextBox>
            первая сторона<div class="auto-style1">
            <asp:TextBox ID="b" runat="server"></asp:TextBox>
            <asp:Label runat="server">вторая сторона</asp:Label>
        <div class="auto-style1">
            <asp:TextBox ID="c" runat="server"></asp:TextBox>
            <asp:Label runat="server">третья сторона</asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="BtnClick" Text="Посчитать" />
        <div class="auto-style1">
           <asp:TextBox runat="server" ID="result"></asp:TextBox>
            результат</div>
        </div>
        </div>
        </div>
    </form>
</body>
</html>
