<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CountryWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="">
                <tr>
                    <td>Id</td>
                    <td><asp:TextBox ReadOnly="True" ID="tb_Id" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Название страны</td>
                    <td><asp:TextBox ID="tb_Name" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>Столиц</td>
                    <td>
                        <asp:DropDownList id="ddl_Capital" runat="server" DataSourceID="SqlDataSource1" DataTextField="Capital" DataValueField="Capital"/>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:countryConnectionString %>" ProviderName="<%$ ConnectionStrings:countryConnectionString.ProviderName %>" SelectCommand="SELECT [Capital] FROM [Capital]"></asp:SqlDataSource>
                       </td>
                </tr>
                <tr>
                    <td>Площадь</td>
                    <td><asp:TextBox ID="tb_Area" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td><asp:Button Text="Отмена" ID="btn_Cancel" runat="server" OnClick="btn_Cancel_OnClick"/></td>
                    <td><asp:Button Text="Добавить" ID="btn_Go" runat="server" OnClick="btn_Go_OnClick"/> </td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Label Text=" " ID="lb_Result" runat="server" Font-Bold="True"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
