using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_commerce
{
    public partial class Dettaglio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica se la pagina è un postback (richiamata dopo un'azione dell'utente)
            if (!IsPostBack)
            {
                // Ottieni l'id dell'articolo dalla query string
                if (int.TryParse(Request.QueryString["id"], out int idArticolo))
                {
                    // Carica i dettagli dell'articolo sulla pagina
                    CaricaDettagliArticolo(idArticolo);
                }
            }
        }

        // Metodo per caricare i dettagli dell'articolo sulla pagina
        private void CaricaDettagliArticolo(int idArticolo)
        {
            // Ottieni l'articolo dalla classe di gestione dati
            Articolo articolo = GestioneDati.GetArticoloById(idArticolo);

            // Popola i controlli della pagina con i dettagli dell'articolo
            lblNome.Text = $"Nome: {articolo.Nome}";
            lblDescrizione.Text = $"Descrizione: {articolo.Descrizione}";
            lblPrezzo.Text = $"Prezzo: ${articolo.Prezzo}";

            // Imposta l'URL dell'immagine dell'articolo
            imgArticolo.ImageUrl = articolo.ImmagineUrl;
        }

        protected void AggiungiCarrello_Click(object sender, EventArgs e)
        {
            // Ottieni l'id dell'articolo dalla query string
            if (int.TryParse(Request.QueryString["id"], out int idArticolo))
            {
                // Ottieni l'articolo reale dalla fonte di dati
                Articolo articolo = GestioneDati.GetArticoloById(idArticolo);

                if (articolo != null)
                {
                    // Aggiungi l'articolo al carrello
                    Carrello.ArticoliInCarrello.Add(articolo);

                    // Aggiorna il totale degli articoli nel carrello
                    AggiornaTotaleCarrello();

                    //  Aggiungo un cookie per memorizzare il carrello dell'utente
                    HttpCookie cookieCarrello = new HttpCookie("Carrello");
                    cookieCarrello.Value = JsonConvert.SerializeObject(Carrello.ArticoliInCarrello);
                    Response.Cookies.Add(cookieCarrello);
                }
            }
        }

        private Articolo GetArticoloById(int idArticolo)
        {
            
            return new Articolo { Id = idArticolo, Nome = $"Prodotto {idArticolo}", Descrizione = $"Descrizione del prodotto {idArticolo}", Prezzo = 19.99m, ImmagineUrl = $"immagine{idArticolo}.jpg" };
        }

        private void AggiornaTotaleCarrello()
        {
            decimal totaleCarrello = 0;

            foreach (var articolo in Carrello.ArticoliInCarrello)
            {
                totaleCarrello += articolo.Prezzo;
            }

            // Salva il totale del carrello nello stato della vista
            ViewState["TotaleCarrello"] = totaleCarrello;
        }
    }
}