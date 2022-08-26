using DependencyInjectionExampleTP.Models;

namespace DependencyInjectionExampleTP.Business
{
    public interface IBLConsultaDatos
    {
        List<DatosCliente> ConsultaDatos();
    }
}