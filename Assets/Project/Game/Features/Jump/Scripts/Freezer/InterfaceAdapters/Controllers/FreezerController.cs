using Jump.Freezers.Domain;
using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;

namespace Jump.Freezers.InterfaceAdapters.Controllers
{
    public class FreezerController : Controller
    {
        private readonly Freezer _freezer;

        public FreezerController(EventBindingViewModel eventBindingViewModel, Freezer freezer) : base(
            eventBindingViewModel)
        {
            _freezer = freezer;
        }

        public override void Execute()
        {
            _freezer.Freeze();
        }
    }
}