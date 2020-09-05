using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class DragObject : MonoBehaviour
{
    [SerializeField]
    private Vector3 mOffset;
    [SerializeField]
    private float mZcoord;
    [SerializeField]
    private GameObject Distance_core_one,obs;
    [SerializeField]
    private float distance, distance_B;
    [SerializeField]
    private Material mat,mat_default;
    private float mousePoint_Offset;
    public bool isture, obs_distance;
    private void Start()
    {
        mousePoint_Offset = 11;
        isture = false;
        this.gameObject.GetComponent<Renderer>().material = mat_default;
        
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
    private void Update()
    {
        distance = Vector2.Distance(this.gameObject.transform.position, Distance_core_one.transform.position);

        if(distance > 5.0f && distance < 6.0f)
        {
            this.gameObject.GetComponent<Renderer>().material = mat;
            isture = true; 
        }
        else
        {
           this.gameObject.GetComponent<Renderer>().material = mat_default;
            isture = false;
        }


        if (obs_distance)
        {
 
            distance_B = Vector2.Distance(this.gameObject.transform.position, Distance_core_one.transform.position);
            distance = Vector2.Distance(this.gameObject.transform.position, obs.transform.position);
            if (distance_B > 5.0f && distance_B < 6.0f && distance > 2.0f && distance < 5.0f)
            {
                this.gameObject.GetComponent<Renderer>().material = mat;
                isture = true;
            }
            else
            {
                this.gameObject.GetComponent<Renderer>().material = mat_default;
                isture = false;
            }


            //distance = Vector2.Distance(this.gameObject.transform.position, obs.transform.position);

            //if (distance > 5.0f && distance < 6.0f)
            //{
            //    this.gameObject.GetComponent<Renderer>().material = mat;
            //    isture = true;
            //}
            //else
            //{
            //    this.gameObject.GetComponent<Renderer>().material = mat_default;
            //    isture = false;
            //}


        }
    }
}
