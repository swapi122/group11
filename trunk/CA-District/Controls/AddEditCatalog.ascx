<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddEditCatalog.ascx.cs"
    Inherits="Controls_AddEditCatalog" %>
<%@ Register Src="ItemCatalog.ascx" TagName="ItemCatalog" TagPrefix="uc1" %>
<h2>
    <asp:Label ID="lblTitle" runat="server"></asp:Label>
</h2>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
<table width="100%">
    <asp:Repeater ID="rep" runat="server" OnItemDataBound="rep_ItemDataBound">
        <ItemTemplate>
            <uc1:ItemCatalog ID="item" runat="server" field="<%# Container.DataItem %>" />
        </ItemTemplate>
    </asp:Repeater>
</table>
<asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
<asp:Button ID="btnEdit" runat="server" Text="Cập nhật" Visible="false" OnClick="btnEdit_Click" />
<asp:Button ID="btnDelete" runat="server" Text="Xóa" Visible="false" ValidationGroup="del"
    OnClick="btnDelete_Click" OnClientClick="return confirm('Xác nhận xóa ?')" />
<asp:Button ID="btnCancel" runat="server" Text="Quay ra" ValidationGroup="cancel"
    OnClick="btnCancel_Click" />
