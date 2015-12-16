using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCFotosAjax.Models;

namespace MVCFotosAjax.Controllers
{
    public class FotoApiController : ApiController
    {
        public IEnumerable<Foto> GetAllFotos()
        {
            return Context.Fotos.AsEnumerable();
        }

        public Foto GetFotoById(int id)
        {
            Foto poto=Context.Fotos.Find(c => c.IdFoto == id);
            if (poto == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return poto;
        }

        public Foto GetFotoByTitulo(string tituloFoto)
        {
            Foto poto = Context.Fotos.Find(c => c.Titulo == tituloFoto);
            if (poto == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return poto;
        }

        public String GetFotoUrlById(int id)
        {
            Foto poto = Context.Fotos.Find(c => c.IdFoto == id);
            if (poto == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return poto.URLFoto;
        }
    }
}
