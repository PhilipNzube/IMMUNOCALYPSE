using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AK47WeaponScript : MonoBehaviour
{
    AK47BulletPool bPool;
    public Transform fpCamera;
    public Transform firePoint;
    public float firePower = 10;
    public bool isShooting;
    public float fireSpeed;
    public float fireTimer;
    public float MaxAmmo = 150;
    public float CurrentAmmo;
    public float MagSize = 5.0f;
    public Text AmmoText;
    public Bullet bulletScript;
    public float CurrentMagSize;
    public Text MagSizeText;
    public GameObject AK47ShootButton;
    public GameObject[] Enemy;
    public bool Autoaim = false;
    public bool Autoreload = false;
    public Transform cam;
    public bool Fire = true;
    public GameObject AK47;
    public ParticleSystem Flash;
    public bool MagMinus = false;
    public AudioSource ShotSound;
    public AudioSource EmptySound;
    public AudioSource ReloadSound;
    public Animator AK47Anim;
    public Transform grenadeSpawnPoint;
    public Transform grenadePrefab;
    public PlayerControllers PC;
    public WASDMovementScript WASD;
    public FirstPersonControls FPC;
    public bool GrenadeEmpty = false;
    public bool ThrowTime = true;
    public float GrenadetimeRemaining = 10.0f;
    public bool GrenadetimerIsRunning = false;
    public Text GrenadetimeText;
    public GameObject GrenadePanel;
    public GameObject GrenadeAmount;
    public GameObject[] QueenEnemy;
    public CamRecoil CR;
    public AK47Recoil AR;
    public AK47ScopeEffect ASE;
    public bool AfterReloadScope = false;
    public GameObject ScopeUI;
    public GameObject casingPrefab;
    public GameObject casingSpawnPoint;
    public Transform Crosshair;
    public GameObject Granadethrowimg;

    private void Start()
    {
        FPC = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonControls>();
        WASD = GameObject.FindGameObjectWithTag("Player").GetComponent<WASDMovementScript>();
        PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllers>();
        Flash.Stop();

        Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        QueenEnemy = GameObject.FindGameObjectsWithTag("Spider");
        CurrentMagSize = MagSize;
        CurrentAmmo = MaxAmmo;
        bPool = AK47BulletPool.main;
    }
    public void Shoot()
    {
        if (CurrentAmmo == 0)
        {
            CurrentAmmo = 0;

            Fire = false;
            EmptySound.Play();
        }
        if (Fire == true)
        {
            Instantiate(casingPrefab,
                casingSpawnPoint.transform.position,
                casingSpawnPoint.transform.rotation);
            Crosshair.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            CR.Recoil();
            ShotSound.Play();
            Flash.Play();
            AR.Recoil();
            if (Autoaim == true)
            {
                foreach (GameObject Enemies in Enemy)
                {
                    if (Vector3.Distance(Enemies.transform.position, transform.position) <= 50.0f)
                    {
                        Vector3 targetPos = new Vector3(Enemies.transform.position.x, 15f - (Enemies.transform.position.y), Enemies.transform.position.z);
                        cam.LookAt(targetPos);
                    }
                }
                foreach (GameObject Queens in QueenEnemy)
                {
                    if (Vector3.Distance(Queens.transform.position, transform.position) <= 50.0f)
                    {
                        Vector3 QueentargetPos = new Vector3(Queens.transform.position.x, 15f - (Queens.transform.position.y), Queens.transform.position.z);
                        cam.LookAt(QueentargetPos);
                    }
                }
            }
            CurrentAmmo--;
            Vector3 bulletVelocity = fpCamera.forward * firePower;
            bPool.PickFromPool(firePoint.position, bulletVelocity, transform.position);
        }
    }
    public void PullTrigger()
    {
        if (fireSpeed < 0) isShooting = true;
        else Shoot();
    }
    public void ReleaseTrigger()
    {
        Flash.Stop();
        isShooting = false;
        fireTimer = 0;
    }

    void Update()
    {
        if (GrenadetimerIsRunning)
        {
            if (GrenadetimeRemaining > 0)
            {
                GrenadetimeRemaining -= Time.deltaTime;
                DisplayGrenadetime(GrenadetimeRemaining);
                GrenadePanel.gameObject.SetActive(true);
                GrenadeAmount.gameObject.SetActive(false);
            }
            else
            {
                GrenadeAmount.gameObject.SetActive(true);
                GrenadePanel.gameObject.SetActive(false);
                GrenadetimeText.text = "";
                GrenadetimeRemaining = 10.0f;
                GrenadetimerIsRunning = false;
            }
        }
        AmmoText.text = "Ammo:" + CurrentAmmo + "/" + MaxAmmo;
        MagSizeText.text = "MagazineSize:" + CurrentMagSize + "/" + MagSize;

        if (CurrentAmmo == 0)
        {
            CurrentAmmo = 0;
            Fire = false;
            if (Autoreload == true)
            {
                Reload();

            }
        }
        else if (CurrentAmmo >= 1)
        {
            Fire = true;
        }
        if (isShooting)
        {
            if (fireTimer > 0) fireTimer -= Time.deltaTime;
            else
            {
                fireTimer = fireSpeed;
                Shoot();
            }
        }
    }
    public void ThrowGranade()
    {
        if (GrenadeEmpty == false)
        {

            StartCoroutine(GrenadeSpawnDelay());
            if (ThrowTime == true)
            {
                ThrowTime = false;
                AK47Anim.Play("GrenadeThrow", 0, 0.0f);
            }
        }
    }
    public void Reload()
    {
        if (CurrentAmmo == 0)
        {
            CurrentAmmo = 0;

            Fire = false;
            if (CurrentMagSize == 0)
            {
                WASD.playerSpeed = 10.0f;
                MagMinus = false;
                Fire = false;
            }
            else if (CurrentMagSize > 0)
            {
                MagMinus = true;
                ReloadSound.Play();
                PC.Run = false;
                AK47Anim.Play("Reload Out Of Ammo", 0, 0f);
                StartCoroutine(Load());

            }
        }
    }
    void DisplayGrenadetime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = Mathf.FloorToInt(timeToDisplay % 1) * 1000;
        GrenadetimeText.text = string.Format("{0:00}:{1:00}", seconds, milliSeconds);
    }
    private IEnumerator Load()
    {
        ScopeUI.gameObject.SetActive(false);
        Granadethrowimg.gameObject.SetActive(false);
        if (ASE.IsAK47Aiming == true)
        {
            ASE.UnScoped();
            AfterReloadScope = true;
        }
        WASD.IsReloading = true;
        FPC.IsReloading = true;
        yield return new WaitForSeconds(2.5f);
        if (MagMinus == true)
        {
            if (AfterReloadScope == true)
            {
                ASE.afterreloadscope();
                AfterReloadScope = false;
            }
            WASD.IsReloading = false;
            FPC.IsReloading = false;
            ScopeUI.gameObject.SetActive(true);
            Granadethrowimg.gameObject.SetActive(true);
            PC.Run = true;
            CurrentMagSize -= 1.0f;
            CurrentAmmo = MaxAmmo;
            Fire = true;
        }
    }
    private IEnumerator GrenadeSpawnDelay()
    {
        if (ASE.IsAK47Aiming == true)
        {
            ASE.UnScoped();
            AfterReloadScope = true;
        }

        yield return new WaitForSeconds(.8f);
        if (AfterReloadScope == true)
        {
            ASE.afterreloadscope();
            AfterReloadScope = false;
        }
        PC.GrenadeNo -= 1.0f;
        ThrowTime = true;
        GrenadetimerIsRunning = true;

        Instantiate(grenadePrefab,
            grenadeSpawnPoint.transform.position,
            grenadeSpawnPoint.transform.rotation);
    }
}
