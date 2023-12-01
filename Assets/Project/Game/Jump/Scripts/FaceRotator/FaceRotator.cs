using DG.Tweening;
using UnityEngine;

namespace Jump.FaceRotators
{
    public class FaceRotator : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Rigidbody2D _rigidbody2D;
        [SerializeField] private Transform _transform;
        [SerializeField] private float _duration;
        [SerializeField] private Ease _ease;
        [SerializeField] private int _angle = 40; 
        
        private float velocity;
        private float angleLerpValue;
        private Vector3 desiredRotation;
        private Vector3 forward;
        private Vector3 back;

        private void Awake()
        {
            forward = Vector3.forward * _angle;
            back = Vector3.back * _angle;
        }

        private void Update()
        {
            velocity = Mathf.Clamp(_rigidbody2D.velocity.y, -1, 1);
            angleLerpValue = Mathf.InverseLerp(-1, 1, velocity);

            desiredRotation = Vector3.Lerp(back, forward, angleLerpValue);

            _transform.DORotate(desiredRotation, _duration).SetEase(_ease);
        }
    }
}