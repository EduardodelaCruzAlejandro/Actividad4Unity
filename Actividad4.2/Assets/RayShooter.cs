using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{

    private int count;
    // Start is called before the first frame update
    void Update()
    {
        Ray ray = new Ray(transform.position, Vector3.left);
        if (Physics.Raycast(ray))
        {
            print(count++);
        }
    }

    // Update is called once per frame
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, Vector3.left);
    }
}
