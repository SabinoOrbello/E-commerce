<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_commerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div>
     <main>
    <asp:Button runat="server" Text="Visualizza Carrello" OnClick="VisualizzaCarrello_Click" />
    </main>
          <!-- Elenco degli articoli utilizzando il Repeater -->
            <h2>Articoli in vendita</h2>
            <asp:Repeater ID="RepeaterArticoli" runat="server">
                <ItemTemplate>
                    <!-- Singolo prodotto all'interno del Repeater -->
                    <div class="prodotto">
                        <img class="w-50" src='<%# Eval("ImmagineUrl") %>' alt='<%# Eval("Nome") %>' />
                        <h3><%# Eval("Nome") %></h3>
                        <p><%# Eval("Descrizione") %></p>
                        <p>Prezzo: $<%# Eval("Prezzo") %></p>
                        <asp:Button runat="server" Text="Dettagli" OnCommand="Dettagli_Click" CommandArgument='<%# Eval("Id") %>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
       
       

</asp:Content>
