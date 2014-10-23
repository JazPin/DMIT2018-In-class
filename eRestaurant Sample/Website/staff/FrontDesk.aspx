<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FrontDesk.aspx.cs" Inherits="FrontDesk" %>

<%@ Register Src="~/UserControl/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>Front Desk</h1>

        <div class="well">
            <h4>Mock Date/Time</h4>
            <div class="pull-right col-md-4">
                Last Billed Date/Time
                <asp:Repeater ID="AdHocBillDateRepeater" runat="server" ItemType="System.DateTime" DataSourceID="AdHocBillDateODS">
                    <ItemTemplate>
                        <%# Item.ToShortDateString() %>
                        &ndash;
                        <%# Item.ToShortTimeString() %>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:ObjectDataSource runat="server" ID="AdHocBillDateODS" OldValuesParameterFormatString="original_{0}" SelectMethod="LastBillDate" TypeName="eRestaurant.BLL.AdhocController"></asp:ObjectDataSource>
            </div>
            <asp:TextBox ID="SearchDate" runat="server" TextMode="Date" Text="2014-10-16"/>
            <asp:TextBox ID="SearchTime" runat="server" TextMode="Time" Text="13:00" CssClass="clockpicker"/>
            <!-- Additional js & css for clock-->
            <script src="../Scripts/clockpicker.js"></script>
            <script>
                $('.clockpicker').clockpicker({ donetext: 'Accept' });
            </script>
            <link itemprop="url" href="../Content/clockpicker.css" rel="stylesheet" />
            <link itemprop="url" href="../Content/standalone.css" rel="stylesheet" />
            <!--End additional files link -->
            <asp:LinkButton ID="MockDateTime" runat="server" CssClass="btn btn-primary">Post-Back new Date/Time</asp:LinkButton>
            <asp:LinkButton ID="MockLastBillingDateTime" runat="server" CssClass="btn btn-default" OnClick="MockLastBillingDateTime_Click">Set to last-billed date/time</asp:LinkButton>
        </div>
        <uc1:MessageUserControl runat="server" ID="MessageUserControl" />
    </div>   
</asp:Content>

