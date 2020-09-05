using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this script only used for center_dot
[ExecuteInEditMode]
public class DragObject_center : MonoBehaviour
{
     
    private Vector3 mOffset;   
    private float mZcoord; 
    private float mousePoint_Offset;
   
    private void Start()
    {
        mousePoint_Offset = 11;
  
    }

    private void OnMouseDown()
    {
        mZcoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
        
    }
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition * mousePoint_Offset;

        mousePoint.z = mZcoord;

        return Camera.main.ScreenToViewportPoint(mousePoint);
    }
    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }
   
}
