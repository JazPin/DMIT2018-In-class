<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MenuItems.aspx.cs" Inherits="MenuItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Repeater ID="MenuItemRepeater" runat="server" DataSourceID="MenuItemDataSource">
        <ItemTemplate>
            <%#((decimal)Eval("CurrentPrice")).ToString("C") %>
            &mdash;<%# Eval("Description") %> &ndash;<%# Eval("MenuCategory.Description") %>
            &mdash; <%# Eval("Calories") %> Calories
        </ItemTemplate>
        <SeparatorTemplate>
            <hr>
        </SeparatorTemplate>
    </asp:Repeater>
    <asp:ObjectDataSource runat="server" ID="MenuItemDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListMenuItems" TypeName="eRestaurant.BLL.MenuItemController"></asp:ObjectDataSource>
</asp:Content>

