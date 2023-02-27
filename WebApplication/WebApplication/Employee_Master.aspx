<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Employee_Master.aspx.cs" Inherits="WebApplication.Employee_Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%">
                <tr>
                        <td><h4>
                            <asp:Label ID="lblUserId" runat="server" Text="="></asp:Label></h4></td>
                        <td><h4>
                            <asp:Label ID="lblFullName" runat="server" Text="="></asp:Label></h4></td>

                </tr>
                <tr>
                    <td>Employee Name</td>
                    <td>
                        <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
                      <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ValidationGroup="save" ControlToValidate="txtEmployeeName" 
                            ErrorMessage="Employee Name is Required" ForeColor="Red"></asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td>Contact No</td>
                    <td>
                        <asp:TextBox ID="txtContactNo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address Line 1</td>
                    <td>
                        <asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address Line 2</td>
                    <td>
                        <asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City</td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>State</td>
                    <td>
                        <asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Country</td>
                    <td>
                        <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Zip Code</td>
                    <td>
                        <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="btnSave" runat="server" ValidationGroup="save" Text="Save" OnClick="btnSave_Click" />

                        <asp:Button ID="btnUpdate" runat="server" ValidationGroup="save" Text="Update" OnClick="btnUpdate_Click" />

                        <asp:Button ID="btnDelete" runat="server" ValidationGroup="save" Text="Delete" OnClick="btnDelete_Click" />
                    </td>
                    <td></td>
                </tr>

                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="grdEmployeeList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                            OnSelectedIndexChanged="grdEmployeeList_SelectedIndexChanged"
                            DataKeyNames="Employee_Id">
                            <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

                            <Columns>
                                <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                            </Columns>

                            <EditRowStyle BackColor="#2461BF"></EditRowStyle>

                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>

                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>

                            <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White"></PagerStyle>

                            <RowStyle BackColor="#EFF3FB"></RowStyle>

                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                            <SortedAscendingCellStyle BackColor="#F5F7FB"></SortedAscendingCellStyle>

                            <SortedAscendingHeaderStyle BackColor="#6D95E1"></SortedAscendingHeaderStyle>

                            <SortedDescendingCellStyle BackColor="#E9EBEF"></SortedDescendingCellStyle>

                            <SortedDescendingHeaderStyle BackColor="#4870BE"></SortedDescendingHeaderStyle>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
</asp:Content>
