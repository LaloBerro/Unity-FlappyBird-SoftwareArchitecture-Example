using Jump.Domain;
using MVVM.PropertyBinding.InteraceAdapters;
using UnityEngine;
using Zenject;
using ZenjectExtensions.Zinstallers;

namespace Jump.Installers
{
    public class JumperInstaller : InstanceZinstaller<Jumper>
    {
        [Header("References")] 
        [SerializeField] private ReactiveVariableTypeSO<float> _forceAmountReactiveVariable;
        
        private IForcer _forcer;
        
        [Inject]
        public void InjectUseCase(IForcer forcer)
        {
            _forcer = forcer;
        }

        protected override Jumper GetInitializedClass()
        {
            var forceAmount = (float)_forceAmountReactiveVariable.GetReactiveVariable().Value;
            Jumper jumper = new Jumper(_forcer, forceAmount);
            
            return jumper;
        }
    }
}