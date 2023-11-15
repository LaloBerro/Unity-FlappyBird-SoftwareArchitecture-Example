using Obstacles.Domain;
using Obstacles.InterfaceAdapters;
using Spawners.Runtime.Core.InterfaceAdapters.Presenters;

namespace Obstacles.Spawner.Installers
{
    public class PipeObstacleSpawnedObjectPresenter : ISpawnedObjectPresenter<PipeObstacleData, IPipeView>
    {
        public void SetSpawnedObject(IPipeView pipeView, PipeObstacleData pipeObstacleData)
        {
            pipeView.SetClampedHeight(pipeObstacleData.Height);
            pipeView.SetAperture(pipeObstacleData.ApertureSize);
        }
    }
}