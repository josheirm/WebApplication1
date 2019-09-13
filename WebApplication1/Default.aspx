

<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.About" %>


 


    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2><%: Title %>.</h2>
    <h3>Your application description page!</h3>
    <p>Use this area to provide additional information.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Button Text = "2" ID="Button5"  OnClick="Browser2Click" runat = "server" Width="500px" />
        <asp:Button runat="server" id="Button1" Text="goto ABC" OnClick="Click" Width="100px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">LinkButton</asp:LinkButton>
        </p>
        <p>
        
        &nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="L3a" >Room 2</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton3" runat="server">Room 3</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;
    </p>
    <p>

        
        <asp:TextBox TextMode ="Multiline" ID ="Text1" name="" runat="server" Height="200px" Rows="5" OnTextChanged="Text1_TextChanged"></asp:TextBox></p>
    <p>
        <asp:TextBox ID="Text2" runat="server"></asp:TextBox></p>
    <p>
        <asp:Button Text = "Submit" ID="Submit"  OnClick="OnSubmit1" runat = "server" Width="500px" /></p>
    <p>
        &nbsp;</p>

         <asp:Label ID="Label1" runat="server" Text="default" Font-Bold="True" />
         

           

</asp:Content>

   
