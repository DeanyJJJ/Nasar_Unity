using System;
using UnityEngine;

namespace Practice_6.Scripts
{
    public class Cube2 : MonoBehaviour
    {
        private MeshRenderer _meshRenderer;

        private void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        private void OnTriggerStay(Collider other)
        {
            if(Input.GetKeyDown(KeyCode.T)) _meshRenderer.material.color = Color.red;
        }
    }
}
