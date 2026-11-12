using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenDropDeadWaveDetection : MonoBehaviour
{
	public bool Die=false;

	public GameObject[] Enemy;
	public bool Dummy=false;

    void Start()
    {

     Enemy=GameObject.FindGameObjectsWithTag("Spider");

    }

    void Update()
    {
		if(Die==true){

foreach(GameObject Enemies in Enemy){
	if(Vector3.Distance(Enemies.transform.position,transform.position)<10.0f){
			 Enemies.GetComponent<QueenEnemyChaseScript>().Death();
			 Die=false;
		}
    }
}
}
	}
