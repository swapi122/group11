<%@ Page Language="C#" MasterPageFile="~/MasterPage-1col.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Test_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerHolder" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentHolder" runat="Server">
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
</asp:Content>
