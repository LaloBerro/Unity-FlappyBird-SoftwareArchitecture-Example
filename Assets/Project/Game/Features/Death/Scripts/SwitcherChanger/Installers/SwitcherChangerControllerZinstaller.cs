using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;
using SwitcherChangers.Domain;
using SwitcherChangers.InterfaceAdapters.Controllers;
using UnityEngine;
using Zenject;
using ZenjectExtensions.Zinstallers;

namespace SwitcherChangers.Installers
{
    public class SwitcherChangerControllerZinstaller : Zinstaller
    {
        [Header("References")] [SerializeField]
        private EventBindingViewModelSO _eventBindingViewModelSO;

        [Inject] private SwitcherChanger _switcherChanger;
        private IController _controller;

        public override void Install()
        {
            _controller = new SwitcherChangerController(_eventBindingViewModelSO.GetViewModel(), _switcherChanger);
        }

        private void OnDestroy()
        {
            _controller.Dispose();
        }
    }
}