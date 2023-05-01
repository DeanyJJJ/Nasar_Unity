using System;
using UnityEngine;

namespace Practice_6.Scripts
{
   public class Cube1 : MonoBehaviour
   {
      private Rigidbody _rigidbody;

      private void Start()
      {
         _rigidbody = GetComponent<Rigidbody>();
      }

      private void Update()
      {
         if(Input.GetKeyDown(KeyCode.R)) _rigidbody.AddForce(0, 200, 0);
      }
   }
}
