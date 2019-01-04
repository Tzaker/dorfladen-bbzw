<%@ Page Title="Übersicht" Language="C#" MasterPageFile="~/Dorfladen.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DorfladenBBZW.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SiteContent" runat="server">
    <h3 class="overview-title">Aktionen
    </h3>
    <asp:ListView ID="ProductListView" runat="server" ItemType="DorfladenBBZW.Models.Product" SelectMethod="GetProducts">
        <LayoutTemplate>
            <span runat="server" id="itemPlaceholder"></span>
        </LayoutTemplate>
        <ItemTemplate>
            <a href="/Product.aspx?pId=<%#: Item.Id %>" class="overviewlist-item">
                <asp:Image runat="server" CssClass="overviewlist-img" ImageUrl='<%# "assets/img/" + Item.ImageName %>' BorderStyle="None"/>                    
                <span class="overviewlist-itemname"><%#: Item.Name %></span>
                <span class="overviewlist-itemnewprice">CHF <%#: Item.SpecialOffer %></span>
                <span class="overviewlist-itemogprice">CHF <%#: Item.OriginalPrice %></span>
            </a>
        </ItemTemplate>
     </asp:ListView>
</asp:Content>
