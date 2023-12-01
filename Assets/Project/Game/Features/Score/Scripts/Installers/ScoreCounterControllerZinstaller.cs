using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;
using Score.Domain;
using Score.InterfaceAdapters.Controllers;

namespace Score.Installers
{
    public class ScoreCounterControllerZinstaller : ControllerZenjectInstaller<ScoreCounter>
    {
        protected override IController GetInitializedController(ScoreCounter scoreCounter,
            EventBindingViewModel eventBindingViewModel)
        {
            return new ScoreCounterController(eventBindingViewModel, scoreCounter);
        }
    }
}