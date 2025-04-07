<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewleaves.aspx.cs" Inherits="LeaveManagement.viewleaves" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <br />
    <asp:GridView ID="grdleaves" class="form-control" runat="server" AutoGenerateColumns="False" OnRowCommand="grdleaves_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="LEAVEID">
                
                <ItemTemplate>
                    <asp:Label ID="Label1" class="form-control" runat="server" Text='<%# Bind("LE_ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LEAVEEMPID">
                
                <ItemTemplate>
                    <asp:Label ID="Label2" class="form-control" runat="server" Text='<%# Bind("LE_EMP_ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LEAVETYPEID">
               
                <ItemTemplate>
                    <asp:Label ID="Label3" class="form-control"  runat="server" Text='<%# Bind("LE_LT_ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LEAVEDESC">
                
                <ItemTemplate>
                    <asp:Label ID="Label4" class="form-control" runat="server" Text='<%# Bind("LE_DESC") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DATEFROM">
                
                <ItemTemplate>
                    <asp:Label ID="Label5" class="form-control"  runat="server" Text='<%# Bind("LE_DATE_FROM") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DATETO">
                
                <ItemTemplate>
                    <asp:Label ID="Label6" class="form-control" runat="server" Text='<%# Bind("LE_DATE_TO") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="NOOFDAYS">
               
                <ItemTemplate>
                    <asp:Label ID="Label7" class="form-control"  runat="server" Text='<%# Bind("LE_NOOFDAYS") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" class="form-control" runat="server" CausesValidation="false" CommandName="EDIT" CommandArgument='<%#Eval("LE_ID")%>' Text="EDIT"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
      </asp:GridView>
</asp:Content>
