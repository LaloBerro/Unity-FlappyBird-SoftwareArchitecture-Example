using System;
using System.Threading.Tasks;
using ScenesLoaderSystem;

namespace Utils
{
    public class LoadSceneOnTime
    {
        private readonly ISceneDataLoader _sceneDataLoader;
        private readonly int _duration;

        public LoadSceneOnTime(int duration, ISceneDataLoader sceneDataLoader)
        {
            _duration = duration;
            _sceneDataLoader = sceneDataLoader;

            Execute();
        }

        private async void Execute()
        {
            await Task.Delay(TimeSpan.FromSeconds(_duration));

            _sceneDataLoader.Load();
        }
    }
}