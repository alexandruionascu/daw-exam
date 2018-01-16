<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register TagPrefix="uc" TagName="MaterialTable" Src="~/Controls/MaterialTable.ascx" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h4>DAW Exam - Searching</h4>
    <div class="row">
        <div class="input-field col s6 offset-s3">
          <input runat="server" id="name" type="text" class="validate">
          <label for="name">Name</label>
        </div>
    </div>

    <div class="row">
        <div class="input-field col s6 offset-s3">
          <input runat="server" id="brand" type="text" class="validate">
          <label for="brand">Brand</label>
        </div>
    </div>

    <div class="row center-align">
        <button type="submit" class="waves-effect waves-light btn large" id="submitButton" onserverclick="submitButton_ServerClick" runat="server">
            <i class="material-icons left">search</i>Search
        </button>
    </div>
    
    <uc:MaterialTable runat="server" Editable="false" />
</asp:Content>