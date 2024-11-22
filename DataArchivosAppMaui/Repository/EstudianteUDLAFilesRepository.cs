using DataArchivosAppMaui.Interfaces;
using DataArchivosAppMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataArchivosAppMaui.Repository
{
    public class EstudianteUDLAFilesRepository : IEstudianteUDLARepository
    {
        public _fileName = Path.Combine(FileSystem.AppDataDirectory, "estudiante.txt")
        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            string estudiate_json
        }

        public EstudianteUDLA DevuelveIndoEstudianteUDLA(int Id)
        {
            return new EstudianteUDLA
            {
                ID = Id,
                Nombre="Darwin",
                Carrera="Ingenieria en software"
            };
        }

        public List<EstudianteUDLA> DevuelveListadoEstudianteUDLA()
        {
            List<EstudianteUDLA> estudiantes= new List<EstudianteUDLA>();
            estudiantes.Add(DevuelveIndoEstudianteUDLA(1));
            estudiantes.Add(DevuelveIndoEstudianteUDLA(2));
            estudiantes.Add(DevuelveIndoEstudianteUDLA(3));
            return estudiantes;
        }

        public bool EliminarEstudianteUDLA(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
