﻿<%@ Page Language="C#" MasterPageFile="~/Site6.Master" AutoEventWireup="true" CodeBehind="removeuser.aspx.cs" Inherits="software.removeuser" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<form id="form1" runat="server">
  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<center>
<asp:GridView ID="GridView1" runat="server" Width="750px" 
        AllowPaging="True" OnRowDeleting ="GridView1_RowDeleting" OnPageIndexChanging = "OnPaging"
        AllowSorting="True" AutoGenerateColumns="False"  DataKeyNames ="UserId">
         <Columns>
                        <asp:BoundField DataField="UserId" HeaderText="User Id"  ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign ="Center"  />     
                        <asp:BoundField DataField="Username" HeaderText="User Name" ItemStyle-HorizontalAlign="Center"  />
                        <asp:BoundField DataField="name" HeaderText="Name" ItemStyle-HorizontalAlign="Center" />  
                        <asp:BoundField DataField="phoneno" HeaderText="Contact" ItemStyle-HorizontalAlign="Center" /> 
                        <asp:BoundField DataField="Branch" HeaderText="Branch " ItemStyle-HorizontalAlign="Center" /> 
                        <asp:BoundField DataField="email" HeaderText="Email ID" ItemStyle-HorizontalAlign="Center" /> 
                        <asp:CommandField  ShowDeleteButton="True" ItemStyle-HorizontalAlign="Center" >
                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                        </asp:CommandField>
                    </Columns>
                        <HeaderStyle BackColor = "Black"  ForeColor ="White"/>
                        
    </asp:GridView>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label> 
</center>
</form>
</asp:Content>