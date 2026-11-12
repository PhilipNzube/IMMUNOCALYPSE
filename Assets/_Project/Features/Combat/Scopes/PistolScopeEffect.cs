using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolScopeEffect : MonoBehaviour
{
	public Animator anim;
	public bool IsPistolAiming=false;
	public GameObject WeaponCamera;
	public Camera MainCamera;
	public float ScopeFOV=15f;
	public float NormalFOV;
	public GameObject WeaponSwitchImage;
	public PistolRecoil PR;
	public AudioSource ScopeSound;
	public CamRecoil CR;
	public GameObject CrossHair;

    void Start()
    {

     anim=GetComponent<Animator>();
    }
	public void PistolAim(){
		IsPistolAiming=!IsPistolAiming;
		anim.SetBool("PistolScoped",IsPistolAiming);
		if(IsPistolAiming){
			ScopeSound.Play();
			PR.aiming=true;
			CR.aiming=true;
			StartCoroutine(OnScoped());
		}else{
			PR.aiming=false;
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
