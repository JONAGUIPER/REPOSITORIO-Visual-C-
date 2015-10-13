using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cd;

namespace GestionCds
{
    public partial class Cds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FactoriaCdMusica miListaCd = new FactoriaCdMusica();
            miListaCd.InsertCd(new CdMusica()
            {
                Titulo = "Binb",
                IdCd = 1,
                Interprete = "AC/DC",
                Discografica = "SONY",
                Ubicacion = "Algun sitio",
                FechaPublicacion = DateTime.Today,
                Genero = "HardRock",
                Caratula = "images/blackice.jpg",
                Canciones = new List<Cancion>()
                {
                    new Cancion() {Track=1,Titulo="track1",Duracion=DateTime.Today },
                    new Cancion() {Track=2,Titulo="track2",Duracion=DateTime.Today },
                }
            });
            miListaCd.InsertCd(new CdMusica(){
                Titulo = "sgsg",
                IdCd = 2,
                Interprete = "Mana",
                Discografica = "SONY",
                Ubicacion = "Algun sitio",
                FechaPublicacion = DateTime.Today,
                Genero = "PopRock",
                Caratula = "images/blackice.jpg",
                Canciones = new List<Cancion>()
                {
                    new Cancion() {Track=1,Titulo="track1",Duracion=DateTime.Today },
                    new Cancion() {Track=2,Titulo="track2",Duracion=DateTime.Today },
                }
            });
            //GridView1.DataSource = FactoriaCdMusica.Cds;
            GridView1.DataBind();
        }
    }
}