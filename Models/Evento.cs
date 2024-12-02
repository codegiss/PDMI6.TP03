using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDMI6_TP03.Models
{
    public class Evento
    {
        public DateTime DataEvento { get; set; }
        public string Descricao { get; set; }
        public Evento(DateTime de, string des)
        {
            this.DataEvento = de;
            this.Descricao = des;
        }
        public Evento() { }
    }
}
