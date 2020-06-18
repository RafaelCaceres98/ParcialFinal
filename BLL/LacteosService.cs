using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LacteosService
    {
        public ConectionManager Conection;
        public LacteosRepository LacteosRepository;

        public LacteosService(string conection)
        {
            Conection = new ConectionManager(conection);
            LacteosRepository = new LacteosRepository(Conection);
        }

        public IList<Lacteos> CargarArchivo(string ruta)
        {
            try
            {
                return LacteosRepository.CargarArchivo(ruta);
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
