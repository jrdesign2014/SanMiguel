<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CarritoSM.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../css/Login/body.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/body.css" rel="stylesheet" />

    <script language="javascript" type="text/javascript">
        function fnAceptar() {
            alert('El Contenido del TextBox es: ');
        }
</script>

    <title></title>
</head>
    
<body>
    <form id="form1" runat="server">
        <div class="contenedor">
            <br />
  <div style="margin: 0 auto 0 auto; width: 280px; height:80px;">
            <img src="../Images/logotipo.png" / >
                </div>
            <br />
            <br />
            <div style="width:400px; margin: 0 auto 0 auto;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LblUsuario" runat="server" Font-Names="Comic Sans MS" Font-Strikeout="False" Text="Usuario"></asp:Label>
            
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
        <asp:TextBox ID="TxtUsuario" runat="server" CssClass="cajasTexto" Height="20px" Width="200px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LblContrasena" runat="server" Font-Names="Comic Sans MS" Text="Contraseña"></asp:Label>
           
        &nbsp;
           
        <asp:TextBox ID="TxtContrasena" runat="server" CssClass="cajasTexto" Font-Names="Comic Sans MS" Height="20px" Width="200px" type="password"></asp:TextBox>
                <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_logueo" runat="server" CssClass="cajasTexto" Height="30px" Text="Iniciar sesion" Width="122px" OnClick="Button1_Click" />
            </div>
          
        </div>
    </form>
</body>
</html>
