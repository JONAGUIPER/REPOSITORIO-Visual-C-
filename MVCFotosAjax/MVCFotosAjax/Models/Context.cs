using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFotosAjax.Models
{
    public class Context
    {
        public static List<Foto> Fotos = new List<Foto>();
        public static List<Comentario> Comentarios = new List<Comentario>();

        static Context()
        {
            Fotos.Add(
                new Foto()
                {
                    IdFoto = 1,
                    Titulo="Plaza",
                    URLFoto="~/images/Vitoria0.jpg"
                });
            Fotos.Add(
                new Foto()
                {
                    IdFoto = 2,
                    Titulo = "Catedral",
                    URLFoto = "~/images/Vitoria1.jpg"
                });
            Fotos.Add(
                new Foto()
                {
                    IdFoto = 3,
                    Titulo = "Green Capital",
                    URLFoto = "~/images/Vitoria2.jpg"
                });
            Fotos.Add(
                new Foto()
                {
                    IdFoto = 4,
                    Titulo = "Palacio",
                    URLFoto = "~/images/Vitoria3.jpg"
                });
            Fotos.Add(
                new Foto()
                {
                    IdFoto = 5,
                    Titulo = "Plaza De Noche",
                    URLFoto = "~/images/Vitoria4.jpg"
                });

            Comentarios.Add(
                new Comentario()
                {
                    IdComentario=1,
                    IdFoto=1,
                    Autor="Deconocido F1-C1",
                    Contenido= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non arcu quis justo posuere congue vitae vitae diam. Aliquam eget. "
                });
            Comentarios.Add(
                new Comentario()
                {
                    IdComentario = 2,
                    IdFoto = 1,
                    Autor = "Deconocido F1-C2",
                    Contenido = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non arcu quis justo posuere congue vitae vitae diam. Aliquam eget. "
                });
            Comentarios.Add(
                new Comentario()
                {
                    IdComentario = 3,
                    IdFoto = 2,
                    Autor = "Deconocido F2-C3",
                    Contenido = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non arcu quis justo posuere congue vitae vitae diam. Aliquam eget. "
                });
            Comentarios.Add(
                new Comentario()
                {
                    IdComentario = 4,
                    IdFoto = 2,
                    Autor = "Deconocido F2-C4",
                    Contenido = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non arcu quis justo posuere congue vitae vitae diam. Aliquam eget. "
                });
            Comentarios.Add(
                new Comentario()
                {
                    IdComentario = 5,
                    IdFoto = 3,
                    Autor = "Deconocido F3-C5",
                    Contenido = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non arcu quis justo posuere congue vitae vitae diam. Aliquam eget. "
                });
            Comentarios.Add(
                new Comentario()
                {
                    IdComentario = 6,
                    IdFoto = 4,
                    Autor = "Deconocido F4-C6",
                    Contenido = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non arcu quis justo posuere congue vitae vitae diam. Aliquam eget. "
                });
            Comentarios.Add(
                new Comentario()
                {
                    IdComentario = 7,
                    IdFoto = 5,
                    Autor = "Deconocido F5-C7",
                    Contenido = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non arcu quis justo posuere congue vitae vitae diam. Aliquam eget. "
                });
            Comentarios.Add(
                new Comentario()
                {
                    IdComentario = 8,
                    IdFoto = 5,
                    Autor = "Deconocido F5-C8",
                    Contenido = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec non arcu quis justo posuere congue vitae vitae diam. Aliquam eget. "
                });
        }
    }
}