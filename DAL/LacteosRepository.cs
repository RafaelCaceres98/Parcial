using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.IO;
using System.Data;

namespace DAL
{
    public class LacteosRepository
    {
        public ConectionManager Conection;
        public IList<Lacteos> Lacteoss;
        public SqlDataReader Reader;

        public LacteosRepository(ConectionManager conection)
        {
            Conection = conection;
            Lacteoss = new List<Lacteos>();
        }

        public IList<Lacteos> CargarArchivo(string ruta)
        {
            FileStream source = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(source);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Lacteos lacteos;
                lacteos = Mapear(linea);
                Lacteoss.Add(lacteos);
            }
            reader.Close();
            source.Close();
            return Lacteoss;
        }

        private Lacteos Mapear(string linea)
        {
            char delimiter = ';';
            string[] Datos = linea.Split(delimiter);
            Lacteos lacteos = new Lacteos();
            lacteos.Sede = int.Parse(Datos[0]);
            lacteos.Cedula = Datos[1];
            lacteos.Nombre = Datos[2];
            lacteos.Mes = int.Parse(Datos[3]);
            lacteos.Año = int.Parse(Datos[4]);
            lacteos.Salario = decimal.Parse(Datos[5]);
            lacteos.Bonificaciones = decimal.Parse(Datos[6]);
            lacteos.Descuentos = decimal.Parse(Datos[7]);
            lacteos.TotalPago = decimal.Parse(Datos[8]);
            return lacteos;
        }

        public void GuardarLacteos(Lacteos lacteos)
        {
            using(var command = Conection.Connection.CreateCommand())
            {
                
                    command.CommandText = "GuardarLacteos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = lacteos.Cedula;
                    command.Parameters.Add("@Sede", SqlDbType.Int).Value = lacteos.Sede;
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = lacteos.Nombre;
                    command.Parameters.Add("@Mes", SqlDbType.Int).Value = lacteos.Mes;
                    command.Parameters.Add("@Año", SqlDbType.Int).Value = lacteos.Año;
                    command.Parameters.Add("@Salario", SqlDbType.Decimal).Value = lacteos.Salario;
                    command.Parameters.Add("@Bonificaciones", SqlDbType.Decimal).Value = lacteos.Bonificaciones;
                    command.Parameters.Add("@Descuento", SqlDbType.Decimal).Value = lacteos.Descuentos;
                    command.Parameters.Add("@Total", SqlDbType.Decimal).Value = lacteos.TotalPago;
                    command.ExecuteNonQuery();
            }
        }

        public IList<Lacteos> ConsultasBD()
        {
            Lacteoss.Clear();
            using(var command = Conection.Connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Lacteos";
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    Lacteos lacteos;
                    lacteos = MapBd(Reader);
                    Lacteoss.Add(lacteos);
                }
            }
            return Lacteoss;
        }

        public IList<Lacteos> FiltroSede(int sede)
        {
            ConsultasBD();
            return Lacteoss.Where(L => L.Sede.Equals(sede)).ToList();
        }

        public IList<Lacteos> Filtro(int sede,DateTime fecha)
        {
            ConsultasBD();
            return Lacteoss.Where(L => L.Sede.Equals(sede) && L.Año.Equals(fecha.Year) && L.Mes.Equals(fecha.Month)).ToList();
        }

        private Lacteos MapBd(SqlDataReader reader)
        {
            Lacteos lacteos = new Lacteos();
            lacteos.Cedula = (string)reader["Cedula"];
            lacteos.Sede = (int)reader["sede"];
            lacteos.Nombre = (string)reader["nombre"];
            lacteos.Mes = (int)reader["mes"];
            lacteos.Año = (int)reader["año"];
            lacteos.Salario = (decimal)reader["salario"];
            lacteos.Bonificaciones = (decimal)reader["bonificaciones"];
            lacteos.Descuentos = (decimal)reader["descuentos"];
            lacteos.TotalPago = (decimal)reader["total"];
            return lacteos;
        }
    }
}
