<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lobby.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="User 1" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="User2" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" text = "next screen" NavigateUrl="~/Default1.aspx"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
