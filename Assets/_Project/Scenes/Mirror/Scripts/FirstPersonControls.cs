using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class FirstPersonControls : NetworkBehaviour
{
    public enum PlayerControlMode { FirstPerson, ThirdPerson }
    public PlayerControlMode mode;

    public Transform fpCameraTransform;
    public Transform cameraPole;
    public Transform tpCameraTransform;
    public Transform graphics;
    public CharacterController characterController;

    public float cameraSensitivity;
    public float moveSpeed = 8.0f;
    public float moveInputDeadZone;

    public LayerMask cameraObstacleLayers;
    float maxCameraDistance;
    bool isMoving;

    int leftFingerId, rightFingerId;
    float halfScreenWidth;

    Vector2 lookInput;
    float cameraPitch;

    Vector2 moveTouchStartPosition;
    Vector2 moveInput;

    public bool Walk = false;
    public bool Look = true;
    public Vector3 playerVelocity;
    public bool groundedPlayer;
    public float gravityValue = -15.81f;
    public AudioSource WalkSound;
    public AudioSource WalkSound2;
    public AudioSource WalkSound3;
    public Animator AK47Uanim;
    public Animator AK47anim;
    public Animator Sniperanim;
    public Animator Pistolanim;
    public int WalkTime = 0;
    public Transform Crosshair;
    public GameObject DashImage;
    public Animator AK47Uanim2;
    public Animator AK47anim2;
    public Animator Sniperanim2;
    public Animator Pistolanim2;
    public float jumpHeight = 5.0f;
    public bool Jump = false;
    public bool IsMoveTimer = false;
    public bool Run = false;
    public bool AK47UAfterRunScope = false;
    public bool AK47AfterRunScope = false;
    public bool PistolAfterRunScope = false;
    public bool SniperAfterRunScope = false;
    public AK47UScopeEffect AUSE;
    public AK47ScopeEffect ASE;
    public PistolScopeEffect PSE;
    public SniperScopeEffect SSE;
    public GameObject[] ScopeUI;
    public bool ScopeRun = true;
    public float AK47UScopeTime = 0f;
    public float AK47ScopeTime = 0f;
    public float PistolScopeTime = 0f;
    public float SniperScopeTime = 0f;
    public bool IsAK47UActive = false;
    public bool IsAK47Active = false;
    public bool IsPistolActive = false;
    public bool IsSniperActive = false;
    public GameObject Scope1;
    public GameObject Scope2;
    public GameObject Scope3;
    public GameObject Scope4;
    public SkinnedMeshRenderer AK47USMR;
    public SkinnedMeshRenderer AK47SMR;
    public SkinnedMeshRenderer SniperSMR;
    public SkinnedMeshRenderer PistolSMR;

    public AudioSource RunSound;
    public AudioSource RunSound2;
    public AudioSource RunSound3;
    public bool IsReloading = false;
    public GameObject AK47UGranadeThrowImage;
    public GameObject AK47GranadeThrowImage;
    public GameObject PistolGranadeThrowImage;
    public GameObject SniperGranadeThrowImage;
    public GameObject AK47UReloadImg;
    public GameObject AK47ReloadImg;
    public GameObject PistolReloadImg;
    public GameObject SniperReloadImg;
    public GameObject AK47UReloadAmountImg;
    public GameObject AK47ReloadAmountImg;
    public GameObject PistolReloadAmountImg;
    public GameObject SniperReloadAmountImg;
    public Animator animator;
    public Animator SWATAnimator;
    public float CamRot = 0.0f;
    public GameObject SuperMelee;
    public GameObject Melee;
    public GameObject DeathBut;
    public GameObject DummyBut;
    public GameObject SwitchImage;
    public bool Moving;
    public bool Looking;
    public GameObject PlayerNameGO;
    public TextMesh PlayerNameText;
    [SyncVar(hook = nameof(OnNameChanged))]
    public string PlayerName;
    private const string PlayerPrefsNameKey = "PlayerName";

    public Text CanvasStatusText;

    [SyncVar(hook = nameof(OnStatusTextChanged))]
    public string StatusText;
    public GameObject CamTrans;
    public bool MVE;
    public Animator SWATAnimator2;
    public float Walking = 0f;
    public float Running = 0f;

    public PlayerHealth PH;

    public bool CanRun = true;

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

    public float oldPosition = 0.0f;
    public float oldZPosition = 0.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
        fpCameraTransform = animator.GetBoneTransform(HumanBodyBones.Chest);

        leftFingerId = -1;
        rightFingerId = -1;

        halfScreenWidth = Screen.width / 2;

        moveInputDeadZone = Mathf.Pow(Screen.height / moveInputDeadZone, 2);

        if (mode == PlayerControlMode.ThirdPerson)
        {
            cameraPitch = cameraPole.localRotation.eulerAngles.x;
            maxCameraDistance = tpCameraTransform.localPosition.z;
        }

        PH = GetComponent<PlayerHealth>();
        if (isClient == true && isServer == false)
        {
            Walk = true;
            Look = true;
        }

        oldPosition = transform.position.x;
        oldZPosition = transform.position.z;
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
        groundedPlayer = characterController.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        characterController.Move(playerVelocity * Time.deltaTime);
        if (hasAuthority == true)
        {
            PlayerNameGO.gameObject.SetActive(false);

            GetTouchInput();

            if (rightFingerId != -1)
            {

                Debug.Log("Rotating");
                Looking = true;

                LookAround2();
            }
            else
            {
                Looking = false;

                if (Look == true)
                {

                }

            }

            if (leftFingerId != -1)
            {

                Debug.Log("Moving");

                Move();
                playerVelocity.y += gravityValue * Time.deltaTime;
                characterController.Move(playerVelocity * Time.deltaTime);
            }
            else if (leftFingerId == -1)
            {
                if (WalkTime > 5)
                {
                    WalkTime = 0;
                }
                if (PH.GUIRemoved == false)
                {
                    AK47UGranadeThrowImage.gameObject.SetActive(true);
                }
                else if (PH.GUIRemoved == true)
                {
                    AK47UGranadeThrowImage.gameObject.SetActive(false);
                }

                DashImage.gameObject.SetActive(false);
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
                SWATAnimator2.SetBool("Walk", false);
                Run = false;
                if (IsMoveTimer == false)
                {
                    if (IsReloading == false)
                    {
                        WalkTime = 0;
                    }
                }
                moveSpeed = 8.0f;
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
                if (Run == false)
                {

                    RunSound.Stop();
                    RunSound2.Stop();
                    RunSound3.Stop();
                }
                Debug.Log("NotMoving");
                if (Look == true)
                {

                }
            }
        }
    }

    void LateUpdate()
    {
        if (hasAuthority == true)
        {

            GetTouchInput();

            if (rightFingerId != -1)
            {

                Debug.Log("Rotating");
                Looking = true;

                LookAround();
            }
            else
            {
                Looking = false;

                if (Look == true)
                {

                    fpCameraTransform.eulerAngles = new Vector3(cameraPitch, fpCameraTransform.eulerAngles.y, 0.0f);

                }

            }
        }

    }

    void FixedUpdate()
    {
        if (mode == PlayerControlMode.ThirdPerson)
        {
            MoveCamera();
        }
    }

    void GetTouchInput()
    {

        for (int i = 0; i < Input.touchCount; i++)
        {

            Touch t = Input.GetTouch(i);

            switch (t.phase)
            {
                case TouchPhase.Began:

                    if (t.position.x < halfScreenWidth && leftFingerId == -1)
                    {

                        leftFingerId = t.fingerId;

                        moveTouchStartPosition = t.position;
                    }
                    else if (t.position.x > halfScreenWidth && rightFingerId == -1)
                    {

                        rightFingerId = t.fingerId;
                    }

                    break;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:

                    if (t.fingerId == leftFingerId)
                    {

                        leftFingerId = -1;
                        Debug.Log("Stopped tracking left finger");
                        isMoving = false;
                    }
                    else if (t.fingerId == rightFingerId)
                    {

                        rightFingerId = -1;
                        Debug.Log("Stopped tracking right finger");
                    }

                    break;
                case TouchPhase.Moved:

                    if (t.fingerId == rightFingerId)
                    {
                        lookInput = t.deltaPosition * cameraSensitivity * Time.deltaTime;
                    }
                    else if (t.fingerId == leftFingerId)
                    {

                        moveInput = t.position - moveTouchStartPosition;
                    }

                    break;
                case TouchPhase.Stationary:

                    if (t.fingerId == rightFingerId)
                    {
                        lookInput = Vector2.zero;
                    }
                    break;
            }
        }
    }

    void LookAround()
    {
        if (Look == true)
        {
            switch (mode)
            {
                case PlayerControlMode.FirstPerson:

                    if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
                    {
                        cameraPitch = Mathf.Clamp(cameraPitch - lookInput.y, -65.0f, 65.0f);
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
                    {
                        cameraPitch = Mathf.Clamp(cameraPitch - lookInput.y, -65.0f, 65.0f);
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
                    {
                        cameraPitch = Mathf.Clamp(cameraPitch - lookInput.y, -65.0f, 65.0f);
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
                    {
                        cameraPitch = Mathf.Clamp(cameraPitch - lookInput.y, -65.0f, 65.0f);
                    }
                    else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
                    {
                        cameraPitch = Mathf.Clamp(cameraPitch - lookInput.y, -65.0f, 65.0f);
                    }
                    CamRot = Mathf.Clamp(CamRot, -1.0f, 10.0f);
                    cameraPitch = Mathf.Clamp(cameraPitch - lookInput.y, -65.0f, 65.0f);

                    fpCameraTransform.eulerAngles = new Vector3(cameraPitch, fpCameraTransform.eulerAngles.y, 0.0f);

                    break;
                case PlayerControlMode.ThirdPerson:
                    cameraPitch = Mathf.Clamp(cameraPitch - lookInput.y, -90f, 90f);
                    cameraPole.localRotation = Quaternion.Euler(cameraPitch, 0, 0);
                    break;
            }
            if (mode == PlayerControlMode.ThirdPerson && !isMoving)
            {
                graphics.Rotate(graphics.up, -lookInput.x);
            }

        }
    }

    void LookAround2()
    {
        if (Look == true)
        {

            transform.Rotate(transform.up, lookInput.x);

        }
    }

    void MoveCamera()
    {
        Vector3 rayDir = tpCameraTransform.position - cameraPole.position;
        Debug.DrawRay(cameraPole.position, rayDir, Color.red);
        if (Physics.Raycast(cameraPole.position, rayDir, out RaycastHit hit, Mathf.Abs(maxCameraDistance), cameraObstacleLayers))
        {
            tpCameraTransform.position = hit.point;
        }
        else
        {
            tpCameraTransform.localPosition = new Vector3(0, 0, maxCameraDistance);
        }
    }

    void Move()
    {
        if (Walk == true)
        {
            SWATAnimator2.SetBool("Walk", true);
            MVE = true;
            if (groundedPlayer && playerVelocity.y < 0)
            {
                playerVelocity.y = 0f;
            }

            if (CanRun == true)
            {
                WalkTime++;
            }
            else
            {
                WalkTime = 0;
                moveSpeed = 8.0f;
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
            if (WalkTime >= 5)
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
                moveSpeed = 20.0f;
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

            if (moveInput.sqrMagnitude <= moveInputDeadZone)
            {
                isMoving = false;
                return;
            }
            if (!isMoving)
            {

                isMoving = true;
            }

            Vector2 movementDirection = moveInput.normalized * moveSpeed * Time.deltaTime;

            characterController.Move(transform.right * movementDirection.x + transform.forward * movementDirection.y);

            if (transform.position.x > oldPosition)
            {
                Debug.Log("TransformFpsRight");

            }

            if (transform.position.x < oldPosition)
            {
                Debug.Log("TransformFpsLeft");

            }

            if (transform.position.x < oldZPosition)
            {
                Debug.Log("TransformFpsBack");

            }
            oldPosition = transform.position.x;
            oldZPosition = transform.position.z;
        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        characterController.Move(playerVelocity * Time.deltaTime);

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

    public void FPSJump()
    {
        if (groundedPlayer && playerVelocity.y < 0)
        {
            Debug.Log("FPCJump");
            SWATAnimator2.SetBool("Jump", true);
            StartCoroutine(StopJump());
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            playerVelocity.y += gravityValue * Time.deltaTime;
            characterController.Move(playerVelocity * Time.deltaTime);
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

}

