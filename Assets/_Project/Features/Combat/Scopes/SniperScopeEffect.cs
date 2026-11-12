using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperScopeEffect : MonoBehaviour
{
    public Animator anim;
    public bool IsSniperAiming = false;
    public GameObject ScopeOverlay;
    public GameObject WeaponSwitchImage;
    public GameObject WeaponCamera;
    public Camera MainCamera;
    public float ScopeFOV = 30.0f;
    public float NormalFOV;
    public SniperRecoil SR;
    public AudioSource ScopeSound;
    public CamRecoil CR;
    public GameObject CrossHair;

    public GameObject ScopeSlider;
    public bool Scoping = false;
    public GameObject ReloadImg;
    public GameObject SniperReloadImg;
    public GameObject PistolReloadImg;
    public GameObject GrenadeAmount;
    public GameObject Grenade;
    public AutoShoot AS;
    public GameObject PLH;
    public GameObject WS1;
    public GameObject WS1b;
    public GameObject WS1c;
    public GameObject WS1d;
    public GameObject WS1e;

    public Animator WS1Anim;
    public Animator WS1bAnim;
    public Animator WS1cAnim;
    public Animator WS1dAnim;
    public Animator WS1eAnim;
    public Animator WS2Anim;
    public Animator WS2bAnim;
    public Animator WS2cAnim;
    public Animator WS2dAnim;
    public Animator WS2eAnim;
    public Animator WS3Anim;
    public Animator WS3bAnim;
    public Animator WS3cAnim;
    public Animator WS3dAnim;
    public Animator WS3eAnim;

    public bool Reloading = false;
    public float PlayScopeSound = 0f;

    public bool IsAssultActive = true;
    public bool IsSniperActive = false;
    public bool IsPistolActive = false;

    public WASDMovementScript WASD;
    public FirstPersonControls FPC;

    void Start()
    {

        MainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        WeaponCamera = GameObject.FindGameObjectWithTag("WeaponCamera");
        AS = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AutoShoot>();
    }
    public void SniperAim()
    {
        IsSniperAiming = !IsSniperAiming;

        if (IsSniperAiming)
        {

            OnScoped();
        }
        else
        {

            UnScoped();
        }

    }
    public void OnScoped()
    {
        if (Reloading == false)
        {

            WASD.CanRun = false;
            FPC.CanRun = false;
            ScopeSound.Play();
            CrossHair.gameObject.SetActive(false);

            Scoping = true;
        }
    }
    public void UnScoped()
    {
        WASD.CanRun = true;
        FPC.CanRun = true;
        CrossHair.gameObject.SetActive(true);
        ScopeSound.Play();
        if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
        {
            MainCamera.fieldOfView = 60f;
            WS1Anim.SetBool("Scope", false);
        }
        else
        if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
        {
            MainCamera.fieldOfView = 60f;
            WS1bAnim.SetBool("Scope", false);
        }
        else
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
        {
            MainCamera.fieldOfView = 60f;
            WS1cAnim.SetBool("Scope", false);
        }
        else
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
        {
            MainCamera.fieldOfView = 60f;
            WS1dAnim.SetBool("Scope", false);
        }
        else
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
        {
            MainCamera.fieldOfView = 60f;
            WS1eAnim.SetBool("Scope", false);
        }

        if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
        {
            MainCamera.fieldOfView = 60f;
            WS2Anim.SetBool("Scope", false);
        }
        else
        if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
        {
            MainCamera.fieldOfView = 60f;
            WS2bAnim.SetBool("Scope", false);
        }
        else
            if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
        {
            MainCamera.fieldOfView = 60f;
            WS2cAnim.SetBool("Scope", false);
        }
        else
            if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
        {
            MainCamera.fieldOfView = 60f;
            WS2dAnim.SetBool("Scope", false);
        }
        else
            if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
        {
            MainCamera.fieldOfView = 60f;
            WS2eAnim.SetBool("Scope", false);
        }

        if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
        {
            MainCamera.fieldOfView = 60f;
            WS3Anim.SetBool("Scope", false);
        }
        else
        if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
        {
            MainCamera.fieldOfView = 60f;
            WS3bAnim.SetBool("Scope", false);
        }
        else
            if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
        {
            MainCamera.fieldOfView = 60f;
            WS3cAnim.SetBool("Scope", false);
        }
        else
            if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
        {
            MainCamera.fieldOfView = 60f;
            WS3dAnim.SetBool("Scope", false);
        }
        else
            if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
        {
            MainCamera.fieldOfView = 60f;
            WS3eAnim.SetBool("Scope", false);
        }

        Scoping = false;

    }
    public void afterreloadscope()
    {

        OnScoped();
    }

    void Update()
    {

        if (Reloading == false)
        {
            if (Scoping == true)
            {
                WASD.CanRun = false;
                FPC.CanRun = false;
                CrossHair.gameObject.SetActive(false);
                PlayScopeSound = 0f;
                if (IsPistolActive == false && IsSniperActive == false)
                {
                    if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
                    {

                        WS1Anim.SetBool("Scope", true);
                        MainCamera.fieldOfView = 55f;
                    }
                    else
                   if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
                    {
                        WS1bAnim.SetBool("Scope", true);
                        MainCamera.fieldOfView = 55f;
                    }
                    else
                       if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
                    {

                        WS1cAnim.SetBool("Scope", true);
                        MainCamera.fieldOfView = 35f;
                    }
                    else
                       if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
                    {
                        WS1dAnim.SetBool("Scope", true);
                        MainCamera.fieldOfView = 45f;
                    }
                    else
                       if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
                    {
                        WS1eAnim.SetBool("Scope", true);
                        MainCamera.fieldOfView = 30f;
                    }
                }
                else if (IsPistolActive == false && IsAssultActive == false)
                {

                    if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
                    {

                        WS2Anim.SetBool("Scope", true);
                        MainCamera.fieldOfView = 25f;
                    }
                    else
                    if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
                    {
                        WS2bAnim.SetBool("Scope", true);
                        MainCamera.fieldOfView = 20f;
                    }
                    else
                        if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
                    {
                        WS2cAnim.SetBool("Scope", true);
                        MainCamera.fieldOfView = 20f;
                    }
                    else
                        if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
                    {
                        WS2dAnim.SetBool("Scope", true);
                        MainCamera.fieldOfView = 35f;
                    }
                    else
                        if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
                    {
                        WS2eAnim.SetBool("Scope", true);
                        MainCamera.fieldOfView = 20f;
                    }
                }
                else if (IsAssultActive == false && IsSniperActive == false)
                {

                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
                    {
                        WS3Anim.SetBool("Scope", true);
                    }
                    else
                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
                    {
                        WS3bAnim.SetBool("Scope", true);
                    }
                    else
                        if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
                    {
                        WS3cAnim.SetBool("Scope", true);
                    }
                    else
                        if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
                    {
                        WS3dAnim.SetBool("Scope", true);
                    }
                    else
                        if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
                    {
                        WS3eAnim.SetBool("Scope", true);
                    }

                }
            }
        }
        else if (Reloading == true)
        {
            WASD.CanRun = false;
            FPC.CanRun = false;
            CrossHair.gameObject.SetActive(true);
            PlayScopeSound += 1f;
            if (PlayScopeSound == 1f)
            {
                ScopeSound.Play();
            }
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
            {
                MainCamera.fieldOfView = 60f;
                WS1Anim.SetBool("Scope", false);
            }
            else
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
            {
                MainCamera.fieldOfView = 60f;
                WS1bAnim.SetBool("Scope", false);
            }
            else
                if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
            {
                MainCamera.fieldOfView = 60f;
                WS1cAnim.SetBool("Scope", false);
            }
            else
                if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
            {
                MainCamera.fieldOfView = 60f;
                WS1dAnim.SetBool("Scope", false);
            }
            else
                if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
            {
                MainCamera.fieldOfView = 60f;
                WS1eAnim.SetBool("Scope", false);
            }

            if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
            {
                MainCamera.fieldOfView = 60f;
                WS2Anim.SetBool("Scope", false);
            }
            else
            if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
            {
                MainCamera.fieldOfView = 60f;
                WS2bAnim.SetBool("Scope", false);
            }
            else
                if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
            {
                MainCamera.fieldOfView = 60f;
                WS2cAnim.SetBool("Scope", false);
            }
            else
                if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
            {
                MainCamera.fieldOfView = 60f;
                WS2dAnim.SetBool("Scope", false);
            }
            else
                if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
            {
                MainCamera.fieldOfView = 60f;
                WS2eAnim.SetBool("Scope", false);
            }

            if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
            {
                MainCamera.fieldOfView = 60f;
                WS3Anim.SetBool("Scope", false);
            }
            else
            if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
            {
                MainCamera.fieldOfView = 60f;
                WS3bAnim.SetBool("Scope", false);
            }
            else
                if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
            {
                MainCamera.fieldOfView = 60f;
                WS3cAnim.SetBool("Scope", false);
            }
            else
                if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
            {
                MainCamera.fieldOfView = 60f;
                WS3dAnim.SetBool("Scope", false);
            }
            else
                if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
            {
                MainCamera.fieldOfView = 60f;
                WS3eAnim.SetBool("Scope", false);
            }
        }
    }
}
