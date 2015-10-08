using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejoEventos
{
    class RaiseEvent
    {
        //public delegate void HolaDelegate(string palabra);
        //public event HolaDelegate miEventoHola = null;

        //declaracion del evento del tipo delegado EventHandler
        public event EventHandler miEvento = null;

        //metodo donde se dispara el evento

        public void Disparo()
        {
            //..
            System.Windows.Forms.MessageBox.Show("RAISEEVENT: entro en el metodo disparo");

            if (miEvento != null)
            {
                System.Windows.Forms.MessageBox.Show("RAISEEVENT: a punto de disparar");

                miEvento(this, new EventArgs());
            }
            System.Windows.Forms.MessageBox.Show("RAISEEVENT: sali del metodo disparo");
        }
    }

}
