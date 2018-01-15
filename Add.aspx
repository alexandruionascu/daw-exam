<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Add" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
         <h1>DAW Exam</h1>
    <div class="row">
        <div class="input-field col s6">
            <input value="Alvin" runat="server" id="name" type="text" class="validate">
            <label class="active" for="first_name2">Name</label>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6">
            <input value="Alvin" id="first_name2" type="text" class="validate">
            <label class="active" for="first_name2">Brand</label>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6">
            <input value="Alvin" id="description" type="text" class="validate">
            <label class="active" for="first_name2">Description</label>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6">
            <input type="date" name="date" class="datepicker">
            <label class="active" for="date">Launch Date</label>
        </div>
    </div>
    <div class="row">
        <div class="input-field col s6">
            <input value="Alvin" type="text" class="validate">
            <label class="active" for="first_name2">OS</label>
        </div>
    </div>

    <div class="row">
            <div class="input-field col s6">
                <select runat="server" id="os">
                    <option value="" disabled selected>Choose your option</option>
                </select>
                <label>Materialize Select</label>
            </div>
    </div>



    <div class="row">
        <div class="input-field col s6">
            <input value="Alvin" type="text" class="validate">
            <label class="active" for="first_name2">OS</label>
        </div>
    </div>

    <div class="row">
        <div class="input-field col s6">
            <input value="Alvin" type="text" class="validate">
            <label class="active" for="first_name2">OS</label>
        </div>
    </div>

</asp:Content>