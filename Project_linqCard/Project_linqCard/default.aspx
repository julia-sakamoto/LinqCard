<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FinalProject_HomePage._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="Stylesheet" href="/css/main.css" type="text/css" />
    <div class="container">
        <div class="deptContainer" dir="ltr">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
            <asp:Image ID="Image1" runat="server" />
        </div>
        <div class="deptContainer">
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
            <asp:Image ID="Image2" runat="server" />
        </div>
        <div class="deptContainer">
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br />
            <asp:Image ID="Image3" runat="server" />
        </div>
        <div class="deptContainer">
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label><br />
            <asp:Image ID="Image5" runat="server" />
        </div>
        <div class="deptContainer">
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><br />
            <asp:Image ID="Image4" runat="server" />
        </div>
    </div>
</asp:Content>

