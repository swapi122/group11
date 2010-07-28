<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ItemCatalog.ascx.cs" Inherits="Controls_ItemCatalog" %>
<%@ Import Namespace="WB.Library.TableSchema" %>
<tr>
    <td width="150">
        <b>
            <%= field.Title %>
        </b>
    </td>
    <td>
        <asp:TextBox ID="txtField" runat="server" CssClass="hide"></asp:TextBox>
        <div id="divTextbox" runat="server" visible="false">
            <asp:TextBox ID="txtItem" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="txtItem" ID="valtxt"
                runat="server" ErrorMessage="RequiredFieldValidator" Text="*"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="regtxt" Display="Dynamic" ControlToValidate="txtItem" runat="server" ErrorMessage="RegularExpressionValidator" Enabled="false"></asp:RegularExpressionValidator>
        </div>
        <div id="divDropdownlist" runat="server" visible="false">
            <asp:DropDownList ID="ddlItem" runat="server" AppendDataBoundItems="true">
                <asp:ListItem Value="">Chọn</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="ddlItem" ID="valddl"
                runat="server" ErrorMessage="RequiredFieldValidator" Text="*"></asp:RequiredFieldValidator>
        </div>
        <div id="divFileUpload" runat="server" visible="false">
            <asp:FileUpload ID="uploadItem" runat="server" />
            <asp:RequiredFieldValidator Display="Dynamic" ControlToValidate="uploadItem" ID="valupload"
                runat="server" ErrorMessage="RequiredFieldValidator" Text="*"></asp:RequiredFieldValidator>
        </div>
        
    </td>
</tr>
