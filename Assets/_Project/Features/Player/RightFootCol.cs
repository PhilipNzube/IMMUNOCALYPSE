using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFootCol : MonoBehaviour
{
    public AudioClip[] GrassWalkClip;
    public AudioSource WalkSound;

    void Start()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "GrassTerrain")
        {
            AudioClip clip = GetRandomClip();
            WalkSound.PlayOneShot(clip);
        }
    }

    public AudioClip GetRandomClip()
    {
        return GrassWalkClip[UnityEngine.Random.Range(0, GrassWalkClip.Length)];
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "GrassTerrain")
        {
            StartCoroutine(Walk());
        }
    }

    private IEnumerator Walk()
    {
        yield return new WaitForSeconds(1.0f);
        WalkSound.Stop();
    }

}
