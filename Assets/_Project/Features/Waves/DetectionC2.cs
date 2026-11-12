using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectionC2 : MonoBehaviour
{
	public Text ReviveDroidText;
	public bool AlmostDead=false;
	public DroidPlayerHealth DPH;
	public PlayerHealth PH;
	public Transform Player;

    void Start()
    {
     DPH=GetComponent<DroidPlayerHealth>();
    }

    void Update()
    {
		if(Vector3.Distance(Player.position,transform.position)>2){
		ReviveDroidText.text="";
			DPH.Tappable=false;
    }
}
}

