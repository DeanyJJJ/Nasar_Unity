using System;
using UnityEngine;

namespace Practice_8.Scripts
{
    public class Practice_8 : MonoBehaviour
    {
        private Animator _animator;

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _animator.SetBool("isJump", true);
            }
        }
    }
}
