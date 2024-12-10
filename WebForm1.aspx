<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ExamenR_JAGS.WebForm1"  Async="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="align-items:center">
            <asp:Label Text="DOG API"  runat="server"/>
            <br />
            <asp:Button Text="Generar" OnClick="Generar" runat="server" />
             <br />
            <asp:Image  ImageUrl="" runat="server" ID="imagen" Visible="false" Width="400px" Height="400px"/>
        </div>
    </form>
</body>
</html>
