using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHeadShot : NetworkBehaviour
{
    public EnemyHealth EH;
    public EnemyChaseScript ECS;
    public Bullet Bullet;
    public SniperBullet sniperBullet;
    public AK47Bullet akBullet;
    public PistolBullet pistolBullet;
    public Animator anim;
    public bool HeadKill = false;
    public int TG;
    public int TC;
    public int CoinsEarnedData;
    public EnemyCollisionDetection ECD;
    public GunManager GM;
    public GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        CoinsEarnedData = PlayerPrefs.GetInt("CoinsEarned");

        anim = GetComponent<Animator>();
        GM = Player.GetComponent<GunManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {

            ECS.Lock = true;
            ECS.m_IsPatrol = false;
            TC += 1;
            PlayerPrefs.SetInt("TempCoin", PlayerPrefs.GetInt("TempCoin") + TC);
            PlayerPrefs.SetInt("CoinsEarned", PlayerPrefs.GetInt("CoinsEarned") + TC);
            HeadKill = true;
            ECD.MeleeKill = false;

            if (SceneManager.GetActiveScene().buildIndex == 30)
            {
                ECD.FreezePlayerNo = 0;
                ECD.ALPHATeleport();
            }
            else
            if (SceneManager.GetActiveScene().buildIndex == 29)
            {
                ECD.FreezePlayerNo = 0;
                ECS.enabled = false;
                ECD.Teleport2();
            }
            if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
            {
                if (GM.isMAKAROVActive == true)
                {
                    EH.TakeDamage(800.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
            {
                if (GM.isGLOCK19Active == true)
                {
                    EH.TakeDamage(1000.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
            {
                if (GM.isM1911Active == true)
                {
                    EH.TakeDamage(1800.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
            {
                if (GM.isUSP45Active == true)
                {
                    EH.TakeDamage(2400.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
            {
                if (GM.isBARETTAM9Active == true)
                {
                    EH.TakeDamage(4800.0f);
                }
            }

            if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
            {
                if (GM.isDRAGUNOVActive == true)
                {
                    EH.TakeDamage(5000.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
            {
                if (GM.isM40A3Active == true)
                {
                    EH.TakeDamage(8000.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
            {
                if (GM.isAWMActive == true)
                {
                    EH.TakeDamage(10000.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
            {
                if (GM.isBARRETTM82Active == true)
                {
                    EH.TakeDamage(15000.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
            {
                if (GM.isBARRETTMRADActive == true)
                {
                    EH.TakeDamage(20000.0f);
                }
            }

            if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
            {
                if (GM.IsM1A1 == true)
                {
                    EH.TakeDamage(400.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
            {
                if (GM.IsAKM == true)
                {
                    EH.TakeDamage(500.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
            {
                if (GM.IsAK74U == true)
                {
                    EH.TakeDamage(1200.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
            {
                if (GM.IsM4A1 == true)
                {
                    EH.TakeDamage(1300.0f);
                }
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
            {
                if (GM.IsM16A4 == true)
                {
                    EH.TakeDamage(1400.0f);
                }
            }
            Bullet.Deactivate();
        }
        else if (other.gameObject.tag == "Knife")
        {

        }

    }

    private IEnumerator DisableHK()
    {
        yield return new WaitForSeconds(1f);
        HeadKill = false;
    }

}
