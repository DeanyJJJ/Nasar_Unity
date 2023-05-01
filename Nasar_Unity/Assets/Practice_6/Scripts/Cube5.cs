using System;
using UnityEngine;

namespace Practice_6.Scripts
{
    public class Cube5 : MonoBehaviour
    {
        // private Vector3 _mouseOffset;
        // private float _mouseZPozition;
        //
        // private void OnMouseDown()
        // {
        //     _mouseZPozition = Camera.main.WorldToScreenPoint(transform.position).z;
        //
        //     _mouseOffset = transform.position - GetMousePosition();
        // }
        //
        // private Vector3 GetMousePosition()
        // {
        //     Vector3 mousePoint = Input.mousePosition;
        //
        //     mousePoint.z = _mouseZPozition;
        //
        //     return Camera.main.WorldToScreenPoint(mousePoint);
        // }
        //
        // private void OnMouseDrag()
        // {
        //     transform.position = GetMousePosition() + _mouseOffset;
        // }
        
        [SerializeField] private float distance = 10f;
 
        void OnMouseDrag()
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
    }
}
