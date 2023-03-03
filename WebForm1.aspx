<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplicationClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 365px; width: 494px">
            <asp:Panel ID="Panel1" runat="server" Height="362px">
                <br />
                <br />
                <asp:Label ID="label1" runat="server"
                    Font-Bold="True"
                    Font-Names="Arial"
                    Font-Size="10pt"
                    ForeColor="Black"> 
                   &nbsp;&nbsp;Número 1: 
                </asp:Label>
               
                <asp:TextBox ID="txtNum1" runat="server" type="number"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="label2" runat="server"
                    Font-Bold="True"
                    Font-Names="Arial"
                    Font-Size="10pt"
                    ForeColor="Black"> 
                    &nbsp;&nbsp;Número 2: 
                </asp:Label>
                
                <asp:TextBox ID="txtNum2" runat="server" type="number"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSuma" runat="server" Font-Bold="True" Text="Suma" />
                &nbsp;&nbsp;
                <asp:Button ID="btnResta" runat="server" Font-Bold="True" Text="Resta" />
                &nbsp;
                <asp:Button ID="btnMultiplicacion" runat="server" Font-Bold="True" Text="Multiplicacion" />
                &nbsp;
                <asp:Button ID="btnDivision" runat="server" Font-Bold="True" Text="Division" />
                <br />
                <br />
                <asp:Label ID="label3" runat="server" 
                    Font-Bold="True"
                    Font-Names="Arial"
                    Font-Size="10pt"
                    ForeColor="Black"> &nbsp;&nbsp;Resultado:  </asp:Label>
                &nbsp; &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnLimpiar" runat="server" Font-Bold="True" Text="Limpiar" />
                <br />
                <br />
                &nbsp;
                <asp:TextBox ID="txtResultado" runat="server" Enabled="False" Height="118px" Width="459px"></asp:TextBox>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
