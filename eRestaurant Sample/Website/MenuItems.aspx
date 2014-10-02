<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MenuItems.aspx.cs" Inherits="MenuItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <%-- Original menu reoeater that showed item entities
        <asp:Repeater ID="MenuItemRepeater" runat="server" DataSourceID="MenuItemDataSource">
        <ItemTemplate>
            <%#((decimal)Eval("CurrentPrice")).ToString("C") %>
            &mdash;<%# Eval("Description") %> &ndash;<%# Eval("MenuCategory.Description") %>
            &mdash; <%# Eval("Calories") %> Calories
        </ItemTemplate>
        <SeparatorTemplate>
            <hr>
        </SeparatorTemplate>
    </asp:Repeater>--%>
    <asp:Repeater ID="MenuItemRepeater" runat="server" DataSourceID="MenuItemDataSource">
        <ItemTemplate>
            <img src="http://placehold.it/150x100/" alt="" /><%# Eval("Description") %>
            <asp:Repeater ID="ItemDetailRepeater" runat="server" DataSource='<%# Eval("MenuItems") %>'> 
                <%--use single quote to DataSouce if inside has double quote--%>
                <ItemTemplate>
                    <div>
                        <%# Eval ("Description") %>&mdash;
                        <%# Eval("Calories") %>&mdash;
                        <%#((decimal)Eval("Price")).ToString("C") %>
                        <br>
                        <%# Eval ("Comment") %>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </ItemTemplate>
        <SeparatorTemplate>
            <hr>
        </SeparatorTemplate>
    </asp:Repeater>
    <asp:ObjectDataSource runat="server" ID="MenuItemDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListCategoryMenuItem" TypeName="eRestaurant.BLL.MenuItemController"></asp:ObjectDataSource>
</asp:Content>

