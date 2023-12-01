using MVVM.PropertyBinding.InteraceAdapters;
using Score.Domain;
using Score.InterfaceAdapters.Presenters;
using UnityEngine;
using ZenjectExtensions.Zinstallers;

namespace Score.Installers
{
    public class ScoreCounterPresenterZinstaller : InstanceZinstaller<IScoreCounterPresenter>
    {
        [Header("References")] [SerializeField]
        private PropertyBindingViewModelSO _scorePropertyBindingViewModelSo;

        protected override IScoreCounterPresenter GetInitializedClass()
        {
            return new ScoreCounterPresenter(_scorePropertyBindingViewModelSo.GetViewModel());
        }
    }
}