using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Mercado
    {
        public int idMercado { get; set; }
        public double cuotaOver { get; set; }
        public double cuotaUnder { get; set; }
        public double dineroOver { get; set; }
        public double dineroUnder { get; set; }
        public double tipoMercado { get; set; }
        public int idEvento { get; set; }

        public Mercado(int idMercado, double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder, double tipoMercado, int idEvento)
        {
            this.idMercado = idMercado;
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
            this.dineroOver = dineroOver;
            this.dineroUnder = dineroUnder;
            this.tipoMercado = tipoMercado;
            this.idEvento = idEvento;
        }
    }

    public class MercadoDTO
    {
        public double cuotaOver { get; set; }
        public double cuotaUnder { get; set; }
        public double dineroOver { get; set; }
        public double dineroUnder { get; set; }
        public double tipoMercado { get; set; }

        public MercadoDTO(double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder, double tipoMercado)
        {
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
            this.dineroOver = dineroOver;
            this.dineroUnder = dineroUnder;
            this.tipoMercado = tipoMercado;
        }
    }
}