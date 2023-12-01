using UnityEngine;

namespace Jump.Freezers.Domain
{
    public class Freezer
    {
        private readonly IFreezableObject _freezableObject;
        private readonly bool _hasToFreeze;

        public Freezer(bool hasToFreeze, IFreezableObject freezableObject)
        {
            _hasToFreeze = hasToFreeze;
            _freezableObject = freezableObject;
        }

        public void Freeze()
        {
            if (_hasToFreeze)
                _freezableObject.Freeze();
            else
                _freezableObject.UnFreeze();
        }
    }

    public interface IFreezableObject
    {
        void Freeze();
        void UnFreeze();
    }
}