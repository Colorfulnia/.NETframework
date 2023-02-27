<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <table>                
                    <tr>
                        <td>Username</td>
                        <td>
                            <asp:TextBox ID="txtUsername" runat="server" required="required"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Password</td>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" required ="required"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan ="2"><h3>
                            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></h3></td>
                    </tr>
                    <tr>
                        <<td colspan="2">
                            <asp:Button ID="btnLogin" runat="server" Text="Sign In" OnClick="btnLogin_Click" />

                         </td>
                    </tr>
                </table>
            </center>
        </div>
    </form>
</body>
</html>
