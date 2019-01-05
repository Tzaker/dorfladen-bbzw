<%@ Page Title="Warenkorb" Language="C#" MasterPageFile="~/Dorfladen.Master" AutoEventWireup="true" CodeBehind="Basket.aspx.cs" Inherits="DorfladenBBZW.Basket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SiteContent" runat="server">
    <asp:Table ID="BasketTable" runat="server">
    </asp:Table>
    <asp:Label CssClass="totallabel" ID="TotalPrice" runat="server" Text="Label"></asp:Label>
</asp:Content>
