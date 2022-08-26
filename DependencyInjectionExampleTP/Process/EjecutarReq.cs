using DependencyInjectionExampleTP.Business;
using DependencyInjectionExampleTP.Process.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExampleTP.Process
{
    public class EjecutarReq : IEjecutarReq
    {
        private readonly IBLConsultaDatos _bl;
        public EjecutarReq(IBLConsultaDatos bl) 
        {
            _bl = bl;
        }
        public void ProcesarInformacion()
        {
            //BLConsultaDatos bl = new BLConsultaDatos();
            var resultado = _bl.ConsultaDatos();
            foreach (var item in resultado)
            {
                Console.WriteLine(JsonConvert.SerializeObject(item));
            }
        }
    }
}
