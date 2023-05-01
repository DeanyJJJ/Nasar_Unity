using System;
using UnityEngine;

namespace Practice_9.Scripts
{
    public class Scripts_9 : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;

        private void OnCollisionEnter(Collision other)
        {
            audioSource.Play();
        }
    }
}
