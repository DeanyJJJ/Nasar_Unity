using System;
using UnityEngine;

namespace Practice_7.Scripts
{
    public class Practice_7_1 : MonoBehaviour
    {
        [SerializeField] private float speedMovement;

        private void Update()
        {
            transform.Translate(transform.forward * speedMovement * Time.deltaTime);
        }
    }
}
