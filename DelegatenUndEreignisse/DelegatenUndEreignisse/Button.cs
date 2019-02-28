using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEreignisse
{
    class Button
    {
        public string Text { get; set; }
        public string Farbe { get; set; }

        // Variante "lang"
        //private EventHandler buttonKlick;
        //public event EventHandler ButtonClickEvent
        //{
        //    add
        //    {
        //        buttonKlick += value;
        //    }
        //    remove
        //    {
        //        buttonKlick -= value;
        //    }
        //}

        // Variante Kurz
        public event EventHandler ButtonClickEvent;

        public void Klick()
        {
            if(ButtonClickEvent != null)
                ButtonClickEvent(this, EventArgs.Empty);
        }
    }
}
