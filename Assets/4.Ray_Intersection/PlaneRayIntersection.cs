using UnityEngine;

public class PlaneRayIntersection : MonoBehaviour
{
    // public LineRenderer lineRenderer;
    // public Transform youTrans;
    // public Transform planeTrans;

    // void Update()
    // {
    //     //Math from http://www.scratchapixel.com/lessons/3d-basic-rendering/minimal-ray-tracer-rendering-simple-shapes/ray-plane-and-ray-disk-intersection

    //     //A plane can be defined as:
    //     //a point representing how far the plane is from the world origin
    //     Vector3 p_0 = planeTrans.position;
    //     //a normal (defining the orientation of the plane), should be negative if we are firing the ray from above
    //     Vector3 n = -planeTrans.up;
    //     //We are intrerested in calculating a point in this plane called p
    //     //The vector between p and p0 and the normal is always perpendicular: (p - p_0) . n = 0

    //     //A ray to point p can be defined as: l_0 + l * t = p, where:
    //     //the origin of the ray
    //     Vector3 l_0 = youTrans.position;
    //     //l is the direction of the ray
    //     Vector3 l = youTrans.forward;
    //     //t is the length of the ray, which we can get by combining the above equations:
    //     //t = ((p_0 - l_0) . n) / (l . n)

    //     //But there's a chance that the line doesn't intersect with the plane, and we can check this by first
    //     //calculating the denominator and see if it's not small. 
    //     //We are also checking that the denominator is positive or we are looking in the opposite direction
    //     float denominator = Vector3.Dot(l, n);

    //     if (denominator > 0.00001f)
    //     {
    //         //The distance to the plane
    //         float t = Vector3.Dot(p_0 - l_0, n) / denominator;

    //         //Where the ray intersects with a plane
    //         Vector3 p = l_0 + l * t;

    //         //Display the ray with a line renderer
    //         lineRenderer.SetPosition(0, p);
    //         lineRenderer.SetPosition(1, l_0);
    //     }
    //     else
    //     {
    //         Debug.Log("No intersection");
    //     }
    // }

    public int rayLength = 10;

    public Transform posDown;

    private void Update()
    {
        RaycastHit hit;
        RaycastHit hitDown;

        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * rayLength, Color.red);

        Ray rayDown = new Ray(transform.position, posDown.position - transform.position);
        Debug.DrawRay(transform.position, (posDown.position - transform.position) * rayLength, Color.yellow);

        Vector3 posDownHit = Vector3.zero;

        if (Physics.Raycast(rayDown, out hitDown, rayLength))
        {
            posDownHit = hitDown.point;
        }

        if (Physics.Raycast(ray, out hit, rayLength))
        {
            Vector3 dir = Vector3.ProjectOnPlane(transform.forward, hit.normal);
            Debug.DrawRay(hit.point, dir * rayLength, Color.green);
            // Vector3 dir2 = hit.point - posDownHit;
            // Debug.DrawRay(posDownHit, dir2, Color.cyan);
        }
    }
}
