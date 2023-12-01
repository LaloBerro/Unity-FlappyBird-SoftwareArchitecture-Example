using Jump.Domain;
using Jump.InterfaceAdapters;
using UnityEngine;
using ZenjectExtensions.Zinstallers;

namespace Jump.Installers
{
    public class RigidbodyForcerZinstaller : InstanceZinstaller<IForcer>
    {
        [Header("References")] 
        [SerializeField] private RigidbodyForcer _rigidbodyForcer; 
        
        protected override IForcer GetInitializedClass()
        {
            return _rigidbodyForcer;
        }
    }
}