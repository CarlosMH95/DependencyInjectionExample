using DependencyInjectionExampleTP.DataAccess;
using DependencyInjectionExampleTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExampleTP.Business
{
    public class BLConsultaDatos : IBLConsultaDatos
    {
        public List<DatosCliente> ConsultaDatos()
        {
            DatosClientesDB datos = new DatosClientesDB();
            var result = datos.GetDatosCliente();
            foreach (DatosCliente datosCliente in result)
            {
                datosCliente.TieneDeuda += " tiene deuda";
            }
            return result;
        }
    }
}
