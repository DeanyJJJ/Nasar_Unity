using System;
using UnityEngine;

namespace Practice_4
{
    public class Practice4 : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.name == "Cube") Destroy(other.gameObject);
        }

        private void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.name == "Cube") Destroy(other.gameObject);
        }
    }
}
