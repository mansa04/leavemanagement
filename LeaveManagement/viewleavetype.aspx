<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewleavetype.aspx.cs" Inherits="LeaveManagement.viewleavetype" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="grdleavetype" class="form-control"  runat="server" AutoGenerateColumns="False" OnRowCommand="grdleavetype_RowCommand1">
        <Columns>
            <asp:TemplateField HeaderText="LEAVETYPEID">
                
                <ItemTemplate>
                    <asp:Label ID="Label1" class="form-control" runat="server" Text='<%# Bind("LT_ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LEAVETYPENAME">
                
                <ItemTemplate>
                    <asp:Label ID="Label2" class="form-control"  runat="server" Text='<%# Bind("LT_NAME") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LEAVETYPEDESC">
                
                <ItemTemplate>
                    <asp:Label ID="Label3" class="form-control" runat="server" Text='<%# Bind("LT_DESC") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" class="form-control"  runat="server" CausesValidation="false" CommandName="EDIT"  CommandArgument='<%#Eval("LT_ID")%>' Text="EDIT"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
