using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App.Models
{
    class Locatie
    {

        private string adresa;

        public Locatie ()
        {
            this.adresa = null;
        }

        public Locatie (string Adresa)
        {
            this.adresa = Adresa;
        }

        public string Adresa { get => adresa; set => adresa = value; }
    }
}
