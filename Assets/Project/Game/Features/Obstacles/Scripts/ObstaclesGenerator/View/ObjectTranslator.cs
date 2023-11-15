using UnityEngine;

namespace Obstacles.View
{
    public class ObjectTranslator : MonoBehaviour
    {
        [Header("Config")] 
        [SerializeField] private float _velocity; 
        [SerializeField] private Vector3 _direction;
    
        private void Update()
        {
            transform.Translate(_velocity * _direction);
        }
    }   
}