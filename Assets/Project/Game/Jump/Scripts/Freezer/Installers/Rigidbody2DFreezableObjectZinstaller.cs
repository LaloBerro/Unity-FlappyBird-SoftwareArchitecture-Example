using Jump.Freezers.Domain;
using Jump.Freezers.InterfaceAdapters.Realtime;
using UnityEngine;
using ZenjectExtensions.Zinstallers;

namespace Jump.Freezers.Installers
{
    public class Rigidbody2DFreezableObjectZinstaller : InstanceZinstaller<IFreezableObject>
    {
        [Header("References")] [SerializeField]
        private Rigidbody2D _rigidbody2D;

        protected override IFreezableObject GetInitializedClass()
        {
            return new Rigidbody2DFreezableObject(_rigidbody2D);
        }
    }
}