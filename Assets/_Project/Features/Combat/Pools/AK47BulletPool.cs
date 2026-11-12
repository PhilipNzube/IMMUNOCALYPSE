using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AK47BulletPool : MonoBehaviour
{
	public static AK47BulletPool main;
	public GameObject AK47bulletPrefab;
	public int poolSize=100;
	private List<Bullet> availableBullets;

    private void Awake()
    {
      main=this;
    }
    private void Start(){
		availableBullets=new List<Bullet>();
		for(int i=0; i < poolSize; i++){
			Bullet b=Instantiate(AK47bulletPrefab,transform).GetComponent<Bullet>();
			b.gameObject.SetActive(false);
			availableBullets.Add(b);
		}
	}
	public void PickFromPool(Vector3 position, Vector3 velocity, Vector3 playerpos){
		if(availableBullets.Count<1) return;
		availableBullets[0].Activate(position, velocity, playerpos);
		availableBullets.RemoveAt(0);
	}
	public void AddToPool(Bullet bullet){
		if(!availableBullets.Contains(bullet)) availableBullets.Add(bullet);
	}

}
