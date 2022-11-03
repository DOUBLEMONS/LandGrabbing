using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float setTime = 10.0f;
    [SerializeField] Text countdownText;

    void Start()
    {
        countdownText.text = setTime.ToString();
    }

    void Update()
    {
        setTime -= Time.deltaTime;
        countdownText.text = Mathf.Round(setTime).ToString();
    }
}
