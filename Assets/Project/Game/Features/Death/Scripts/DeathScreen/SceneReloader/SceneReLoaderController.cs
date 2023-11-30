using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;
using ScenesLoaderSystem.Core.Domain;

namespace Death.DeathScreen.InterfaceAdapters
{
    public class SceneReLoaderController : Controller
    {
        private readonly ISceneLoader _sceneLoader;
        
        public SceneReLoaderController(EventBindingViewModel eventBindingViewModel, ISceneLoader sceneLoader) : base(eventBindingViewModel)
        {
            _sceneLoader = sceneLoader;
        }

        public override void Execute()
        {
            _sceneLoader.ReloadCurrentScene();
        }
    }
}

