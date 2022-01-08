using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App.Models
{
    class Schedule
    {

        private int id;
        private Antrenor antrenor;
        private Locatie locatie;
        private DateTime data;

        public Schedule (int id, Antrenor antrenor, Locatie locatie, DateTime data)
        {
            this.id = id;
            this.antrenor = antrenor;
            this.locatie = locatie;
            this.data = data;
        }

        public DateTime Data { get => data; set => data = value; }
        public Antrenor Antrenor { get => antrenor; set => antrenor = value; }
        public Locatie Locatie { get => locatie; set => locatie = value; }
        public int Id { get => id; set => id = value; }
    }
}
