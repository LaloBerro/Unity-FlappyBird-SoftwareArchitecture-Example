using Obstacles.Domain;
using Obstacles.InterfaceAdapters;
using Spawners.Runtime.Core.Domain;
using Spawners.Runtime.Core.InterfaceAdapters.Presenters;

namespace Obstacles.Spawner.Installers
{
    public class PipeObstacleGeneralSpawnerZinstaller : GeneralSpawnerZinstaller<PipeObstacleData, IPipeView>
    {
        protected override ISpawnedObjectPresenter<PipeObstacleData, IPipeView> GetSpawnerPresenter()
        {
            return new PipeObstacleSpawnedObjectPresenter();
        }
    }
}