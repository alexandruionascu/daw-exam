<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="Manage" %>
<%@ Register TagPrefix="uc" TagName="MaterialTable" Src="~/Controls/MaterialTable.ascx" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h1>Read Update Delete</h1>
    <uc:MaterialTable runat="server" Editable="true" />
</asp:Content>