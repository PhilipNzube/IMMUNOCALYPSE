using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK47ScopeEffect : MonoBehaviour
{
	public Animator anim;
	public Animator anim2;
	public bool IsAK47Aiming=false;
	public GameObject WeaponCamera;
	public Camera MainCamera;
	public float ScopeFOV=30f;
	public float NormalFOV;
	public GameObject WeaponSwitchImage;
	public AK47Recoil AR;
	public AudioSource ScopeSound;
	public CamRecoil CR;
	public GameObject CrossHair;

    void Start()
    {

     anim=GetComponent<Animator>();
    }
	public void AK47Aim(){
		IsAK47Aiming=!IsAK47Aiming;
		anim.SetBool("AK47Scoped",IsAK47Aiming);
		if(IsAK47Aiming){
			ScopeSound.Play();
			AR.aiming=true;
			CR.aiming=true;
			StartCoroutine(OnScoped());
		}else{
			AR.aiming=false;
			CR.aiming=false;
			UnScoped();
		}

	}
	public IEnumerator OnScoped(){
		yield return new WaitForSeconds(.15f);
		CrossHair.gameObject.SetActive(false);
		WeaponSwitchImage.gameObject.SetActive(false);
		NormalFOV=MainCamera.fieldOfView;
		MainCamera.fieldOfView=ScopeFOV;
	}
	public void UnScoped(){
		CrossHair.gameObject.SetActive(true);
		ScopeSound.Play();
		WeaponSwitchImage.gameObject.SetActive(true);
		MainCamera.fieldOfView=NormalFOV;
	}
	public void afterreloadscope(){
		StartCoroutine(OnScoped());
	}

    void Update()
    {

    }
}
