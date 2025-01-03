using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] GameObject AudioPlayObj;
    [SerializeField] AudioClip BGM;
    [SerializeField] float SEvol =1;
    [SerializeField] float BGMvol = 0.5f;

    AudioSource BgmSource;

    AudioPlay audioPlay;

    // Start is called before the first frame update
    void Start()
    {
        BgmSource = GetComponent<AudioSource>();
        BgmSource.volume = BGMvol;
        if (BGM != null)
        {
            BgmSource.clip = BGM;
            BgmSource.Play();
        }

        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void isPlaySE(AudioClip Clip)
    {
        GameObject CL_AudioPlay = Instantiate(AudioPlayObj);

        AudioPlay audio = CL_AudioPlay.GetComponent<AudioPlay>();
        audio.isPlaySE(Clip,SEvol);

        //CL_AudioPlay.isStatic = true;
        CL_AudioPlay.SetActive(true);

    }
}
