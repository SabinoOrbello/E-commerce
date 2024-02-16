using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_commerce
{
    public partial class Carrello1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CaricaCarrello();
            }
        }

        private void CaricaCarrello()
        {
            // Collega il carrello al repeater per mostrarne i dettagli
            RepeaterCarrello.DataSource = Carrello.ArticoliInCarrello;
            RepeaterCarrello.DataBind();
        }

        protected void Rimuovi_Click(object sender, CommandEventArgs e)
        {
            int idArticolo = Convert.ToInt32(e.CommandArgument);
            // Rimuovi l'articolo dal carrello
            Carrello.ArticoliInCarrello.RemoveAll(a => a.Id == idArticolo);

            // Aggiorna il totale degli articoli nel carrello
            AggiornaTotaleCarrello();

            //  Aggiorna il cookie del carrello
            HttpCookie cookieCarrello = new HttpCookie("Carrello");
            cookieCarrello.Value = JsonConvert.SerializeObject(Carrello.ArticoliInCarrello);
            Response.Cookies.Add(cookieCarrello);

            // Ricarica la pagina
            CaricaCarrello();
        }

        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            // Svuota completamente il carrello
            Carrello.ArticoliInCarrello.Clear();

            // Aggiorna il totale degli articoli nel carrello
            AggiornaTotaleCarrello();

            //  Rimuovi il cookie del carrello
            Response.Cookies["Carrello"].Expires = DateTime.Now.AddDays(-1);

            // Ricarica la pagina
            CaricaCarrello();
        }

        private void AggiornaTotaleCarrello()
        {
            
        }
    }
}