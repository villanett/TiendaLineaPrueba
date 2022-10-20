<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="pnl1" runat="server">
        <table width="100%"  border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td style="text-align:center;vertical-align:top;width:25%">
                <asp:Button ID="Button1" runat="server" Text="Obtener Categorias" OnClick="Button1_Click" />
                <br />
                <asp:Label ID="lblResultado1" runat="server"></asp:Label>
            </td>
            <td style="text-align:center;vertical-align:top;width:25%">
                <asp:Button ID="Button2" runat="server" Text="Obtener Etiquetas" OnClick="Button2_Click" />
                <br />
                <asp:Label ID="lblResultado2" runat="server"></asp:Label>
            </td>
          </tr>
          </table>
         </asp:Panel>
        <asp:Panel ID="pnl2" runat="server">
        <table width="100%"  border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td style="text-align:center;vertical-align:top;width:25%">
                <asp:Button ID="Button3" runat="server" Text="Obtener Artículos" OnClick="Button3_Click" />
                <br />
                <asp:Label ID="lblResultado3" runat="server"></asp:Label>
            </td>
            <td style="text-align:center;vertical-align:top;width:25%">
                <asp:Button ID="Button4" runat="server" Text="Obtener Promociones" OnClick="Button4_Click" />
                <br />
                <asp:Label ID="lblResultado4" runat="server"></asp:Label>
            </td>
          </tr>
          </table>
         </asp:Panel>
        <asp:Panel ID="pnl3" runat="server">
        <table width="100%"  border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td style="text-align:center;vertical-align:top;width:25%">
                <asp:Button ID="Button5" runat="server" Text="Obtener Artículo" OnClick="Button5_Click" />
                <br />
                <asp:TextBox ID="txb5" runat="server"></asp:TextBox>
                <asp:Label ID="lblResultado51" runat="server"></asp:Label>
                <asp:Image ID="imgResultado52" runat="server" ImageAlign="Left" />
            </td>
          </tr>
          </table>
         </asp:Panel>
        <asp:Panel ID="pnlGrupos" runat="server">
        <table width="100%"  border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td style="text-align:center;vertical-align:top;width:25%">
                <asp:Button ID="Button9" runat="server" Text="Obtener Grupos" OnClick="Button9_Click" />
                <br />
                Tipo: <asp:DropDownList ID="ddlTipo" runat="server">
                        <asp:ListItem Value="1" Text="1 Dimensiones" />
                        <asp:ListItem Value="2" Text="2 Divisiones" />
                        <asp:ListItem Value="3" Text="3 Grupos" />
                        <asp:ListItem Value="4" Text="4 Subgrupos" />
                        <asp:ListItem Value="5" Text="5 Artículos" />
                      </asp:DropDownList>
                <asp:Label ID="lblResultado9" runat="server"></asp:Label>
            </td>
          </tr>
          </table>
         </asp:Panel>
        <br /><br />
        <asp:Panel ID="pnl4" runat="server">
        <table width="100%"  border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td style="text-align:center;vertical-align:top;width:25%">
                <asp:Button ID="Button6" runat="server" Text="Agregar Cotización" OnClick="Button6_Click" />
                <br />
                <asp:DropDownList ID="ddl6" runat="server">
                    <asp:ListItem Value="1" Text="Transferencia" /><asp:ListItem Value="2" Text="Efectivo" /><asp:ListItem Value="3" Text="Tarjeta" /><asp:ListItem Value="4" Text="Paypal" />
                </asp:DropDownList>
                <asp:Label ID="lblResultado6" runat="server"></asp:Label>
            </td>
            <td style="text-align:center;vertical-align:top;width:25%">
                <asp:Button ID="Button7" runat="server" Text="Solicitar Facturación" OnClick="Button7_Click" />
                <br />
                <asp:Label ID="lblResultado7" runat="server"></asp:Label>
            </td>
          </tr>
          </table>
         </asp:Panel>
        <asp:Panel ID="pnl5" runat="server">
        <table width="100%"  border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td style="text-align:center;vertical-align:top;width:25%">
                <asp:Button ID="Button8" runat="server" Text="Facturar" OnClick="Button8_Click" />
                <br />
                <asp:HyperLink ID="hlk8xml" runat="server" Target="_blank" />
                <asp:HyperLink ID="hlk8pdf" runat="server" Target="_blank" />
                <asp:Label ID="lblResultado8" runat="server"></asp:Label>
            </td>
          </tr>
          </table>
         </asp:Panel>
        <p><asp:Label ID="lblError" runat="server" ForeColor="Red" EnableViewState="false"></asp:Label></p>
    </div>
    </form>
</body>
</html>
