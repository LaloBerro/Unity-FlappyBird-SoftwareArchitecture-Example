using Jump.Domain;
using Jump.InterfaceAdapters;
using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;

namespace Jump.Installers
{
    public class JumpControllerInstaller : ControllerZenjectInstaller<Jumper>
    {
        protected override IController GetInitializedController(Jumper jumper, EventBindingViewModel eventBindingViewModel)
        {
            return new JumpController(eventBindingViewModel, jumper);
        }
    }
}