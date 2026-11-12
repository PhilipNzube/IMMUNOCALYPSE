using System.Collections;
using UnityEngine;

public abstract class WeaponScopeBase : MonoBehaviour, IScope
{
    public Animator anim;
    public Animator anim2;
    public bool IsAiming = false;
    public GameObject WeaponCamera;
    public Camera MainCamera;
    public float ScopeFOV = 30f;
    public float NormalFOV;
    public GameObject WeaponSwitchImage;
    public AudioSource ScopeSound;
    public CamRecoil CR;
    public GameObject CrossHair;

    public bool IsScoped => IsAiming;

    protected virtual void Start()
    {
        if (anim == null) anim = GetComponent<Animator>();
        if (MainCamera != null) NormalFOV = MainCamera.fieldOfView;
    }

    public virtual void ToggleScope()
    {
        IsAiming = !IsAiming;
        if (anim != null) anim.SetBool("Scoped", IsAiming);
        if (IsAiming)
        {
            if (ScopeSound != null) ScopeSound.Play();
            if (CR != null) CR.aiming = true;
            StartCoroutine(OnScopedRoutine());
        }
        else
        {
            if (CR != null) CR.aiming = false;
            OnUnscoped();
        }
    }

    protected virtual IEnumerator OnScopedRoutine()
    {
        yield return new WaitForSeconds(0.15f);
        if (CrossHair != null) CrossHair.SetActive(false);
        if (WeaponSwitchImage != null) WeaponSwitchImage.SetActive(false);
        if (MainCamera != null)
        {
            NormalFOV = MainCamera.fieldOfView;
            MainCamera.fieldOfView = ScopeFOV;
        }
    }

    protected virtual void OnUnscoped()
    {
        if (CrossHair != null) CrossHair.SetActive(true);
        if (ScopeSound != null) ScopeSound.Play();
        if (WeaponSwitchImage != null) WeaponSwitchImage.SetActive(true);
        if (MainCamera != null) MainCamera.fieldOfView = NormalFOV;
    }
}
