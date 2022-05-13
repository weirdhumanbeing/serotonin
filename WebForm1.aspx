<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CountDownToSerotonin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="StyleSheet1.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Label ID="Text1" Class="Text" Text="Iki pilnos laimės liko:" runat="server" />
                    <asp:Timer ID="timer" runat="server" Interval="1000">
                    </asp:Timer>
                    <br />
                    <br />
                    <asp:Label ID="Time1" Class="Text" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label2" Class="Text" Text="Arba" runat="server" />
                    <br />
                    <br />
                    <asp:Label ID="Time2" Class="Text" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
