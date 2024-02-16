<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello1.aspx.cs" Inherits="E_commerce.Carrello1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Carrello</h2>
            <asp:Repeater ID="RepeaterCarrello" runat="server">
                <ItemTemplate>
                    <div class="carrello-item">
                        <h3><%# Eval("Nome") %></h3>
                        <p>Prezzo: $<%# Eval("Prezzo") %></p>
                        <asp:Button runat="server" Text="Rimuovi" OnCommand="Rimuovi_Click" CommandArgument='<%# Eval("Id") %>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Button runat="server" Text="Svuota Carrello" OnClick="SvuotaCarrello_Click" />
        </div>
       
    </form>
</body>
</html>
