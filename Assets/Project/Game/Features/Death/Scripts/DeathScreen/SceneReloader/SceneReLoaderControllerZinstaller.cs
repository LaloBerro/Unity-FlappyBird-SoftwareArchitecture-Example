using Death.DeathScreen.InterfaceAdapters;
using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;
using ScenesLoaderSystem.Core.Domain;
using ServiceLocatorPattern;
using UnityEngine;
using ZenjectExtensions.Zinstallers;

namespace Death.DeathScreen.Installers
{
    public class SceneReLoaderControllerZinstaller : InstanceZinstaller<IController>
    {
        [Header("References")]
        [SerializeField] private EventBindingViewModelSO _eventBindingViewModelSO;
        
        protected override IController GetInitializedClass()
        {
            ISceneLoader sceneLoader = ServiceLocator.Instance.Get<ISceneLoader>();
            
            return new SceneReLoaderController(_eventBindingViewModelSO.GetViewModel(), sceneLoader);
        }
    }
}