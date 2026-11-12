using Mirror;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerControllers : NetworkBehaviour
{

    public Button AttackBut;
    public Text AutoaimText;
    public Text AutoreloadText;
    public Button DropdeadBut;
    public DummyWaveDetection DWD;
    public DropDeadWaveDetection DDWD;
    public DummyCountdownTimer DummyCountDown;
    public DropDeadCountDown DropdeadCountDown;

    public QueenDummyWaveDetection QDWD;
    public QueenDropDeadWaveDetection QDDWD;
    public QueenDummyCountdownTimer QDummyCountDown;
    public QueenDropDeadCountDown QDropdeadCountDown;

    public int No = 1;
    public int ReloadNo = 1;
    public Text fpsDisplay;
    public Text averageFPSDisplay;
    int framePassed = 0;
    float fpsTotal = 0f;
    public Text minFPSDisplay;
    public Text maxFPSDisplay;
    float minFPS = Mathf.Infinity;
    float maxFPS = 0f;
    public DroidAttackScript DAS;
    public GameObject[] Enemy;
    public GameObject[] Removables;
    public GameObject MissionComplete;
    public AudioSource music;
    public int DeathNum = 0;
    public int IMusic = 0;
    public AudioSource IntenseMusic;
    public float GrenadeNo = 10.0f;
    public Text GrenadeAmount;
    public AutoShoot AS;
    public Text AutoshootText;
    public int AutoShootNo = 1;
    public Animator AK47UAnim;
    public Animator AK47Anim;
    public Animator SniperAnim;
    public Animator PistolAnim;

    public Animator AK47UAnim2;
    public Animator AK47Anim2;
    public Animator SniperAnim2;
    public Animator PistolAnim2;
    public WASDMovementScript WASD;
    public FirstPersonControls FPC;
    public bool Run = false;
    public float DashNo = 0.0f;
    public Transform DashImage;
    public bool IsAK47UActive = false;
    public bool IsAK47Active = false;
    public bool IsSniperActive = false;
    public bool IsPistolActive = false;
    public Collider col;
    public GameObject Melee2Panel;
    public float Melee2timeRemaining = 10.0f;
    public bool Melee2timerIsRunning = false;
    public Text Melee2timeText;
    public Animator SWATAnimator;
    public float ECN = 0f;
    public bool EnemyAllDead = false;
    public AudioSource SoldierEngageVoice;

    public bool NewPlayer;

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

    public bool DisplayFPS = true;

    void Start()
    {

        music = GameObject.FindGameObjectWithTag("BGMusicGO").GetComponent<AudioSource>();
        AS = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AutoShoot>();
        if (NewPlayer == false)
        {
            DropdeadCountDown = GetComponent<DropDeadCountDown>();
            DummyCountDown = GetComponent<DummyCountdownTimer>();
            DWD = GetComponent<DummyWaveDetection>();
            DDWD = GetComponent<DropDeadWaveDetection>();

            QDropdeadCountDown = GetComponent<QueenDropDeadCountDown>();
            QDummyCountDown = GetComponent<QueenDummyCountdownTimer>();
            QDWD = GetComponent<QueenDummyWaveDetection>();
            QDDWD = GetComponent<QueenDropDeadWaveDetection>();

        }
        MissionComplete.gameObject.SetActive(false);

        if (PlayerPrefs.GetInt("AutoaimValue") == 1)
        {
            AutoaimText.text = "OFF";

        }
        else if (PlayerPrefs.GetInt("AutoaimValue") == 2)
        {
            AutoaimText.text = "ON";

        }

        if (PlayerPrefs.GetInt("AutoReloadValue") == 1)
        {
            AutoreloadText.text = "OFF";
            if (NewPlayer == false)
            {

            }
            else
            {
                AssultWeapon.GetComponent<GunController>().AutoReload = false;
                AssultWeapon2.GetComponent<GunController>().AutoReload = false;
                AssultWeapon3.GetComponent<GunController>().AutoReload = false;
                AssultWeapon4.GetComponent<GunController>().AutoReload = false;
                AssultWeapon5.GetComponent<GunController>().AutoReload = false;

                SniperWeapon.GetComponent<GunController>().AutoReload = false;
                SniperWeapon2.GetComponent<GunController>().AutoReload = false;
                SniperWeapon3.GetComponent<GunController>().AutoReload = false;
                SniperWeapon4.GetComponent<GunController>().AutoReload = false;
                SniperWeapon5.GetComponent<GunController>().AutoReload = false;

                PistolWeapon.GetComponent<GunController>().AutoReload = false;
                PistolWeapon2.GetComponent<GunController>().AutoReload = false;
                PistolWeapon3.GetComponent<GunController>().AutoReload = false;
                PistolWeapon4.GetComponent<GunController>().AutoReload = false;
                PistolWeapon5.GetComponent<GunController>().AutoReload = false;
            }

        }
        else if (PlayerPrefs.GetInt("AutoReloadValue") == 2)
        {
            AutoreloadText.text = "ON";
            if (NewPlayer == false)
            {

            }
            else
            {
                AssultWeapon.GetComponent<GunController>().AutoReload = true;
                AssultWeapon2.GetComponent<GunController>().AutoReload = true;
                AssultWeapon3.GetComponent<GunController>().AutoReload = true;
                AssultWeapon4.GetComponent<GunController>().AutoReload = true;
                AssultWeapon5.GetComponent<GunController>().AutoReload = true;

                SniperWeapon.GetComponent<GunController>().AutoReload = true;
                SniperWeapon2.GetComponent<GunController>().AutoReload = true;
                SniperWeapon3.GetComponent<GunController>().AutoReload = true;
                SniperWeapon4.GetComponent<GunController>().AutoReload = true;
                SniperWeapon5.GetComponent<GunController>().AutoReload = true;

                PistolWeapon.GetComponent<GunController>().AutoReload = true;
                PistolWeapon2.GetComponent<GunController>().AutoReload = true;
                PistolWeapon3.GetComponent<GunController>().AutoReload = true;
                PistolWeapon4.GetComponent<GunController>().AutoReload = true;
                PistolWeapon5.GetComponent<GunController>().AutoReload = true;
            }
        }

        if (PlayerPrefs.GetInt("AutoShootValue") == 1)
        {
            AutoshootText.text = "OFF";
            AS.autoshoot = false;
        }
        else if (PlayerPrefs.GetInt("AutoShootValue") == 2)
        {
            AutoshootText.text = "ON";
            AS.autoshoot = true;
        }
        if (NewPlayer == false)
        {
            col = GameObject.FindGameObjectWithTag("PlayerLeftHand").GetComponent<Collider>();
        }

    }

    void Update()
    {
        if (hasAuthority == true)
        {
            if (Melee2timerIsRunning)
            {
                if (Melee2timeRemaining > 0)
                {
                    Melee2timeRemaining -= Time.smoothDeltaTime;
                    Melee2Displaytime(Melee2timeRemaining);
                    Melee2Panel.gameObject.SetActive(true);
                }
                else
                {
                    Melee2Panel.gameObject.SetActive(false);
                    Melee2timeText.text = "";
                    Melee2timeRemaining = 10.0f;
                    Melee2timerIsRunning = false;
                }
            }

            if (EnemyAllDead == true)
            {

            }
            if (DisplayFPS == true)
            {
                float fps = 1 / Time.unscaledDeltaTime;
                fpsDisplay.text = "" + fps;
                fpsTotal += fps;
                framePassed++;
                averageFPSDisplay.text = "" + (fpsTotal / framePassed);
                if (fps > maxFPS && framePassed > 10)
                {
                    maxFPS = fps;
                    maxFPSDisplay.text = "Max:" + maxFPS;
                }
                if (fps < minFPS && framePassed > 10)
                {
                    minFPS = fps;
                    minFPSDisplay.text = "Min:" + minFPS;
                }
            }
            if (EnemyAllDead == false)
            {
                Enemy = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (GameObject Enemies in Enemy)
                {
                    if (Vector3.Distance(Enemies.transform.position, transform.position) < 50.0f)
                    {
                        IMusic++;
                        if (IMusic == 1)
                        {
                            music.Pause();
                            SoldierEngageVoice.Play();
                            IntenseMusic.Play();
                            EnemyAllDead = true;
                        }
                    }
                }
            }
        }
    }

    public void Dumb()
    {

        DummyCountDown.DummyTime();
    }

    public void Dropdead()
    {

        DropdeadCountDown.DeathTime();
    }

    public void QDumb()
    {

        QDummyCountDown.DummyTime();
    }

    public void QDropdead()
    {

        QDropdeadCountDown.DeathTime();
    }

    public void ControlAutoaim()
    {
        No++;

        if (No == 2)
        {
            AutoaimText.text = "ON";

            PlayerPrefs.SetInt("AutoaimValue", 2);
        }
        else if (No == 3)
        {
            No = 1;
            AutoaimText.text = "OFF";

            PlayerPrefs.SetInt("AutoaimValue", 1);
        }
    }

    public void ControlAutoreload()
    {
        ReloadNo++;

        if (ReloadNo == 2)
        {
            AutoreloadText.text = "ON";
            if (NewPlayer == false)
            {

            }
            else
            {
                AssultWeapon.GetComponent<GunController>().AutoReload = true;
                AssultWeapon2.GetComponent<GunController>().AutoReload = true;
                AssultWeapon3.GetComponent<GunController>().AutoReload = true;
                AssultWeapon4.GetComponent<GunController>().AutoReload = true;
                AssultWeapon5.GetComponent<GunController>().AutoReload = true;

                SniperWeapon.GetComponent<GunController>().AutoReload = true;
                SniperWeapon2.GetComponent<GunController>().AutoReload = true;
                SniperWeapon3.GetComponent<GunController>().AutoReload = true;
                SniperWeapon4.GetComponent<GunController>().AutoReload = true;
                SniperWeapon5.GetComponent<GunController>().AutoReload = true;

                PistolWeapon.GetComponent<GunController>().AutoReload = true;
                PistolWeapon2.GetComponent<GunController>().AutoReload = true;
                PistolWeapon3.GetComponent<GunController>().AutoReload = true;
                PistolWeapon4.GetComponent<GunController>().AutoReload = true;
                PistolWeapon5.GetComponent<GunController>().AutoReload = true;
            }
            PlayerPrefs.SetInt("AutoReloadValue", 2);
        }
        else if (ReloadNo == 3)
        {
            ReloadNo = 1;
            AutoreloadText.text = "OFF";
            if (NewPlayer == false)
            {

            }
            else
            {
                AssultWeapon.GetComponent<GunController>().AutoReload = false;
                AssultWeapon2.GetComponent<GunController>().AutoReload = false;
                AssultWeapon3.GetComponent<GunController>().AutoReload = false;
                AssultWeapon4.GetComponent<GunController>().AutoReload = false;
                AssultWeapon5.GetComponent<GunController>().AutoReload = false;

                SniperWeapon.GetComponent<GunController>().AutoReload = false;
                SniperWeapon2.GetComponent<GunController>().AutoReload = false;
                SniperWeapon3.GetComponent<GunController>().AutoReload = false;
                SniperWeapon4.GetComponent<GunController>().AutoReload = false;
                SniperWeapon5.GetComponent<GunController>().AutoReload = false;

                PistolWeapon.GetComponent<GunController>().AutoReload = false;
                PistolWeapon2.GetComponent<GunController>().AutoReload = false;
                PistolWeapon3.GetComponent<GunController>().AutoReload = false;
                PistolWeapon4.GetComponent<GunController>().AutoReload = false;
                PistolWeapon5.GetComponent<GunController>().AutoReload = false;
            }
            PlayerPrefs.SetInt("AutoReloadValue", 1);
        }
    }

    public void ControlAutoshoot()
    {
        AutoShootNo++;

        if (AutoShootNo == 2)
        {
            AutoshootText.text = "ON";
            AS.autoshoot = true;
            PlayerPrefs.SetInt("AutoShootValue", 2);
        }
        else if (AutoShootNo == 3)
        {
            AutoShootNo = 1;
            AutoshootText.text = "OFF";
            AS.autoshoot = false;
            PlayerPrefs.SetInt("AutoShootValue", 1);
        }
    }

    public void Melee()
    {
        col.enabled = true;
        SWATAnimator.SetTrigger("SuperMelee");
        StartCoroutine(Reset());
    }
    public void OldMelee()
    {
        col.enabled = true;
        StartCoroutine(Reset());
        if (IsAK47UActive == true)
        {

            AK47UAnim.Play("Knife Attack 2", 0, 0f);
        }
        else if (IsSniperActive == true)
        {

            SniperAnim.Play("Knife Attack 2", 0, 0f);
        }
        else if (IsPistolActive == true)
        {

            PistolAnim.Play("Knife Attack 2", 0, 0f);
        }
    }
    public void Melee2()
    {
        SWATAnimator.SetBool("SuperMelee", true);
    }
    public void OldMelee2()
    {
        col.enabled = true;
        Melee2timerIsRunning = true;
        StartCoroutine(Reset2());
        if (IsAK47UActive == true)
        {

            AK47UAnim.Play("Knife Attack 1", 0, 0f);
        }
        else if (IsSniperActive == true)
        {

            SniperAnim.Play("Knife Attack 1", 0, 0f);
        }
        else if (IsPistolActive == true)
        {

            PistolAnim.Play("Knife Attack 1", 0, 0f);
        }
    }
    public void Dash()
    {
        DashNo += 1.0f;
        if (DashNo == 1.0f)
        {
            DashImage.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Run = true;
            if (Run == true)
            {
                FPC.IsMoveTimer = true;
                FPC.Run = true;
                WASD.IsMoveTimer = true;
                WASD.Run = true;
            }
        }
        else if (DashNo == 2.0f)
        {
            DashImage.localScale = new Vector3(1f, 1f, 1f);
            Run = false;
            if (Run == false)
            {
                FPC.IsMoveTimer = false;
                FPC.Run = false;
                WASD.IsMoveTimer = false;
                WASD.Run = false;
            }
            DashNo = 0f;
        }

    }
    public void Jump()
    {
        FPC.FPSJump();
    }

    void Melee2Displaytime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = Mathf.FloorToInt(timeToDisplay % 1) * 1000;
        Melee2timeText.text = string.Format("{0:00}:{1:00}", seconds, milliSeconds);
    }

    public IEnumerator Reset()
    {
        yield return new WaitForSeconds(.7f);
        col.enabled = false;
    }
    public IEnumerator Reset2()
    {
        yield return new WaitForSeconds(2f);
        col.enabled = false;
    }

    IEnumerator LoadMission()
    {
        music.Play();
        IMusic = 0;
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("SceneLoader");
    }

}
