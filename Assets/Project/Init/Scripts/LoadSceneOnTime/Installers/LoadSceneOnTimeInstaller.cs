using Installers.Core;
using ScenesLoaderSystem;
using UnityEngine;

namespace Utils
{
    public class LoadSceneOnTimeInstaller : MonoInstaller<LoadSceneOnTime>
    {
        [Header("References")]
        [SerializeField] private MonoInstaller<SceneDataLoader> _sceneDataLoaderInstaller;

        [Header("Config")]
        [SerializeField] private int _duration;

        protected override LoadSceneOnTime GetData()
        {
            return new LoadSceneOnTime(_duration, _sceneDataLoaderInstaller.Data);
        }
    }
}