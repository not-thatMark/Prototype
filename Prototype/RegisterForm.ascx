<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.ascx.cs" Inherits="Prototype.RegisterForm" %>
<!DOCTYPE html>  
  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title></title>  
</head>  
<body>  
    <form id="form1" runat="server">  
        <div>  
            <table class="">  
                <tr>  
                    <td>Name</td>  
                    <td>  
                        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td>Password</td>  
                     <td> <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td>Confirm Password</td>  
                    <td>  
                        <asp:TextBox ID="confirmPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>  
                    </td>  
                </tr> 
                <tr>
                    <td>Gender</td>  
                    <td>  
                        <asp:RadioButtonList ID="genderRidioList" runat="server">  
                            <asp:ListItem>Male</asp:ListItem>  
                            <asp:ListItem>Female</asp:ListItem>  
                        </asp:RadioButtonList>  
                    </td>  
                </tr>  
                    
              
                <tr>  
                    <td>Gmail</td>  
                    <td>  
                        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>  
                    </td>  
                   </tr>    
                <tr>
                     <td>Phone number</td>  
                    <td>  
                        <asp:TextBox ID="phoneNumberTextBox" runat="server"></asp:TextBox>  
                    </td>  
                </tr> 
                <tr></tr>
              <tr>
                 <asp:RadioButtonList ID="promotionCheck" runat="server">  
                            <asp:ListItem>Check to receive wonderful promotion emails :) </asp:ListItem>  
                        </asp:RadioButtonList>  
             </tr>
                  
                <tr>  
                    <td>  
                        <asp:Button ID="Submit" runat="server" Text="Submit" />  
                    </td>  
                </tr>
              
                
            </table>  
        </div>  
    </form>  
</body>  
</html> 