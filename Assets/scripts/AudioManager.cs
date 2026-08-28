using UnityEngine;

using UnityEngine;

public class AudioManeger : MonoBehaviour
{
    public static AudioManeger instance;

    [SerializeField] private AudioSource ambientSource;
    [SerializeField] private AudioClip ambientClip;

    void Awake()
    {
        AudioListener.volume = 1f;


        instance = this;
        DontDestroyOnLoad(gameObject);

        ambientSource.clip = ambientClip;
        ambientSource.loop = true;
    }
}