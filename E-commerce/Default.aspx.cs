using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_commerce
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Carica gli articoli solo se la pagina non è un postback (prima visita)
            if (!IsPostBack) 
            {
                CaricaArticoli();
            }
        }

        private void CaricaArticoli()
        {
            // Popola la lista di articoli 
            List<Articolo> articoli = new List<Articolo>
        {
            new Articolo { Id = 1, Nome = "tavolo per colazione", Descrizione = "tavolo colazione legno massello", Prezzo = 19.99m, ImmagineUrl = "Images/immagine1.jpg" },
            new Articolo { Id = 2, Nome = "guardaroba con ramificazioni", Descrizione = "legno di ciliegio", Prezzo = 29.99m, ImmagineUrl = "Images/immagine2.jpeg" },
            new Articolo { Id = 3, Nome = "Asciugatrice jet set", Descrizione = "asciugatrice accaio inox", Prezzo = 14.99m, ImmagineUrl = "Images/immagine3.jpeg" },
            new Articolo { Id = 4, Nome = "lavatrice da campeggio", Descrizione = "lavatrice da campeggio portatile bianca", Prezzo = 24.99m, ImmagineUrl = "Images/immagine4.jpg" },
            new Articolo { Id = 5, Nome = "Fine Destiny", Descrizione = "Forno microonde 2in1", Prezzo = 39.99m, ImmagineUrl = "Images/immagine5.jpeg" },
            new Articolo { Id = 6, Nome = "Jiulieta", Descrizione = "forno a microonde con grill", Prezzo = 17.99m, ImmagineUrl = "Images/immagine6.jpg" },
            new Articolo { Id = 7, Nome = "Luminance Frost", Descrizione = "Nero 150Lt, congelatore,frigorifero", Prezzo = 21.99m, ImmagineUrl = "Images/immagine7.jpg" },
            new Articolo { Id = 8, Nome = "Steam Bro Ferro", Descrizione = "Ferro da stiro a vapore 2200watt", Prezzo = 32.99m, ImmagineUrl = "Images/immagine8.jpg" },
            new Articolo { Id = 9, Nome = "IVC-30", Descrizione = "Aspiratore secco/umido", Prezzo = 26.99m, ImmagineUrl = "Images/immagine9.jpg" },
            new Articolo { Id = 10, Nome = "Clean Butler", Descrizione = "Aspirapolvere silente, nero", Prezzo = 19.99m, ImmagineUrl = "Images/immagine10.jpg" },
            new Articolo { Id = 11, Nome = "Delicatessa Slim", Descrizione = "piano di cottura doppio nero/trasparente", Prezzo = 29.99m, ImmagineUrl = "Images/immagine11.jpeg" },
            new Articolo { Id = 12, Nome = "Full-House 2.0", Descrizione = "triplo piano cottura Trasparente", Prezzo = 14.99m, ImmagineUrl = "Images/immagine12.jpg" },
            new Articolo { Id = 13, Nome = "Goldflame 3 Piano", Descrizione = "cottura a gas", Prezzo = 24.99m, ImmagineUrl = "Images/immagine13.jpeg" },
            new Articolo { Id = 14, Nome = "Firetale - Piano", Descrizione = "cottura a gas, 2", Prezzo = 39.99m, ImmagineUrl = "Images/immagine14.jpg" },
            new Articolo { Id = 15, Nome = "El Dorado 108 - Humidor e", Descrizione = "Umidificatore, frigorifero per vini Nero 41 dB 108 Ltr", Prezzo = 17.99m, ImmagineUrl = "Images/immagine15.jpg" },
            new Articolo { Id = 16, Nome = "Shiraz 12 Slim Uno", Descrizione = "- Frigorifero, nero", Prezzo = 21.99m, ImmagineUrl = "Images/immagine16.jpg" },
            new Articolo { Id = 17, Nome = "Silent Vino 16 Uno", Descrizione = "Frigorifero per vini ", Prezzo = 32.99m, ImmagineUrl = "Images/immagine17.jpg" },
            new Articolo { Id = 18, Nome = "Shiraz Premium", Descrizione = "Smart 12 Slim", Prezzo = 26.99m, ImmagineUrl = "Images/immagine18.jpeg" },
            new Articolo { Id = 19, Nome = "Vinovilla 43 Built", Descrizione = "Duo Onyx Edition", Prezzo = 19.99m, ImmagineUrl = "Images/immagine19.jpg" },
            new Articolo{Id = 20,Nome = "Vinamour 26 Uno",Descrizione = "Frigorifero per vini",Prezzo = 29.99m,ImmagineUrl = "Images/immagine20.jpg"
            }
            // Aggiungi altri articoli secondo necessità
        };

            // Collega la lista di articoli al Repeater per la visualizzazione
            RepeaterArticoli.DataSource = articoli;
            RepeaterArticoli.DataBind();
        }

        protected void Dettagli_Click(object sender, CommandEventArgs e)
        {
            // Gestisce l'evento Dettagli_Click quando il pulsante Dettagli viene premuto
            int idArticolo = Convert.ToInt32(e.CommandArgument);
            // Reindirizza alla pagina di dettaglio con l'id dell'articolo come parametro
            Response.Redirect($"Dettaglio.aspx?id={idArticolo}");
        }

        protected void VisualizzaCarrello_Click(object sender, EventArgs e)
        {
            // Reindirizza all pagina del carrello
            Response.Redirect("Carrello1.aspx");
        }
    }
}