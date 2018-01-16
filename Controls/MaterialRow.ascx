<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MaterialRow.ascx.cs" Inherits="Controls_MaterialRow" %>
<asp:Panel runat="server" ID="viewPanel">
    <tr>
        <td><%# Instance.name %></td>
        <td><%# Instance.description %></td>
        <td><%# Instance.brand %></td>
        <td><%# Instance.launchDate.ToString("yyyy-MM-dd") %></td>
        <% if (Editable) { %>
        <td><a runat="server" onserverclick="Edit_Click"><i class="material-icons">mode_edit</i></a></td>
        <td><a runat="server" onserverclick="Delete_Click"><i class="material-icons">delete</i></a></td>
        <% } %>
    </tr>
</asp:Panel>
<asp:Panel runat="server" ID="editPanel">
    <td>
        <input runat="server" id="edit_name" placeholder="<%# Instance.name %>" type="text" class="validate">
        <asp:RequiredFieldValidator ID="v_name" runat="server" ControlToValidate="edit_name" ErrorMessage="Please enter the name"/>
    </td>

    <td>
        <input runat="server" id="edit_description" placeholder="<%# Instance.description %>" type="text" class="validate">
        <asp:RequiredFieldValidator runat="server" ControlToValidate="edit_description" ErrorMessage="Please enter the description"/>
    </td>

    <td>
        <input runat="server" id="edit_brand" placeholder="<%# Instance.brand %>" type="text" class="validate">
        <asp:RequiredFieldValidator runat="server" ControlToValidate="edit_brand" ErrorMessage="Please enter a brand" />
    </td>

    <td>
        <input runat="server" id="edit_date" type="date" class="validate">
        <asp:RequiredFieldValidator runat="server" ControlToValidate="edit_date" ErrorMessage="Please select a date" />
    </td>


    <td><a runat="server" onserverclick="Update_Click"><i class="material-icons">check_circle</i></a></td>
</asp:Panel>