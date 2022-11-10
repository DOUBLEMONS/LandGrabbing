using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuckyBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player1") && ItemManager.Instance.CheckUesingFolkItem())
        {
            ItemManager.Instance.GetFolkItem();
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player2") && ItemManager.Instance.CheckUesingModernItem())
        {
            ItemManager.Instance.GetModernItem();
            Destroy(gameObject);
        }
    }
}
