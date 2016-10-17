<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNewTeacher.aspx.cs" Inherits="Admin_AddNewTeacher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="教师类型"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Width="129px">
        </asp:DropDownList>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="所属部门"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" Width="129px">
        </asp:DropDownList>
        <asp:Label ID="Label3" runat="server" Text="提示"></asp:Label>
        <br />
            <asp:Label ID="Label4" runat="server" Text="教师工号"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="教师姓名"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="密码"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="权限"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server" Width="151px">
        </asp:DropDownList>
        <p>
            <asp:Button ID="Button1" runat="server" Text="确定" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="取消" />
        </p>
    </form>
</body>
</html>
