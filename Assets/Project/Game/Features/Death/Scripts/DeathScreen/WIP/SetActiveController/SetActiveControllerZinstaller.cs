using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;
using UnityEngine;
using ZenjectExtensions.Zinstallers;

namespace DefaultNamespace
{
    public class SetActiveControllerZinstaller : Zinstaller
    {
        [Header("References")]
        [SerializeField] private EventBindingViewModelSO _eventBindingViewModelSO;
        [SerializeField] private GameObject _gameObject;
        [SerializeField] private bool _isActive;

        private IController _controller;

        public override void Install()
        {
            _controller = new SetActiveController(_eventBindingViewModelSO.GetViewModel(), _gameObject, _isActive);
        }

        private void OnDestroy()
        {
            _controller.Dispose();
        }
    }
}