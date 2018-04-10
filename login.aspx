<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
           background-color: wheat;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table=style="margin:auto;border:5px solid white">
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="username"></asp:Label></td>
                    <td></td>
                </tr>

                <tr>
                    <td></td>
                    <td></td>

                </tr>

                <tr>
                    <td></td>
                    <td>
                        </td>

                </tr>

                <tr>
                    <td></td>
                    <td>
                        </td>
                </tr>
            </table>
            <asp:TextBox ID="Textusername" runat="server" style="margin-left: 31px" Width="126px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="password"></asp:Label><asp:TextBox ID="Textpassword" runat="server" TextMode="Password" style="margin-left: 29px" Width="128px"></asp:TextBox>
        </p>
        <p>
                        <asp:Button ID="Btnlogin" runat="server" Text="Login" OnClick="Btnlogin_Click" style="height: 26px" />
        </p>
        <p>
                        <asp:Label ID="lblErrorMessage" runat="server" Text="incorrect user cerdentials" ForeColor ="Red"></asp:Label>
        </p>
    </form>
</body>
</html>
