using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_7_3 : MonoBehaviour
{
    [SerializeField] private GameObject spherePrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) Instantiate(spherePrefab, transform.position, Quaternion.identity);
    }
}
