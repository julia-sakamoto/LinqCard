<%@ Page Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="businessCard.aspx.cs" Inherits="Project_linqcard.businessCard" %>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	 <link rel="Stylesheet" href="/css/card.css" type="text/css" /> 

	<div id="div2" runat="server" style="display:flex;justify-content:center;flex-wrap:wrap">
		</div>

	<div runat="server" id="myModal" class="modal">

  <!-- Modal content -->
  <div runat="server" class="modal-content">
    <div  runat="server" class="modal-header">
		<asp:Button ID="close" runat="server" OnClick="close_Click" class="close" Text=" &times;" style="border-color:transparent;background-color:transparent;"/>
        <h2>Edit or Delete</h2>
	</div>
    <div runat="server" class="modal-body">
      <div class='card back'>
		<div class='yellow'></div>
		<div class='top dots'></div>
		<div class='personal-info'>
			<asp:TextBox ID="name" runat="server"></asp:TextBox>
			<asp:TextBox ID="title" runat="server"></asp:TextBox>
			<asp:TextBox ID="address" runat="server"></asp:TextBox>
			<asp:TextBox ID="phone" runat="server"></asp:TextBox>
			<asp:TextBox ID="email" runat="server"></asp:TextBox>
            <asp:TextBox ID="id" runat="server" style="visibility:hidden"></asp:TextBox>
  </div>
  <div class='bottom'></div>
  <div class='pink'></div>
</div>
    </div>
    <div runat="server" class="modal-footer">
      <h3>
		  <asp:Button ID="update" runat="server" Text="Update" Onclick="update_Click"/>
		  <asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" />
      </h3>
    </div>
  </div>
</div>

	<div runat="server" id="insertModal" class="modal">

        <div runat="server" class="modal-content">
    <div  runat="server" class="modal-header">
		<asp:Button ID="btnCloseInsert" runat="server" OnClick="insertClose_Click" class="close" Text=" &times;" style="border-color:transparent;background-color:transparent;"/>
        <h2>Insert New Business Card</h2>
	</div>
    <div runat="server" class="modal-body">
      <div class='card back'>
		<div class='yellow'></div>
		<div class='top dots'></div>
		<div class='personal-info'>
            <asp:TextBox ID="newName" runat="server" placeholder="Name"></asp:TextBox>
			<asp:TextBox ID="newTitle" runat="server" placeholder="Job Title"></asp:TextBox>
			<asp:TextBox ID="newAddress" runat="server" placeholder="Address"></asp:TextBox>
			<asp:TextBox ID="newPhone" runat="server" placeholder="Phone Number"></asp:TextBox>
			<asp:TextBox ID="newEmail" runat="server" placeholder="Email"></asp:TextBox>
			</div>
  <div class='bottom'></div>
  <div class='pink'></div>
</div>
    </div>
    <div runat="server" class="modal-footer">
      <h3>
		  <asp:Button ID="btnInsert" runat="server" Text="Insert" Onclick="insert_Click"/>
	  </h3>
    </div>
  </div>

	</div>

    <asp:Button ID="btnShowInsert" runat="server" Text="Insert" onClick="btnShowInsert_Click"/>
	
</asp:Content>
