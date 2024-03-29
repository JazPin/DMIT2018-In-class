﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageSpecialEvents.aspx.cs" Inherits="Admin_ManageSpecialEvents" %>

<%@ Register Src="~/UserControl/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>Manage Special Events <span class="glyphicon glyphicon-glass"></span></h1>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SpecialEventsDataObjectSource" InsertItemPosition="LastItem">
            <EditItemTemplate>
                <span style="">
                    <asp:LinkButton runat="server" CommandName="Update" Text="Update" ID="UpdateButton" />
                    &nbsp;&nbsp;
                    <asp:LinkButton runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:CheckBox Checked='<%# Bind("Active") %>' runat="server" ID="ActiveCheckBox" Text="Active" />
                    &mdash;
                    <asp:Label ID="Label5" runat="server" AssociatedControlID="EventCodeTextBox" CssClass="control-label">EventCode</asp:Label>
                    <asp:TextBox Text='<%# Bind("EventCode") %>' runat="server" ID="EventCodeTextBox" />
                    &mdash;
                    <asp:Label ID="Label6" runat="server" AssociatedControlID="DescriptionTextBox" CssClass="control-label">Description</asp:Label>       
                    <asp:TextBox Text='<%# Bind("Description") %>' runat="server" ID="DescriptionTextBox" />
                </span>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <span>No data was returned.</span>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <span style="">
                    <asp:LinkButton runat="server" CommandName="Insert" ID="InsertButton">Insert <span class="glyphicon glyphicon-plus"></span></asp:LinkButton>&nbsp;&nbsp;
                    <asp:LinkButton runat="server" CommandName="Cancel" Text="Clear" ID="CancelButton">Clear <span class="glyphicon glyphicon-refresh"></span></asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox Checked='<%# Bind("Active") %>' runat="server" ID="ActiveCheckBox" Text="Active" />&mdash;
                    <asp:Label ID="Label3" runat="server" AssociatedControlID="EventCodeTextBox" CssClass="control-label">EventCode:</asp:Label>
                    <asp:TextBox Text='<%# Bind("EventCode") %>' runat="server" ID="EventCodeTextBox" />&mdash;
                    <asp:Label ID="Label4" runat="server" AssociatedControlID="DescriptionTextBox" CssClass="control-label">Description:</asp:Label>
                    <asp:TextBox Text='<%# Bind("Description") %>' runat="server" ID="DescriptionTextBox" />
                </span>
            </InsertItemTemplate>
            <ItemTemplate>
                <div>
                    <asp:LinkButton runat="server" CommandName="Edit" ID="EditButton">Edit <span class="glyphicon glyphicon-pencil"></span></asp:LinkButton>&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton runat="server" CommandName="Delete" ID="DeleteButton" >Delete <span class="glyphicon glyphicon-trash"></span></asp:LinkButton>   &nbsp;&nbsp;&nbsp;              
                    <asp:CheckBox Checked='<%# Eval("Active") %>' runat="server" ID="ActiveCheckBox" Enabled="false" Text="Active" />
                    &mdash;
                    <asp:Label ID="Label1" runat="server" AssociatedControlID="EventCodeLabel" CssClass="cotrol-label">EventCode:</asp:Label>
                    <asp:Label Text='<%# Eval("EventCode") %>' runat="server" ID="EventCodeLabel" />
                    <asp:Label ID="Label2" runat="server" AssociatedControlID="DescriptionLabel" CssClass="cotrol-label">Description:</asp:Label>                   
                    <asp:Label Text='<%# Eval("Description") %>' runat="server" ID="DescriptionLabel" />
                  
                </div>
            </ItemTemplate>
            <LayoutTemplate>
                <fieldset runat="server" id="itemPlaceholderContainer" style="">
                    <div runat="server" id="itemPlaceholder" />
                </fieldset>
            </LayoutTemplate>
            
        </asp:ListView>
        <uc1:MessageUserControl runat="server" ID="MessageUserControl" />
        <asp:ObjectDataSource runat="server" ID="SpecialEventsDataObjectSource" DataObjectTypeName="eRestaurant.Entities.SpecialEvent" DeleteMethod="DeleteSpecialEvent" InsertMethod="AddSpecialEvent" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllSpecialEvents" TypeName="eRestaurant.BLL.RestaurantAdminController" UpdateMethod="UpdateSpecialEvent" OnDeleted="HandleCRUDErrors" OnInserted="HandleCRUDErrors" OnUpdated="HandleCRUDErrors" ></asp:ObjectDataSource>
    </div>
</asp:Content>

