<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReservationBySpecialEvent.aspx.cs" Inherits="ReservationBySpecialEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Special Event:"></asp:Label>
    <asp:DropDownList ID="specialEvent" runat="server" DataSourceID="SpecialEventsDataSource" DataTextField="Description" DataValueField="EventCode" AppendDataBoundItems="True">
        <asp:ListItem>Select a Special Event</asp:ListItem>
        <asp:ListItem Value="">No Event</asp:ListItem>
    </asp:DropDownList>
    <asp:ObjectDataSource runat="server" ID="SpecialEventsDataSource" OldValuesParameterFormatString="original_{0}" SelectMethod="ListSpecialEvent" TypeName="eRestaurant.BLL.ReservationBySpecialeventController"></asp:ObjectDataSource>
    <asp:LinkButton ID="LinkButton1" runat="server">View Reservation</asp:LinkButton><br />
    <asp:Label ID="Label2" runat="server" Text="Reservation:"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ReservationsDataSource">
        <Columns>
            <asp:BoundField DataField="ReservationID" HeaderText="ReservationID" SortExpression="ReservationID" />
            <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" SortExpression="CustomerName" />
            <asp:BoundField DataField="ReservationDate" HeaderText="ReservationDate" SortExpression="ReservationDate" />
            <asp:BoundField DataField="NumberInParty" HeaderText="NumberInParty" SortExpression="NumberInParty" />
            <asp:BoundField DataField="ContactPhone" HeaderText="ContactPhone" SortExpression="ContactPhone" />
            <asp:BoundField DataField="ReservationStatus" HeaderText="ReservationStatus" SortExpression="ReservationStatus" />
            <asp:BoundField DataField="EventCode" HeaderText="EventCode" SortExpression="EventCode" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ReservationsDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListReservationBySpecialEvent" TypeName="eRestaurant.BLL.ReservationBySpecialeventController">
        <SelectParameters>
            <asp:ControlParameter ControlID="specialEvent" DefaultValue="" Name="eventCode" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

