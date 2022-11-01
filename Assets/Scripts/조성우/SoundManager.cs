using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;

    public static SoundManager Instance
    {
        get
        {

            if (instance == null)
            {
                instance = FindObjectOfType<SoundManager>();
            }

            return instance;
        }
    } // Sound�� �������ִ� ��ũ��Ʈ�� �ϳ��� �����ؾ��ϰ� instance������Ƽ�� ���� ��𿡼��� �ҷ��������� �̱��� ���

    [Header("��������� ������ AudioSource�� ȿ������ ������ AudioSource�� SoundManager�� �ڽ� ������Ʈ�� ����")]

    private AudioSource bgmPlayer;
    private AudioSource sfxPlayer;

    [SerializeField] private float masterVolumeSFX = 1f;
    [SerializeField] private float masterVolumeBGM = 1f;

    [SerializeField]
    private AudioClip mainSceneBgmAudioClip; //����ȭ�鿡�� ����� BGM
    [SerializeField]
    private AudioClip gameSceneBgmAudioClip; //���Ӿ����� ����� BGM

    [SerializeField]
    private AudioClip[] sfxAudioClips; //ȿ������ ����

    Dictionary<string, AudioClip> audioClipsDic = new Dictionary<string, AudioClip>(); //ȿ���� ��ųʸ�
    // AudioClip�� Key,Value ���·� �����ϱ� ���� ��ųʸ� ���

    private void Awake()
    {
        if (Instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject); //���� ������ ����� ��.

        bgmPlayer = transform.GetChild(0).GetComponent<AudioSource>();
        sfxPlayer = transform.GetChild(1).GetComponent<AudioSource>();

        foreach (AudioClip audioclip in sfxAudioClips)
        {
            audioClipsDic.Add(audioclip.name, audioclip);
        }
    }

    // ȿ�� ���� ��� : �̸��� �ʼ� �Ű�����, ������ ������ �Ű������� ����
    public void PlaySFXSound(string name, float volume = 1f)
    {
        if (audioClipsDic.ContainsKey(name) == false)
        {
            Debug.Log(name + " is not Contained audioClipsDic");
            return;
        }
        sfxPlayer.PlayOneShot(audioClipsDic[name], volume * masterVolumeSFX);
    }

    //BGM ���� ��� : ������ ������ �Ű������� ����
    public void PlayBGMSound(float volume = 1f)
    {
        bgmPlayer.loop = true; //BGM �����̹Ƿ� ��������
        bgmPlayer.volume = volume * masterVolumeBGM;

        //���ξ������� ��� ���
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            bgmPlayer.clip = mainSceneBgmAudioClip;
            bgmPlayer.Play();
        }
        //���Ӿ������� ��� ���
        else if (SceneManager.GetActiveScene().name == "GameScene")
        {
            bgmPlayer.clip = gameSceneBgmAudioClip;
            bgmPlayer.Play();
        }
        //���� ���� �´� BGM ���
    }
}
