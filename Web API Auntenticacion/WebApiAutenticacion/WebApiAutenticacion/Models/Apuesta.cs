using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Apuesta
    {
        public int idApuesta { get; set; }
        public double tipoMercado { get; set; }
        public double cuota { get; set; }
        public double dinero { get; set; }
        public string fecha { get; set; }
        public int idMercado { get; set; }
        public string gmail { get; set; }
        public string tipoCuota { get; set; }

        public Apuesta(int idApuesta, double tipoMercado, double cuota, double dinero, string fecha, int idMercado, string gmail, string tipoCuota)
        {
            this.idApuesta = idApuesta;
            this.tipoMercado = tipoMercado;
            this.cuota = cuota;
            this.dinero = dinero;
            this.fecha = fecha;
            this.idMercado = idMercado;
            this.gmail = gmail;
            this.tipoCuota = tipoCuota;
        }
    }
    public class ApuestaDTO
    {
        public double tipoMercado { get; set; }
        public double cuota { get; set; }
        public double dinero { get; set; }
        public string fecha { get; set; }
        public string gmail { get; set; }
        public string tipoCuota { get; set; }

        public ApuestaDTO(double tipoMercado, double cuota, double dinero, string fecha, string gmail, string tipoCuota)
        {
            this.tipoMercado = tipoMercado;
            this.cuota = cuota;
            this.dinero = dinero;
            this.fecha = fecha;
            this.gmail = gmail;
            this.tipoCuota = tipoCuota;
        }
    }

    public class ApuestaDTO2
    {
        public int idMercado { get; set; }
        public string tipoApuesta { get; set; }
        public double cuota { get; set; }
        public double dinero { get; set; }

        public ApuestaDTO2(string t, double c, double d, int i)
        {
            this.tipoApuesta = t;
            this.cuota = c;
            this.dinero = d;
            this.idMercado = i;
        }

    }

    public class ApuestaDTO3
    {
        public double tipoMercado { get; set; }
        public string tipoApuesta { get; set; }
        public double cuota { get; set; }
        public double dinero { get; set; }

        public ApuestaDTO3(double tipoMercado, string tipoApuesta, double cuota, double dinero)
        {
            this.tipoMercado = tipoMercado;
            this.tipoApuesta = tipoApuesta;
            this.cuota = cuota;
            this.dinero = dinero;
        }
    }
}