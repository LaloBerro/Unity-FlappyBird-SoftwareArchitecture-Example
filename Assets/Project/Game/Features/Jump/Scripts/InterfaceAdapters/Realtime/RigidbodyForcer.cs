﻿using Jump.Domain;
using UnityEngine;

namespace Jump.InterfaceAdapters
{
    public class RigidbodyForcer : MonoBehaviour, IForcer
    {
        [Header("References")] 
        [SerializeField] private Rigidbody2D _rigidbody;
        
        public void AddForce(float force)
        {
            Vector2 forceUp = new Vector2(0, force);
            _rigidbody.AddForce(forceUp);
        }
    }
}