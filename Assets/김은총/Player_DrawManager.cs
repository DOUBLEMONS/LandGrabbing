using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_DrawManager : MonoBehaviour
{
    private Camera Camera;
    [SerializeField] private LineRenderer LineRenderer;

    private LineRenderer CurrentLine;

    void Start()
    {
        Camera = Camera.main;
    }

    void Update()
    {
        
    }
}
