<%@ Page Language="C#" MasterPageFile="~/MasterPage-2col.master" AutoEventWireup="true"
    CodeFile="Default-2col.aspx.cs" Inherits="Test_Default_2col" Title="Page 2 col" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerHolder" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentHolder" runat="Server">
    <div>
        content
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="rightHolder" runat="Server">
    <div class="widget-black">
        <div class="t1">
            <div class="t2">
                <div class="t3">
                    <h3>
                        Chức năng</h3>
                </div>
            </div>
        </div>
        <div class="items">
            <div>
                <ul>
                    <li><a href="#">Doi tuong</a></li>
                    <li><a href="#">Vu viec</a></li>
                </ul>
            </div>
        </div>
        <div class="b1">
            <div class="b2">
                <div class="b3">
                </div>
            </div>
        </div>
    </div>
    
    <div class="widget-white">
        <div class="t1">
            <div class="t2">
                <div class="t3">
                    <h3>
                        Chức năng</h3>
                </div>
            </div>
        </div>
        <div class="items">
            <div>
                <ul>
                    <li><a href="#">Doi tuong</a></li>
                    <li><a href="#">Vu viec</a></li>
                </ul>
            </div>
        </div>
        <div class="b1">
            <div class="b2">
                <div class="b3">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
