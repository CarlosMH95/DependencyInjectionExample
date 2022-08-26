using DependencyInjectionExampleTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExampleTP.DataAccess
{
    public class DatosClientesDB
    {
        public List<DatosCliente> GetDatosCliente() 
        {
            BaseDatos bd = new BaseDatos();
            var result = bd.EjecutarDataset();
            return result;
        }
    }
}
