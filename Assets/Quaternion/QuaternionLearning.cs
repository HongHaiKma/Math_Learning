using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class QuaternionLearning : MonoBehaviour
{
    public Transform origin;
    public Transform target;

    private void Update()
    {
        TestRotate();
    }

    [Button]
    public void TestRotate()
    {
        Vector3 relativePos = target.position - origin.position;
        // origin.rotation = Quaternion.LookRotation(new Vector3(relativePos.x, 0f, relativePos.z), Vector3.right);
        origin.rotation = Quaternion.LookRotation(relativePos);
    }
}
