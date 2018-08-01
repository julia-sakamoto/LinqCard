<%@ Page Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Project_linqCard._default" %> 
 
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <link rel="Stylesheet" href="/css/main.css" type="text/css" /> 
    <div class="container"> 
        <div class="deptContainer" dir="ltr"> 
            <asp:Label ID="Label1" runat="server" Text="Information Technology" class="label"></asp:Label><br /> 
            <asp:Image ID="Image1" runat="server" class="img"/> 
        </div> 
        <div class="deptContainer"> 
            <asp:Label ID="Label2" runat="server" Text="Medical" class="label"></asp:Label><br /> 
            <asp:Image ID="Image2" runat="server" class="img"/> 
        </div> 
        <div class="deptContainer"> 
            <asp:Label ID="Label3" runat="server" Text="Financial Services" class="label"></asp:Label><br /> 
            <asp:Image ID="Image3" runat="server" class="img" /> 
        </div> 
        <div class="deptContainer"> 
            <asp:Label ID="Label5" runat="server" Text="Sales" class="label"></asp:Label><br /> 
            <asp:Image ID="Image5" runat="server" class="img" /> 
        </div> 
        <div class="deptContainer"> 
            <asp:Label ID="Label4" runat="server" Text="Consulting" class="label"></asp:Label><br /> 
            <asp:Image ID="Image4" runat="server" class="img" /> 
        </div> 
    </div> 
</asp:Content> 
