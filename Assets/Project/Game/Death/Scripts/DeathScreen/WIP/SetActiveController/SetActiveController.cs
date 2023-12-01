using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;
using UnityEngine;

namespace DefaultNamespace
{
    public class SetActiveController : Controller
    {
        private readonly GameObject _gameObject;
        private readonly bool _isActive;

        public SetActiveController(EventBindingViewModel eventBindingViewModel, GameObject gameObject, bool isActive) : base(eventBindingViewModel)
        {
            _gameObject = gameObject;
            _isActive = isActive;
        }

        public override void Execute()
        {
            _gameObject.SetActive(_isActive);
        }
    }
}