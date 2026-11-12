using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperGun : MonoBehaviour
{
	public Animator anim;
	public string animatorParam="aiming";
	public Camera cam;
	public float defaultFOV, aimingFOV;
	public float aimSpeed=0.2f;
	public bool enableScope;
	public GameObject SniperRenderer;
	public GameObject scopeOverlay;
	public GameObject CrossHair;

    void Start()
    {
     if(!SniperRenderer||!scopeOverlay) enableScope=true;
    }

    void Update()
    {

    }
	private IEnumerator Aim(bool isAiming){
		float blendValue=0, timeElapsed=0;
		if(enableScope){
			SniperRenderer.SetActive(true);
			scopeOverlay.SetActive(false);
		}
		while(timeElapsed < aimSpeed){
			blendValue=timeElapsed/aimSpeed;
			if(isAiming){
				anim.SetFloat(animatorParam, blendValue);
				cam.fieldOfView=Mathf.Lerp(aimingFOV, defaultFOV, 1-blendValue);
			}
			else
			{
				anim.SetFloat(animatorParam, 1-blendValue);
				cam.fieldOfView=Mathf.Lerp(aimingFOV, defaultFOV, blendValue);
			}
			timeElapsed+=Time.deltaTime;
			yield return null;
		}
		if(enableScope){
			SniperRenderer.SetActive(!isAiming);
			scopeOverlay.SetActive(isAiming);
			CrossHair.SetActive(true);
		}
		if(isAiming){
			anim.SetFloat(animatorParam, 1);
			cam.fieldOfView=aimingFOV;
		}
	}
	public void OnAim(bool state){
		StopAllCoroutines();
		StartCoroutine(Aim(state));
	}

}
