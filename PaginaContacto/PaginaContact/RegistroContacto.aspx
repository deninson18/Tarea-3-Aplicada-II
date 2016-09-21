<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistroContacto.aspx.cs" Inherits="PaginaContacto.PaginaContact.RegistroContacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>MIS CONTACTOS</h1>
    <p>&nbsp;</p>
    <p>ID:
        <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
    &nbsp;<asp:Button ID="Buscar" runat="server" Height="22px" Text="Buscar" />
    </p>
    <p>E-Mail:&nbsp;
        <asp:TextBox ID="emailTextBox" runat="server" Height="16px" Width="234px"></asp:TextBox>
    </p>
    <p>Asunto:
        <asp:TextBox ID="AsuntoTextBox" runat="server" style="margin-left: 6px" Width="234px"></asp:TextBox>
    </p>
    <p>Mensaje:
        <asp:TextBox ID="mensajeTextBox" runat="server" Width="234px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Nuevo" runat="server" style="margin-left: 61px; height: 26px;" Text="NUEVO" Width="96px" OnClick="Nuevo_Click" />
        <asp:Button ID="Guardar" runat="server" style="margin-left: 38px" Text="GUARDAR" width="96px" OnClick="Guardar_Click"/>
        <asp:Button ID="Eliminar" runat="server" style="margin-left: 31px" Text="ELIMINAR" Width="96px" OnClick="Eliminar_Click" />
    </p>
    <p>&nbsp;</p>
</asp:Content>
