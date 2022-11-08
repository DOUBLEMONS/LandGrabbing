using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Move : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float playerLotation;

    public Transform MovePoint;
    
    public LayerMask WhatStopMovement;

    public bool canMove = true;

    void Start()
    {
        MovePoint.parent = null;
    }

    void Update()
    {
        if (canMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, MovePoint.position, MoveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, MovePoint.position) <= .05f)
            {
                if (!Physics2D.OverlapCircle(MovePoint.position + new Vector3(Input.GetAxisRaw("AD"), 0f, 0f), 0.25f, WhatStopMovement))
                {
                    if (Mathf.Abs(Input.GetAxisRaw("AD")) == 1f)
                    {
                        if (Input.GetKey(KeyCode.A)) 
                        {
                            MovePoint.position -= new Vector3(1.0f, 0.0f, 0.0f);
                            playerLotation = 90;
                        }
                        if (Input.GetKey(KeyCode.D)) 
                        {
                            MovePoint.position += new Vector3(1.0f, 0.0f, 0.0f);
                            playerLotation = -90;
                        }
                    }
                }
                else if (!Physics2D.OverlapCircle(MovePoint.position + new Vector3(0f, Input.GetAxisRaw("WS"), 0f), 0.25f, WhatStopMovement))
                {
                    if (Mathf.Abs(Input.GetAxisRaw("WS")) == 1f)
                    {
                        if (Input.GetKey(KeyCode.W))
                        {
                            MovePoint.position += new Vector3(0.0f, 1.0f, 0.0f);
                            playerLotation = 0;
                        }
                        if (Input.GetKey(KeyCode.S))
                        {
                            MovePoint.position -= new Vector3(0.0f, 1.0f, 0.0f);
                            playerLotation = 180;
                        }
                    }
                }
            }
        }

    }
}
