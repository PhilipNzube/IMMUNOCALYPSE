using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : NetworkBehaviour
{
    public PlayerHealth PH;
    public GameObject[] EnemyGO;
    public DroidPlayerHealth DPH;
    public Text ReviveDroidText;
    public Transform Player;
    public bool blink = false;
    public bool SpiderAlive = true;
    public bool EnemyAlive = true;
    public AudioSource PlayerHit;
    public bool PlayerAlive = true;
    public bool IsAK47UActive = false;
    public bool IsAK47Active = false;
    public bool IsPistolActive = false;
    public bool IsSniperActive = false;

    public GameObject SpawnedAK47UPoint;

    public Animator SWATAnimator;

    public bool LoadMission = false;

    public GameObject AK47U;
    public GameObject AK47;
    public GameObject AK47UAMOD;
    public GameObject AK47UKS;
    public GameObject MEGASHOT;

    public GameObject SVD;
    public GameObject SLP;
    public GameObject M40a3;
    public GameObject Ksvk;
    public GameObject ALPHARIFLE;

    public GameObject Glock;
    public GameObject M1911;
    public GameObject M1323;
    public GameObject WP01;
    public GameObject ULTRA;

    public bool NewPlayer;
    public GunManager GM;

    public GameObject AssultWeapon;
    public GameObject AssultWeapon2;
    public GameObject AssultWeapon3;
    public GameObject AssultWeapon4;
    public GameObject AssultWeapon5;
    public GameObject SniperWeapon;
    public GameObject SniperWeapon2;
    public GameObject SniperWeapon3;
    public GameObject SniperWeapon4;
    public GameObject SniperWeapon5;
    public GameObject PistolWeapon;
    public GameObject PistolWeapon2;
    public GameObject PistolWeapon3;
    public GameObject PistolWeapon4;
    public GameObject PistolWeapon5;

    public int AWMag;
    public int AW2Mag;
    public int AW3Mag;
    public int AW4Mag;
    public int AW5Mag;
    public int SWMag;
    public int SW2Mag;
    public int SW3Mag;
    public int SW4Mag;
    public int SW5Mag;
    public int PWMag;
    public int PW2Mag;
    public int PW3Mag;
    public int PW4Mag;
    public int PW5Mag;

    public AudioSource SwitchSound;
    public PlayerHeadShot PHS;

    void Start()
    {

        PH = GetComponent<PlayerHealth>();
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");

        if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
        {
            AWMag = AssultWeapon.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
        {
            AW2Mag = AssultWeapon2.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
        {
            AW3Mag = AssultWeapon3.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
        {
            AW4Mag = AssultWeapon4.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
        {
            AW5Mag = AssultWeapon5.GetComponent<GunController>().totalBullets;
        }

        if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
        {
            SWMag = SniperWeapon.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
        {
            SW2Mag = SniperWeapon2.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
        {
            SW3Mag = SniperWeapon3.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
        {
            SW4Mag = SniperWeapon4.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
        {
            SW5Mag = SniperWeapon5.GetComponent<GunController>().totalBullets;
        }

        if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
        {
            PWMag = PistolWeapon.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
        {
            PW2Mag = PistolWeapon2.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
        {
            PW3Mag = PistolWeapon3.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
        {
            PW4Mag = PistolWeapon4.GetComponent<GunController>().totalBullets;
        }
        else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
        {
            PW5Mag = PistolWeapon5.GetComponent<GunController>().totalBullets;
        }
    }

    public override void OnStartAuthority()
    {
        SpawnedAK47UPoint = GameObject.FindGameObjectWithTag("AK47USpawnPoint");
    }

    void OnTriggerEnter(Collider other)
    {
        if (hasAuthority == true)
        {
            if (other.gameObject.tag == "EnemyHands")
            {
                if (PlayerAlive == true)
                {

                }

                PH.TakeDamage(13.0f);
            }
            else if (other.gameObject.tag == "TitanHands")
            {
                if (PlayerAlive == true)
                {

                }

                PH.TakeDamage(200.0f);
            }
            else if (other.gameObject.tag == "Bullet")
            {

            }
            else if (other.gameObject.tag == "Knife")
            {
                PH.TakeDamage(25.0f);
            }
            else if (other.gameObject.tag == "fireball")
            {
                PH.TakeDamage(5.0f);
            }
            else if (other.gameObject.tag == "BossKnife")
            {
                PH.TakeDamage(100.0f);
            }
            else if (other.gameObject.tag == "AmmoBox")
            {
                if (NewPlayer == false)
                {

                }
                else
                {

                    if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
                    {
                        if (!AssultWeapon.GetComponent<GunController>().swapping! && AssultWeapon.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            AssultWeapon.GetComponent<GunController>().totalBullets = AWMag;
                            AssultWeapon.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().IsM1A1 == true)
                            {
                                AssultWeapon.GetComponent<GunController>().AmmoCollected = false;
                                if (AssultWeapon.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    AssultWeapon.GetComponent<GunController>().Reload();
                                    AssultWeapon.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
                    {
                        if (!AssultWeapon2.GetComponent<GunController>().swapping! && AssultWeapon2.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            AssultWeapon2.GetComponent<GunController>().totalBullets = AW2Mag;
                            AssultWeapon2.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().IsAKM == true)
                            {
                                AssultWeapon2.GetComponent<GunController>().AmmoCollected = false;
                                if (AssultWeapon2.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    AssultWeapon2.GetComponent<GunController>().Reload();
                                    AssultWeapon2.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
                    {
                        if (!AssultWeapon3.GetComponent<GunController>().swapping! && AssultWeapon3.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            AssultWeapon3.GetComponent<GunController>().totalBullets = AW3Mag;
                            AssultWeapon3.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().IsAK74U == true)
                            {
                                AssultWeapon3.GetComponent<GunController>().AmmoCollected = false;
                                if (AssultWeapon3.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    AssultWeapon3.GetComponent<GunController>().Reload();
                                    AssultWeapon3.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
                    {
                        if (!AssultWeapon4.GetComponent<GunController>().swapping! && AssultWeapon4.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            AssultWeapon4.GetComponent<GunController>().totalBullets = AW4Mag;
                            AssultWeapon4.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().IsM4A1 == true)
                            {
                                AssultWeapon4.GetComponent<GunController>().AmmoCollected = false;
                                if (AssultWeapon4.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    AssultWeapon4.GetComponent<GunController>().Reload();
                                    AssultWeapon4.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
                    {
                        if (!AssultWeapon5.GetComponent<GunController>().swapping! && AssultWeapon5.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            AssultWeapon5.GetComponent<GunController>().totalBullets = AW5Mag;
                            AssultWeapon5.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().IsM16A4 == true)
                            {
                                AssultWeapon5.GetComponent<GunController>().AmmoCollected = false;
                                if (AssultWeapon5.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    AssultWeapon5.GetComponent<GunController>().Reload();
                                    AssultWeapon5.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }

                    if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
                    {
                        if (!SniperWeapon.GetComponent<GunController>().swapping! && SniperWeapon.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            SniperWeapon.GetComponent<GunController>().totalBullets = SWMag;
                            SniperWeapon.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().isDRAGUNOVActive == true)
                            {
                                SniperWeapon.GetComponent<GunController>().AmmoCollected = false;
                                if (SniperWeapon.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    SniperWeapon.GetComponent<GunController>().Reload();
                                    SniperWeapon.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
                    {
                        if (!SniperWeapon2.GetComponent<GunController>().swapping! && SniperWeapon2.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            SniperWeapon2.GetComponent<GunController>().totalBullets = SW2Mag;
                            SniperWeapon2.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().isM40A3Active == true)
                            {
                                SniperWeapon2.GetComponent<GunController>().AmmoCollected = false;
                                if (SniperWeapon2.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    SniperWeapon2.GetComponent<GunController>().Reload();
                                    SniperWeapon2.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
                    {
                        if (!SniperWeapon3.GetComponent<GunController>().swapping! && SniperWeapon3.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            SniperWeapon3.GetComponent<GunController>().totalBullets = SW3Mag;
                            SniperWeapon3.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().isAWMActive == true)
                            {
                                SniperWeapon3.GetComponent<GunController>().AmmoCollected = false;
                                if (SniperWeapon3.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    SniperWeapon3.GetComponent<GunController>().Reload();
                                    SniperWeapon3.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
                    {
                        if (!SniperWeapon4.GetComponent<GunController>().swapping! && SniperWeapon4.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            SniperWeapon4.GetComponent<GunController>().totalBullets = SW4Mag;
                            SniperWeapon4.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().isBARRETTM82Active == true)
                            {
                                SniperWeapon4.GetComponent<GunController>().AmmoCollected = false;
                                if (SniperWeapon4.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    SniperWeapon4.GetComponent<GunController>().Reload();
                                    SniperWeapon4.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
                    {
                        if (!SniperWeapon5.GetComponent<GunController>().swapping! && SniperWeapon5.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            SniperWeapon5.GetComponent<GunController>().totalBullets = SW5Mag;
                            SniperWeapon5.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().isBARRETTMRADActive == true)
                            {
                                SniperWeapon5.GetComponent<GunController>().AmmoCollected = false;
                                if (SniperWeapon5.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    SniperWeapon5.GetComponent<GunController>().Reload();
                                    SniperWeapon5.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }

                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
                    {
                        if (!PistolWeapon.GetComponent<GunController>().swapping! && PistolWeapon.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            PistolWeapon.GetComponent<GunController>().totalBullets = PWMag;
                            PistolWeapon.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().isMAKAROVActive == true)
                            {
                                PistolWeapon.GetComponent<GunController>().AmmoCollected = false;
                                if (PistolWeapon.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    PistolWeapon.GetComponent<GunController>().Reload();
                                    PistolWeapon.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
                    {
                        if (!PistolWeapon2.GetComponent<GunController>().swapping! && PistolWeapon2.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            PistolWeapon2.GetComponent<GunController>().totalBullets = PW2Mag;
                            PistolWeapon2.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().isGLOCK19Active == true)
                            {
                                PistolWeapon2.GetComponent<GunController>().AmmoCollected = false;
                                if (PistolWeapon2.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    PistolWeapon2.GetComponent<GunController>().Reload();
                                    PistolWeapon2.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
                    {
                        if (!PistolWeapon3.GetComponent<GunController>().swapping! && PistolWeapon3.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            PistolWeapon3.GetComponent<GunController>().totalBullets = PW3Mag;
                            PistolWeapon3.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().isM1911Active == true)
                            {
                                PistolWeapon3.GetComponent<GunController>().AmmoCollected = false;
                                if (PistolWeapon3.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    PistolWeapon3.GetComponent<GunController>().Reload();
                                    PistolWeapon3.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
                    {
                        if (!PistolWeapon4.GetComponent<GunController>().swapping! && PistolWeapon4.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            PistolWeapon4.GetComponent<GunController>().totalBullets = PW4Mag;
                            PistolWeapon4.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().isUSP45Active == true)
                            {
                                PistolWeapon4.GetComponent<GunController>().AmmoCollected = false;
                                if (PistolWeapon4.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    PistolWeapon4.GetComponent<GunController>().Reload();
                                    PistolWeapon4.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
                    {
                        if (!PistolWeapon5.GetComponent<GunController>().swapping! && PistolWeapon5.GetComponent<GunController>().totalBullets == 0)
                        {
                            SwitchSound.Play();
                            PistolWeapon5.GetComponent<GunController>().totalBullets = PW5Mag;
                            PistolWeapon5.GetComponent<GunController>().AmmoCollected = true;
                            if (gameObject.GetComponent<GunManager>().isBARETTAM9Active == true)
                            {
                                PistolWeapon5.GetComponent<GunController>().AmmoCollected = false;
                                if (PistolWeapon5.GetComponent<GunController>().bulletsInMag == 0)
                                {
                                    PistolWeapon5.GetComponent<GunController>().Reload();
                                    PistolWeapon5.GetComponent<GunController>().AmmoCollected = false;
                                }
                            }
                            Destroy(other.gameObject, 1.0f);
                        }
                    }

                }
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "fireball")
        {
            PH.TakeDamage(5.0f);
        }
    }

}
