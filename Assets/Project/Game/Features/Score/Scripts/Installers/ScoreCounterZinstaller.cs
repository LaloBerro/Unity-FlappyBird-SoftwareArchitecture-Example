using Score.Domain;
using Zenject;
using ZenjectExtensions.Zinstallers;

namespace Score.Installers
{
    public class ScoreCounterZinstaller : InstanceZinstaller<ScoreCounter>
    {
        [Inject] private IScoreCounterPresenter _scoreCounterPresenter;

        protected override ScoreCounter GetInitializedClass()
        {
            return new ScoreCounter(_scoreCounterPresenter);
        }
    }
}