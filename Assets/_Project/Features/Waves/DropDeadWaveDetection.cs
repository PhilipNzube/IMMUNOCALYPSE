using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDeadWaveDetection : NetworkBehaviour
{
	public bool Die=false;

	public GameObject[] Enemy;
	public bool Dummy=false;
	public GameObject[] LightningPrefab;
	public LightningBoltScript LBS;

    void Start()
    {
    Enemy=GameObject.FindGameObjectsWithTag("Enemy");

    }

    void Update()
    {
		if(hasAuthority==true){
		if(Die==true){

			StartCoroutine(Light());

		}
    }
	}
private IEnumerator Light(){
	foreach(GameObject Enemies in Enemy){
	if(Vector3.Distance(Enemies.transform.position,transform.position)<10.0f){
		Enemies.GetComponent<EnemyHealth>().Die();
		 Die=false;
	foreach(GameObject Lightning in LightningPrefab){
Lightning.GetComponent<LightningBoltScript>().EndPosition=new Vector3(Enemies.transform.position.x,15f-(Enemies.transform.position.y),Enemies.transform.position.z);
				Lightning.GetComponent<LightningBoltScript>().ManualMode=false;
				yield return new WaitForSeconds(1.0f);
				Lightning.GetComponent<LightningBoltScript>().ManualMode=true;
	}
}
	}
	}
	}
