using ScenesLoaderSystem;
using UnityEngine;
using Zenject;
using ZenjectExtensions.Zinstallers;

namespace Utils
{
    public class LoadSceneOnTimeInstaller :  Zinstaller
    {
        [Header("Config")]
        [SerializeField] private int _duration;
        
        [Inject]
        private ISceneDataLoader _sceneDataLoader;

        public override void Install()
        {
            new LoadSceneOnTime(_duration, _sceneDataLoader);
        }
    }
}