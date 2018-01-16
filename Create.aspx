<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Create.aspx.cs" Inherits="Add" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="center-align">Add new entry</h1>
    <div class="row">
        <div class="input-field col s6 offset-s3">
            <input runat="server" id="name" type="text" class="validate">
            <label class="active" for="first_name2">Name</label>
            <asp:RequiredFieldValidator ID="v_name" 
                runat="server" ControlToValidate="name"
                ErrorMessage="Please enter the name"/>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6 offset-s3">
            <input runat="server" id="brand" type="text" class="validate">
            <label class="active" for="first_name2">Brand</label>
            <asp:RequiredFieldValidator ID="v_brand" 
                runat="server" ControlToValidate="brand"
                ErrorMessage="Please enter the brand"/>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6 offset-s3">
            <input runat="server" id="description" type="text" class="validate">
            <label class="active" for="first_name2">Description</label>
            <asp:RequiredFieldValidator ID="v_description" 
                runat="server" ControlToValidate="description"
                ErrorMessage="Please enter the description"/>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6 offset-s3">
            <input type="date" id="launchDate" runat="server" name="date" class="datepicker">
            <label class="active" for="date">Launch Date</label>
            <asp:RequiredFieldValidator id="v_launchDate" 
                runat="server" ControlToValidate="launchDate"
                ErrorMessage="Please enter the date"/>
        </div>
    </div>

    <div class="row">
            <div class="input-field col s6 offset-s3">
                <select runat="server" id="os">
                    <option value="" disabled selected>Choose your option</option>
                </select>
                <label>OS</label>
                <asp:RequiredFieldValidator ID="v_os" 
                    runat="server" ControlToValidate="os"
                    ErrorMessage="Please select an os"/>
            </div>
    </div>

    <div class="row center-align">
        <button type="submit" class="waves-effect waves-light btn large" id="submitButton" runat="server" onserverclick="Submit_Click">
            <i class="material-icons left">add_circle</i>Add
        </button>
    </div>

</asp:Content>