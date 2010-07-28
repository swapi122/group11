<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Tables.ascx.cs" Inherits="Controls_Tables" %>
<%@ Import Namespace="WB.Library" %>
<div style="margin-bottom: 10px;">
    Bảng :
    <asp:DropDownList ID="ddlTable" runat="server" AppendDataBoundItems="true" Width="250px">
        <asp:ListItem Value="">----------------- Chọn bảng -----------------</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" 
        onclick="btnUpdate_Click" />
</div>
<table class="grid">
    <tr>
        <th width="150px">
            Name
        </th>
        <th>
            Title
        </th>
        <th width="120px">
            SqlDataType
        </th>
        <th width="80px">
            Key
        </th>
        <th width="40px">
            IsShow
        </th>
        <th width="40px">
            IsNull
        </th>
        <th width="110px">
            Control
        </th>
        <th width="70px">
            Length
        </th>
        <th width="70px">
            Width
        </th>
        <th width="120px">
            FK
        </th>
    </tr>
    <asp:Repeater ID="reptables" runat="server" OnItemDataBound="reptables_ItemDataBound">
        <ItemTemplate>
            <tr>
                <td>
                    <%# Eval("ColumnName") %>
                    <asp:HiddenField ID="hidColumnName" runat="server" Value='<%# Eval("ColumnName") %>' />
                </td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server" Text='<%# Eval("Title") %>'></asp:TextBox>
                </td>
                <td>
                    <%# Eval("SqlDataType")%>
                </td>
                <td>
                    <asp:DropDownList ID="ddlKey" runat="server" Width="100%">
                        <asp:ListItem Value="">--|--</asp:ListItem>
                        <asp:ListItem Value="PRIMARY KEY">PRIMARY KEY</asp:ListItem>
                        <asp:ListItem Value="FOREIGN KEY">FOREIGN KEY</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td align="center">
                    <asp:CheckBox ID="chkIsShow" runat="server" Checked='<%# Eval("IsShow") %>' />
                </td>
                <td align="center">
                    <asp:CheckBox ID="chkIsNull" runat="server" Checked='<%# Eval("IsNull") %>' />
                </td>
                <td>
                    <asp:DropDownList ID="ddlControl" runat="server" Width="100%">
                        <asp:ListItem Value="input">input</asp:ListItem>
                        <asp:ListItem Value="area">area</asp:ListItem>
                        <asp:ListItem Value="fileupload">fileupload</asp:ListItem>
                        <asp:ListItem Value="date">date</asp:ListItem>
                        <asp:ListItem Value="datetime">datetime</asp:ListItem>
                        <asp:ListItem Value="email">email</asp:ListItem>
                        <asp:ListItem Value="numric">numric</asp:ListItem>
                        <asp:ListItem Value="select">select</asp:ListItem>
                        <asp:ListItem Value="checkbox">checkbox</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="txtMaxLength" runat="server" Text='<%# Eval("MaxLength") %>' Width="92%"></asp:TextBox>
                </td>
                <td>
                <asp:TextBox ID="txtWidth" runat="server" Text='<%# Eval("Width") %>' Width="92%"></asp:TextBox>
                </td>
                <td>
                <asp:TextBox ID="txtColumnId" runat="server" Text='<%# FGuid.ToGuid(Eval("ColumnId")) != Guid.Empty ? Eval("ColumnId") : ""%>' Width="92%"></asp:TextBox>
                </td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>
<style type="text/css">
    .txt
    {
        width: 98%;
    }
</style>

<script type="text/javascript">
    $(document).ready(function(){
        $(".grid input[type='text']").addClass("txt");
        
        $("#<%= ddlTable.ClientID %>").change(function(){
            window.location = "/Modules/Tables.aspx?t=" + $(this).val();
        });
    });
</script>

