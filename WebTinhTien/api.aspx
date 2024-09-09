<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="api.aspx.cs" Inherits="WebTinhTien.api" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính tiền thuê khách sạn</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <h1>Tính tiền phòng thuê khách sạn</h1>
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="phong">Chọn phòng:</label>
                <asp:DropDownList ID="phong" runat="server">
                    <asp:ListItem Value="1">Phòng thường (200k/giờ)</asp:ListItem>
                    <asp:ListItem Value="2">Phòng VIP (300k/giờ)</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="soGio">Bạn thuê trong bao lâu (giờ):</label>
                <asp:TextBox id="sogio" runat="server" />
            </div>
            <div class="form-group">
                <asp:Button ID="btnTinhTien" runat="server" Text="Tinh tien" OnClick="btnTinhTien_Click" />
            </div>
            <div class="result">
                <asp:Label ID="result" runat="server"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>