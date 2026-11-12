using Mirror;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyHealth : NetworkBehaviour
{
    public EnemyChaseScript ECS;
    public Animator anim;
    public UnityEngine.AI.NavMeshAgent agent;
    public PlayerControllers PC;
    public PlayerCollision PLC;
    public int No = 0;
    public AudioSource EnemyDeath;
    public float EnemyDeathNo = 0f;
    public float EnemyHealthLow = 0f;
    public MiniMapComponent MMC;
    public float Health = 400.0f;
    public Transform HealthKitPrefab;
    public Vector3 HealthPos;
    public bool bounce = false;
    public ParticleSystem Burn;
    public ParticleSystem RFire;
    public ParticleSystem LFire;
    public ParticleSystem HFire;
    public Collider ECol;
    public Collider ELH;
    public Collider ERH;
    public Collider ES;
    public Vector3 EnemyPos;
    public AudioSource SoldierEnemyDownVoice;
    public PlayerHealth PH;
    public EnemyHeadShot EHS;
    public EnemyCollisionDetection EC;
    public GameObject HSPanelGO;
    public int HSK;
    public int MK;
    public int AK;
    public int SK;
    public int PK;
    public int GranadeK;
    public int TG;
    public int TC;
    public int CoinsEarnedData;
    public int TotalKilledData;
    public bool GK = false;
    public BossEnemyHealthBar BEHB;
    public EnemyHealthBar EHB;
    public Rigidbody[] ragdollbodies;
    public Collider[] ragdollcolliders;
    public EnemyDissolveOverTime[] ED;
    public float timer = 0;
    public bool AttacksWithHands = true;
    public bool BossEnemy;

    void Start()
    {
        PH = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        EnemyPos = new Vector3(0, 6.0f, 0);
        HealthPos = new Vector3(0, 8.0f, 0);
        PC = GameObject.FindWithTag("Player").GetComponent<PlayerControllers>();
        BEHB = GetComponent<BossEnemyHealthBar>();
        anim = GetComponent<Animator>();
        ragdollbodies = GetComponentsInChildren<Rigidbody>();

        RagdollState(false);
    }

    public void RagdollState(bool state)
    {
        anim.enabled = !state;
        foreach (Rigidbody rb in ragdollbodies)
        {
            rb.isKinematic = !state;
        }

        foreach (Collider colliders in ragdollcolliders)
        {

        }
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if (BossEnemy == false)
        {
            EHB.Disable = false;
            StartCoroutine(DisableHB());
        }
        else
        {
            BEHB.Disable = false;
            StartCoroutine(DisableBHB());
        }
        if (EHS.HeadKill == true)
        {

            PH.HSDisplay();

        }
        if (Health <= 0)
        {
            if (AttacksWithHands == true)
            {
                ELH.enabled = false;
                ERH.enabled = false;
            }
            else
            {
                ES.enabled = false;
            }

            if (BossEnemy == true)
            {
                BEHB.Disable = true;
            }
            else
            {
                EHB.Disable = true;
            }

            EnemyHealthLow += 1.0f;
            if (EnemyHealthLow == 1.0f)
            {
                TotalKilledData += 1;
                TC += 1;
                PlayerPrefs.SetInt("TempCoin", PlayerPrefs.GetInt("TempCoin") + TC);
                PlayerPrefs.SetInt("CoinsEarned", PlayerPrefs.GetInt("CoinsEarned") + TC);
                PlayerPrefs.SetInt("TotalKilled", PlayerPrefs.GetInt("TotalKilled") + TotalKilledData);
                PlayerPrefs.SetInt("Kill500Enemies", PlayerPrefs.GetInt("Kill500Enemies") + TotalKilledData);
                PlayerPrefs.SetInt("20HeadShots", PlayerPrefs.GetInt("20HeadShots") + TotalKilledData);
                PlayerPrefs.SetInt("10EnemyKills", PlayerPrefs.GetInt("10EnemyKills") + TotalKilledData);
                if (EHS.HeadKill == true)
                {
                    TG += 1;
                    PlayerPrefs.SetInt("TempGem", PlayerPrefs.GetInt("TempGem") + TG);
                    PlayerPrefs.SetInt("GemsEarned", PlayerPrefs.GetInt("GemsEarned") + TG);

                    PH.HSDisplay();
                    HSK += 1;
                    PlayerPrefs.SetInt("HeadshotKilled", PlayerPrefs.GetInt("HeadshotKilled") + HSK);
                    EHS.HeadKill = false;
                }

                if (EC.MeleeKill == true)
                {
                    MK += 1;
                    PlayerPrefs.SetInt("MeleeKills", PlayerPrefs.GetInt("MeleeKills") + MK);
                    PlayerPrefs.SetInt("500MeleeKills", MK);
                    EC.MeleeKill = false;
                }

                if (EC.AssultKill == true)
                {
                    AK += 1;
                    PlayerPrefs.SetInt("AssultKilled", PlayerPrefs.GetInt("AssultKilled") + AK);
                    EC.AssultKill = false;
                }

                if (EC.SniperKill == true)
                {
                    SK += 1;
                    PlayerPrefs.SetInt("SniperKilled", PlayerPrefs.GetInt("SniperKilled") + SK);
                    EC.SniperKill = false;
                }

                if (EC.PistolKill == true)
                {
                    PK += 1;
                    PlayerPrefs.SetInt("PistolKilled", PlayerPrefs.GetInt("PistolKilled") + PK);
                    EC.PistolKill = false;
                }

                if (GK == true)
                {
                    GranadeK += 1;
                    PlayerPrefs.SetInt("GrenadeKilled", PlayerPrefs.GetInt("GrenadeKilled") + GranadeK);
                }
            }
            Die();
            if (isServer)
            {
                RpcDie();
            }
            else if (isClient)
            {
                CmdDie();
            }
        }

    }

    [ClientRpc]
    public void RpcDie()
    {
        if (hasAuthority == false)
        {
            EnemyDeathNo += 1.0f;

            PC.EnemyAllDead = true;
            if (EnemyDeathNo == 1.0f)
            {

                if (PlayerPrefs.GetInt("CurrentLevel") == 30)
                {
                    foreach (EnemyDissolveOverTime EDOT in ED)
                    {
                        EDOT.enabled = false;
                    }
                }
                else if (PlayerPrefs.GetInt("CurrentLevel") == 29)
                {
                    foreach (EnemyDissolveOverTime EDOT in ED)
                    {
                        EDOT.enabled = false;
                    }
                }
                ECS.enabled = false;

                ECS.BulletLock = true;
                ECS.Lockb = true;
                PH.SEDV();

                ECol.enabled = false;
                if (AttacksWithHands == true)
                {
                    ELH.enabled = false;
                    ERH.enabled = false;
                }
                RFire.Stop();
                LFire.Stop();
                HFire.Stop();

                EnemyDeath.Play();

                StartCoroutine(Blow());
            }

            agent.enabled = false;

            RagdollState(true);

            CmdDestroyMe();
            Destroy(this.gameObject, 10.5f);
        }
    }

    [Command]
    public void CmdDie()
    {
        RpcDie();
    }

    private IEnumerator DisableHB()
    {
        yield return new WaitForSeconds(5.0f);
        EHB.Disable = true;
    }

    private IEnumerator DisableBHB()
    {
        yield return new WaitForSeconds(5.0f);
        BEHB.Disable = true;
    }

    public void Die()
    {
        EnemyDeathNo += 1.0f;

        PC.EnemyAllDead = true;
        if (EnemyDeathNo == 1.0f)
        {

            if (PlayerPrefs.GetInt("CurrentLevel") == 30)
            {
                foreach (EnemyDissolveOverTime EDOT in ED)
                {
                    EDOT.enabled = false;
                }
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 29)
            {
                foreach (EnemyDissolveOverTime EDOT in ED)
                {
                    EDOT.enabled = false;
                }
            }
            ECS.enabled = false;

            ECS.BulletLock = true;
            ECS.Lockb = true;
            PH.SEDV();

            ECol.enabled = false;
            RFire.Stop();
            LFire.Stop();
            HFire.Stop();

            EnemyDeath.Play();

            StartCoroutine(Blow());
        }

        agent.enabled = false;

        RagdollState(true);

        CmdDestroyMe();
        Destroy(this.gameObject, 10.5f);

    }

    [Command]
    public void CmdDestroyMe()
    {
        Destroy(this.gameObject, 10.5f);
    }

    public IEnumerator Blow()
    {
        yield return new WaitForSeconds(8.0f);

        foreach (EnemyDissolveOverTime EDOT in ED)
        {
            EDOT.enabled = true;
        }
    }

    public IEnumerator Blink()
    {
        while (bounce == true)
        {
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.0f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.1f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.2f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.3f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.4f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.5f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.6f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.7f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.8f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.9f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 35.0f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.9f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.8f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.7f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.6f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.5f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.4f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.3f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.2f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.1f, 0);
            yield return new WaitForSeconds(0.1f);
            HealthPos = new Vector3(0, 34.0f, 0);
        }
    }

    private IEnumerator DisableMMC()
    {
        yield return new WaitForSeconds(5.5f);
        MMC.enabled = false;
    }
}
