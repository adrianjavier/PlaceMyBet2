using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class EventosRepository
    {
        //private MySqlConnection Connect()
        //{
        //    string connString = "Server=localhost;Port=3306;Database=PlaceMyBet;Uid=root;password=";
        //    MySqlConnection con = new MySqlConnection(connString);
        //    return con;
        //}
        internal List<Evento> Retrieve()
        {
            //MySqlConnection con = Connect();
            //MySqlCommand command = con.CreateCommand();
            //command.CommandText = "select * from evento";

            //try
            //{
            //    con.Open();
            //    MySqlDataReader res = command.ExecuteReader();

            //    Evento a = null;
            //    List<Evento> lista = new List<Evento>();
            //    while (res.Read())
            //    {
            //        Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3));
            //        a = new Evento(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3));
            //        lista.Add(a);
            //    }

            //    return lista;
            //}
            //catch (MySqlException e)
            //{
            //    Debug.WriteLine("Se ha producido un error de conexion");
            //    return null;
            //}
            List<Evento> eventos = new List<Evento>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.Eventos.ToList();
            }
            return eventos;
        }

        internal List<EventoDTO> RetrieveDTO()
        {
            //MySqlConnection con = Connect();
            //MySqlCommand command = con.CreateCommand();
            //command.CommandText = "select * from evento";

            //try
            //{
            //    con.Open();
            //    MySqlDataReader res = command.ExecuteReader();

            //    EventoDTO a = null;
            //    List<EventoDTO> lista = new List<EventoDTO>();
            //    while (res.Read())
            //    {
            //        Debug.WriteLine("Recuperado: "+ res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3));
            //        a = new EventoDTO(res.GetString(1), res.GetString(2), res.GetString(3));
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