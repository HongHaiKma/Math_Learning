using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class MathLib : MonoBehaviour
{
    public Transform youTrans;
    public Transform enemyTrans;
    public Transform cross;
    public Transform origin;

    public bool front;
    public bool behind;

    public float angle;

    public Transform originProject;
    public Transform plane;

    // [Sirenix.OdinInspector.Button]
    public void Update()
    {
        // youTrans.LookAt(enemyTrans);

        //The vector from you to the enemy
        // Vector3 youToEnemy = enemyTrans.position - youTrans.position;
        Vector3 enemyToPlayer = youTrans.position - enemyTrans.position;

        //Now we need to figure out if these vectors are pointing in the opposite direction, if so
        //the enemy is behind you. To do that we will use the dot product
        //Unity's built in version:
        //float dotProduct = Vector3.Dot(youForward.normalized, youToEnemy.normalized);
        //Our own version, which is the same:
        float dotProduct = DotProduct(enemyToPlayer, enemyTrans.forward);
        // float dotProduct = DotProduct(enemyTrans.forward, enemyToPlayer);
        // float dotProduct = DotProduct(youForward, youToEnemy);

        //For normalized vectors the dot product returns: 
        // 1 if they point in exactly the same direction, 
        //-1 if they point in completely opposite directions 
        // 0 if the vectors are perpendicular
        //But normalization takes some computer time, so you can ignore it if you are just interested
        //in knowing if the enemy is behind you and your field-of-view is 90 degrees
        //Otherwise you have to normalize the vectors and define "in front" as something like > 0.5
        if (dotProduct >= 0f)
        {
            front = true;
            behind = false;
        }
        else
        {
            front = false;
            behind = true;
        }

        angle = Vector3.Angle(enemyTrans.position, youTrans.position);
    }

    [Sirenix.OdinInspector.Button]
    public void GetCross()
    {
        // Debug.Log("Cross: " + Vector3.Cross(youTrans.position, enemyTrans.position));
        Debug.Log("Cross: " + Vector3.Cross(enemyTrans.position, youTrans.position));
        // cross.position = Vector3.Cross(youTrans.position, enemyTrans.position);
        cross.position = Vector3.Cross(enemyTrans.position, youTrans.position);
    }

    [Sirenix.OdinInspector.Button]
    public void GetDot()
    {
        // Debug.Log("Cross: " + Vector3.Cross(youTrans.position, enemyTrans.position));
        // Debug.Log("Dot: " + Vector3.Dot(enemyTrans.position.normalized, youTrans.position.normalized));
        float dot = Vector3.Dot(enemyTrans.position.normalized, youTrans.position.normalized);

        Debug.Log("Dot: " + dot);
        Debug.Log("Dot2: " + 1 / (Mathf.Sqrt(26)));
        Debug.Log("Angle: " + Mathf.Acos(dot) * Mathf.Rad2Deg);
        Debug.Log("Angle2: " + Mathf.Acos(1 / (Mathf.Sqrt(26))) * Mathf.Rad2Deg);
        Debug.Log("Acos: " + Mathf.Acos(dot));
        Debug.Log("ANGLE: " + Vector3.Angle(enemyTrans.position, youTrans.position));

        Debug.Log("Normalize enemy: " + enemyTrans.position.normalized);
        Debug.Log("Normalize player: " + youTrans.position.normalized);

        Debug.Log("NORMALIZE: " + new Vector3(4f, 4f, 4f).normalized);
        // cross.position = Vector3.Cross(youTrans.position, enemyTrans.position);
        // cross.position = Vector3.Cross(enemyTrans.position, youTrans.position);
    }

    bool abc()
    {
        return true;
    }

    [Sirenix.OdinInspector.Button]
    public void MoveForward()
    {
        youTrans.transform.position += youTrans.forward;
    }

    [Sirenix.OdinInspector.Button]
    float DotProduct(Vector3 vec1, Vector3 vec2)
    {
        // float dotProduct = vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z;

        // Vector3 youToEnemy = youTrans.position - enemyTrans.position;
        // float dotProduct = youToEnemy.x * enemyTrans.forward.x + youToEnemy.y * enemyTrans.forward.y + youToEnemy.z * enemyTrans.forward.z;

        // Debug.Log("youToEnemy X: " + youToEnemy.x);
        // Debug.Log("enemyTrans.forward X: " + enemyTrans.forward.x);

        // Debug.Log("youToEnemy Y: " + youToEnemy.y);
        // Debug.Log("enemyTrans.forward Y: " + enemyTrans.forward.y);

        // Debug.Log("youToEnemy Z: " + youToEnemy.z);
        // Debug.Log("enemyTrans.forward Z: " + enemyTrans.forward.z);

        // // Debug.Log("Vector3.forward X: " + Vector3.forward.x);
        // // Debug.Log("Vector3.forward Y: " + Vector3.forward.y);
        // // Debug.Log("Vector3.forward Z: " + Vector3.forward.z);

        // Debug.Log("X: " + youToEnemy.x * enemyTrans.forward.x);
        // Debug.Log("Y: " + youToEnemy.y * enemyTrans.forward.y);
        // Debug.Log("Z: " + youToEnemy.z * enemyTrans.forward.z);

        float dotProduct = Vector3.Dot(vec1, vec2);

        // Debug.Log("Dot Product: " + dotProduct);

        return dotProduct;
    }

    // void OnDrawGizmos()
    // {
    //     Gizmos.color = Color.red;
    //     Gizmos.DrawLine(origin.position, enemyTrans.position);

    //     Gizmos.color = Color.green;
    //     Gizmos.DrawLine(origin.position, youTrans.position);
    // }

    [Button]
    public void GetProjectOnPlane()
    {
        Vector3 project = enemyTrans.position - originProject.position;
        Vector3 normal = Vector3.Cross(plane.forward, plane.right);

        // Debug.Log(project);
        // youTrans.position = Vector3.ProjectOnPlane(project, plane.position);
        // Debug.Log(Vector3.ProjectOnPlane(project, plane.position));

        youTrans.position = Vector3.ProjectOnPlane(project, plane.up);
        Debug.Log(Vector3.ProjectOnPlane(project, plane.up));
    }
}
