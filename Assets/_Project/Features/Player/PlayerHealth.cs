using Mirror;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;
public class PlayerHealth : NetworkBehaviour
{
    public Slider PlayerHealthBar;
    public AudioSource DeathSound;
    public GameObject[] Removables;
    public GameObject[] RemovablesGUI;
    public GameObject GameOver;
    public bool timerIsRunning = false;
    public Text timeText;
    public Text ReviveText;
    public GameObject RevivePanel;
    public bool TimerLow = false;
    public TimerScript TS;
    public bool blink = true;
    public CamRotateTest CRT;
    public WASDMovementScript WASD;
    public Look2 L;
    public bool OriginalPlayer = true;
    public bool Charge = false;
    public PlayerCollision PC;
    public int PlayerIsAlive = 0;
    public AK47UScopeEffect AUSE;
    public AK47ScopeEffect ASE;
    public PistolScopeEffect PSE;
    public SniperScopeEffect SSE;
    public bool IsAK47UActive = false;
    public bool IsAK47Active = false;
    public bool IsPistolActive = false;
    public bool IsSniperActive = false;
    public Animator SWATAnimator;
    public Animator SWATAnimator2;
    public float Health = 100.0f;
    public float CurrentHealth;
    public float timeRemaining = 10.0f;
    public CharacterController controller;
    public Vector3 PlayerPos;

    public Vector3 PlayerPos2;
    public PlayerAiming PA;
    public CameraController CC;
    public CameraControlledIK CCIK;
    public AudioSource SoldierHealthRechargeVoice;
    public AudioSource SoldierAllClearVoice;
    public AudioSource SoldierEnemyDownVoice;
    public bool RGame = false;
    public AudioSource PlayerHit;
    public bool ReviveOnStart = true;
    public int EnergyValue;
    public int GemValue;
    public int CoinValue;
    public GameObject NoEnergyPopUp;
    public GameObject PG;
    public GameObject NoGemPanel;

    public Text EnergyDisplay;
    public Text CoinDisplay;
    public Text GemDisplay;

    public GameObject HSPanelGO;

    public GameObject TutorialPanel;

    public GameObject TutorialButton;
    public FirstPersonControls FPC;
    public int UCFT;
    public GameObject NM;
    public Rigidbody[] ragdollbodies;
    public Collider[] ragdollcolliders;

    public Collider MainColliders;
    public Collider BloodColliders;

    public Image BloodSplatterImg;
    public bool GUIRemoved = false;

    public int RegenRate = 15;
    public bool CanRegen = false;

    public float HealCoolDown = 15.0f;
    public float MaxHealCoolDown = 15.0f;

    public bool StartCoolDown = false;

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

    public pausescript PS;

    public bool NewPlayer;

    GameObject tempdoll;

    public GameObject ragdoll;

    public Animator FPSAnimator;

    public Animator FPSAnimator2;

    public PostProcessProfile pprocessing;

    public PostProcessProfile pprocessing2;

    DepthOfField dofComponent;

    DepthOfField dofComponent2;

    public GameObject PlayerBody;
    Vector3 PreviousPos;
    public GameObject[] Enemy;
    public GameObject ControlsButton;
    public GunManager GM;
    public GameObject PlayerCounter;
    public GameObject PlayerWinUI;
    public bool DontPlay;
    public RewardedVideoAds RVA;
    public bool LockTakeDamage;

    public float ImmunityTimeRemaining = 5.0f;
    public bool ImmunityTimerIsRunning = false;
    public Text ImmunityTimeText;
    public GameObject ImmunityUI;
    public bool PlayerDead;

    public override void OnStartAuthority()
    {
        CurrentHealth = Health;
        PlayerHealthBar.value = CurrentHealth;
        if (PlayerPrefs.HasKey("CurrentLevel"))
        {
            ControlsButton.gameObject.SetActive(true);
        }

    }

    public override void OnStartClient()
    {
        if (NewPlayer == false)
        {
            float Mass = 250f;
            RagdollState(false, Mass);
            if (isServer)
            {
                RpcRagD();
            }
            else if (isClient)
            {
                CmdRagD();
            }
        }
        else
        {
            float Mass = 250f;
            RagdollState(false, Mass);
        }
    }

