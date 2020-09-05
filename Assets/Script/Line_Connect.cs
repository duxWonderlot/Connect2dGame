using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Line_Connect : MonoBehaviour
{
    [SerializeField]
    private LineRenderer line;
    [SerializeField]
    private LineRenderer[] for_center_line;
    [SerializeField]
    private Transform[] object_points;
    [SerializeField]
    private Transform[] center_1,center_2,center_3,center_4,center_5,center_6,center_7,center_8,center_9;
    public bool newdiff,center_Dot,Dot;
    private void Update()
    {
        line.positionCount = object_points.Length;
        line.SetPosition(0, object_points[0].position);
        line.SetPosition(1, object_points[1].position);
        line.SetPosition(2, object_points[2].position);
        line.SetPosition(3, object_points[3].position);
        line.SetPosition(4, object_points[4].position);
        line.SetPosition(5, object_points[5].position);
        line.SetPosition(6, object_points[6].position);
        if (newdiff)
        {
            line.SetPosition(7, object_points[7].position);
            line.SetPosition(8, object_points[8].position);
        }
        if (center_Dot)
        {
            //----------1
            for_center_line[0].positionCount = center_1.Length;
            for_center_line[0].SetPosition(0, center_1[0].position);
            for_center_line[0].SetPosition(1, center_1[1].position);
            //----------2
            for_center_line[1].positionCount = center_2.Length;
            for_center_line[1].SetPosition(0, center_2[0].position);
            for_center_line[1].SetPosition(1, center_2[1].position);
            //----------3
            for_center_line[2].positionCount = center_3.Length;
            for_center_line[2].SetPosition(0, center_3[0].position);
            for_center_line[2].SetPosition(1, center_3[1].position);
            //----------4
            for_center_line[3].positionCount = center_4.Length;
            for_center_line[3].SetPosition(0, center_4[0].position);
            for_center_line[3].SetPosition(1, center_4[1].position);
            //----------5
            for_center_line[4].positionCount = center_5.Length;
            for_center_line[4].SetPosition(0, center_5[0].position);
            for_center_line[4].SetPosition(1, center_5[1].position);
            //----------6
            for_center_line[5].positionCount = center_6.Length;
            for_center_line[5].SetPosition(0, center_6[0].position);
            for_center_line[5].SetPosition(1, center_6[1].position);
            //----------7
            for_center_line[6].positionCount = center_7.Length;
            for_center_line[6].SetPosition(0, center_7[0].position);
            for_center_line[6].SetPosition(1, center_7[1].position);
            //----------8
            for_center_line[7].positionCount = center_8.Length;
            for_center_line[7].SetPosition(0, center_8[0].position);
            for_center_line[7].SetPosition(1, center_8[1].position);
            //----------9
            for_center_line[8].positionCount = center_9.Length;
            for_center_line[8].SetPosition(0, center_9[0].position);
            for_center_line[8].SetPosition(1, center_9[1].position);
        }
         
    }
}
