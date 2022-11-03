using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block_ChangeSprite : MonoBehaviour
{
    public Sprite[] sprites = new Sprite[3];
    SpriteRenderer SpriteRenderer;

    [SerializeField]
    private Slider AreaSlider;

    private float maxBlock = 100;
    private float curBlock = 100;

    void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer.sprite = sprites[0];
    }

    void Start()
    {
        AreaSlider.value = (float)curBlock / (float)maxBlock;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player1")
        {
            SpriteRenderer.sprite = sprites[1];

            //�μ��� ���� �϶�

            if (SpriteRenderer.sprite != sprites[1])
            {
                //���� �߰�
            }
        }
        
        if(other.gameObject.tag == "Player2")
        {
            SpriteRenderer.sprite = sprites[2];

            //�μ��� ���� �϶�

            if (SpriteRenderer.sprite != sprites[2])
            {
                //���� ���
            }
        }
    }
}
