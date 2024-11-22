using DataArchivosAppMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataArchivosAppMaui.Interfaces
{
    public interface IEstudianteUDLARepository
    {
        List<EstudianteUDLA> DevuelveListadoEstudianteUDLA();

        EstudianteUDLA DevuelveIndoEstudianteUDLA(int Id);
        Boolean CrearEstudianteUDLA(EstudianteUDLA estudiante);
        Boolean ActualizarEstudianteUDLA (EstudianteUDLA estudiante);
        Boolean EliminarEstudianteUDLA(int Id);
    }
}
