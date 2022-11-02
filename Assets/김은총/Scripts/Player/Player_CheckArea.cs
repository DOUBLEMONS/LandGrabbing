using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_CheckArea : MonoBehaviour
{
    //Raycast
    [SerializeField]
    GameObject face;

    [SerializeField]
    Transform castPoint;

    [SerializeField]
    float agroRange;

    bool isFacingLeft;

    void Start()
    {

    }

    void Update()
    {
        CollisionDetection(agroRange);
    }

    //Raycast
    bool CollisionDetection(float distance)
    {
        bool val = false;
        float canDist = distance;
        float canDistWithFloor = distance;

        if (isFacingLeft)
        {
            canDist = -distance;
            canDistWithFloor = -distance;
        }

        Vector2 endPosdown = castPoint.position + Vector3.down * distance;

        RaycastHit2D hitdown = Physics2D.Linecast(transform.position, endPosdown, 1 << LayerMask.NameToLayer("Wall"));

        Vector2 endPosleft = castPoint.position + Vector3.left * distance;

        RaycastHit2D hitleft = Physics2D.Linecast(transform.position, endPosleft, 1 << LayerMask.NameToLayer("Wall"));

        Vector2 endPosright = castPoint.position + Vector3.right * distance;

        RaycastHit2D hitright = Physics2D.Linecast(transform.position, endPosright, 1 << LayerMask.NameToLayer("Wall"));

        Vector2 endPosup = castPoint.position + Vector3.up * distance;

        RaycastHit2D hitup = Physics2D.Linecast(transform.position, endPosup, 1 << LayerMask.NameToLayer("Wall"));

        if (hitleft.collider != null)
        {
            //Ray
            Debug.DrawLine(castPoint.position, hitleft.point, Color.yellow);
        }
        else if(hitleft.collider == null)
        {
            //Ray
            Debug.DrawLine(castPoint.position, endPosleft, Color.blue);
        }

        if (hitright.collider != null)
        {
            //Ray
            Debug.DrawLine(castPoint.position, hitright.point, Color.yellow);
        }
        else if(hitright.collider == null)
        {
            //Ray
            Debug.DrawLine(castPoint.position, endPosright, Color.blue);
        }


        if (hitup.collider != null)
        {
            //Ray
            Debug.DrawLine(castPoint.position, hitup.point, Color.yellow);
        }
        else if (hitup.collider == null)
        {
            //Ray
            Debug.DrawLine(castPoint.position, endPosup, Color.blue);
        }

        if (hitdown.collider != null)
        {
            //Ray
            Debug.DrawLine(castPoint.position, hitdown.point, Color.yellow);
        }
        else if (hitdown.collider == null)
        {
            //Ray
            Debug.DrawLine(castPoint.position, endPosdown, Color.blue);
        }

        return val;
    }
}
