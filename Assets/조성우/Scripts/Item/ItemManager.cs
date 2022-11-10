using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField] public GameObject[] folkItemImage;
    [SerializeField] public GameObject[] modernItemImage;

    private static ItemManager _instance;

    public static ItemManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(ItemManager)) as ItemManager;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void GetFolkItem()
    {
        int RandomIndex = Random.Range(0,3);

        while(folkItemImage[RandomIndex].activeSelf)
        {
            RandomIndex = Random.Range(0, 3);
        }

        folkItemImage[RandomIndex].SetActive(true);
    }

    public void GetModernItem()
    {
        int RandomIndex = Random.Range(0, 3);

        while (modernItemImage[RandomIndex].activeSelf)
        {
            RandomIndex = Random.Range(0, 3);
        }

        modernItemImage[RandomIndex].SetActive(true);
    }

    public bool CheckUesingFolkItem()
    {
        int index = 0;

        for(int i = 0; i < folkItemImage.Length; i++)
        {
            if(folkItemImage[i].activeSelf)
            {
                index++;
            }
            else if(!folkItemImage[i].activeSelf)
            {
                break;
            }

            if(index == 3)
            {
                return false;
            }
        }

        return true;
    }

    public bool CheckUesingModernItem()
    {
        int index = 0;

        for (int i = 0; i < modernItemImage.Length; i++)
        {
            if (modernItemImage[i].activeSelf)
            {
                index++;
            }
            else if (!modernItemImage[i].activeSelf)
            {
                break;
            }

            if (index == 3)
            {
                return false;
            }
        }

        return true;
    }
}