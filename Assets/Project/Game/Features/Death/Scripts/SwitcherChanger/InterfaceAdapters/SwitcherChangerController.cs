using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;
using SwitcherChangers.Domain;

namespace SwitcherChangers.InterfaceAdapters.Controllers
{
    public class SwitcherChangerController : Controller
    {
        private readonly SwitcherChanger _switcherChanger;

        public SwitcherChangerController(EventBindingViewModel eventBindingViewModel, SwitcherChanger switcherChanger) :
            base(eventBindingViewModel)
        {
            _switcherChanger = switcherChanger;
        }

        public override void Execute()
        {
            _switcherChanger.TurnSwitcher();
        }
    }
}