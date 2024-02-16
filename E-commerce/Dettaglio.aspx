<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="E_commerce.Dettaglio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Sezione per visualizzare i dettagli dell'articolo -->
            <h2>Dettaglio Articolo</h2>
            <asp:Image class="w-50" ID="imgArticolo" runat="server" AlternateText="Immagine Articolo" />
            <asp:Label ID="lblNome" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblDescrizione" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblPrezzo" runat="server" Text=""></asp:Label><br />
            <!-- Pulsante per aggiungere l'articolo al carrello -->
            <asp:Button runat="server" Text="Aggiungi al Carrello" OnClick="AggiungiCarrello_Click" />
        </div>
    </form>
</body>
</html>