    void Start()
    {
        NM = GameObject.FindGameObjectWithTag("NM");
        HSPanelGO = GameObject.FindGameObjectWithTag("HS");

        PlayerHealthBar = GameObject.FindGameObjectWithTag("PHB").GetComponent<Slider>();
        HSPanelGO.gameObject.SetActive(false);

        ReviveText.gameObject.SetActive(false);
        CurrentHealth = Health;
        PlayerHealthBar.value = CurrentHealth;

        if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
            gameObject.GetComponentInChildren<ThirdPersonCharacter>().enabled = true;

        if (PlayerPrefs.HasKey("CurrentLevel"))
        {
            PC.PlayerAlive = true;

            ControlsButton.gameObject.SetActive(true);
        }

        GameOver.gameObject.SetActive(false);
        PC = GetComponent<PlayerCollision>();
        PlayerPos = new Vector3(0, 4.0f, 0);
        PlayerPos2 = new Vector3(0, 0.5f, 0);

        if(SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 5){
            DontPlay = true;
        }

    }

    [Command]
    public void CmdRagD()
    {
        RpcRagD();
    }

    [ClientRpc]
    public void RpcRagD()
    {
        if (hasAuthority == false)
        {
            float Mass = 250f;
            RagdollState(false, Mass);
        }
    }

