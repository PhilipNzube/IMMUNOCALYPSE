using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorScript : MonoBehaviour
{
    public GameObject PlayerGO;
    public Animator DoorAnim;
    public AudioSource DoorOpenedOrClosedSoundGO;
    public float Open = 0.0f;
    public float Close = 0.0f;

    void Start()
    {
        DoorOpenedOrClosedSoundGO = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Close = 0.0f;
            Open += 1.0f;
            if (Open == 1.0f)
            {
                DoorOpenedOrClosedSoundGO.Play();
                DoorAnim.SetBool("character_nearby", true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Open = 0.0f;
            Close += 1.0f;
            if (Close == 1.0f)
            {
                DoorOpenedOrClosedSoundGO.Play();
                DoorAnim.SetBool("character_nearby", false);
            }
        }
    }

}
