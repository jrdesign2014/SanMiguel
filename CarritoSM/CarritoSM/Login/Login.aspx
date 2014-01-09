<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CarritoSM.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../css/Login/body.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/body.css" rel="stylesheet" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="contenedor">

            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LblUsuario" runat="server" Font-Names="Comic Sans MS" Font-Strikeout="False" Text="Usuario"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtUsuario" runat="server" CssClass="cajasTexto" Height="20px" Width="200px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LblContrasena" runat="server" Font-Names="Comic Sans MS" Text="Contraseña"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtContrasena" runat="server" CssClass="cajasTexto" Font-Names="Comic Sans MS" Height="20px" Width="200px" type="password"></asp:TextBox>

            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" CssClass="cajasTexto" Height="30px" Text="Iniciar sesion" Width="122px" />

            <div class="contenedor2">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
