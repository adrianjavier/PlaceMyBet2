using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Apuesta
    {
        public int idApuesta { get; set; }
        public int tipoMercado { get; set; }
        public double cuota { get; set; }
        public double dinero { get; set; }
        public string fecha { get; set; }
        public int idMercado { get; set; }
        public string gmail { get; set; }

        public Apuesta(int idApuesta, int tipoMercado, double cuota, double dinero, string fecha, int idMercado, string gmail)
        {
            this.idApuesta = idApuesta;
            this.tipoMercado = tipoMercado;
            this.cuota = cuota;
            this.dinero = dinero;
            this.fecha = fecha;
            this.idMercado = idMercado;
            this.gmail = gmail;
        }
    }
}