    public void RagdollState(bool state, float Mass)
    {
        if (NewPlayer == false)
        {
            SWATAnimator.enabled = !state;
            SWATAnimator2.enabled = !state;
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
            {
                WS1Anim.enabled = !state;
            }
            else
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
            {
                WS1bAnim.enabled = !state;
            }
            else
                if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
            {
                WS1cAnim.enabled = !state;
            }
            else
                if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
            {
                WS1dAnim.enabled = !state;
            }
            else
                if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
            {
                WS1eAnim.enabled = !state;
            }

            if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
            {

                WS2Anim.enabled = !state;
            }
            else
                    if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
            {
                WS2bAnim.enabled = !state;
            }
            else
                        if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
            {
                WS2cAnim.enabled = !state;
            }
            else
                        if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
            {
                WS2dAnim.enabled = !state;
            }
            else
                        if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
            {
                WS2eAnim.enabled = !state;
            }

            if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
            {
                WS3Anim.enabled = !state;
            }
            else
                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
            {
                WS3bAnim.enabled = !state;
            }
            else
                        if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
            {
                WS3cAnim.enabled = !state;
            }
            else
                        if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
            {
                WS3dAnim.enabled = !state;
            }
            else
                        if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
            {
                WS3eAnim.enabled = !state;
            }

            foreach (Rigidbody rb in ragdollbodies)
            {
                rb.isKinematic = !state;
            }

            foreach (Collider colliders in ragdollcolliders)
            {

            }
        }
        else
        {

            BloodColliders.enabled = !state;
            foreach (Rigidbody rb in ragdollbodies)
            {
                rb.isKinematic = !state;
                rb.mass = Mass;
            }

            foreach (Collider colliders in ragdollcolliders)
            {
                colliders.enabled = state;
            }

            FPSAnimator.enabled = !state;
            FPSAnimator2.enabled = !state;

            if (gameObject.GetComponent<SimpleFootsteps>())
                gameObject.GetComponent<SimpleFootsteps>().enabled = !state;

            if (gameObject.GetComponentInChildren<OffsetRotation>())
                gameObject.GetComponentInChildren<OffsetRotation>().enabled = !state;

            if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())

                if (gameObject.GetComponentInChildren<Adjuster>())
                    gameObject.GetComponentInChildren<Adjuster>().enabled = !state;

        }
    }

    void Update()
    {

        if (StartCoolDown == true)
        {
            HealCoolDown -= Time.smoothDeltaTime;
            if (HealCoolDown <= 0)
            {
                CanRegen = true;
                StartCoolDown = false;
            }
        }

        if (CanRegen == true)
        {
            if (CurrentHealth <= Health - 0.01)
            {
                CurrentHealth += Time.smoothDeltaTime * RegenRate;
                PlayerHealthBar.value = CurrentHealth;
                StartCoroutine(ReturnColor());
            }
            else
            {
                CurrentHealth = Health;
                HealCoolDown = MaxHealCoolDown;
                CanRegen = false;
            }
        }
        Color BloodAlpha = BloodSplatterImg.color;
        BloodAlpha.a = 1 - (CurrentHealth / Health);
        BloodSplatterImg.color = BloodAlpha;

        EnergyValue = PlayerPrefs.GetInt("EnergyValue");
        CoinValue = PlayerPrefs.GetInt("CoinValue");
        GemValue = PlayerPrefs.GetInt("GemValue");

        EnergyDisplay.text = EnergyValue.ToString() + "/" + "100";
        CoinDisplay.text = CoinValue.ToString();
        GemDisplay.text = GemValue.ToString();
        if (timerIsRunning)
        {

            if (timeRemaining > 0)
            {

                timeRemaining -= Time.smoothDeltaTime;
                Displaytime(timeRemaining);
            }
            else
            {
                ReviveText.text = "SHIT!!!";
                timeRemaining = 0.0f;
                timerIsRunning = false;
                Death();
                if (isServer)
                {
                    RpcDeath();
                }
                else if (isClient)
                {
                    CmdDeath();
                }
            }
        }

        if (ImmunityTimerIsRunning)
        {

            if (ImmunityTimeRemaining > 0)
            {

                ImmunityTimeRemaining -= Time.smoothDeltaTime;
                DisplayImmunityTime(ImmunityTimeRemaining);
            }
            else
            {
                ImmunityTimeRemaining = 5.0f;
                ImmunityTimerIsRunning = false;
                LockTakeDamage = false;
                ImmunityUI.gameObject.SetActive(false);
            }
        }

    }
    public void TakeDamage(float damage)
    {
        if (hasAuthority == true)
        {
            if(LockTakeDamage == false)
            {

            CurrentHealth -= damage;
            PlayerHealthBar.value = CurrentHealth;
            if (CurrentHealth > 0)
            {
                CanRegen = false;
                HealCoolDown = MaxHealCoolDown;
                StartCoolDown = true;
            }
            if (CurrentHealth <= 0)
            {

                if (NewPlayer == false)
                {
                    WASD.Move = false;
                    L.Look = false;
                    PA.Look = false;
                }
                else
                {
                    if (GM.DeathMatch == true)
                    {
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().prone = true;
                    }
                    else
                    {
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    }
                    PreviousPos = transform.position;

                    if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    {
                        gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;
                    }

                    if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    {
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                    }
                    CC.Look = false;

                }
                PC.PlayerAlive = false;
                ReviveText.gameObject.SetActive(true);
                ReviveText.text = "TapToRevive!!!";
                timerIsRunning = true;
                blink = true;
                StartCoroutine(Blink());
            }
            GameObject fill = PlayerHealthBar.transform.GetChild(1).GetChild(0).gameObject;
            Image fillImage = fill.GetComponent<Image>();
            fillImage.color = Color.red;
            StartCoroutine(ReturnColor());
        }
    }
    }

    public void Death()
    {

        if (NewPlayer == false)
        {
            AK47U.gameObject.SetActive(false);
            AK47.gameObject.SetActive(false);
            MEGASHOT.gameObject.SetActive(false);
            AK47UAMOD.gameObject.SetActive(false);
            AK47UKS.gameObject.SetActive(false);

            SVD.gameObject.SetActive(false);
            SLP.gameObject.SetActive(false);
            M40a3.gameObject.SetActive(false);
            Ksvk.gameObject.SetActive(false);
            ALPHARIFLE.gameObject.SetActive(false);

            Glock.gameObject.SetActive(false);
            M1911.gameObject.SetActive(false);
            M1323.gameObject.SetActive(false);
            WP01.gameObject.SetActive(false);
            ULTRA.gameObject.SetActive(false);

            float Mass = 500f;
            RagdollState(true, Mass);

            if (AUSE.IsAK47UAiming == true)
            {
                if (IsAK47UActive == true)
                {
                    AUSE.UnScoped();
                }
            }
            else if (ASE.IsAK47Aiming == true)
            {
                if (IsAK47Active == true)
                {
                    ASE.UnScoped();
                }
            }
            else if (PSE.IsPistolAiming == true)
            {
                if (IsPistolActive == true)
                {
                    PSE.UnScoped();
                }
            }
            else if (SSE.IsSniperAiming == true)
            {
                if (IsSniperActive == true)
                {
                    SSE.UnScoped();
                }
            }
            controller.enabled = false;
        }
        else
        {
            PlayerDead = true;
            Time.timeScale = 1f;
            PlayerWinUI.SetActive(false);
            Destroy(PlayerCounter);
            Enemy = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemies in Enemy)
            {
                if (Vector3.Distance(Enemies.transform.position, transform.position) < 20.0f)
                {
                    Enemies.GetComponent<EnemyChaseScript>().m_IsPatrol = true;
                    Enemies.GetComponent<EnemyChaseScript>().UpdateDestination();
                }
            }
            PS.Locked = true;

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;

            CC.Look = false;
            CCIK.enabled = false;
            PC.enabled = false;

            if (gameObject.GetComponent<SimpleFootsteps>())
                gameObject.GetComponent<SimpleFootsteps>().enabled = false;

            if (gameObject.GetComponent<AudioSource>())
                gameObject.GetComponent<AudioSource>().enabled = false;

            if (gameObject.GetComponentInChildren<OffsetRotation>())
                gameObject.GetComponentInChildren<OffsetRotation>().enabled = false;

            if (gameObject.GetComponentInChildren<AiGunController>())
                gameObject.GetComponentInChildren<AiGunController>().enabled = false;

            if (gameObject.GetComponentInChildren<Adjuster>())
                gameObject.GetComponentInChildren<Adjuster>().enabled = false;

            float Mass = 500f;
            RagdollState(true, Mass);
        }
        PlayerIsAlive++;
        PC.PlayerAlive = false;
        if (NewPlayer == false)
        {
            FPC.Walk = false;
            FPC.Look = false;
            WASD.Move = false;
            L.Look = false;
            PA.Look = false;
        }

        ReviveText.gameObject.SetActive(false);
        ReviveText.text = "";
        timeText.text = "";
        foreach (GameObject RemovablesGO in Removables)
        {
            RemovablesGO.gameObject.SetActive(false);
        }

        GameOver.gameObject.SetActive(true);
        if (PlayerIsAlive == 1)
        {
            DeathSound.Play();
        }

        StartCoroutine(CLIENTRestart());
    }

    [Command]
    public void CmdDeath()
    {
        RpcDeath();
    }

    [ClientRpc]
    public void RpcDeath()
    {
        if (hasAuthority == false)
        {
            if (NewPlayer == false)
            {
                AK47U.gameObject.SetActive(false);
                AK47.gameObject.SetActive(false);
                MEGASHOT.gameObject.SetActive(false);
                AK47UAMOD.gameObject.SetActive(false);
                AK47UKS.gameObject.SetActive(false);

                SVD.gameObject.SetActive(false);
                SLP.gameObject.SetActive(false);
                M40a3.gameObject.SetActive(false);
                Ksvk.gameObject.SetActive(false);
                ALPHARIFLE.gameObject.SetActive(false);

                Glock.gameObject.SetActive(false);
                M1911.gameObject.SetActive(false);
                M1323.gameObject.SetActive(false);
                WP01.gameObject.SetActive(false);
                ULTRA.gameObject.SetActive(false);

                float Mass = 1000f;
                RagdollState(true, Mass);
                PlayerIsAlive++;

                FPC.Walk = false;
                FPC.Look = false;
                WASD.Move = false;
                L.Look = false;
                PA.Look = false;
                controller.enabled = false;
            }
            else
            {
                Time.timeScale = 1f;
                Destroy(PlayerCounter);

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;

                CC.Look = false;
                CCIK.enabled = false;
                PC.enabled = false;

                if (gameObject.GetComponent<SimpleFootsteps>())
                    gameObject.GetComponent<SimpleFootsteps>().enabled = false;

                if (gameObject.GetComponent<AudioSource>())
                    gameObject.GetComponent<AudioSource>().enabled = false;

                if (gameObject.GetComponentInChildren<OffsetRotation>())
                    gameObject.GetComponentInChildren<OffsetRotation>().enabled = false;

                if (gameObject.GetComponentInChildren<AiGunController>())
                    gameObject.GetComponentInChildren<AiGunController>().enabled = false;

                if (gameObject.GetComponentInChildren<Adjuster>())
                    gameObject.GetComponentInChildren<Adjuster>().enabled = false;

                float Mass = 400f;
                RagdollState(true, Mass);
            }

            if (PlayerIsAlive == 1)
            {
                DeathSound.Play();
            }
        }
    }

    public void RemoveGUIS()
    {
        GUIRemoved = true;
        foreach (GameObject RemovablesGO in RemovablesGUI)
        {
            RemovablesGO.gameObject.SetActive(false);
        }
    }
    public void ShowGUIS()
    {
        GUIRemoved = false;
        foreach (GameObject RemovablesGO in RemovablesGUI)
        {
            RemovablesGO.gameObject.SetActive(true);
        }
    }

    public void RefillHealth()
    {
        if (CurrentHealth < 375)
        {
            SoldierHealthRechargeVoice.Play();
            CurrentHealth += 25.0f;
            PlayerHealthBar.value = CurrentHealth;
            StartCoroutine(ReturnColor());
        }
    }

    void Displaytime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}", seconds);
    }

    void DisplayImmunityTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        ImmunityTimeText.text = string.Format("{0:00}", seconds);
    }

    public void OpenTut()
    {
        SoldierHealthRechargeVoice.Play();

        if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
            gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
        CC.Look = false;

        TutorialPanel.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void CloseTut()
    {

        ControlsButton.gameObject.SetActive(true);
        SoldierHealthRechargeVoice.Play();

        if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
            gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
        CC.Look = true;

        TutorialPanel.gameObject.SetActive(false);

        PlayerHealthBar.gameObject.SetActive(true);
        Time.timeScale = 1f;
        PC.PlayerAlive = true;

    }

    [Command]
    public void CmdRevive()
    {
        RpcRevive();
    }

    [ClientRpc]
    public void RpcRevive()
    {
        if (hasAuthority == false)
        {
            CurrentHealth = Health;
        }
    }

    public void Revive()
    {

        if (EnergyValue >= 10)
        {
            LockTakeDamage = true;
            ImmunityUI.gameObject.SetActive(true);
            ImmunityTimerIsRunning = true;
            Time.timeScale = 1f;
            EnergyValue -= 10;
            PlayerPrefs.SetInt("EnergyValue", EnergyValue);
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + 1);
            SoldierHealthRechargeVoice.Play();
            PC.PlayerAlive = true;
            if (GUIRemoved == false)
            {
                if (NewPlayer == false)
                {
                    FPC.Walk = true;
                    FPC.Look = true;
                    WASD.Move = true;
                    PA.Look = true;
                }
                else
                {
                    if (GM.DeathMatch == true)
                    {
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().prone = false;
                    }
                    else
                    {
                        if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                        {
                            gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                        }
                    }

                    CC.Look = true;

                }
            }
            timeRemaining = 10.0f;
            timerIsRunning = false;

            CurrentHealth = Health;
            PlayerHealthBar.value = CurrentHealth;
            if (isServer)
            {
                RpcRevive();
            }
            else if (isClient)
            {
                CmdRevive();
            }
            ReviveText.text = "";
            ReviveText.gameObject.SetActive(false);
            timeText.text = "";
            StartCoroutine(ReturnColor());
            if (TimerLow == true)
            {

                TS.timerIsRunning = true;
                TS.timeRemaining = 120;
                TimerLow = false;
            }
        }
        else if (EnergyValue < 10)
        {
            Time.timeScale = 0f;
            NoEnergyPopUp.gameObject.SetActive(true);

        }

    }

    public void DisableNoEnergyPopUp()
    {
        Time.timeScale = 1f;
        NoEnergyPopUp.gameObject.SetActive(false);
    }

    public void PurchaseGem()
    {
        PG.gameObject.SetActive(true);
    }

    public void DisablePurchaseGem()
    {
        PG.gameObject.SetActive(false);
    }

    public void UseGemInstead()
    {
        if (GemValue >= 5)
        {
            LockTakeDamage = true;
            ImmunityUI.gameObject.SetActive(true);
            ImmunityTimerIsRunning = true;
            Time.timeScale = 1f;
            GemValue -= 5;
            UCFT += 1;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            NoEnergyPopUp.gameObject.SetActive(false);
            SoldierHealthRechargeVoice.Play();
            PC.PlayerAlive = true;
            if (GUIRemoved == false)
            {
                if (NewPlayer == false)
                {
                    FPC.Walk = true;
                    FPC.Look = true;
                    WASD.Move = true;
                    PA.Look = true;
                }
                else
                {

                    if (GM.DeathMatch == true)
                    {
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().prone = false;
                    }
                    else
                    {
                        if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                        {
                            gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                        }
                    }
                    CC.Look = true;

                }
            }
            timeRemaining = 10.0f;
            timerIsRunning = false;

            CurrentHealth = Health;
            PlayerHealthBar.value = CurrentHealth;
            ReviveText.text = "";
            ReviveText.gameObject.SetActive(false);
            timeText.text = "";
            StartCoroutine(ReturnColor());
            if (TimerLow == true)
            {

                TS.timerIsRunning = true;
                TS.timeRemaining = 120;
                TimerLow = false;
            }
        }
        else if (GemValue < 5)
        {
            NoGemPanel.gameObject.SetActive(true);
        }
    }

    public void AwardedHealth()
    {
            LockTakeDamage = true;
            ImmunityUI.gameObject.SetActive(true);
            ImmunityTimerIsRunning = true;
            NoEnergyPopUp.gameObject.SetActive(false);
            SoldierHealthRechargeVoice.Play();
            PC.PlayerAlive = true;
            if (GUIRemoved == false)
            {
                if (NewPlayer == false)
                {
                    FPC.Walk = true;
                    FPC.Look = true;
                    WASD.Move = true;
                    PA.Look = true;
                }
                else
                {

                    if (GM.DeathMatch == true)
                    {
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().prone = false;
                    }
                    else
                    {
                        if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                        {
                            gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                        }
                    }
                    CC.Look = true;

                }
            }
            timeRemaining = 10.0f;
            timerIsRunning = false;

            CurrentHealth = Health;
            PlayerHealthBar.value = CurrentHealth;
            ReviveText.text = "";
            ReviveText.gameObject.SetActive(false);
            timeText.text = "";
            StartCoroutine(ReturnColor());
            if (TimerLow == true)
            {

                TS.timerIsRunning = true;
                TS.timeRemaining = 120;
                TimerLow = false;
            }
    }

    public void DisableNGP()
    {
        NoGemPanel.gameObject.SetActive(false);
    }

    public void HSDisplay()
    {
        HSPanelGO.gameObject.SetActive(true);
        StartCoroutine(ClearHS());
    }
    public IEnumerator ClearHS()
    {
        yield return new WaitForSeconds(2.0f);
        HSPanelGO.gameObject.SetActive(false);
    }

    public IEnumerator ReturnColor()
    {
        yield return new WaitForSeconds(1.0f);
        OnSliderWasChanged();

    }

    public void OnSliderWasChanged()
    {
        GameObject fill = PlayerHealthBar.transform.GetChild(1).GetChild(0).gameObject;
        Image fillImage = fill.GetComponent<Image>();
        Color newColour = new Color(1f - (PlayerHealthBar.value / PlayerHealthBar.maxValue), PlayerHealthBar.value / PlayerHealthBar.maxValue, 0f);
        fillImage.color = newColour;
    }

    public void RoutineRestart()
    {
        StartCoroutine(Restart());
    }

    public IEnumerator CLIENTRestart()
    {
        yield return new WaitForSeconds(4.0f);
        PS.ShowUI();

    }
    public IEnumerator Restart()
    {
        yield return new WaitForSeconds(4.0f);
        RGame = true;
    }
    public IEnumerator DeathRot()
    {

        yield return new WaitForSeconds(0.4f);
        this.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        this.transform.localPosition = new Vector3(this.transform.localPosition.x, PlayerPos.y, this.transform.localPosition.z);
    }

    public IEnumerator Blink()
    {
        while (blink == true)
        {
            timeText.gameObject.SetActive(false);
            yield return new WaitForSeconds(1f);
            timeText.gameObject.SetActive(true);
            yield return new WaitForSeconds(1f);
        }
    }
    private IEnumerator Recharge()
    {
        while (Charge == true)
        {
            yield return new WaitForSeconds(1.0f);
            if (CurrentHealth < 100)
            {
                CurrentHealth += 2.0f;
            }
            else if (CurrentHealth == 100)
            {
                CurrentHealth = Health;
                Charge = false;
                yield return new WaitForSeconds(1.0f);
            }
        }
    }
    public void SEDV()
    {
        SoldierEnemyDownVoice.Play();
    }

    public void SACV()
    {
        SoldierAllClearVoice.Play();
    }

}

