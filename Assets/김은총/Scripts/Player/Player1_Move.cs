using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Move : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public Transform MovePoint;

    public LayerMask WhatStopMovement;

    void Start()
    {
        MovePoint.parent = null;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, MovePoint.position, MoveSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position, MovePoint.position) <= .05f)
        {
            if (!Physics2D.OverlapCircle(MovePoint.position + new Vector3(Input.GetAxisRaw("AD"), 0f, 0f), .2f, WhatStopMovement))
            {
                if (Mathf.Abs(Input.GetAxisRaw("AD")) == 1f)
                {
                    if (Input.GetKey(KeyCode.A)) // 왼쪽
                    {
                        MovePoint.position -= new Vector3(1.0f, 0.0f, 0.0f);
                        //Debug.Log("확인");
                    }
                    if (Input.GetKey(KeyCode.D)) // 오른쪽
                    {
                        MovePoint.position += new Vector3(1.0f, 0.0f, 0.0f);
                        //Debug.Log("확인");
                    }
                }
            }
            else if (!Physics2D.OverlapCircle(MovePoint.position + new Vector3(0f, Input.GetAxisRaw("WS"), 0f), .2f, WhatStopMovement))
            {
                if (Mathf.Abs(Input.GetAxisRaw("WS")) == 1f)
                {
                    if (Input.GetKey(KeyCode.W))
                    {
                        MovePoint.position += new Vector3(0.0f, 1.0f, 0.0f);
                    }
                    if (Input.GetKey(KeyCode.S))
                    {
                        MovePoint.position -= new Vector3(0.0f, 1.0f, 0.0f);
                    }
                }
            }
        }
    }
}
