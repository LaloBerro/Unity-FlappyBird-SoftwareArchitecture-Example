using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;

namespace Death.Activator.InterfaceAdapters
{
    public class DeathActivatorController : Controller
    {
        private readonly EventBindingViewModel _deathEventBindingViewModel;
        
        public DeathActivatorController(EventBindingViewModel eventBindingViewModel, EventBindingViewModel deathEventBindingViewModel) : base(eventBindingViewModel)
        {
            _deathEventBindingViewModel = deathEventBindingViewModel;
        }

        public override void Execute()
        {
            _deathEventBindingViewModel.ReactiveCommand.Execute();
        }
    }
}