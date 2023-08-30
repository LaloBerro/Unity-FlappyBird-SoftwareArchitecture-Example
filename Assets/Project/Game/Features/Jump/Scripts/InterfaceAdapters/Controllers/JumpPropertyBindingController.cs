using Jump.Domain;
using MVVM.PropertyBinding.InteraceAdapters;

namespace Jump.InterfaceAdapters
{
    public class JumpPropertyBindingController : PropertyBindingController<float, Jumper>
    {
        public JumpPropertyBindingController(IReactiveVariable reactiveVariable, Jumper useCase) : base(reactiveVariable, useCase)
        {
        }
        
        protected override void Execute(Jumper jumper, float forceAmount)
        {
            jumper.SetForceAmount(forceAmount);
        }
    }
}