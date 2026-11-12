using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyCollisionDetection : NetworkBehaviour
{
    public EnemyHealth EH;
    public EnemyChaseScript ECS;
    public EnemyHeadShot EHS;
    public Bullet Bullet;
    public Animator anim;
    Vector3 destination;
    public NavMeshAgent agent;
    public float EnemyHit = 0f;
    public GameObject Player;
    public ParticleSystem RFire;
    public ParticleSystem LFire;
    public ParticleSystem HFire;
    public bool MeleeKill = false;
    public bool AssultKill = false;
    public bool SniperKill = false;
    public bool PistolKill = false;

    public typewriter2 TW2;
    public int FreezePlayerNo = 0;
    public WASDMovementScript WMS;
    public FirstPersonControls FPC;
    public PlayerAiming PA;
    public PlayerHealth PH;

    public EnemyDissolveOverTime ED;
    public GunManager GM;
    public bool NewPlayer;

    void Start()
    {
        destination = agent.destination;
        Player = GameObject.FindGameObjectWithTag("Player");

        TW2 = GameObject.FindGameObjectWithTag("Player").GetComponent<typewriter2>();

        anim = GetComponent<Animator>();

        if (NewPlayer == false)
        {

            WMS = Player.GetComponent<WASDMovementScript>();
            FPC = Player.GetComponent<FirstPersonControls>();
            PA = Player.GetComponent<PlayerAiming>();
            PH = Player.GetComponent<PlayerHealth>();

        }
        else
        if (NewPlayer == true)
        {
            GM = Player.GetComponent<GunManager>();
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {

            ECS.DodgeGrenade = false;
            ECS.Lock = true;
            ECS.m_IsPatrol = false;
            ECS.Chase = true;

            if (NewPlayer == false)
            {

            }
            else if (NewPlayer == true)
            {
                if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
                {
                    if (GM.isMAKAROVActive == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 5)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 5 || FreezePlayerNo > 5)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 5)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 5 || FreezePlayerNo > 5)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        PistolKill = true;
                        SniperKill = false;
                        AssultKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(500.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
                {
                    if (GM.isGLOCK19Active == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 5)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 5 || FreezePlayerNo > 5)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 5)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 5 || FreezePlayerNo > 5)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        PistolKill = true;
                        SniperKill = false;
                        AssultKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(1000.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
                {
                    if (GM.isM1911Active == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 5)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 5 || FreezePlayerNo > 5)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 5)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 5 || FreezePlayerNo > 5)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        PistolKill = true;
                        SniperKill = false;
                        AssultKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(1500.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
                {
                    if (GM.isUSP45Active == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 5)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 5 || FreezePlayerNo > 5)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 5)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 5 || FreezePlayerNo > 5)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        PistolKill = true;
                        SniperKill = false;
                        AssultKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(2000.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
                {
                    if (GM.isBARETTAM9Active == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 5)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 5 || FreezePlayerNo > 5)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 5)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 5 || FreezePlayerNo > 5)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        PistolKill = true;
                        SniperKill = false;
                        AssultKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(3000.0f);
                    }
                }

                if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
                {
                    if (GM.isDRAGUNOVActive == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 1)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 1 || FreezePlayerNo > 1)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 1)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 1 || FreezePlayerNo > 1)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        SniperKill = true;
                        PistolKill = false;
                        AssultKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(2000.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
                {
                    if (GM.isM40A3Active == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 1)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 1 || FreezePlayerNo > 1)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 1)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 1 || FreezePlayerNo > 1)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        SniperKill = true;
                        PistolKill = false;
                        AssultKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(4000.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
                {
                    if (GM.isAWMActive == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 1)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 1 || FreezePlayerNo > 1)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 1)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 1 || FreezePlayerNo > 1)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        SniperKill = true;
                        PistolKill = false;
                        AssultKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(6000.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
                {
                    if (GM.isBARRETTM82Active == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 1)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 1 || FreezePlayerNo > 1)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 1)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 1 || FreezePlayerNo > 1)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        SniperKill = true;
                        PistolKill = false;
                        AssultKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(8000.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
                {
                    if (GM.isBARRETTMRADActive == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 1)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 1 || FreezePlayerNo > 1)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 1)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 1 || FreezePlayerNo > 1)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        SniperKill = true;
                        PistolKill = false;
                        AssultKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(10000.0f);
                    }
                }

                if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
                {
                    if (GM.IsM1A1 == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 10)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 10)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 10)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 10)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        AssultKill = true;
                        SniperKill = false;
                        PistolKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(100.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
                {
                    if (GM.IsAKM == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 10)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 10)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 10)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 10)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        AssultKill = true;
                        SniperKill = false;
                        PistolKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(200.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
                {
                    if (GM.IsAK74U == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 10)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 10)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 10)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 10)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        AssultKill = true;
                        SniperKill = false;
                        PistolKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(300.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
                {
                    if (GM.IsM4A1 == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 10)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 10)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 10)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 10)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        AssultKill = true;
                        SniperKill = false;
                        PistolKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(500.0f);
                    }
                }
                else if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
                {
                    if (GM.IsM16A4 == true)
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            if (FreezePlayerNo < 10)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 10)
                            {
                                FreezePlayerNo = 0;
                                transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
                            }
                        }
                        else
                        if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            if (FreezePlayerNo < 10)
                            {
                                FreezePlayerNo += 1;
                            }
                            else
                            if (FreezePlayerNo == 10)
                            {
                                FreezePlayerNo = 0;
                                ECS.enabled = false;
                                ED.enabled = true;
                                StartCoroutine(Teleport());
                                if (isServer)
                                {
                                    RpcTele();
                                }
                                else if (isClient)
                                {
                                    CmdTele();
                                }
                            }
                        }
                        AssultKill = true;
                        SniperKill = false;
                        PistolKill = false;
                        MeleeKill = false;
                        EHS.HeadKill = false;
                        EH.GK = false;

                        EH.TakeDamage(800.0f);
                    }
                }
            }
        }
        else if (other.gameObject.tag == "PlayerLeftHand")
        {
            MeleeKill = true;
            PistolKill = false;
            SniperKill = false;
            AssultKill = false;
            EHS.HeadKill = false;
            EH.GK = false;

            EH.TakeDamage(20.0f);
            anim.SetBool("Roar", true);
        }

    }

    [ClientRpc]
    public void RpcTele()
    {
        if (hasAuthority == false)
        {
            StartCoroutine(Teleport());
        }
    }

    [Command]
    public void CmdTele()
    {
        RpcTele();
    }
    public IEnumerator Teleport()
    {
        yield return new WaitForSeconds(2.5f);
        transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
        yield return new WaitForSeconds(3.5f);
        ECS.enabled = true;
        ED.t = 0f;
        ED.enabled = false;
    }

    public IEnumerator Teleport2()
    {
        ED.enabled = true;
        yield return new WaitForSeconds(2.5f);
        transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
        yield return new WaitForSeconds(3.5f);
        ECS.enabled = true;
        ED.t = 0f;
        ED.enabled = false;
    }

    public void ALPHATeleport()
    {
        transform.position = Player.transform.position - new Vector3(Random.Range(-30f, 30f), 0, Random.Range(10f, 30f));
    }

    private IEnumerator DisableMK()
    {
        yield return new WaitForSeconds(1.5f);
        MeleeKill = false;
    }

    private IEnumerator DisableAK()
    {
        yield return new WaitForSeconds(1.5f);
        AssultKill = false;
    }

    private IEnumerator DisableSK()
    {
        yield return new WaitForSeconds(1.5f);
        SniperKill = false;
    }

    private IEnumerator DisablePK()
    {
        yield return new WaitForSeconds(1.5f);
        PistolKill = false;
    }

    public IEnumerator DamagingMelee()
    {
        yield return new WaitForSeconds(3.0f);
        EH.TakeDamage(2.0f);
    }
}
