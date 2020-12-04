﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Apuesta
    {
        public int ApuestaId { get; set; }
        public double tipoMercado { get; set; }
        public double cuota { get; set; }
        public double dinero { get; set; }
        public string fecha { get; set; }
        public string tipoCuota { get; set; }

        public int MercadoId { get; set; }
        public Mercado Mercado { get; set; }

        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public Apuesta(int idApuesta, double tipoMercado, double cuota, double dinero, string fecha, int idMercado, string gmail, string tipoCuota)
        {
            this.ApuestaId = idApuesta;
            this.tipoMercado = tipoMercado;
            this.cuota = cuota;
            this.dinero = dinero;
            this.fecha = fecha;
            this.MercadoId = idMercado;
            this.UsuarioId = gmail;
            this.tipoCuota = tipoCuota;
        }
        public Apuesta() { }
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
        public string UsuarioId { get; set; }
        public string tipoCuota { get; set; }
        public double cuota { get; set; }
        public double dinero { get; set; }
        public int EventoId { get; set; }
        public Mercado Mercado { get; set; }

        public ApuestaDTO2 (string UsuarioId, string tipoCuota, double cuota, double dinero, int EventoId, Mercado Mercado)
        {
            this.UsuarioId = UsuarioId;
            this.tipoCuota = tipoCuota;
            this.cuota = cuota;
            this.dinero = dinero;
            this.EventoId = EventoId;
            this.Mercado = Mercado;
        }
    }
}