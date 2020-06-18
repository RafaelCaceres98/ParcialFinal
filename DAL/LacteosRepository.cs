using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.IO;

namespace DAL
{
    public class LacteosRepository
    {
        public ConectionManager Conection;
        public IList<Lacteos> Lacteoss;

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
    }
}
