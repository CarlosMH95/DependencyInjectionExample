using DependencyInjectionExampleTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExampleTP.DataAccess
{
    public class BaseDatos
    {
        public List<DatosCliente> EjecutarDataset()
        {
            List<DatosCliente> dataset = new List<DatosCliente>();
            for (int i = 1; i < 11; i++)
            {
                if (i%2 == 0)
                {
                   dataset.Add( new DatosCliente(i, "Carlos", "No"));
                }
                else
                {
                    dataset.Add(new DatosCliente(i, "Carlos", "Si"));
                }
            }
            return dataset;
        }
    }
}
