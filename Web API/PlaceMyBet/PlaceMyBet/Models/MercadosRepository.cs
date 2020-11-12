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
            }
            return mercados;
        }

        internal List<MercadoDTO> RetrieveDTO()
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
            return null;
        }
    }
}