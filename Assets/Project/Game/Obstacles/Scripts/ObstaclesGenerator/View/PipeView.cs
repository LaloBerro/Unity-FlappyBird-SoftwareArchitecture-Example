using Obstacles.InterfaceAdapters;
using UnityEngine;

namespace Obstacles.View
{
    public class PipeView : MonoBehaviour, IPipeView
    {
        [Header("References")] 
        [SerializeField] private Transform _upperTransform;
        [SerializeField] private Transform _bottomTransform;

        [SerializeField] private Transform _centerTransform;
        
        public void Init()
        {
            gameObject.SetActive(true);
        }

        public void Recycle()
        {
            gameObject.SetActive(false);
        }

        public void SetClampedHeight(float clampedHeight)
        {
            Vector3 offset = new Vector3(0, clampedHeight, 0);
            Vector3 centerPosition = transform.position + offset;
            _centerTransform.position = centerPosition;
        }

        public void SetAperture(float apertureSize)
        {
            Vector3 offset = new Vector3(0, apertureSize * 2.5f, 0);
            Vector3 upperPipePosition = _centerTransform.position + offset;
            _upperTransform.position = upperPipePosition;
            
            Vector3 bottomPipePosition = _centerTransform.position - offset;
            _bottomTransform.position = bottomPipePosition;
        }
    }
}