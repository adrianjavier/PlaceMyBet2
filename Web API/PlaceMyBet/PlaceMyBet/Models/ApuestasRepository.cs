using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class ApuestasRepository
    {
        //private MySqlConnection Connect() 
        //{
        //    string connString = "Server=localhost;Port=3306;Database=PlaceMyBet;Uid=root;password=";
        //    MySqlConnection con = new MySqlConnection(connString);
        //    return con;
        //}
        internal List<Apuesta> Retrieve() 
        {
            //MySqlConnection con = Connect();
            //MySqlCommand command = con.CreateCommand();
            //command.CommandText = "select * from apuesta";

            //try
            //{
            //    con.Open();
            //    MySqlDataReader res = command.ExecuteReader();

            //    Apuesta a = null;
            //    List<Apuesta> listaApuestas = new List<Apuesta>();
            //    while (res.Read())
            //    {
            //        Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetString(4) + " " + res.GetInt32(5) + " " + res.GetString(6) + " " + res.GetString(7));
            //        a = new Apuesta(res.GetInt32(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetString(4), res.GetInt32(5), res.GetString(6), res.GetString(7));
            //        listaApuestas.Add(a);
            //    }

            //    return listaApuestas;
            //}catch(MySqlException e)
            //{
            //    Debug.WriteLine("Se ha producido un error de conexion");
            //    return null;
            //}
            List<Apuesta> apuestas = new List<Apuesta>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuestas = context.Apuestas.ToList();
                apuestas = context.Apuestas.Include(p => p.Mercado).ToList();
            }
            return apuestas;
        }

        internal List<ApuestaDTO2> RetrieveDTO()
        {
            //MySqlConnection con = Connect();
            //MySqlCommand command = con.CreateCommand();
            //command.CommandText = "select * from apuesta";

            //try
            //{
            //    con.Open();
            //    MySqlDataReader res = command.ExecuteReader();

            //    ApuestaDTO a = null;
            //    List<ApuestaDTO> listaApuestas = new List<ApuestaDTO>();
            //    while (res.Read())
            //    {
            //        Debug.WriteLine("Recuperado: " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetString(4) + " " + res.GetString(6), res.GetString(7));
            //        a = new ApuestaDTO(res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetString(4), res.GetString(6), res.GetString(7));
            //        listaApuestas.Add(a);
            //    }

            //    return listaApuestas;
            //}
            //catch (MySqlException e)
            //{
            //    Debug.WriteLine("Se ha producido un error de conexion");
            //    return null;
            //}
            List<Apuesta> apuestas = new List<Apuesta>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuestas = context.Apuestas.ToList();
                apuestas = context.Apuestas.Include(p => p.Mercado).ToList();
            }
            List<ApuestaDTO2> apuestas2 = new List<ApuestaDTO2>();
            for (int i = 0; i < apuestas.Count; i++)
            {
                apuestas2.Add(ToDTO2(apuestas[i]));
            }
            return apuestas2;
        }

        internal void Save(Apuesta a) 
        {
            //MySqlConnection con = Connect();
            //MySqlCommand command = con.CreateCommand();
            //CultureInfo culInfo = new System.Globalization.CultureInfo("es-ES");

            //culInfo.NumberFormat.NumberDecimalSeparator = ".";

            //culInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            //culInfo.NumberFormat.PercentDecimalSeparator = ".";
            //culInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            //System.Threading.Thread.CurrentThread.CurrentCulture = culInfo;

            //command.CommandText = "select * from mercado where idMercado="+a.idMercado+";";
            //try
            //{
            //    con.Open();
            //    MySqlDataReader res = command.ExecuteReader();
            //    res.Read();
            //    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4) + " " + res.GetDouble(5) + " " + res.GetInt32(6));
            //    Mercado m = new Mercado(res.GetInt32(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4), res.GetDouble(5), res.GetInt32(6));

            //    double dineroOver = 0;
            //    double dineroUnder = 0;
            //    if (a.tipoCuota == "over")
            //    {
            //        dineroOver = a.dinero + m.dineroOver;
            //        dineroUnder = m.dineroUnder;
            //    }
            //    else
            //    {
            //        dineroOver = m.dineroOver;
            //        dineroUnder = a.dinero + m.dineroUnder;
            //    }

            //    double cuotaOver = dineroOver / (dineroOver + dineroUnder);
            //    cuotaOver = (1 / cuotaOver) * 0.95;
            //    double cuotaUnder = dineroUnder / (dineroUnder + dineroOver);
            //    cuotaUnder = (1 / cuotaUnder) * 0.95;
            //    res.Close();
            //    con.Close();
            //    command.CommandText = "update mercado set cuotaOver=" + Math.Round(cuotaOver,2) + ", cuotaUnder=" + Math.Round(cuotaUnder,2) +", dineroOver="+dineroOver+", dineroUnder="+ dineroUnder+ " where idMercado="+a.idMercado + ";";
            //    try
            //    {
            //        con.Open();
            //        command.ExecuteNonQuery();
            //        con.Close();
            //        double cuotaApuesta = 0;
            //        if (a.tipoCuota == "under")
            //        {
            //            cuotaApuesta = cuotaUnder;
            //        }
            //        else
            //        {
            //            cuotaApuesta = cuotaOver;
            //        }
            //        command.CommandText = "insert into apuesta(tipoMercado, cuota, dinero, fecha, idMercado, gmail, tipoCuota) values (" + a.tipoMercado + ", " + Math.Round(cuotaApuesta, 2) + ", " + a.dinero + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + a.idMercado + ", '" + a.gmail + "', '" + a.tipoCuota + "');";
            //        try
            //        {
            //            con.Open();
            //            command.ExecuteNonQuery();
            //            con.Close();
            //        }
            //        catch (MySqlException e)
            //        {
            //            Debug.WriteLine("Se ha producido un error de conexion");
            //        }
            //    }
            //    catch (MySqlException e)
            //    {
            //        Debug.WriteLine("Se ha producido un error de conexion");
            //    }

            //}
            //catch (MySqlException e)
            //{
            //    Debug.WriteLine("Se ha producido un error de conexion");
            //}

            PlaceMyBetContext context = new PlaceMyBetContext();

            context.Apuestas.Add(a);
            context.SaveChanges();

            Mercado m;
            using (context)
            {
                m = context.Mercados.Single(b => b.MercadoId == a.MercadoId);
                if(a.tipoCuota == "under")
                {
                    m.DineroUnder = m.DineroUnder + a.dinero;
                }
                else
                {
                    m.DineroOver = m.DineroOver + a.dinero;
                }

                m.CuotaOver = m.DineroOver / (m.DineroOver + m.DineroUnder);
                m.CuotaOver = Math.Round((1/m.CuotaOver)*0.95,2);
                m.CuotaUnder = m.DineroUnder / (m.DineroUnder + m.DineroOver);
                m.CuotaUnder = Math.Round((1 / m.CuotaUnder) * 0.95,2);
                context.SaveChanges();
            }

        }

        internal Apuesta RetrievebyId(int id)
        {
            Apuesta a;
            using (var context = new PlaceMyBetContext())
            {
                a = context.Apuestas.Single(b => b.ApuestaId == id);
            }
            return a;
        }
        static public ApuestaDTO2 ToDTO2(Apuesta a)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Mercado m;
            using (context)
            {
                m= context.Mercados.Single(b => b.MercadoId == a.MercadoId);
                
            }
                return new ApuestaDTO2(a.UsuarioId, a.tipoCuota, a.cuota, a.dinero, m.EventoId, a.Mercado);
        }
    }
}