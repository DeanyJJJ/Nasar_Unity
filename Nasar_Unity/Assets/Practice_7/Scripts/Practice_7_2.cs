using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_7_2 : MonoBehaviour
{
    [SerializeField] private Vector3 speedMovement;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _rigidbody.velocity = speedMovement * Time.deltaTime;
    }
}
