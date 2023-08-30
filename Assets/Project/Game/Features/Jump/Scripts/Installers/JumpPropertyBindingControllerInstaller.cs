using Jump.Domain;
using Jump.InterfaceAdapters;
using MVVM.PropertyBinding.InteraceAdapters;

namespace Jump.Installers
{
    public class JumpPropertyBindingControllerInstaller :  PropertyBindingControllerZinstaller<float, Jumper>
    {
        protected override PropertyBindingController<float, Jumper> GetController(IReactiveVariable reactiveVariable, Jumper jumper)
        {
            return new JumpPropertyBindingController(reactiveVariable, jumper);
        }
    }
}