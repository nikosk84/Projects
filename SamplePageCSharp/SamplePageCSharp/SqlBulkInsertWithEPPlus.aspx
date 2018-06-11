<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlBulkInsertWithEPPlus.aspx.cs" Inherits="SamplePageCSharp.SqlBulkInsertWithEPPlus1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

            </ContentTemplate>
        </asp:UpdatePanel>
         <asp:FileUpload ID="uploader" runat="server" />
        <asp:Button ID="btnUpload" Text="Upload" runat="server" OnClick="btnUpload_Click" />
        <table>
            <tr>
                <td>
                   <asp:Label ID="lblShow" Text="Here" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
