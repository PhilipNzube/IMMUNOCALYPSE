using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BgMusicScript : MonoBehaviour
{
    public AudioSource BGMusic;

    void Awake()
    {
        GameObject[] music = GameObject.FindGameObjectsWithTag("BGMusicGO");
        if (music.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
