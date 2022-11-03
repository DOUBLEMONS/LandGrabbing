using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueBar : MonoBehaviour
{
    [SerializeField]
    private Slider AreaSlider;

    private float maxBlock = 100;
    private float curBlock = 100;

    // Start is called before the first frame update
    void Start()
    {
        AreaSlider.value = (float) curBlock / (float) maxBlock;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
