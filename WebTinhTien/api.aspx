<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="api.aspx.cs" Inherits="WebTinhTien.api" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tinh tien thue phong khach san</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <h1>Tinh tien thue phong khach san</h1>
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="phong">Chon loai phong:</label>
                <asp:DropDownList ID="phong" runat="server">
                    <asp:ListItem Value="1">Phong thuong (200k/gio)</asp:ListItem>
                    <asp:ListItem Value="2">Phong VIP (300k/gio)</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="soGio">Ban thue trong bao lau (gio):</label>
                <asp:TextBox ID="soGio" runat="server" />
            </div>
            <div class="form-group">
                <asp:Button ID="btnTinhTien" runat="server" Text="Tinh tien" />
            </div>
            <div class="result">
                <asp:Label ID="result" runat="server"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>