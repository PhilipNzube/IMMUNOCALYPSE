
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerAiming : NetworkBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public Animator anim;
    Transform chest;
    public float speedH = 4.0f;
    public float ChestSpeedH = 2.0f;
    public float speedV = 2.0f;
    private float yaw = 0.0f;
    private float ChestYaw = 0.0f;
    private float pitch = 0.0f;
    public Transform Player;
    public bool Look = true;
    public Transform Cam;
    public float CamRot;
    public bool Moving;
    public bool Looking;
    public PlayerHealth PH;

    void Start()
    {
        PH = GetComponent<PlayerHealth>();
        anim = GetComponent<Animator>();
        chest = anim.GetBoneTransform(HumanBodyBones.Chest);
        if (isClient == true && isServer == false)
        {
            Look = true;
        }
    }

    void LateUpdate()
    {
        if (hasAuthority == true)
        {
            if (Look == true)
            {
                if (Input.GetMouseButton(0))
                {
                    Looking = true;
                    Moving = false;

                    ChestYaw += ChestSpeedH * Input.GetAxis("Mouse X");
                    yaw += speedH * Input.GetAxis("Mouse X");
                    pitch -= speedV * Input.GetAxis("Mouse Y");
                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
                    {
                        pitch = Mathf.Clamp(pitch, -65.0f, 65.0f);
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
                    {
                        pitch = Mathf.Clamp(pitch, -65.0f, 65.0f);
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
                    {
                        pitch = Mathf.Clamp(pitch, -65.0f, 65.0f);
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
                    {
                        pitch = Mathf.Clamp(pitch, -65.0f, 65.0f);
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
                    {
                        pitch = Mathf.Clamp(pitch, -65.0f, 65.0f);
                    }
                    pitch = Mathf.Clamp(pitch, -65.0f, 65.0f);
                    CamRot = Mathf.Clamp(CamRot, -1.0f, 9.0f);

                    chest.eulerAngles = new Vector3(pitch, chest.eulerAngles.y, 0.0f);
                    Player.eulerAngles = new Vector3(0.0f, yaw, 0.0f);

                }
                else
                {
                    Looking = false;
                    if (Moving == false)
                    {
                        if (PH.CurrentHealth > 0)
                        {
                            chest.eulerAngles = new Vector3(pitch, chest.eulerAngles.y, 0.0f);
                        }
                        else
                        {
                            chest.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
                            Player.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);

                        }
                    }
                }
            }
        }
        else if (hasAuthority == false)
        {
            Debug.Log("NoAuthority");
        }

    }
}

