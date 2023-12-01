using System;
using MVVM.EventBinding.InteraceAdapters;
using UnityEngine;
using UniRx;

namespace Obstacles.View
{
    public class ObjectTranslator : MonoBehaviour
    {
        [Header("Config")] 
        [SerializeField] private float _velocity; 
        [SerializeField] private Vector3 _direction;

        [Header("References")] 
        [SerializeField] private EventBindingViewModelSO _eventBindingViewModelSo;

        private EventBindingViewModel _eventBindingViewModel;
        private IDisposable _disposable;

        private void Awake()
        {
            _eventBindingViewModel = _eventBindingViewModelSo.GetViewModel();
            _disposable = _eventBindingViewModel.ReactiveCommand.Subscribe(_ =>
            {
                _velocity = 0;
            });
        }

        private void Update()
        {
            transform.Translate(_direction * (_velocity * Time.deltaTime));
        }

        private void OnDestroy()
        {
            _disposable.Dispose();
        }
    }   
}