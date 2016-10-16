<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-bottom: 0px">
        <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;<br />
        <asp:Label ID="Label4" runat="server" Text="验证码"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <img src="ValidateImage.aspx" alt="提示文字" style ="width:80px; height:20px" onclick ="this.src = this.src + '?'" /><br />
        <asp:Button ID="Button1" runat="server" onclick="Button_Click" Text="登陆" />
        <br />
        <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="帐密123"></asp:Label>
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
