using Death.Activator.InterfaceAdapters;
using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;
using UnityEngine;
using ZenjectExtensions.Zinstallers;

namespace Death.Activator.Installers
{
    public class DeathActivatorControllerZinstaller : InstanceZinstaller<IController>
    {
        [Header("References")]
        [SerializeField] private EventBindingViewModelSO _obstacleEventBindingViewModelSO;
        [SerializeField] private EventBindingViewModelSO _deathEventBindingViewModelSO;
        
        protected override IController GetInitializedClass()
        {
            return new DeathActivatorController(_obstacleEventBindingViewModelSO.GetViewModel(), _deathEventBindingViewModelSO.GetViewModel());
        }
    }
}