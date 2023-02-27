<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Emp_Educational_Details.aspx.cs" Inherits="WebApplication.Emp_Educational_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Educational Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width ="100">
                <tr>
                    <td>Select Employee</td>
                    <td>
                        <asp:DropDownList ID="ddlEmployee" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Education</td>
                    <td>
                        <asp:TextBox ID="txtEducation" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>University</td>
                    <td>
                        <asp:TextBox ID="txtUniversity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Grade Obtained</td>
                    <td>
                        <asp:TextBox ID="txtGradeObtained" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Passing Year</td>
                    <td>
                        <asp:TextBox ID="txtPassingYear" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
                    </td>
                </tr>

                <tr>
                    <td colspan ="2">
                        <asp:GridView ID="grdEducationalDetail" runat="server" CellPadding="4" DataKeyNames ="Educational_Details_Id" 
                            OnSelectedIndexChanged="grdEducationalDetail_SelectedIndexChanged"
                            ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>

                            <Columns>
                                <asp:CommandField SelectText="Edit" ShowSelectButton="True"></asp:CommandField>
                            </Columns>

                            <EditRowStyle BackColor="#999999"></EditRowStyle>

                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>

                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>

                            <PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>

                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                            <SortedAscendingCellStyle BackColor="#E9E7E2"></SortedAscendingCellStyle>

                            <SortedAscendingHeaderStyle BackColor="#506C8C"></SortedAscendingHeaderStyle>

                            <SortedDescendingCellStyle BackColor="#FFFDF8"></SortedDescendingCellStyle>

                            <SortedDescendingHeaderStyle BackColor="#6F8DAE"></SortedDescendingHeaderStyle>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
