<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LeaveManagement.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1> LOGIN PAGE </h1>

    <table>
             <tr>
            <td>
                 mailId
            </td>
            <td>
                <asp:TextBox ID="textmailid"   runat="server"></asp:TextBox>
            </td>
        </tr>
             <tr>
            <td>
                password
            </td>
            <td>
                <asp:TextBox ID="textpassword"  runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
              <tr>
            <td>
                <asp:Button ID="buttonsave" runat="server" Text="login" OnClick="buttonsave_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="labelmsg" runat="server" Text="label"></asp:Label>
            </td>
        </tr>
        </table>
   
    </div>
    </form>
</body>
</html>
