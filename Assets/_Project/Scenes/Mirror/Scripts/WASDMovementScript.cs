using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class WASDMovementScript : NetworkBehaviour
{
    public CharacterController controller;
    public Vector3 playerVelocity;
    public bool groundedPlayer;
    public float playerSpeed = 10.0f;
    public float jumpHeight = 5.0f;
    public float gravityValue = -15.81f;
    public bool Move = false;
    public AudioSource WalkSound;
    public AudioSource WalkSound2;
    public AudioSource WalkSound3;
    public Animator AK4Uanim;
    public Animator AK47anim;
    public Animator Sniperanim;
    public Animator Pistolanim;
    public int MoveTime = 0;
    public Transform Crosshair;
    public GameObject DashImage;
    public Animator AK47Uanim2;
    public Animator AK47anim2;
    public Animator Sniperanim2;
    public Animator Pistolanim2;
    public bool Run = false;
    public bool IsMoveTimer = false;
    public bool AK47UAfterRunScope = false;
    public bool AK47AfterRunScope = false;
    public bool PistolAfterRunScope = false;
    public bool SniperAfterRunScope = false;
    public AK47UScopeEffect AUSE;
    public AK47ScopeEffect ASE;
    public PistolScopeEffect PSE;
    public SniperScopeEffect SSE;
    public GameObject Scope1;
    public GameObject Scope2;
    public GameObject Scope3;
    public GameObject Scope4;
    public bool ScopeRun = true;
    public float AK47UScopeTime = 0f;
    public float AK47ScopeTime = 0f;
    public float PistolScopeTime = 0f;
    public float SniperScopeTime = 0f;
    public bool IsAK47UActive = false;
    public bool IsAK47Active = false;
    public bool IsPistolActive = false;
    public bool IsSniperActive = false;
    public SkinnedMeshRenderer AK47USMR;
    public SkinnedMeshRenderer AK47SMR;
    public SkinnedMeshRenderer SniperSMR;
    public SkinnedMeshRenderer PistolSMR;

    public bool Wlk = false;
    public AudioSource RunSound;
    public AudioSource RunSound2;
    public AudioSource RunSound3;
    public bool IsReloading = false;
    public GameObject AK47UGranadeThrowImage;
    public GameObject AK47UReloadImg;
    public GameObject PistolReloadImg;
    public GameObject SniperReloadImg;
    public GameObject AK47UReloadAmountImg;
    public GameObject PistolReloadAmountImg;
    public GameObject SniperReloadAmountImg;

    public Animator SWATAnimator;

    public GameObject SuperMelee;
    public GameObject Melee;
    public GameObject DeathBut;
    public GameObject DummyBut;
    public GameObject SwitchImage;

    public PlayerAiming PA;
    public GameObject PlayerNameGO;
    public TextMesh PlayerNameText;

    [SyncVar(hook = nameof(OnNameChanged))]
    public string PlayerName;

    private const string PlayerPrefsNameKey = "PlayerName";
    public Text CanvasStatusText;

    [SyncVar(hook = nameof(OnStatusTextChanged))]
    public string StatusText;

    public bool MVE;

    public GameObject CamTrans;

    public GameObject WS1;
    public GameObject WS1b;
    public GameObject WS1c;
    public GameObject WS1d;
    public GameObject WS1e;

    public GameObject WS2;
    public GameObject WS2b;
    public GameObject WS2c;
    public GameObject WS2d;
    public GameObject WS2e;

    public GameObject WS3;
    public GameObject WS3b;
    public GameObject WS3c;
    public GameObject WS3d;
    public GameObject WS3e;

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

    public Camera MainCamera;

    public Animator SWATAnimator2;

    public float Walking = 0f;
    public float Running = 0f;

    public PlayerHealth PH;

    public bool CanRun = true;

    void Start()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        PA = GetComponent<PlayerAiming>();

        PH = GetComponent<PlayerHealth>();
        if (isClient == true && isServer == false)
        {
            Move = true;
        }
    }

    public override void OnStartAuthority()
    {
        string defaultName = PlayerPrefs.GetString(PlayerPrefsNameKey);
        CmdSetupName(defaultName);
    }

    void OnNameChanged(string _Old, string _New)
    {
        PlayerNameText.text = PlayerName;
    }

    void OnStatusTextChanged(string _Old, string _New)
    {
        CanvasStatusText.text = StatusText;
    }

    public override void OnStopClient()
    {
        CmdSetupStat();
    }

    [Command]
    public void CmdSetupName(string _defaultName)
    {
        PlayerName = _defaultName;

    }

    [Command]
    public void CmdSetupStat()
    {
        StatusText = $"{PlayerName} Left.";
    }

    void Update()
    {
        PlayerNameGO.transform.LookAt(Camera.main.transform);
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
        if (hasAuthority == true)
        {
            PlayerNameGO.gameObject.SetActive(false);

            if (Move == true)
            {
                SWATAnimator2.SetBool("Walk", true);
                Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                controller.Move(move * Time.deltaTime * playerSpeed);
                if (move != Vector3.zero)
                {
                    MVE = true;
                    if (PA.Looking == false)
                    {
                        PA.Moving = true;
                    }
                    if (Input.GetAxis("Horizontal") == 1)
                    {
                        Debug.Log("HorizontalMovement");
                    }
                    else if (Input.GetAxis("Vertical") == 1)
                    {
                        Debug.Log("VerticalMovement");
                    }
                    playerVelocity.y += gravityValue * Time.deltaTime;
                    controller.Move(playerVelocity * Time.deltaTime);

                    SuperMelee.gameObject.SetActive(false);
                    Melee.gameObject.SetActive(false);
                    DummyBut.gameObject.SetActive(false);
                    DeathBut.gameObject.SetActive(false);
                    AK47UGranadeThrowImage.gameObject.SetActive(false);

                    Crosshair.localScale = new Vector3(1.2f, 1.2f, 1.2f);

                    if (groundedPlayer)
                    {
                        Walking += 1f;
                        if (Walking == 1f)
                        {
                            StartCoroutine(StopWalkSound());
                        }
                    }
                    if (CanRun == true)
                    {
                        MoveTime++;
                    }
                    else
                    {
                        MoveTime = 0;
                        playerSpeed = 10.0f;
                        SWATAnimator2.SetBool("Run", false);
                        if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
                        {
                            WS1Anim.SetBool("Run", false);
                        }
                        else
               if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
                        {
                            WS1bAnim.SetBool("Run", false);
                        }
                        else
                   if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
                        {
                            WS1cAnim.SetBool("Run", false);
                        }
                        else
                   if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
                        {
                            WS1dAnim.SetBool("Run", false);
                        }
                        else
                   if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
                        {
                            WS1eAnim.SetBool("Run", false);
                        }

                        if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
                        {

                            WS2Anim.SetBool("Run", false);
                        }
                        else
                                if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
                        {
                            WS2bAnim.SetBool("Run", false);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
                        {
                            WS2cAnim.SetBool("Run", false);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
                        {
                            WS2dAnim.SetBool("Run", false);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
                        {
                            WS2eAnim.SetBool("Run", false);
                        }

                        if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
                        {
                            WS3Anim.SetBool("Run", false);
                        }
                        else
                                if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
                        {
                            WS3bAnim.SetBool("Run", false);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
                        {
                            WS3cAnim.SetBool("Run", false);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
                        {
                            WS3dAnim.SetBool("Run", false);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
                        {
                            WS3eAnim.SetBool("Run", false);
                        }
                    }
                    gameObject.transform.forward = move;
                    if (MoveTime >= 5)
                    {
                        Run = true;
                        SWATAnimator2.SetBool("Walk", false);
                        SWATAnimator2.SetBool("Run", true);
                        if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
                        {
                            WS1Anim.SetBool("Run", true);
                        }
                        else
                   if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
                        {
                            WS1bAnim.SetBool("Run", true);
                        }
                        else
                       if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
                        {
                            WS1cAnim.SetBool("Run", true);
                        }
                        else
                       if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
                        {
                            WS1dAnim.SetBool("Run", true);
                        }
                        else
                       if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
                        {
                            WS1eAnim.SetBool("Run", true);
                        }

                        if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
                        {

                            WS2Anim.SetBool("Run", true);
                        }
                        else
                                if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
                        {
                            WS2bAnim.SetBool("Run", true);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
                        {
                            WS2cAnim.SetBool("Run", true);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
                        {
                            WS2dAnim.SetBool("Run", true);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
                        {
                            WS2eAnim.SetBool("Run", true);
                        }

                        if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
                        {
                            WS3Anim.SetBool("Run", true);
                        }
                        else
                                if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
                        {
                            WS3bAnim.SetBool("Run", true);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
                        {
                            WS3cAnim.SetBool("Run", true);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
                        {
                            WS3dAnim.SetBool("Run", true);
                        }
                        else
                                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
                        {
                            WS3eAnim.SetBool("Run", true);
                        }

                        playerSpeed = 20.0f;
                        if (groundedPlayer)
                        {
                            Walking = 0f;
                            Running += 1f;
                            if (Running == 1f)
                            {
                                StartCoroutine(StopRunSound());
                            }
                        }
                        if (!PlayerPrefs.HasKey("CurrentLevel"))
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 3)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 7)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 8)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 9)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 10)
                        {
                            WalkSound2.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 11)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 12)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 13)
                        {
                            WalkSound2.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 14)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 15)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 16)
                        {
                            WalkSound2.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 17)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 18)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 19)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 20)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 21)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 22)
                        {
                            WalkSound2.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 23)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 24)
                        {
                            WalkSound3.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 25)
                        {
                            WalkSound3.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 26)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 27)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 28)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 29)
                        {
                            WalkSound.Pause();
                        }
                        else if (PlayerPrefs.GetInt("CurrentLevel") == 30)
                        {
                            WalkSound.Pause();
                        }

                    }
                }
                else
                {
                    PA.Moving = false;
                    if (MoveTime > 5)
                    {
                        MoveTime = 0;
                    }

                    if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
                    {
                        WS1Anim.SetBool("Run", false);
                    }
                    else
                            if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
                    {
                        WS1bAnim.SetBool("Run", false);
                    }
                    else
                                if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
                    {
                        WS1cAnim.SetBool("Run", false);
                    }
                    else
                                if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
                    {
                        WS1dAnim.SetBool("Run", false);
                    }
                    else
                                if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
                    {
                        WS1eAnim.SetBool("Run", false);
                    }

                    if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
                    {

                        WS2Anim.SetBool("Run", false);
                    }
                    else
                            if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
                    {
                        WS2bAnim.SetBool("Run", false);
                    }
                    else
                                if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
                    {
                        WS2cAnim.SetBool("Run", false);
                    }
                    else
                                if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
                    {
                        WS2dAnim.SetBool("Run", false);
                    }
                    else
                                if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
                    {
                        WS2eAnim.SetBool("Run", false);
                    }

                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
                    {
                        WS3Anim.SetBool("Run", false);
                    }
                    else
                            if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
                    {
                        WS3bAnim.SetBool("Run", false);
                    }
                    else
                                if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
                    {
                        WS3cAnim.SetBool("Run", false);
                    }
                    else
                                if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
                    {
                        WS3dAnim.SetBool("Run", false);
                    }
                    else
                                if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
                    {
                        WS3eAnim.SetBool("Run", false);
                    }

                    if (PH.GUIRemoved == false)
                    {
                        AK47UGranadeThrowImage.gameObject.SetActive(true);
                    }
                    else if (PH.GUIRemoved == true)
                    {
                        AK47UGranadeThrowImage.gameObject.SetActive(false);
                    }
                    Crosshair.localScale = new Vector3(1f, 1f, 1f);

                    if (!PlayerPrefs.HasKey("CurrentLevel"))
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 3)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 7)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 8)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 9)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 10)
                    {
                        WalkSound2.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 11)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 12)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 13)
                    {
                        WalkSound2.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 14)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 15)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 16)
                    {
                        WalkSound2.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 17)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 18)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 19)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 20)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 21)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 22)
                    {
                        WalkSound2.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 23)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 24)
                    {
                        WalkSound3.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 25)
                    {
                        WalkSound3.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 26)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 27)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 28)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 29)
                    {
                        WalkSound.Pause();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 30)
                    {
                        WalkSound.Pause();
                    }

                    Walking = 0f;
                    Running = 0f;
                    MVE = false;

                    SWATAnimator2.SetBool("Run", false);
                    SWATAnimator2.SetBool("Walk", false);
                    SWATAnimator.SetBool("PistolWalk", false);

                    SWATAnimator.SetBool("Shoot", true);
                    Run = false;
                    if (IsMoveTimer == false)
                    {
                        if (IsReloading == false)
                        {
                            MoveTime = 0;
                        }
                    }
                    playerSpeed = 10.0f;

                    if (Run == false)
                    {
                        RunSound.Stop();
                        RunSound2.Stop();
                        RunSound3.Stop();
                    }
                }
                Debug.Log("NotMoving");
            }
            if (Input.GetButtonDown("Jump") && groundedPlayer)
            {
                Debug.Log("FPCJump");
                SWATAnimator2.SetBool("Jump", true);
                StartCoroutine(StopJump());
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
                playerVelocity.y += gravityValue * Time.deltaTime;
                controller.Move(playerVelocity * Time.deltaTime);
            }
        }
    }

    public IEnumerator StopWalkSound()
    {
        if (!PlayerPrefs.HasKey("CurrentLevel"))
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 3)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 7)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 8)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 9)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 10)
        {
            WalkSound2.Play();
            yield return new WaitForSeconds(1.0f);
            Walking = 0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 11)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 12)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 13)
        {
            WalkSound2.Play();
            yield return new WaitForSeconds(1.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 14)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 15)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 16)
        {
            WalkSound2.Play();
            yield return new WaitForSeconds(1.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 17)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 18)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 19)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 20)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 21)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 22)
        {
            WalkSound2.Play();
            yield return new WaitForSeconds(1.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 23)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 24)
        {
            WalkSound3.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 25)
        {
            WalkSound3.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 26)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 27)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 28)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 29)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 30)
        {
            WalkSound.Play();
            yield return new WaitForSeconds(10.0f);
            Walking = 0f;
        }
    }

    public IEnumerator StopRunSound()
    {
        if (!PlayerPrefs.HasKey("CurrentLevel"))
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 3)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 7)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 8)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 9)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 10)
        {
            RunSound2.Play();
            yield return new WaitForSeconds(0.4f);
            Running = 0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 11)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 12)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 13)
        {
            RunSound2.Play();
            yield return new WaitForSeconds(0.4f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 14)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 15)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 16)
        {
            RunSound2.Play();
            yield return new WaitForSeconds(0.4f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 17)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 18)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 19)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 20)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 21)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 22)
        {
            RunSound2.Play();
            yield return new WaitForSeconds(0.4f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 23)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 24)
        {
            RunSound3.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 25)
        {
            RunSound3.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 26)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 27)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 28)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 29)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 30)
        {
            RunSound.Play();
            yield return new WaitForSeconds(1.0f);
            Running = 0f;
        }
    }

    public IEnumerator StopJump()
    {

        yield return new WaitForSeconds(0.5f);
        SWATAnimator2.SetBool("Jump", false);

    }

    public IEnumerator DisableAK47UMesh()
    {
        yield return new WaitForSeconds(0.2f);
        AK47USMR.enabled = false;
    }
    public IEnumerator DisableAK47Mesh()
    {
        yield return new WaitForSeconds(0.2f);
        AK47SMR.enabled = false;
    }
    public IEnumerator DisableSniperMesh()
    {
        yield return new WaitForSeconds(0.2f);
        SniperSMR.enabled = false;
    }

    public void PlayWonderAnim()
    {
        WS1Anim.SetBool("Wonder", true);
    }

    public void StopWonderAnim()
    {
        WS1Anim.SetBool("Wonder", false);
    }

}

