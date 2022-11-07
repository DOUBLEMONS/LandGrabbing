using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int folkloreScore = 0;
    public int modernityScore = 0;

    [SerializeField] private GameObject resultObj;
    [SerializeField] private RectTransform victoryImage;
    [SerializeField] private GameObject drawObj;

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;

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

    private void Start()
    {
        SoundManager.Instance.PlayBGMSound();
    }

    public void LoadResult()
    {
        if(folkloreScore > modernityScore)
        {
            victoryImage.anchoredPosition = new Vector2(-510, -245);
        }
        else if(folkloreScore < modernityScore)
        {
            victoryImage.anchoredPosition = new Vector2(510, -245);
        }
        else if(folkloreScore == modernityScore)
        {
            victoryImage.gameObject.SetActive(false);
            drawObj.SetActive(true);
        }

        resultObj.SetActive(true);
    }
    
    public void LoadRestart()
    {
        SceneManager.LoadScene("NomalGameScene");
    }

    public void LoadTitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
