using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Practice_3
{
    public class Practice3 : MonoBehaviour
    {
        [SerializeField] private string randomWorld;
        [SerializeField] private GameObject randomObject;
        [SerializeField] private float randomNumber;

        private void Start()
        {
            Debug.Log(randomNumber);
        }

        private void Update()
        {
            Randomize();
        }

        private void Randomize()
        {
            // Debug.Log(randomNumber);

            randomNumber = Random.Range(1, 100);
            
            Debug.Log(randomNumber);
            
            if(randomNumber == 3) Debug.Log("Condition check!");

        }
    }
}
