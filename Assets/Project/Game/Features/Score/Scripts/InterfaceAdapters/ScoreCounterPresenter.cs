using MVVM.PropertyBinding.InteraceAdapters;
using Score.Domain;

namespace Score.InterfaceAdapters.Presenters
{
    public class ScoreCounterPresenter : IScoreCounterPresenter
    {
        private readonly PropertyBindingViewModel _propertyBinding;

        public ScoreCounterPresenter(PropertyBindingViewModel propertyBinding)
        {
            _propertyBinding = propertyBinding;
        }

        public void SetScore(int score)
        {
            string scoreText = score.ToString();

            _propertyBinding.GetReactiveVariableByType(typeof(string)).SetValue(scoreText);
        }
    }
}