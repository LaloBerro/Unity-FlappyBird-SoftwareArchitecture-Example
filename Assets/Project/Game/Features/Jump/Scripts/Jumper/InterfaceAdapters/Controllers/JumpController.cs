using Jump.Domain;
using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;

namespace Jump.InterfaceAdapters
{
    public class JumpController : Controller
    {
        private readonly Jumper _jumper;
        
        public JumpController(EventBindingViewModel eventBindingViewModel, Jumper jumper) : base(eventBindingViewModel)
        {
            _jumper = jumper;
        }

        public override void Execute()
        {
            _jumper.Jump();
        }
    }
}