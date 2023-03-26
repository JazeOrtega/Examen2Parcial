using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Text;

namespace Datos
{
    public class TickectDB
    {
        string cadena = "server=localhost; user=root; database=facturaExamen; password=123456;";

        public bool Guardar(Ticket ticket)
        {
            bool inserto = false;
            int IdTicket = 0;
            try
            {
                StringBuilder sqlTicket = new StringBuilder();
                sqlTicket.Append(" INSERT INTO ticket (Fecha, CodigoUsuario, IdentidadCliente, TipoSoporte, DescripcionSolicitud, DescripcionRespuesta, Precio, Impuesto, Descuento, Total ) VALUES (@Fecha, @CodigoUsuario, @IdentidadCliente, @TipoSoporte, @DescripcionSolicitud, @DescripcionRespuesta, @Precio, @Impuesto, @Descuento, @Total );");
                sqlTicket.Append("SELECT LAST_INSERT_ID();");

                using (MySqlConnection con = new MySqlConnection(cadena))
                {
                    con.Open();

                    MySqlTransaction transaction = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    try
                    {
                        using (MySqlCommand cmd1 = new MySqlCommand(sqlTicket.ToString(), con, transaction))
                        {
                            cmd1.CommandType = System.Data.CommandType.Text;
                            cmd1.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = ticket.Fecha;
                            cmd1.Parameters.Add("@CodgioUsuario", MySqlDbType.VarChar, 50).Value = ticket.CodigoUsuario;
                            cmd1.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 25).Value = ticket.IdentidadCliente;
                            cmd1.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 30).Value = ticket.TipoSoporte;
                            cmd1.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 80).Value = ticket.DescripcionSolicitud;
                            cmd1.Parameters.Add("@DescripcionRespuesta", MySqlDbType.VarChar, 80).Value = ticket.DescripcionRespuesta;
                            cmd1.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = ticket.Precio;
                            cmd1.Parameters.Add("@Impuesto", MySqlDbType.Decimal).Value = ticket.Impuesto;
                            cmd1.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = ticket.Descuento;
                            cmd1.Parameters.Add("@Total", MySqlDbType.Decimal).Value = ticket.Total;
                            IdTicket = Convert.ToInt32(cmd1.ExecuteScalar());
                        }

                        transaction.Commit();
                        inserto = true;

                    }
                    catch (System.Exception)
                    {
                        inserto = false;
                        transaction.Rollback();

                    }
                }

            }
            catch (System.Exception)
            {

            }
            return inserto;
        }
    }
}
