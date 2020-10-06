using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class ApuestasRepository
    {
        private MySqlConnection Connect() 
        {
            string connString = "Server=localhost;Port=3306;Database=PlaceMyBet;Uid=root;password=";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal List<Apuesta> Retrieve() 
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from apuesta";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                Apuesta a = null;
                List<Apuesta> listaApuestas = new List<Apuesta>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetInt32(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetString(4) + " " + res.GetInt32(5) + " " + res.GetString(6));
                    a = new Apuesta(res.GetInt32(0), res.GetInt32(1), res.GetDouble(2), res.GetDouble(3), res.GetString(4), res.GetInt32(5), res.GetString(6));
                    listaApuestas.Add(a);
                }

                return listaApuestas;
            }catch(MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexion");
                return null;
            }
        } 

    }
}