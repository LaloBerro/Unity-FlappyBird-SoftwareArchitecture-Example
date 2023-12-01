using MechanicsObstaclesGenerator.Core.Domain;
using MechanicsObstaclesGenerator.Timer.Domain;
using Spawners.Runtime.Core.Domain;

namespace Obstacles.Domain
{
    public class PipeObstacleSpawner : ObstacleSpawner<PipeObstacleData>
    {
        private readonly IRandomGetter<float> _apertureRandomGetter;
        
        public PipeObstacleSpawner(ISpawner<PipeObstacleData> spawner, IRandomGetter<float> apertureRandomGetter) : base(spawner)
        {
            _apertureRandomGetter = apertureRandomGetter;
        }

        protected override PipeObstacleData GetData()
        {
            float randomAperture = _apertureRandomGetter.GetRandomNumber();

            PipeObstacleData pipeObstacleData = new PipeObstacleData(randomAperture, UnityEngine.Random.Range(-2, 2));

            return pipeObstacleData;
        }
    }
}