<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="employee.aspx.cs" Inherits="LeaveManagement.employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1> LEAVE MANAGEMENT </h1>
    <asp:Label ID="labeluser" runat="server" Text="label"></asp:Label>

    <table>
        <tr>
            <td>
               
                 Name
               
                </td>
            <td>
                <asp:TextBox ID="textname" class="form-control" runat="server"></asp:TextBox>
            </td>
            </tr>
        <tr>
             <td>
                CompanyId
               
            </td>
                
        
            <td>
                <asp:TextBox ID="textcompid" class="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 EmailId
            </td>
            <td>
                <asp:TextBox ID="textmailid" class="form-control"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td>
                mobilenumber
               
            </td>

            <td>
                <asp:TextBox ID="textmobileno" class="form-control"  runat="server"></asp:TextBox>
            </td>
            </tr>
         <tr>
        <td>
                Date of join
               
            </td>

            <td>
                <asp:TextBox ID="textdoj" class="form-control" runat="server"></asp:TextBox>
            </td>
            </tr>
         <tr>
        <td>
                Date of leave
               
            </td>

            <td>
                <asp:TextBox ID="textdol" class="form-control" runat="server"></asp:TextBox>
            </td>
            </tr>
      
        <tr>
            <td>
                password
                 <asp:HiddenField ID="hiddenempid" runat="server" />
            </td>
            <td>
                <asp:TextBox ID="textpassword" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
         <tr>
           <td>
               role
           </td>
           <td>
               <asp:DropDownList ID="drprole"  class="form-control" runat="server" >
               </asp:DropDownList>
           </td>
       </tr>
            
<tr>
     <td>
         <asp:Button ID="buttonsave"  class="btn btn-primary" runat="server" Text="save" OnClick="buttonsave_Click" />
         </td>
    </tr>
        <tr>
     <td>
         <asp:Button ID="buttonnext" class="btn btn-primary" runat="server" Text="next" OnClick="buttonnext_Click1" />
         </td>
    </tr>
        <tr>
            <td>
                <asp:Button ID="buttonview" class="btn btn-primary" runat="server" Text="view" OnClick="buttonview_Click" />
            </td>
        </tr>
      
        <tr>
            <td>
                <asp:Label ID="labelmsg" runat="server" Text="label"></asp:Label>
            </td>
        </tr>
        </table>
</asp:Content>
