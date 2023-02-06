using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class TestParalell : MonoBehaviour
{
    public Transform origin;
    public Transform firePoint;
    public Transform target;

    public Vector3 forward;

    private void Update()
    {
        SetParalell();
    }

    // [Button]
    // public void SetVector()
    // {
    //     Debug.DrawRay(origin.position, origin.forward, Color.red);
    // }

    // [Button]
    // public void SetForward()
    // {
    //     forward = origin.forward * Mathf.Rad2Deg;
    // }

    [Button]
    public void SetParalell()
    {
        Vector3 aaa = firePoint.position - origin.forward;
        Vector3 originFoward = new Vector3(aaa.x, origin.position.y, aaa.z);
        // Debug.Log(originFoward);
        Vector3 point = aaa * 2f;

        // Ray ray = new Ray(origin.position, aaa);
        // Debug.DrawRay(origin.position, originFoward, Color.red);
        Debug.DrawRay(origin.position, origin.forward * 5f, Color.red);

        // Physics.Raycast

        // Debug.Log("Forward: " + originFoward);
        // target.position = new Vector3(originFoward.x, aaa.y, originFoward.z * 5f);
    }

    [Button]
    public void GetForward()
    {
        Debug.Log("Forward: " + origin.forward);
        Debug.Log("Forward: " + firePoint.forward);
        Debug.Log("Vector Forward: " + Vector3.forward);
    }

    [Button]
    public void TransformDirection()
    {
        // origin.TransformDirection();
        Debug.Log("TransformDirection: " + origin.TransformDirection(firePoint.position));
        Debug.Log("TransformDirection: " + origin.TransformPoint(firePoint.position));
        Debug.Log("TransformDirection: " + origin.TransformVector(firePoint.position));
    }
}
