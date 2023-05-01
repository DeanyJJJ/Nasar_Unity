using System;
using UnityEngine;

namespace Practice_6.Scripts
{
    public class Cube3 : MonoBehaviour
    {
        private MeshRenderer _meshRenderer;

        private void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        private void OnMouseEnter()
        {
            _meshRenderer.material.color = Color.green;
        }

        private void OnMouseExit()
        {
            _meshRenderer.material.color = Color.blue;
        }
    }
}
