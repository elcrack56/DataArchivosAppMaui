using DataArchivosAppMaui.Models;
using DataArchivosAppMaui.Repository;

namespace DataArchivosAppMaui
{
    public partial class MainPage : ContentPage
    {
        public EstudianteUDLA estudiante;
        EstudianteUDLAFilesRepository _repository;
        public MainPage()
        {
            InitializeComponent();

            _repository = new EstudianteUDLAFilesRepository();
            estudiante = _repository.DevuelveIndoEstudianteUDLA(1);

            BindingContext = estudiante;
        }


    }

}
