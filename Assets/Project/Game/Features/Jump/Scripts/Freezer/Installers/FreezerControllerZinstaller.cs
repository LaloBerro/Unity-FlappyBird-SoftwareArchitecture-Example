using Jump.Freezers.Domain;
using Jump.Freezers.InterfaceAdapters.Controllers;
using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;

namespace Jump.Freezers.Installers
{
    public class FreezerControllerZinstaller : ControllerZenjectInstaller<Freezer>
    {
        protected override IController GetInitializedController(Freezer useCase,
            EventBindingViewModel eventBindingViewModel)
        {
            return new FreezerController(eventBindingViewModel, useCase);
        }
    }
}