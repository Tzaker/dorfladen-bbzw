<%@ Page Title="Produktedetails" Language="C#" MasterPageFile="~/Dorfladen.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="DorfladenBBZW.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SiteContent" runat="server">

    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "assets/img/" + this.prod.ImageName %>'/>
    <p><%# this.prod.Name %></p>
</asp:Content>
