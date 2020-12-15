﻿using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class MercadosRepository
    {
        //private MySqlConnection Connect()
        //{
        //    string connString = "Server=localhost;Port=3306;Database=PlaceMyBet;Uid=root;password=";
        //    MySqlConnection con = new MySqlConnection(connString);
        //    return con;
        //}
        internal List<Mercado> Retrieve()
        {
            //MySqlConnection con = Connect();
            //MySqlCommand command = con.CreateCommand();
            //command.CommandText = "select * from mercado";

            //try
            //{
            //    con.Open();
            //    MySqlDataReader res = command.ExecuteReader();

            //    Mercado a = null;
            //    List<Mercado> lista = new List<Mercado>();
            //    while (res.Read())
            //    {
            //        Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4) + " " + res.GetDouble(5) + " " + res.GetInt32(6));
            //        a = new Mercado(res.GetInt32(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4), res.GetDouble(5), res.GetInt32(6));
            //        lista.Add(a);
            //    }

            //    return lista;
            //}
            //catch (MySqlException e)
            //{
            //    Debug.WriteLine("Se ha producido un error de conexion");
            //    return null;
            //}
            List<Mercado> mercados = new List<Mercado>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                mercados = context.Mercados.ToList();
                mercados = context.Mercados.Include(p => p.Evento).ToList();
            }
            return mercados;
        }

        internal List<MercadoDTO2> RetrieveDTO()
        {
            //MySqlConnection con = Connect();
            //MySqlCommand command = con.CreateCommand();
            //command.CommandText = "select * from mercado";

            //try
            //{
            //    con.Open();
            //    MySqlDataReader res = command.ExecuteReader();

            //    MercadoDTO a = null;
            //    List<MercadoDTO> lista = new List<MercadoDTO>();
            //    while (res.Read())
            //    {
            //        Debug.WriteLine("Recuperado: " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4) + " " + res.GetDouble(5));
            //        a = new MercadoDTO(res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4), res.GetDouble(5));
            //        lista.Add(a);
            //    }

            //    return lista;
            //}
            //catch (MySqlException e)
            //{
            //    Debug.WriteLine("Se ha producido un error de conexion");
            //    return null;
            //}
            List<MercadoDTO2> mercados = new List<MercadoDTO2>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                mercados = context.Mercados.Select(p => ToDTO2(p)).ToList();
            }
            return mercados;
        }

        //Nuevo examen
        internal List<ApuestaDTO3> RetrievebyId(int id)
        {
            List<Apuesta> lista;
            List<ApuestaDTO3> final = new List<ApuestaDTO3>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                lista = context.Apuestas.Where(a => a.MercadoId == id).ToList();
            }
            for(int i = 0; i < lista.Count; i++)
            {
                final.Add(toDTO3(lista[i]));
            }
            return final;
        }

        internal void Save (Mercado m)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();

            context.Mercados.Add(m);
            context.SaveChanges();
        }
        static public MercadoDTO2 ToDTO2(Mercado m)
        {
            return new MercadoDTO2(m.TipoMercado, m.CuotaOver, m.CuotaUnder);

        }

        //Nuevo examen
        static public ApuestaDTO3 toDTO3(Apuesta a)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Usuario u;
            using (context)
            {
                u = context.Usuarios.Single(b => b.UsuarioId == a.UsuarioId);

            }
            return new ApuestaDTO3(a.dinero, a.tipoCuota, u.Nombre);
        }
    }

}