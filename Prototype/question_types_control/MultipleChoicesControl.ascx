<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MultipleChoicesControl.ascx.cs" Inherits="Prototype.MultipleChoicesControl" %>
<asp:Label ID="MultipleChoices_Question_Label" runat="server" Text="Question: "></asp:Label>
<p>
    <asp:CheckBoxList ID="MultipleChoices_Question_CheckBoxList" runat="server">
    </asp:CheckBoxList>
</p>