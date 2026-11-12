using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look2 : MonoBehaviour
{
	public float speedH=2.0f;
	public float speedV=2.0f;
	private float yaw=0.0f;
	private float pitch=0.0f;
	public bool Look=true;
	public Transform Soldier;
	public Transform Soldier2;
	public PlayerAiming PA;

    void Start()
    {

    }

    void Update()
    {
		if(Look==true){
			if(Input.GetMouseButton(0)){

     yaw+=speedH*Input.GetAxis("Mouse X");
pitch-=speedV*Input.GetAxis("Mouse Y");
pitch=Mathf.Clamp(pitch, -25.0f, 25.0f);
yaw=Mathf.Clamp(pitch, -75.0f, 75.0f);
Soldier.eulerAngles=new Vector3(pitch, yaw, 0.0f);

			}
		}
	}
    }

