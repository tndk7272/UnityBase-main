using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GzmoTest : MonoBehaviour
{
    public float distance = 1;
    public bool DrawShpere = true;
    public bool DrawWireSphere = true;
    public bool DrawWireCube = true;
    public bool DrawRay = true;
    public bool DrawIcon = true;
    public bool DrawFrustum = true;


    private void OnDrawGizmosSelected() //Soldier_demo 를 선택하면 그려진다
    {
        if (DrawWireSphere)
            Gizmos.DrawWireSphere(transform.position, distance);

        if (DrawWireSphere)
            Gizmos.DrawWireSphere(transform.position, distance);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;


        // Vector3.one == new Vector3(1, 1, 1)
        if (DrawWireCube)
            Gizmos.DrawWireCube(transform.position, Vector3.one * distance);

        if (DrawRay)
            Gizmos.DrawRay(transform.position, transform.position);

        if (DrawIcon)
            Gizmos.DrawIcon(transform.position, "testIcon.png");

        /*if (DrawFrustum)
            Gizmos.DrawIcon(transform.position, 60, );*/





    }
}
