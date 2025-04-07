<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="leavetype.aspx.cs" Inherits="LeaveManagement.leavetype" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Leave Type</h1>
    <table>
        
        <tr>
            <td>
                <asp:HiddenField ID="hiddenleavetypeid" runat="server" />
                leavetype name
            </td>
            <td>
                <asp:TextBox ID="textltname"  class="form-control"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                description
            </td>
            <td>
                <asp:TextBox ID="textltdesc"  class="form-control"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="buttonsave" class="btn btn-primary"  runat="server" Text="save" OnClick="buttonsave_Click" />
            </td>
        </tr>
         <tr>
            <td>
                <asp:Button ID="buttonnext" class="btn btn-primary"  runat="server" Text="next" OnClick="buttonnext_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="buttonview" class="btn btn-primary" runat="server" Text="view" OnClick="buttonview_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="labelmsg" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
