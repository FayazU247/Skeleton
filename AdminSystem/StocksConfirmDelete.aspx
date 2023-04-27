﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StocksConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWarning" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
    </form>
</body>
</html>
