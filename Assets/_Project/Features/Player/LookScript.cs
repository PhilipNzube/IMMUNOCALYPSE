using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookScript : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    public bool Look = true;
    public Transform Soldier;
    public PlayerAiming PA;
    public GameObject Target;

    void Start()
    {

    }

    void Update()
    {
        if (Look == true)
        {
            if (Input.GetMouseButton(0))
            {
                PA.enabled = false;
                Vector3 targetPos = new Vector3(Target.transform.position.x, 15f - (Target.transform.position.y), Target.transform.position.z);

                yaw += speedH * Input.GetAxis("Mouse X");
                pitch -= speedV * Input.GetAxis("Mouse Y");
                pitch = Mathf.Clamp(pitch, -80.0f, 80.0f);
                Soldier.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
            }
            else
            {

            }
        }
    }
}

