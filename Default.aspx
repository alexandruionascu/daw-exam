<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h1>DAW Exam</h1>
    <div class="row">
        <div class="input-field col s6">
            <input value="Alvin" id="first_name2" type="text" class="validate">
            <label class="active" for="first_name2">First Name</label>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6">
            <input type="date" name="date" class="datepicker">
            <label class="active" for="date">Pick Date</label>
        </div>
    </div>
</asp:Content>