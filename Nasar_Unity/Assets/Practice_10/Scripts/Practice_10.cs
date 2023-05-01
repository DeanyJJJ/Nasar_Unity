using System;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Practice_10.Scripts
{
    public class Practice_10 : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Scene_1");
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Scene_2");
            }
        }
    }
}
