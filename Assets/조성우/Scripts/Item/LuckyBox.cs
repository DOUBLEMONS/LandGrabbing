using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuckyBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player1") && ItemManager.Instance.CheckUesingFolkItem())
        {
            SoundManager.Instance.PlaySFXSound("ItemEat");
            ItemManager.Instance.GetFolkItem();
            ItemManager.Instance.MakeItemBox();
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player2") && ItemManager.Instance.CheckUesingModernItem())
        {
            SoundManager.Instance.PlaySFXSound("ItemEat");
            ItemManager.Instance.GetModernItem();
            ItemManager.Instance.MakeItemBox();
            Destroy(gameObject);
        }
    }
}
