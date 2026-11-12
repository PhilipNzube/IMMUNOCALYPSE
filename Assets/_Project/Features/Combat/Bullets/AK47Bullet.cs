using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AK47Bullet : MonoBehaviour
{
	public Rigidbody rbody;
	public float lifeTime;
	public ParticleSystem SandyBulletHolePrefab;
	public ParticleSystem ConcreteBulletHolePrefab;
	public ParticleSystem MetallicBulletHolePrefab;
	public ParticleSystem WoodenBulletHolePrefab;
	public ParticleSystem ImpactPrefab;
	public GameObject ImpactPoint;

    void Start()
    {

    }

	public void Activate(Vector3 position, Vector3 velocity){
		transform.position=position;
		rbody.velocity=velocity;
		gameObject.SetActive(true);
		StartCoroutine("Decay");
	}
	private IEnumerator Decay(){
		yield return new WaitForSeconds(lifeTime);
		Deactivate();
	}
	public void Deactivate(){

		StopAllCoroutines();
		gameObject.SetActive(false);
	}

    void Update()
    {

    }
}
