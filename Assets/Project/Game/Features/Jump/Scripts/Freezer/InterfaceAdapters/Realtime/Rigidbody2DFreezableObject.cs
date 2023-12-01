using Jump.Freezers.Domain;
using UnityEngine;

namespace Jump.Freezers.InterfaceAdapters.Realtime
{
    public class Rigidbody2DFreezableObject : IFreezableObject
    {
        private readonly Rigidbody2D _rigidbody2D;

        public Rigidbody2DFreezableObject(Rigidbody2D rigidbody2D)
        {
            _rigidbody2D = rigidbody2D;
        }

        public void Freeze()
        {
            _rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;
        }

        public void UnFreeze()
        {
            _rigidbody2D.constraints = RigidbodyConstraints2D.None;
        }
    }
}