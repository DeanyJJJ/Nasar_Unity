using System;
using UnityEngine;

namespace Practice_6.Scripts
{
    public class Cube4 : MonoBehaviour
    {
        private MeshRenderer _meshRenderer;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnMouseDown()
        {
            Debug.Log(name);
            Debug.Log(transform.position);
            Debug.Log(_meshRenderer.material.color);
            Debug.Log(_rigidbody.mass);
        }
    }
}
