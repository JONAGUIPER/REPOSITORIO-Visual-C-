using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Nobel.Models
{
    public class Context
    {
        public static List<Foto> Fotos = new List<Foto>();
        public static List<Comentario> Comentarios = new List<Comentario>();

        static Context()
        {
            Fotos.Add(new Foto() {fotoID=1, fotoTitulo="Boston", fotoURL= "~/Images/Boston.jpg "});
            Fotos.Add(new Foto() { fotoID = 2, fotoTitulo = "NewYork", fotoURL = "~/Images/NewYork.jpg " });
            Fotos.Add(new Foto() { fotoID = 3, fotoTitulo = "Londres", fotoURL = "~/Images/Londres.png " });
            Fotos.Add(new Foto() { fotoID = 4, fotoTitulo = "Berlin", fotoURL = "~/Images/Berlin.jpg " });
            Fotos.Add(new Foto() { fotoID = 5, fotoTitulo = "Donostia", fotoURL = "~/Images/Donostia.jpg " });

            Comentarios.Add(new Comentario() {comentarioID=1, fotoID=1, Autor="Martin", Texto="La primera de todas" });
            Comentarios.Add(new Comentario() {comentarioID =2, fotoID = 2, Autor = "Martin", Texto = "La más famosa" });
            Comentarios.Add(new Comentario() {comentarioID = 3, fotoID = 3, Autor = "Martin", Texto = "La de la mantequilla" });
            Comentarios.Add(new Comentario() {comentarioID = 4, fotoID = 4, Autor = "Martin", Texto = "La de los records" });
            Comentarios.Add(new Comentario() {comentarioID = 5, fotoID = 5, Autor = "Martin", Texto = "La nuestra" });
        }
    }
}