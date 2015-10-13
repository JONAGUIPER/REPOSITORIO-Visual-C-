using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cd
{
    public class FactoriaCdMusica
    {
        static public List<CdMusica> Cds = new List<CdMusica>();
        public CdMusica this[string titulo]
        {
            get { return FindCdByTitle(titulo); }
        }
        public CdMusica this[int id]
        {
            get { return FindCdById(id); }
            set { UpdateCdById(value, id); }
        }

        private void UpdateCdById(CdMusica value, int id)
        {
            Cds[Cds.FindIndex(c => c.IdCd == id)] = value;
        }

        private CdMusica FindCdById(int id)
        {
            return Cds.Find(c => c.IdCd == id);
        }

        private CdMusica FindCdByTitle(string titulo)
        {
            return Cds.Find(c => c.Titulo == titulo);
        }
        public void DeleteCdById(int id)
        {
            Cds.RemoveAt(Cds.FindIndex(c => c.IdCd == id));
        }
        public void InsertCd(CdMusica cd)
        {
            Cds.Add(cd);
        }
    }
}
