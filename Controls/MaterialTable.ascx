<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MaterialTable.ascx.cs" Inherits="Controls_MaterialTable" %>
<%@ Register TagPrefix="uc" TagName="MaterialRow" Src="~/Controls/MaterialRow.ascx" %>

<table class="centered">
    <thead runat="server" id="tableHead">
        <tr>
            <th>Name</th>
            <th>Description</th>
            <th>Brand</th>
            <th>Launch Date</th>
        </tr>
    </thead>
    <tbody runat="server" id="tableBody" />
</table>
