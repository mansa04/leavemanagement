<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="leaves.aspx.cs" Inherits="LeaveManagement.leave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <table>
        
        <tr>
            <td>
                employee id
               
                </td>
            <td>
                <asp:HiddenField ID="hiddenleaveempid" runat="server" />
                <asp:TextBox ID="textlempid" class="form-control" runat="server"></asp:TextBox>
            </td>
            </tr>
        
        <tr>
            <td>
               
                 leave type id
               
                </td>
            <td>
                <asp:DropDownList ID="drpletid" runat="server" OnSelectedIndexChanged="buttonsave_Click">
                   
                    </asp:DropDownList>
            </td>
            </tr>

        <tr>
            <td>
               
                 Description
               
                </td>
            <td>
                <asp:TextBox ID="textldesc" class="form-control" runat="server"></asp:TextBox>
            </td>
            </tr>
        <tr>
             <td>
               datefrom
               
            </td>
                
        
            <td>
                <asp:TextBox ID="textdatefrom" class="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 todate
            </td>
            <td>
                <asp:TextBox ID="textdateto" class="form-control"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td>
               numberofdays
               
            </td>

            <td>
                <asp:TextBox ID="textnoofdays" class="form-control"  runat="server"></asp:TextBox>
            </td>
            </tr>
        <tr>
     <td>
         <asp:Button ID="buttonsave"  class="btn btn-primary" runat="server" Text="save" OnClick="buttonsave_Click" />
         </td>
    </tr>
      <tr>
     <td>
         <asp:Button ID="buttonback"  class="btn btn-primary"  runat="server" Text="back" OnClick="buttonback_Click" />
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
