using System;
using UnityEngine;
using UnityEngine.UI;

namespace RawImageScrollers
{
    public class RawImageScroller : MonoBehaviour
    {
        [Header("References")] 
        [SerializeField] private RawImage _rawImage; 
        
        [Header("Config")] 
        [SerializeField] private Vector2 _offset;
        [SerializeField] private float _speed;

        private float _speedConverted;

        private void Awake()
        {
            _speedConverted = _speed / 100000f;
        }

        private void Update()
        {
            Rect rect = _rawImage.uvRect;

            rect.x += _offset.x * _speedConverted;
            rect.y += _offset.y * _speedConverted;

            _rawImage.uvRect = rect;
        }
    }
}