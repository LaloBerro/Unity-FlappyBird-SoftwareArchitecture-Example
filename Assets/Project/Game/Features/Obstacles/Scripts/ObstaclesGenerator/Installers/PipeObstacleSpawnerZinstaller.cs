using MechanicsObstaclesGenerator.Core.Domain;
using MechanicsObstaclesGenerator.Core.Installers;
using MechanicsObstaclesGenerator.Timer.Domain;
using Obstacles.Domain;
using Spawners.Runtime.Core.Domain;
using Zenject;

namespace Obstacles.Installers
{
    public class PipeObstacleSpawnerZinstaller : ObstacleSpawnerZinstaller<PipeObstacleData>
    {
        [Inject]
        private IRandomGetter<float> _apertureRandomGetter;
        
        protected override IObstacleSpawner GetObstacleSpawner(ISpawner<PipeObstacleData> spawner)
        {
            return new PipeObstacleSpawner(spawner, _apertureRandomGetter);
        }
    }
}