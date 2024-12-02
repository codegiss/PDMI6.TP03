using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PDMI6_TP03.Models
{
    public class Pacote
    {
        public string CodRastreio { get; set; }
        public string Status { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime DataPrevistaEntrega { get; set; }
        public List<Evento> HistoricoEventos { get; set; }

        public Pacote(string cr, string s, DateTime de, DateTime dpe)
        {
            this.CodRastreio = cr;
            this.Status = s;
            this.DataEnvio = de.Date;
            this.DataPrevistaEntrega = dpe.Date;
            this.HistoricoEventos = new List<Evento>();
        }
        public Pacote() { }
    }
}
