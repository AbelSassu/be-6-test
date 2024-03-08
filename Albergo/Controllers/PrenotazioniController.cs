using Albergo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Albergo.Controllers
{
    public class PrenotazioniController : Controller
    {
        // GET: Prenotazioni
        [Authorize]
        public ActionResult Index()
        {


            List<Prenotazione> prenotazioni = new List<Prenotazione>();
            try
            {
                Db.conn.Open();
                var command = new SqlCommand(@"SELECT Prenotazione_ID, Data_Pren, Data_Arrivo, Data_Partenza, Numero, Tipo as TipoPensione
                                      FROM Prenotazioni as p
                                      JOIN Ospiti as o ON o.Ospite_ID = p.Ospite_ID
                                      JOIN Pensioni as pe ON pe.Pensione_ID = p.Pensione_ID
                                      JOIN Camere as c ON c.Camera_ID = p.Camera_ID", Db.conn);

                var reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var pren = new Prenotazione();
                        pren.Prenotazione_ID = (int)reader["Prenotazione_ID"];
                        pren.Data_Pren = (DateTime)reader["Data_Pren"];
                        pren.Data_Arrivo = (DateTime)reader["Data_Arrivo"];
                        pren.Data_Partenza = (DateTime)reader["Data_Partenza"];
                        pren.Camera = new Camera { Numero = (int)reader["Numero"] };
                        pren.Pensione = new Pensione { Tipo = reader["TipoPensione"].ToString() };
                        prenotazioni.Add(pren);
                    }
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Db.conn.Close();

            }

            return View(prenotazioni);

        }
    }
}