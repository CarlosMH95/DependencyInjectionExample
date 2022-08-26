using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExampleTP.Models
{
    public class DatosCliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TieneDeuda { get; set; }
        public DatosCliente(int id, string name, string tieneDeuda)
        {
            Id = id;
            Name = name;
            TieneDeuda = tieneDeuda;
        }
    }
}
