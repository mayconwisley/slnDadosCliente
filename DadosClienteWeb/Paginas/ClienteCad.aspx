<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ClienteCad.aspx.cs" Inherits="DadosClienteWeb.Paginas.ClienteCad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CplHolder" runat="server">
    <asp:Panel ID="PnlCadastro" runat="server">
        <ul>
            <li>
                <asp:Label Text="Nome" runat="server" />
                <asp:TextBox ID="TxtNome" runat="server" />
            </li>
            <li>
                <asp:Button ID="BtnGravar" Text="Gravar" runat="server" />
                <asp:Button ID="BtnAlterar" Text="Alterar" runat="server" />
                <asp:Button ID="BtnExcluir" Text="Excluir" runat="server" />
            </li>
        </ul>



    </asp:Panel>
</asp:Content>
