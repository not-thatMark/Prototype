<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question.aspx.cs" Inherits="Prototype.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AITR</title>

</head>
<body>

    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Haudi from AITR"></asp:Label>
        <p>
            <asp:Button ID="staffLoginButton" runat="server" OnClick="staffLoginButton_Click" Text="Staff Login" />
        </p>
        <p>
            <asp:PlaceHolder ID="quesitonPlaceHolder" runat="server"></asp:PlaceHolder>
        </p>
        <asp:Button ID="nextButton" runat="server" Text="Next" OnClick="nextButton_Click" />
    </form>
    <p>
        &nbsp;</p>

</body>
</html>
