<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewemployee.aspx.cs" Inherits="LeaveManagement.viewemployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="grdemployee" class="form-control"  runat="server" AutoGenerateColumns="False" OnRowCommand="grdemployee_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="ID">
               
                <ItemTemplate>
                    <asp:Label ID="Label1" class="form-control" runat="server" Text='<%# Bind("EMP_ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="NAME">
                
                <ItemTemplate>
                    <asp:Label ID="Label2" class="form-control" runat="server" Text='<%# Bind("EMP_NAME") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="COMPANYID">
                
                <ItemTemplate>
                    <asp:Label ID="Label3" class="form-control" runat="server" Text='<%# Bind("EMP_COMP_ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="MAILID">
               
                <ItemTemplate>
                    <asp:Label ID="Label4" class="form-control" runat="server" Text='<%# Bind("EMP_MAILID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="MOBILENUMBER">
               
                <ItemTemplate>
                    <asp:Label ID="Label5" class="form-control" runat="server" Text='<%# Bind("EMP_MOBILENO") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DATEOFJOIN">
               
                <ItemTemplate>
                    <asp:Label ID="Label6" class="form-control"  runat="server" Text='<%# Bind("EMP_DOJ") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="DATEOFLEAVE">
               
                <ItemTemplate>
                    <asp:Label ID="Label7" class="form-control" runat="server" Text='<%# Bind("EMP_DOL") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField  HeaderText="ROLE">
                
                <ItemTemplate>
                    <asp:Label ID="Label8" class="form-control"  runat="server" Text='<%# Bind("EMP_ROLEID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PASSWORD">
                
                <ItemTemplate>
                    <asp:Label ID="Label9" class="form-control" runat="server" Text='<%# Bind("EMP_PASSWORD") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="ROLE ID">
                
                <ItemTemplate>
                    <asp:Label ID="Label10" class="form-control" runat="server" Text='<%# Bind("RL_ID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="ROLE NAME">
                
                <ItemTemplate>
                    <asp:Label ID="Label11" class="form-control" runat="server" Text='<%# Bind("RL_NAME") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" class="form-control" runat="server" CausesValidation="false" CommandName="EDIT"  CommandArgument='<%#Eval("EMP_ID")%>' Text="EDIT"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
