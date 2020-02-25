using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public LineRenderer LR;
    public GameObject Tri;
    public GameObject Tri2;
  
    private void Update()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);

        if (hit)
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);

            Debug.DrawLine(hit.point, hit.normal * 100f, Color.red);

          
        }
        else
        {
            Debug.DrawRay(transform.position, transform.up * 100f, Color.red);
        }

        LR.SetPosition(0, Tri.transform.position);
        LR.SetPosition(1, Tri2.transform.position);
        
    }
}
