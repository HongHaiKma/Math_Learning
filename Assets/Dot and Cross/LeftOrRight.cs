using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftOrRight : MonoBehaviour
{
    public Transform youTrans;
    public Transform wayPointTrans;

    public Transform crossPoint;

    public Vector3 up;

    public bool right;
    public bool left;

    void Update()
    {
        // //The direction you are facing
        // Vector3 youDir = youTrans.forward;

        // //The direction from you to the waypoint
        // Vector3 waypointDir = wayPointTrans.position - youTrans.position;

        // //The cross product between these vectors
        // Vector3 crossProduct = Vector3.Cross(youDir, waypointDir);
        // // Vector3 crossProduct = Vector3.Cross(waypointDir, youDir);

        // crossPoint.position = crossProduct;

        // //The dot product between the your up vector and the cross product
        // //This can be said to be a volume that can be negative
        // float dotProduct = Vector3.Dot(crossProduct, youTrans.up);

        // up = youTrans.up;

        // //Now we can decide if we should turn left or right
        // if (dotProduct > 0f)
        // {
        //     Debug.Log("Turn right");
        //     right = true;
        //     left = false;
        // }
        // else
        // {
        //     Debug.Log("Turn left");
        //     right = false;
        //     left = true;
        // }

        Vector3 youDir = youTrans.right;

        //The direction from you to the waypoint
        Vector3 waypointDir = wayPointTrans.position - youTrans.position;

        //The dot product between the vectors
        float dotProduct = Vector3.Dot(youDir, waypointDir);

        //Now we can decide if we should turn left or right
        if (dotProduct > 0f)
        {
            Debug.Log("Turn right");
            right = true;
            left = false;
        }
        else
        {
            Debug.Log("Turn left");
            right = false;
            left = true;
        }
    }
}
