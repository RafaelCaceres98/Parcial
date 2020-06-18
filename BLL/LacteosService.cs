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

        public string GuardarLacteos(IList<Lacteos> lacteos,int malos)
        {
            try
            {
                Conection.Open();
                foreach (var item in lacteos)
                {
                    LacteosRepository.GuardarLacteos(item);
                }
                    return $" Se han guardado correctamente. Buenos: {lacteos.Count} Malos: {malos}";
            }
            catch(Exception e)
            {
                return $"Error. {e.Message.ToString()}";
            }
            finally
            {
                Conection.Close();
            }
        }

        public IList<Lacteos> ConsultasBD()
        {
            try
            {
                Conection.Open();
                return LacteosRepository.ConsultasBD();
            }
            catch(Exception e)
            {
                return null;
            }
            finally
            {
                Conection.Close();
            }
        }

        public IList<Lacteos> FiltroSede(int sede)
        {
            try
            {
                Conection.Open();
                return LacteosRepository.FiltroSede(sede);
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Conection.Close();
            }
        }

        public IList<Lacteos> Filtro(int sede, DateTime fecha)
        {
            try
            {
                Conection.Open();
                return LacteosRepository.Filtro(sede, fecha);
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Conection.Close();
            }
        }
    }
}
