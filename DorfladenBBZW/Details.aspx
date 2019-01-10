<%@ Page Title="Produktdetails" Language="C#" MasterPageFile="~/Dorfladen.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="DorfladenBBZW.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SiteContent" runat="server">

    <asp:Image CssClass="floatleft detailpicture" ID="DetailPicture" runat="server"/>

    <h3 runat="server" class="DetailName"><%= prod.Name %></h3>
    <br />
    <span runat="server"><%= prod.Description %></span>
    <br /> <br />
    <asp:Button ID="AddToBasket" class="orangebutton" runat="server" Text="Zum Warenkorb hinzufügen" OnClick="AddToBasket_Click" />
    <br /><br /><br />
    <a class="orangebutton" href="/">Zurück</a>
</asp:Content>
