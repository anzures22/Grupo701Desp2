<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Grupo701Desp2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp; matricula<br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp; Nombre
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Telefono<br />
            <br />
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            Correo<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
            &nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Editar" OnClick="Button2_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Mostrar" OnClick="Button3_Click" />
            &nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Eliminar" />
            <br />
        </div>
    </form>
</body>
</html>
