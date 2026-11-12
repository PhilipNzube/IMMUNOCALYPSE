using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;

public class typewriter2 : NetworkBehaviour
{

    public GameObject Day1GO;
    public GameObject Day2GO;
    public GameObject Day3GO;
    public GameObject Day4GO;
    public GameObject Day5GO;
    public GameObject Day6GO;
    public GameObject Day7GO;
    public GameObject Day8GO;
    public GameObject Day9GO;
    public GameObject Day10GO;
    public GameObject Day11GO;
    public GameObject Day12GO;
    public GameObject Day13GO;
    public GameObject Day14GO;
    public GameObject Day15GO;
    public GameObject Day16GO;
    public GameObject Day17GO;
    public GameObject Day18GO;
    public GameObject Day19GO;
    public GameObject Day20GO;
    public GameObject Day21GO;
    public GameObject Day22GO;
    public GameObject Day23GO;
    public GameObject Day24GO;
    public GameObject Day25GO;
    public GameObject Day26GO;
    public GameObject Day27GO;
    public GameObject Day28GO;

    public Text Subtitle;
    public string Subtitlestory;
    public GameObject SubtitleBG;
    public Text Subtitle2;
    public string Subtitle2story;
    public GameObject Subtitle2BG;
    public Text Subtitle3;
    public string Subtitle3story;
    public GameObject Subtitle3BG;
    public Text Subtitle4;
    public string Subtitle4story;
    public GameObject Subtitle4BG;
    public Text Subtitle5;
    public string Subtitle5story;
    public GameObject Subtitle5BG;

    public Text Subtitle6;
    public string Subtitle6story;
    public GameObject Subtitle6BG;
    public Text Subtitle7;
    public string Subtitle7story;
    public GameObject Subtitle7BG;
    public Text Subtitle8;
    public string Subtitle8story;
    public GameObject Subtitle8BG;
    public Text Subtitle9;
    public string Subtitle9story;
    public GameObject Subtitle9BG;
    public Text Subtitle10;
    public string Subtitle10story;
    public GameObject Subtitle10BG;
    public Text Subtitle11;
    public string Subtitle11story;
    public GameObject Subtitle11BG;
    public Text Subtitle12;
    public string Subtitle12story;
    public GameObject Subtitle12BG;
    public Text Subtitle13;
    public string Subtitle13story;
    public GameObject Subtitle13BG;
    public Text Subtitle14;
    public string Subtitle14story;
    public GameObject Subtitle14BG;
    public Text Subtitle15;
    public string Subtitle15story;
    public GameObject Subtitle15BG;
    public Text Subtitle16;
    public string Subtitle16story;
    public GameObject Subtitle16BG;
    public Text Subtitle17;
    public string Subtitle17story;
    public GameObject Subtitle17BG;
    public Text Subtitle18;
    public string Subtitle18story;
    public GameObject Subtitle18BG;
    public Text Subtitle19;
    public string Subtitle19story;
    public GameObject Subtitle19BG;
    public Text Subtitle20;
    public string Subtitle20story;
    public GameObject Subtitle20BG;
    public Text Subtitle21;
    public string Subtitle21story;
    public GameObject Subtitle21BG;
    public Text Subtitle22;
    public string Subtitle22story;
    public GameObject Subtitle22BG;
    public Text Subtitle23;
    public string Subtitle23story;
    public GameObject Subtitle23BG;
    public Text Subtitle24;
    public string Subtitle24story;
    public GameObject Subtitle24BG;
    public Text Subtitle25;
    public string Subtitle25story;
    public GameObject Subtitle25BG;
    public Text Subtitle26;
    public string Subtitle26story;
    public GameObject Subtitle26BG;
    public Text Subtitle27;
    public string Subtitle27story;
    public GameObject Subtitle27BG;
    public Text Subtitle28;
    public string Subtitle28story;
    public GameObject Subtitle28BG;
    public Text Subtitle29;
    public string Subtitle29story;
    public GameObject Subtitle29BG;
    public Text Subtitle30;
    public string Subtitle30story;
    public GameObject Subtitle30BG;
    public Text Subtitle31;
    public string Subtitle31story;
    public GameObject Subtitle31BG;
    public Text Subtitle32;
    public string Subtitle32story;
    public GameObject Subtitle32BG;
    public Text Subtitle33;
    public string Subtitle33story;
    public GameObject Subtitle33BG;
    public Text Subtitle34;
    public string Subtitle34story;
    public GameObject Subtitle34BG;
    public Text Subtitle35;
    public string Subtitle35story;
    public GameObject Subtitle35BG;
    public Text Subtitle36;
    public string Subtitle36story;
    public GameObject Subtitle36BG;
    public Text Subtitle37;
    public string Subtitle37story;
    public GameObject Subtitle37BG;
    public Text Subtitle38;
    public string Subtitle38story;
    public GameObject Subtitle38BG;
    public Text Subtitle39;
    public string Subtitle39story;
    public GameObject Subtitle39BG;
    public Text Subtitle40;
    public string Subtitle40story;
    public GameObject Subtitle40BG;
    public Text Subtitle41;
    public string Subtitle41story;
    public GameObject Subtitle41BG;
    public Text Subtitle42;
    public string Subtitle42story;
    public GameObject Subtitle42BG;
    public Text Subtitle43;
    public string Subtitle43story;
    public GameObject Subtitle43BG;
    public Text Subtitle44;
    public string Subtitle44story;
    public GameObject Subtitle44BG;
    public Text Subtitle45;
    public string Subtitle45story;
    public GameObject Subtitle45BG;
    public Text Subtitle46;
    public string Subtitle46story;
    public GameObject Subtitle46BG;
    public Text Subtitle47;
    public string Subtitle47story;
    public GameObject Subtitle47BG;
    public Text Subtitle48;
    public string Subtitle48story;
    public GameObject Subtitle48BG;
    public Text Subtitle49;
    public string Subtitle49story;
    public GameObject Subtitle49BG;
    public Text Subtitle50;
    public string Subtitle50story;
    public GameObject Subtitle50BG;
    public Text Subtitle51;
    public string Subtitle51story;
    public GameObject Subtitle51BG;
    public Text Subtitle52;
    public string Subtitle52story;
    public GameObject Subtitle52BG;
    public Text Subtitle53;
    public string Subtitle53story;
    public GameObject Subtitle53BG;
    public Text Subtitle54;
    public string Subtitle54story;
    public GameObject Subtitle54BG;
    public Text Subtitle55;
    public string Subtitle55story;
    public GameObject Subtitle55BG;
    public Text Subtitle56;
    public string Subtitle56story;
    public GameObject Subtitle56BG;
    public Text Subtitle57;
    public string Subtitle57story;
    public GameObject Subtitle57BG;
    public Text Subtitle58;
    public string Subtitle58story;
    public GameObject Subtitle58BG;
    public Text Subtitle59;
    public string Subtitle59story;
    public GameObject Subtitle59BG;
    public Text Subtitle60;
    public string Subtitle60story;
    public GameObject Subtitle60BG;
    public Text Subtitle61;
    public string Subtitle61story;
    public GameObject Subtitle61BG;

    public Text Subtitle62;
    public string Subtitle62story;
    public GameObject Subtitle62BG;
    public Text Subtitle63;
    public string Subtitle63story;
    public GameObject Subtitle63BG;
    public Text Subtitle64;
    public string Subtitle64story;
    public GameObject Subtitle64BG;
    public Text Subtitle65;
    public string Subtitle65story;
    public GameObject Subtitle65BG;
    public Text Subtitle66;
    public string Subtitle66story;
    public GameObject Subtitle66BG;
    public Text Subtitle67;
    public string Subtitle67story;
    public GameObject Subtitle67BG;
    public Text Subtitle68;
    public string Subtitle68story;
    public GameObject Subtitle68BG;
    public Text Subtitle69;
    public string Subtitle69story;
    public GameObject Subtitle69BG;
    public Text Subtitle70;
    public string Subtitle70story;
    public GameObject Subtitle70BG;
    public Text Subtitle71;
    public string Subtitle71story;
    public GameObject Subtitle71BG;
    public Text Subtitle72;
    public string Subtitle72story;
    public GameObject Subtitle72BG;
    public Text Subtitle73;
    public string Subtitle73story;
    public GameObject Subtitle73BG;
    public Text Subtitle74;
    public string Subtitle74story;
    public GameObject Subtitle74BG;
    public Text Subtitle75;
    public string Subtitle75story;
    public GameObject Subtitle75BG;
    public Text Subtitle76;
    public string Subtitle76story;
    public GameObject Subtitle76BG;
    public GameObject CaptainFriend;
    public GameObject CaptainFriendBody;
    public GameObject FriendBody;
    public FriendAI FAI;
    public MiniMapComponent MMC;
    public MiniMapComponent MMC2;
    public PlayerCompass2 PC2;
    public WASDMovementScript WMS;
    public FirstPersonControls FPC;
    public PlayerAiming PA;
    public GameObject Player;
    public PlayerHealth PH;
    public TimerScript TS;
    public GameObject TutorialPanel;
    public Slider PlayerHealthBar;
    public bool FirstTime = true;
    public GameObject[] EnemyGO;
    public EnemyDissolveOverTime ED;

    public bool NewPlayer;

    public CameraController CC;

    public GameObject SkipButton;
    public GameObject SkipButton2;

    public bool SkipEnabled;
    public pausescript Pausescript;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        CaptainFriend = GameObject.Find("Captain");
        CaptainFriendBody = GameObject.Find("CaptainBody");
        FriendBody = GameObject.Find("FriendBody");
        if (NewPlayer == false)
        {
            WMS = GetComponent<WASDMovementScript>();
            FPC = GetComponent<FirstPersonControls>();
            PA = GetComponent<PlayerAiming>();
        }
        else
        {

        }
        PH = GetComponent<PlayerHealth>();
        TS = GetComponent<TimerScript>();

        if (SceneManager.GetActiveScene().buildIndex == 30)
        {
            ED = GameObject.Find("Vampire").GetComponent<EnemyDissolveOverTime>();
        }
        if (PlayerPrefs.HasKey("TutFirstTime"))
        {
            FirstTime = false;
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            FAI = CaptainFriendBody.GetComponent<FriendAI>();
            MMC = CaptainFriendBody.GetComponent<MiniMapComponent>();
            MMC2 = FriendBody.GetComponent<MiniMapComponent>();
            PC2 = CaptainFriendBody.GetComponent<PlayerCompass2>();
            Day1GO.gameObject.SetActive(true);
            Subtitlestory = Subtitle.text;

            Subtitle3story = Subtitle3.text;
            Subtitle4story = Subtitle4.text;
            Subtitle5story = Subtitle5.text;
            Subtitle6story = Subtitle6.text;
            Subtitle7story = Subtitle7.text;

            Subtitle.gameObject.SetActive(false);
            SubtitleBG.gameObject.SetActive(false);

            Subtitle3.gameObject.SetActive(false);
            Subtitle3BG.gameObject.SetActive(false);
            Subtitle4.gameObject.SetActive(false);
            Subtitle4BG.gameObject.SetActive(false);
            Subtitle5.gameObject.SetActive(false);
            Subtitle5BG.gameObject.SetActive(false);
            Subtitle6.gameObject.SetActive(false);
            Subtitle6BG.gameObject.SetActive(false);
            Subtitle7.gameObject.SetActive(false);
            Subtitle7BG.gameObject.SetActive(false);

            FAI.Captain = true;

        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            SkipButton.gameObject.SetActive(true);
            Day2GO.gameObject.SetActive(true);
            Subtitle2story = Subtitle2.text;
            Subtitle8story = Subtitle8.text;

            Subtitle2.gameObject.SetActive(false);
            Subtitle2BG.gameObject.SetActive(false);
            Subtitle8.gameObject.SetActive(false);
            Subtitle8BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            FAI = CaptainFriendBody.GetComponent<FriendAI>();
            MMC = CaptainFriendBody.GetComponent<MiniMapComponent>();
            MMC2 = FriendBody.GetComponent<MiniMapComponent>();
            PC2 = CaptainFriendBody.GetComponent<PlayerCompass2>();
            Day3GO.gameObject.SetActive(true);

            Subtitle9story = Subtitle9.text;
            Subtitle10story = Subtitle10.text;
            Subtitle11story = Subtitle11.text;

            Subtitle9.gameObject.SetActive(false);
            Subtitle9BG.gameObject.SetActive(false);
            Subtitle10.gameObject.SetActive(false);
            Subtitle10BG.gameObject.SetActive(false);
            Subtitle11.gameObject.SetActive(false);
            Subtitle11BG.gameObject.SetActive(false);

            FAI.Captain = true;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            SkipButton.gameObject.SetActive(true);
            Day4GO.gameObject.SetActive(true);
            Subtitle12story = Subtitle12.text;
            Subtitle13story = Subtitle13.text;

            Subtitle12.gameObject.SetActive(false);
            Subtitle12BG.gameObject.SetActive(false);
            Subtitle13.gameObject.SetActive(false);
            Subtitle13BG.gameObject.SetActive(false);

        }
        else if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            SkipButton.gameObject.SetActive(true);
            Day5GO.gameObject.SetActive(true);
            Subtitle14story = Subtitle14.text;
            Subtitle15story = Subtitle15.text;

            Subtitle14.gameObject.SetActive(false);
            Subtitle14BG.gameObject.SetActive(false);
            Subtitle15.gameObject.SetActive(false);
            Subtitle15BG.gameObject.SetActive(false);

        }
        else if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            SkipButton.gameObject.SetActive(true);
            Day6GO.gameObject.SetActive(true);
            Subtitle16story = Subtitle16.text;
            Subtitle17story = Subtitle17.text;

            Subtitle16.gameObject.SetActive(false);
            Subtitle16BG.gameObject.SetActive(false);
            Subtitle17.gameObject.SetActive(false);
            Subtitle17BG.gameObject.SetActive(false);

        }
        else if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            SkipButton.gameObject.SetActive(true);
            Day7GO.gameObject.SetActive(true);
            Subtitle18story = Subtitle18.text;
            Subtitle19story = Subtitle19.text;

            Subtitle18.gameObject.SetActive(false);
            Subtitle18BG.gameObject.SetActive(false);
            Subtitle19.gameObject.SetActive(false);
            Subtitle19BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            SkipButton.gameObject.SetActive(true);
            Day8GO.gameObject.SetActive(true);
            Subtitle20story = Subtitle20.text;
            Subtitle21story = Subtitle21.text;

            Subtitle20.gameObject.SetActive(false);
            Subtitle20BG.gameObject.SetActive(false);
            Subtitle21.gameObject.SetActive(false);
            Subtitle21BG.gameObject.SetActive(false);

        }
        else if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            SkipButton.gameObject.SetActive(true);
            Day9GO.gameObject.SetActive(true);
            Subtitle22story = Subtitle22.text;
            Subtitle23story = Subtitle23.text;

            Subtitle22.gameObject.SetActive(false);
            Subtitle22BG.gameObject.SetActive(false);
            Subtitle23.gameObject.SetActive(false);
            Subtitle23BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            SkipButton.gameObject.SetActive(true);
            Day10GO.gameObject.SetActive(true);
            Subtitle24story = Subtitle24.text;
            Subtitle25story = Subtitle25.text;

            Subtitle24.gameObject.SetActive(false);
            Subtitle24BG.gameObject.SetActive(false);
            Subtitle25.gameObject.SetActive(false);
            Subtitle25BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 13)
        {
            SkipButton.gameObject.SetActive(true);
            Day11GO.gameObject.SetActive(true);
            Subtitle26story = Subtitle26.text;
            Subtitle27story = Subtitle27.text;

            Subtitle26.gameObject.SetActive(false);
            Subtitle26BG.gameObject.SetActive(false);
            Subtitle27.gameObject.SetActive(false);
            Subtitle27BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 14)
        {
            SkipButton.gameObject.SetActive(true);
            Day12GO.gameObject.SetActive(true);
            Subtitle28story = Subtitle28.text;
            Subtitle29story = Subtitle29.text;

            Subtitle28.gameObject.SetActive(false);
            Subtitle28BG.gameObject.SetActive(false);
            Subtitle29.gameObject.SetActive(false);
            Subtitle29BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 15)
        {
            SkipButton.gameObject.SetActive(true);
            Day13GO.gameObject.SetActive(true);
            Subtitle30story = Subtitle30.text;
            Subtitle31story = Subtitle31.text;

            Subtitle30.gameObject.SetActive(false);
            Subtitle30BG.gameObject.SetActive(false);
            Subtitle31.gameObject.SetActive(false);
            Subtitle31BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 16)
        {
            SkipButton.gameObject.SetActive(true);
            Day14GO.gameObject.SetActive(true);
            Subtitle32story = Subtitle32.text;
            Subtitle33story = Subtitle33.text;

            Subtitle32.gameObject.SetActive(false);
            Subtitle32BG.gameObject.SetActive(false);
            Subtitle33.gameObject.SetActive(false);
            Subtitle33BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 17)
        {
            SkipButton.gameObject.SetActive(true);
            Day15GO.gameObject.SetActive(true);
            Subtitle34story = Subtitle34.text;
            Subtitle35story = Subtitle35.text;

            Subtitle34.gameObject.SetActive(false);
            Subtitle34BG.gameObject.SetActive(false);
            Subtitle35.gameObject.SetActive(false);
            Subtitle35BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 18)
        {
            SkipButton.gameObject.SetActive(true);
            Day16GO.gameObject.SetActive(true);
            Subtitle36story = Subtitle36.text;
            Subtitle37story = Subtitle37.text;

            Subtitle36.gameObject.SetActive(false);
            Subtitle36BG.gameObject.SetActive(false);
            Subtitle37.gameObject.SetActive(false);
            Subtitle37BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 19)
        {
            SkipButton.gameObject.SetActive(true);
            Day17GO.gameObject.SetActive(true);
            Subtitle38story = Subtitle38.text;
            Subtitle39story = Subtitle39.text;

            Subtitle38.gameObject.SetActive(false);
            Subtitle38BG.gameObject.SetActive(false);
            Subtitle39.gameObject.SetActive(false);
            Subtitle39BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 20)
        {
            SkipButton.gameObject.SetActive(true);
            Day18GO.gameObject.SetActive(true);
            Subtitle40story = Subtitle40.text;
            Subtitle41story = Subtitle41.text;

            Subtitle40.gameObject.SetActive(false);
            Subtitle40BG.gameObject.SetActive(false);
            Subtitle41.gameObject.SetActive(false);
            Subtitle41BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 21)
        {
            SkipButton.gameObject.SetActive(true);
            Day19GO.gameObject.SetActive(true);
            Subtitle42story = Subtitle42.text;
            Subtitle43story = Subtitle43.text;

            Subtitle42.gameObject.SetActive(false);
            Subtitle42BG.gameObject.SetActive(false);
            Subtitle43.gameObject.SetActive(false);
            Subtitle43BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 22)
        {
            SkipButton.gameObject.SetActive(true);
            Day20GO.gameObject.SetActive(true);
            Subtitle44story = Subtitle44.text;
            Subtitle45story = Subtitle45.text;

            Subtitle44.gameObject.SetActive(false);
            Subtitle44BG.gameObject.SetActive(false);
            Subtitle45.gameObject.SetActive(false);
            Subtitle45BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 23)
        {
            SkipButton.gameObject.SetActive(true);
            Day21GO.gameObject.SetActive(true);
            Subtitle46story = Subtitle46.text;
            Subtitle47story = Subtitle47.text;

            Subtitle46.gameObject.SetActive(false);
            Subtitle46BG.gameObject.SetActive(false);
            Subtitle47.gameObject.SetActive(false);
            Subtitle47BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 24)
        {
            SkipButton.gameObject.SetActive(true);
            Day22GO.gameObject.SetActive(true);
            Subtitle48story = Subtitle48.text;
            Subtitle49story = Subtitle49.text;

            Subtitle48.gameObject.SetActive(false);
            Subtitle48BG.gameObject.SetActive(false);
            Subtitle49.gameObject.SetActive(false);
            Subtitle49BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 25)
        {
            SkipButton.gameObject.SetActive(true);
            Day23GO.gameObject.SetActive(true);
            Subtitle50story = Subtitle50.text;
            Subtitle51story = Subtitle51.text;

            Subtitle50.gameObject.SetActive(false);
            Subtitle50BG.gameObject.SetActive(false);
            Subtitle51.gameObject.SetActive(false);
            Subtitle51BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 26)
        {
            SkipButton.gameObject.SetActive(true);
            Day24GO.gameObject.SetActive(true);
            Subtitle52story = Subtitle52.text;
            Subtitle53story = Subtitle53.text;

            Subtitle52.gameObject.SetActive(false);
            Subtitle52BG.gameObject.SetActive(false);
            Subtitle53.gameObject.SetActive(false);
            Subtitle53BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 27)
        {
            SkipButton.gameObject.SetActive(true);
            Day25GO.gameObject.SetActive(true);
            Subtitle54story = Subtitle54.text;
            Subtitle55story = Subtitle55.text;

            Subtitle54.gameObject.SetActive(false);
            Subtitle54BG.gameObject.SetActive(false);
            Subtitle55.gameObject.SetActive(false);
            Subtitle55BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 28)
        {
            SkipButton.gameObject.SetActive(true);
            Day26GO.gameObject.SetActive(true);
            Subtitle56story = Subtitle56.text;
            Subtitle57story = Subtitle57.text;

            Subtitle56.gameObject.SetActive(false);
            Subtitle56BG.gameObject.SetActive(false);
            Subtitle57.gameObject.SetActive(false);
            Subtitle57BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 29)
        {
            SkipButton.gameObject.SetActive(true);
            Day27GO.gameObject.SetActive(true);
            Subtitle58story = Subtitle58.text;
            Subtitle59story = Subtitle59.text;

            Subtitle58.gameObject.SetActive(false);
            Subtitle58BG.gameObject.SetActive(false);
            Subtitle59.gameObject.SetActive(false);
            Subtitle59BG.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 30)
        {
            SkipButton.gameObject.SetActive(true);
            Day28GO.gameObject.SetActive(true);
            Subtitle60story = Subtitle60.text;
            Subtitle61story = Subtitle61.text;
            Subtitle62story = Subtitle62.text;
            Subtitle63story = Subtitle63.text;
            Subtitle64story = Subtitle64.text;
            Subtitle65story = Subtitle65.text;
            Subtitle66story = Subtitle66.text;
            Subtitle67story = Subtitle67.text;
            Subtitle68story = Subtitle68.text;
            Subtitle69story = Subtitle69.text;
            Subtitle70story = Subtitle70.text;
            Subtitle71story = Subtitle71.text;
            Subtitle72story = Subtitle72.text;
            Subtitle73story = Subtitle73.text;
            Subtitle74story = Subtitle74.text;
            Subtitle75story = Subtitle75.text;
            Subtitle76story = Subtitle76.text;

            Subtitle60.gameObject.SetActive(false);
            Subtitle60BG.gameObject.SetActive(false);
            Subtitle61.gameObject.SetActive(false);
            Subtitle61BG.gameObject.SetActive(false);
            Subtitle62.gameObject.SetActive(false);
            Subtitle62BG.gameObject.SetActive(false);
            Subtitle63.gameObject.SetActive(false);
            Subtitle63BG.gameObject.SetActive(false);
            Subtitle64.gameObject.SetActive(false);
            Subtitle64BG.gameObject.SetActive(false);
            Subtitle65.gameObject.SetActive(false);
            Subtitle65BG.gameObject.SetActive(false);
            Subtitle66.gameObject.SetActive(false);
            Subtitle66BG.gameObject.SetActive(false);
            Subtitle67.gameObject.SetActive(false);
            Subtitle67BG.gameObject.SetActive(false);
            Subtitle68.gameObject.SetActive(false);
            Subtitle68BG.gameObject.SetActive(false);
            Subtitle69.gameObject.SetActive(false);
            Subtitle69BG.gameObject.SetActive(false);
            Subtitle70.gameObject.SetActive(false);
            Subtitle70BG.gameObject.SetActive(false);
            Subtitle71.gameObject.SetActive(false);
            Subtitle71BG.gameObject.SetActive(false);
            Subtitle72.gameObject.SetActive(false);
            Subtitle72BG.gameObject.SetActive(false);
            Subtitle73.gameObject.SetActive(false);
            Subtitle73BG.gameObject.SetActive(false);
            Subtitle74.gameObject.SetActive(false);
            Subtitle74BG.gameObject.SetActive(false);
            Subtitle75.gameObject.SetActive(false);
            Subtitle75BG.gameObject.SetActive(false);
            Subtitle76.gameObject.SetActive(false);
            Subtitle76BG.gameObject.SetActive(false);
        }

    }

    public void PS()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC());
        }
    }

    public void PS2()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles2());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC2());
        }
    }

    public void PS3()
    {

        if (isServer)
        {
            StartCoroutine(PlaySubtitles3());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC3());
        }
    }

    public void PS4()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles4());
        }
    }

    public void PS5()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles5());
        }
    }

    public void PS6()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles6());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC6());
        }
    }

    public void PS7()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles7());
        }
    }

    public void PS8()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles8());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC8());
        }
    }

    public void PS9()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles9());
        }
    }

    public void PS10()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles10());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC10());
        }
    }

    public void PS11()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles11());
        }
    }

    public void PS12()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles12());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC12());
        }
    }

    public void PS13()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles13());
        }
    }

    public void PS14()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles14());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC30());
        }
    }

    public void PS15()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles15());
        }
    }

    public void PS16()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles16());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC16());
        }
    }

    public void PS17()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles17());
        }
    }

    public void PS18()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles18());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC18());
        }
    }

    public void PS19()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles19());
        }
    }

    public void PS20()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles20());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC20());
        }
    }

    public void PS21()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles21());
        }
    }

    public void PS22()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles22());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC22());
        }
    }

    public void PS23()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles23());
        }
    }

    public void PS24()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles24());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC24());
        }
    }

    public void PS25()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles25());
        }
    }

    public void PS26()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles26());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC26());
        }
    }

    public void PS27()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles27());
        }
    }

    public void PS28()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles28());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC28());
        }
    }

    public void PS29()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles29());
        }
    }

    public void PS30()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles30());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC30());
        }

    }

    public void PS31()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles31());
        }
    }

    public void PS32()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles32());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC32());
        }
    }

    public void PS33()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles33());
        }
    }

    public void PS34()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles34());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC34());
        }
    }

    public void PS35()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles35());
        }
    }

    public void PS36()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles36());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC36());
        }
    }

    public void PS37()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles37());
        }
    }

    public void PS38()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles38());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC38());
        }
    }

    public void PS39()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles39());
        }
    }

    public void PS40()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles40());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC40());
        }
    }

    public void PS41()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles41());
        }
    }

    public void PS42()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles42());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC42());
        }
    }

    public void PS43()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles43());
        }
    }

    public void PS44()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles44());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC44());
        }
    }

    public void PS45()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles45());
        }
    }

    public void PS46()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles46());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC46());
        }
    }

    public void PS47()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles47());
        }
    }

    public void PS48()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles48());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC48());
        }
    }

    public void PS49()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles49());
        }
    }

    public void PS50()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles50());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC50());
        }
    }

    public void PS51()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles51());
        }
    }

    public void PS52()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles52());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC52());
        }
    }

    public void PS53()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles53());
        }
    }

    public void PS54()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles54());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC54());
        }
    }

    public void PS55()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles55());
        }
    }

    public void PS56()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles56());
        }
        else if (isClient)
        {
            StartCoroutine(PlaySubtitlesC56());
        }
    }

    public void PS57()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles57());
        }
    }

    public void PS58()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles58());
        }
    }

    public void PS59()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles59());
        }
    }
    public void PS60()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles60());
        }
    }
    public void PS61()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles61());
        }
    }
    public void PS62()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles62());
        }
    }
    public void PS63()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles63());
        }
    }
    public void PS64()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles64());
        }
    }
    public void PS65()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles65());
        }
    }
    public void PS66()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles66());
        }
    }
    public void PS67()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles67());
        }
    }
    public void PS68()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles68());
        }
    }
    public void PS69()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles69());
        }
    }
    public void PS70()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles70());
        }
    }
    public void PS71()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles71());
        }
    }

    public void PS72()
    {
        if (isServer)
        {
            StartCoroutine(PlaySubtitles72());
        }
    }

    public void PS73()
    {
        if (isServer)
        {
            PH.RemoveGUIS();
            PH.LockTakeDamage = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonCharacter>())
                    gameObject.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                CC.Look = false;
            }
            TS.STOP();
            StartCoroutine(PlaySubtitles73());
        }
    }

    public void PS74()
    {
        if (isServer)
        {
            TS.STOP();
            StartCoroutine(PlaySubtitles74());
        }
    }

    IEnumerator PlaySubtitles()
    {

        Subtitle.gameObject.SetActive(true);
        SubtitleBG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        MMC.enabled = false;
        PC2.Disable = true;
        MMC2.enabled = false;
        FAI.AlreadyCollided = true;
        FAI.Captain = false;
        Subtitle.gameObject.SetActive(false);
        SubtitleBG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC()
    {

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles2()
    {

        Subtitle10.gameObject.SetActive(true);
        Subtitle10BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle10.gameObject.SetActive(false);
        Subtitle10BG.gameObject.SetActive(false);

    }

    IEnumerator PlaySubtitlesC2()
    {

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles3()
    {

        SkipButton.gameObject.SetActive(true);
        Subtitle2.gameObject.SetActive(false);
        Subtitle2BG.gameObject.SetActive(false);
        Subtitle3.gameObject.SetActive(true);
        Subtitle3BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (FirstTime == true)
        {
            FirstTime = false;
            PlayerPrefs.SetInt("TutFirstTime", 1);
            TutorialPanel.gameObject.SetActive(true);
            PlayerHealthBar.gameObject.SetActive(false);

            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                CC.Look = false;
            }
            MMC.enabled = false;
            PC2.Disable = true;
            MMC2.enabled = false;
            FAI.AlreadyCollided = true;
            FAI.Captain = false;
            SkipButton.gameObject.SetActive(false);
            Subtitle3.gameObject.SetActive(false);
            Subtitle3BG.gameObject.SetActive(false);
            PS();
            Time.timeScale = 0f;
        }
        else
        {

            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            MMC.enabled = false;
            PC2.Disable = true;
            MMC2.enabled = false;
            FAI.AlreadyCollided = true;
            FAI.Captain = false;
            SkipButton.gameObject.SetActive(false);
            Subtitle3.gameObject.SetActive(false);
            Subtitle3BG.gameObject.SetActive(false);
            PS();
        }
    }

    IEnumerator PlaySubtitlesC3()
    {

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        MMC.enabled = false;
        PC2.Disable = true;
        MMC2.enabled = false;
        FAI.AlreadyCollided = true;
        FAI.Captain = false;

    }

    IEnumerator PlaySubtitles4()
    {

        Subtitle3.gameObject.SetActive(false);
        Subtitle3BG.gameObject.SetActive(false);
        Subtitle4.gameObject.SetActive(true);
        Subtitle4BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);

        Subtitle4.gameObject.SetActive(false);
        Subtitle4BG.gameObject.SetActive(false);
        Subtitle5.gameObject.SetActive(true);
        Subtitle5BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        Subtitle5.gameObject.SetActive(false);
        Subtitle5BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitles5()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle5.gameObject.SetActive(false);
        Subtitle5BG.gameObject.SetActive(false);
        Subtitle6.gameObject.SetActive(true);
        Subtitle6BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(8.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle6.gameObject.SetActive(false);
        Subtitle6BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles6()
    {

        Subtitle2.gameObject.SetActive(true);
        Subtitle2BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle2.gameObject.SetActive(false);
        Subtitle2BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC6()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles7()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle7.gameObject.SetActive(false);
        Subtitle7BG.gameObject.SetActive(false);
        Subtitle8.gameObject.SetActive(true);
        Subtitle8BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(15.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle8.gameObject.SetActive(false);
        Subtitle8BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles8()
    {

        SkipButton.gameObject.SetActive(true);
        Subtitle8.gameObject.SetActive(false);
        Subtitle8BG.gameObject.SetActive(false);
        Subtitle9.gameObject.SetActive(true);
        Subtitle9BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(15.0f);

        PH.ShowGUIS();
        if (NewPlayer == false)
        {

            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        MMC.enabled = false;
        PC2.Disable = true;
        MMC2.enabled = false;
        FAI.AlreadyCollided = true;
        FAI.Captain = false;
        SkipButton.gameObject.SetActive(false);
        Subtitle9.gameObject.SetActive(false);
        Subtitle9BG.gameObject.SetActive(false);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
    }

    IEnumerator PlaySubtitlesC8()
    {

        yield return new WaitForSeconds(15.0f);

        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        MMC.enabled = false;
        PC2.Disable = true;
        MMC2.enabled = false;
        FAI.AlreadyCollided = true;
        FAI.Captain = false;
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
    }

    IEnumerator PlaySubtitles9()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle10.gameObject.SetActive(false);
        Subtitle10BG.gameObject.SetActive(false);
        Subtitle11.gameObject.SetActive(true);
        Subtitle11BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(8.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle11.gameObject.SetActive(false);
        Subtitle11BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles10()
    {

        Subtitle12.gameObject.SetActive(true);
        Subtitle12BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle12.gameObject.SetActive(false);
        Subtitle12BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC10()
    {

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles11()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle12.gameObject.SetActive(false);
        Subtitle12BG.gameObject.SetActive(false);
        Subtitle13.gameObject.SetActive(true);
        Subtitle13BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(8.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle13.gameObject.SetActive(false);
        Subtitle13BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles12()
    {

        Subtitle14.gameObject.SetActive(true);
        Subtitle14BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle14.gameObject.SetActive(false);
        Subtitle14BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC12()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles13()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle14.gameObject.SetActive(false);
        Subtitle14BG.gameObject.SetActive(false);
        Subtitle15.gameObject.SetActive(true);
        Subtitle15BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle15.gameObject.SetActive(false);
        Subtitle15BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles14()
    {

        Subtitle16.gameObject.SetActive(true);
        Subtitle16BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle16.gameObject.SetActive(false);
        Subtitle16BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC14()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles15()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle16.gameObject.SetActive(false);
        Subtitle16BG.gameObject.SetActive(false);
        Subtitle17.gameObject.SetActive(true);
        Subtitle17BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle17.gameObject.SetActive(false);
        Subtitle17BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles16()
    {

        Subtitle18.gameObject.SetActive(true);
        Subtitle18BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle18.gameObject.SetActive(false);
        Subtitle18BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC16()
    {

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles17()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle18.gameObject.SetActive(false);
        Subtitle18BG.gameObject.SetActive(false);
        Subtitle19.gameObject.SetActive(true);
        Subtitle19BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(8.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle19.gameObject.SetActive(false);
        Subtitle19BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles18()
    {

        Subtitle20.gameObject.SetActive(true);
        Subtitle20BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle20.gameObject.SetActive(false);
        Subtitle20BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC18()
    {

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles19()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle20.gameObject.SetActive(false);
        Subtitle20BG.gameObject.SetActive(false);
        Subtitle21.gameObject.SetActive(true);
        Subtitle21BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(8.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle21.gameObject.SetActive(false);
        Subtitle21BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles20()
    {

        Subtitle22.gameObject.SetActive(true);
        Subtitle22BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle22.gameObject.SetActive(false);
        Subtitle22BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC20()
    {

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles21()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle22.gameObject.SetActive(false);
        Subtitle22BG.gameObject.SetActive(false);
        Subtitle23.gameObject.SetActive(true);
        Subtitle23BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(8.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle23.gameObject.SetActive(false);
        Subtitle23BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles22()
    {

        Subtitle24.gameObject.SetActive(true);
        Subtitle24BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle24.gameObject.SetActive(false);
        Subtitle24BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC22()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles23()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle24.gameObject.SetActive(false);
        Subtitle24BG.gameObject.SetActive(false);
        Subtitle25.gameObject.SetActive(true);
        Subtitle25BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle25.gameObject.SetActive(false);
        Subtitle25BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles24()
    {

        Subtitle26.gameObject.SetActive(true);
        Subtitle26BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle26.gameObject.SetActive(false);
        Subtitle26BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC24()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles25()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle26.gameObject.SetActive(false);
        Subtitle26BG.gameObject.SetActive(false);
        Subtitle27.gameObject.SetActive(true);
        Subtitle27BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle27.gameObject.SetActive(false);
        Subtitle27BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles26()
    {

        Subtitle28.gameObject.SetActive(true);
        Subtitle28BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle28.gameObject.SetActive(false);
        Subtitle28BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC26()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles27()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle28.gameObject.SetActive(false);
        Subtitle28BG.gameObject.SetActive(false);
        Subtitle29.gameObject.SetActive(true);
        Subtitle29BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle29.gameObject.SetActive(false);
        Subtitle29BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles28()
    {

        Subtitle30.gameObject.SetActive(true);
        Subtitle30BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle30.gameObject.SetActive(false);
        Subtitle30BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC28()
    {

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles29()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle30.gameObject.SetActive(false);
        Subtitle30BG.gameObject.SetActive(false);
        Subtitle31.gameObject.SetActive(true);
        Subtitle31BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(8.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle31.gameObject.SetActive(false);
        Subtitle31BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles30()
    {

        Subtitle32.gameObject.SetActive(true);
        Subtitle32BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(15.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle32.gameObject.SetActive(false);
        Subtitle32BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC30()
    {

        yield return new WaitForSeconds(15.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles31()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle32.gameObject.SetActive(false);
        Subtitle32BG.gameObject.SetActive(false);
        Subtitle33.gameObject.SetActive(true);
        Subtitle33BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle33.gameObject.SetActive(false);
        Subtitle33BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles32()
    {

        Subtitle34.gameObject.SetActive(true);
        Subtitle34BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle34.gameObject.SetActive(false);
        Subtitle34BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC32()
    {

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles33()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle34.gameObject.SetActive(false);
        Subtitle34BG.gameObject.SetActive(false);
        Subtitle35.gameObject.SetActive(true);
        Subtitle35BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(8.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle35.gameObject.SetActive(false);
        Subtitle35BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles34()
    {

        Subtitle36.gameObject.SetActive(true);
        Subtitle36BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle36.gameObject.SetActive(false);
        Subtitle36BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC34()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles35()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle36.gameObject.SetActive(false);
        Subtitle36BG.gameObject.SetActive(false);
        Subtitle37.gameObject.SetActive(true);
        Subtitle37BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle37.gameObject.SetActive(false);
        Subtitle37BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles36()
    {

        Subtitle38.gameObject.SetActive(true);
        Subtitle38BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(5.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle38.gameObject.SetActive(false);
        Subtitle38BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC36()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles37()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle38.gameObject.SetActive(false);
        Subtitle38BG.gameObject.SetActive(false);
        Subtitle39.gameObject.SetActive(true);
        Subtitle39BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle39.gameObject.SetActive(false);
        Subtitle39BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles38()
    {

        Subtitle40.gameObject.SetActive(true);
        Subtitle40BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle40.gameObject.SetActive(false);
        Subtitle40BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC38()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles39()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle40.gameObject.SetActive(false);
        Subtitle40BG.gameObject.SetActive(false);
        Subtitle41.gameObject.SetActive(true);
        Subtitle41BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle41.gameObject.SetActive(false);
        Subtitle41BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles40()
    {

        Subtitle42.gameObject.SetActive(true);
        Subtitle42BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle42.gameObject.SetActive(false);
        Subtitle42BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC40()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles41()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle42.gameObject.SetActive(false);
        Subtitle42BG.gameObject.SetActive(false);
        Subtitle43.gameObject.SetActive(true);
        Subtitle43BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle43.gameObject.SetActive(false);
        Subtitle43BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles42()
    {

        Subtitle44.gameObject.SetActive(true);
        Subtitle44BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle44.gameObject.SetActive(false);
        Subtitle44BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC42()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles43()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle44.gameObject.SetActive(false);
        Subtitle44BG.gameObject.SetActive(false);
        Subtitle45.gameObject.SetActive(true);
        Subtitle45BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle45.gameObject.SetActive(false);
        Subtitle45BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles44()
    {

        Subtitle46.gameObject.SetActive(true);
        Subtitle46BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle46.gameObject.SetActive(false);
        Subtitle46BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC44()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles45()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle46.gameObject.SetActive(false);
        Subtitle46BG.gameObject.SetActive(false);
        Subtitle47.gameObject.SetActive(true);
        Subtitle47BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(15.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle47.gameObject.SetActive(false);
        Subtitle47BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles46()
    {

        Subtitle48.gameObject.SetActive(true);
        Subtitle48BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle48.gameObject.SetActive(false);
        Subtitle48BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC46()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles47()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle48.gameObject.SetActive(false);
        Subtitle48BG.gameObject.SetActive(false);
        Subtitle49.gameObject.SetActive(true);
        Subtitle49BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle49.gameObject.SetActive(false);
        Subtitle49BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles48()
    {

        Subtitle50.gameObject.SetActive(true);
        Subtitle50BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(5.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle50.gameObject.SetActive(false);
        Subtitle50BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC48()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles49()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle50.gameObject.SetActive(false);
        Subtitle50BG.gameObject.SetActive(false);
        Subtitle51.gameObject.SetActive(true);
        Subtitle51BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle51.gameObject.SetActive(false);
        Subtitle51BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles50()
    {

        Subtitle52.gameObject.SetActive(true);
        Subtitle52BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle52.gameObject.SetActive(false);
        Subtitle52BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC50()
    {

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles51()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle52.gameObject.SetActive(false);
        Subtitle53.gameObject.SetActive(true);
        Subtitle53BG.gameObject.SetActive(true);

        SkipButton2.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        Subtitle53.gameObject.SetActive(false);
        Subtitle53BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles52()
    {

        Subtitle54.gameObject.SetActive(true);
        Subtitle54BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(15.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle54.gameObject.SetActive(false);
        Subtitle54BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC52()
    {

        yield return new WaitForSeconds(15.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles53()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle54.gameObject.SetActive(false);
        Subtitle54BG.gameObject.SetActive(false);
        Subtitle55.gameObject.SetActive(true);
        Subtitle55BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle55.gameObject.SetActive(false);
        Subtitle55BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles54()
    {

        Subtitle56.gameObject.SetActive(true);
        Subtitle56BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        SkipButton.gameObject.SetActive(false);
        Subtitle56.gameObject.SetActive(false);
        Subtitle56BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC54()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles55()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle56.gameObject.SetActive(false);
        Subtitle56BG.gameObject.SetActive(false);
        Subtitle57.gameObject.SetActive(true);
        Subtitle57BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle57.gameObject.SetActive(false);
        Subtitle57BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles56()
    {

        Subtitle58.gameObject.SetActive(true);
        Subtitle58BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }

        SkipButton.gameObject.SetActive(false);
        Subtitle58.gameObject.SetActive(false);
        Subtitle58BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitlesC56()
    {

        yield return new WaitForSeconds(3.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
        }

    }

    IEnumerator PlaySubtitles57()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle58.gameObject.SetActive(false);
        Subtitle58BG.gameObject.SetActive(false);
        Subtitle59.gameObject.SetActive(true);
        Subtitle59BG.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle59.gameObject.SetActive(false);
        Subtitle59BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles58()
    {

        Subtitle60.gameObject.SetActive(true);
        Subtitle60BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        if (SkipEnabled == false)
        {
            PS59();
        }
        Subtitle60.gameObject.SetActive(false);
        Subtitle60BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitles59()
    {

        Subtitle61.gameObject.SetActive(true);
        Subtitle61BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        if (SkipEnabled == false)
        {
            PS60();
        }
        Subtitle61.gameObject.SetActive(false);
        Subtitle61BG.gameObject.SetActive(false);
    }
    IEnumerator PlaySubtitles60()
    {

        Subtitle62.gameObject.SetActive(true);
        Subtitle62BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        if (SkipEnabled == false)
        {
            PS61();
        }
        Subtitle62.gameObject.SetActive(false);
        Subtitle62BG.gameObject.SetActive(false);
    }
    IEnumerator PlaySubtitles61()
    {

        Subtitle63.gameObject.SetActive(true);
        Subtitle63BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        if (SkipEnabled == false)
        {
            PS62();
        }
        Subtitle63.gameObject.SetActive(false);
        Subtitle63BG.gameObject.SetActive(false);
    }
    IEnumerator PlaySubtitles62()
    {

        Subtitle64.gameObject.SetActive(true);
        Subtitle64BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        if (SkipEnabled == false)
        {
            PS63();
        }
        Subtitle64.gameObject.SetActive(false);
        Subtitle64BG.gameObject.SetActive(false);
    }
    IEnumerator PlaySubtitles63()
    {

        Subtitle65.gameObject.SetActive(true);
        Subtitle65BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        if (SkipEnabled == false)
        {
            PS64();
        }
        Subtitle65.gameObject.SetActive(false);
        Subtitle65BG.gameObject.SetActive(false);
    }
    IEnumerator PlaySubtitles64()
    {

        Subtitle66.gameObject.SetActive(true);
        Subtitle66BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(15.0f);
        if (SkipEnabled == false)
        {
            PS65();
        }
        Subtitle66.gameObject.SetActive(false);
        Subtitle66BG.gameObject.SetActive(false);
    }
    IEnumerator PlaySubtitles65()
    {

        Subtitle67.gameObject.SetActive(true);
        Subtitle67BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        if (SkipEnabled == false)
        {
            PS66();
        }
        Subtitle67.gameObject.SetActive(false);
        Subtitle67BG.gameObject.SetActive(false);
    }
    IEnumerator PlaySubtitles66()
    {

        Subtitle68.gameObject.SetActive(true);
        Subtitle68BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(15.0f);
        if (SkipEnabled == false)
        {
            PS67();
        }
        Subtitle68.gameObject.SetActive(false);
        Subtitle68BG.gameObject.SetActive(false);
    }
    IEnumerator PlaySubtitles67()
    {

        Subtitle69.gameObject.SetActive(true);
        Subtitle69BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(15.0f);
        if (SkipEnabled == false)
        {
            PS68();
        }
        Subtitle69.gameObject.SetActive(false);
        Subtitle69BG.gameObject.SetActive(false);
    }
    IEnumerator PlaySubtitles68()
    {

        Subtitle70.gameObject.SetActive(true);
        Subtitle70BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(15.0f);
        if (SkipEnabled == false)
        {
            PS69();
        }
        Subtitle70.gameObject.SetActive(false);
        Subtitle70BG.gameObject.SetActive(false);
    }
    IEnumerator PlaySubtitles69()
    {

        Subtitle71.gameObject.SetActive(true);
        Subtitle71BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(15.0f);
        if (SkipEnabled == false)
        {
            PS70();
        }
        Subtitle71.gameObject.SetActive(false);
        Subtitle71BG.gameObject.SetActive(false);
    }
    IEnumerator PlaySubtitles70()
    {

        Subtitle72.gameObject.SetActive(true);
        Subtitle72BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        if (SkipEnabled == false)
        {
            PS71();
        }
        Subtitle72.gameObject.SetActive(false);
        Subtitle72BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitles71()
    {

        Subtitle73.gameObject.SetActive(true);
        Subtitle73BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        if (SkipEnabled == false)
        {
            PS72();
        }
        Subtitle73.gameObject.SetActive(false);
        Subtitle73BG.gameObject.SetActive(false);
    }

    IEnumerator PlaySubtitles72()
    {

        SkipButton.gameObject.SetActive(false);
        Subtitle74.gameObject.SetActive(true);
        Subtitle74BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemy in EnemyGO)
        {
            Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            Enemy.GetComponent<EnemyChaseScript>().PauseChaseAtTheBeginning = false;

        }
        PH.ShowGUIS();
        if (NewPlayer == false)
        {
            FPC.Walk = true;
            FPC.Look = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {

            if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
            CC.Look = true;
        }
        ED.enabled = true;
        SkipButton.gameObject.SetActive(false);
        Subtitle74.gameObject.SetActive(false);
        Subtitle74BG.gameObject.SetActive(false);
    }

    public void SkipSubtitle()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (FirstTime == true)
            {
                FirstTime = false;
                PlayerPrefs.SetInt("TutFirstTime", 1);
                TutorialPanel.gameObject.SetActive(true);
                PlayerHealthBar.gameObject.SetActive(false);
                if (NewPlayer == false)
                {
                    FPC.Walk = true;
                    FPC.Look = true;
                    WMS.Move = true;
                    PA.Look = true;
                }
                else
                {
                    if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    CC.Look = false;
                }
                SkipEnabled = true;
                MMC.enabled = false;
                PC2.Disable = true;
                MMC2.enabled = false;
                FAI.AlreadyCollided = true;
                FAI.Captain = false;
                Subtitle3.gameObject.SetActive(false);
                Subtitle3BG.gameObject.SetActive(false);
                SkipButton.gameObject.SetActive(false);
                PS();
                Time.timeScale = 0f;
            }
            else
            {
                if (NewPlayer == false)
                {
                    FPC.Walk = true;
                    FPC.Look = true;
                    WMS.Move = true;
                    PA.Look = true;
                }
                else
                {
                    if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                        gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                    CC.Look = true;
                }
                SkipEnabled = true;
                MMC.enabled = false;
                PC2.Disable = true;
                MMC2.enabled = false;
                FAI.AlreadyCollided = true;
                FAI.Captain = false;
                Subtitle3.gameObject.SetActive(false);
                Subtitle3BG.gameObject.SetActive(false);
                SkipButton.gameObject.SetActive(false);
                PS();
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle2.gameObject.SetActive(false);
            Subtitle2BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            PH.ShowGUIS();
            if (NewPlayer == false)
            {

                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            MMC.enabled = false;
            PC2.Disable = true;
            MMC2.enabled = false;
            FAI.AlreadyCollided = true;
            FAI.Captain = false;
            Subtitle9.gameObject.SetActive(false);
            Subtitle9BG.gameObject.SetActive(false);
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle12.gameObject.SetActive(false);
            Subtitle12BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle14.gameObject.SetActive(false);
            Subtitle14BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle16.gameObject.SetActive(false);
            Subtitle16BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);

        }
        else if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle18.gameObject.SetActive(false);
            Subtitle18BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle20.gameObject.SetActive(false);
            Subtitle20BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);

        }
        else if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle22.gameObject.SetActive(false);
            Subtitle22BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle24.gameObject.SetActive(false);
            Subtitle24BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 13)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle26.gameObject.SetActive(false);
            Subtitle26BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 14)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle28.gameObject.SetActive(false);
            Subtitle28BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 15)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle30.gameObject.SetActive(false);
            Subtitle30BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 16)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle32.gameObject.SetActive(false);
            Subtitle32BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 17)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle34.gameObject.SetActive(false);
            Subtitle34BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 18)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle36.gameObject.SetActive(false);
            Subtitle36BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 19)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle38.gameObject.SetActive(false);
            Subtitle38BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 20)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle40.gameObject.SetActive(false);
            Subtitle40BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 21)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle42.gameObject.SetActive(false);
            Subtitle42BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 22)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle44.gameObject.SetActive(false);
            Subtitle44BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 23)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle46.gameObject.SetActive(false);
            Subtitle46BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 24)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle48.gameObject.SetActive(false);
            Subtitle48BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 25)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle50.gameObject.SetActive(false);
            Subtitle50BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 26)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle52.gameObject.SetActive(false);
            Subtitle52BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 27)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle54.gameObject.SetActive(false);
            Subtitle54BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 28)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle56.gameObject.SetActive(false);
            Subtitle56BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 29)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipEnabled = true;
            Subtitle58.gameObject.SetActive(false);
            Subtitle58BG.gameObject.SetActive(false);
            SkipButton.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 30)
        {
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in EnemyGO)
            {
                Enemy.GetComponent<EnemyChaseScript>().Chase = true;
                Enemy.GetComponent<EnemyChaseScript>().PauseChaseAtTheBeginning = false;

            }
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Walk = true;
                FPC.Look = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            ED.enabled = true;

            SkipEnabled = true;

            Subtitle60.gameObject.SetActive(false);
            Subtitle60BG.gameObject.SetActive(false);
            Subtitle61.gameObject.SetActive(false);
            Subtitle61BG.gameObject.SetActive(false);
            Subtitle62.gameObject.SetActive(false);
            Subtitle62BG.gameObject.SetActive(false);
            Subtitle63.gameObject.SetActive(false);
            Subtitle63BG.gameObject.SetActive(false);
            Subtitle64.gameObject.SetActive(false);
            Subtitle64BG.gameObject.SetActive(false);
            Subtitle65.gameObject.SetActive(false);
            Subtitle65BG.gameObject.SetActive(false);
            Subtitle66.gameObject.SetActive(false);
            Subtitle66BG.gameObject.SetActive(false);
            Subtitle67.gameObject.SetActive(false);
            Subtitle67BG.gameObject.SetActive(false);
            Subtitle68.gameObject.SetActive(false);
            Subtitle68BG.gameObject.SetActive(false);
            Subtitle69.gameObject.SetActive(false);
            Subtitle69BG.gameObject.SetActive(false);
            Subtitle70.gameObject.SetActive(false);
            Subtitle70BG.gameObject.SetActive(false);
            Subtitle71.gameObject.SetActive(false);
            Subtitle71BG.gameObject.SetActive(false);
            Subtitle72.gameObject.SetActive(false);
            Subtitle72BG.gameObject.SetActive(false);
            Subtitle73.gameObject.SetActive(false);
            Subtitle73BG.gameObject.SetActive(false);
            Subtitle74.gameObject.SetActive(false);
            Subtitle74BG.gameObject.SetActive(false);

            SkipButton.gameObject.SetActive(false);
        }
    }

    public void SkipSubtitle2()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            Subtitle6.gameObject.SetActive(false);
            Subtitle6BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Subtitle8.gameObject.SetActive(false);
            Subtitle8BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            Subtitle11.gameObject.SetActive(false);
            Subtitle11BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            Subtitle13.gameObject.SetActive(false);
            Subtitle13BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            Subtitle15.gameObject.SetActive(false);
            Subtitle15BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            Subtitle17.gameObject.SetActive(false);
            Subtitle17BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);

        }
        else if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            Subtitle19.gameObject.SetActive(false);
            Subtitle19BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            Subtitle21.gameObject.SetActive(false);
            Subtitle21BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);

        }
        else if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            Subtitle23.gameObject.SetActive(false);
            Subtitle23BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            Subtitle25.gameObject.SetActive(false);
            Subtitle25BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 13)
        {
            Subtitle27.gameObject.SetActive(false);
            Subtitle27BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 14)
        {
            Subtitle29.gameObject.SetActive(false);
            Subtitle29BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 15)
        {
            Subtitle31.gameObject.SetActive(false);
            Subtitle31BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 16)
        {
            Subtitle33.gameObject.SetActive(false);
            Subtitle33BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 17)
        {
            Subtitle35.gameObject.SetActive(false);
            Subtitle35BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 18)
        {
            Subtitle37.gameObject.SetActive(false);
            Subtitle37BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 19)
        {
            Subtitle39.gameObject.SetActive(false);
            Subtitle39BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 20)
        {
            Subtitle41.gameObject.SetActive(false);
            Subtitle41BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 21)
        {
            Subtitle43.gameObject.SetActive(false);
            Subtitle43BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 22)
        {
            Subtitle45.gameObject.SetActive(false);
            Subtitle45BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 23)
        {
            Subtitle47.gameObject.SetActive(false);
            Subtitle47BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 24)
        {
            Subtitle49.gameObject.SetActive(false);
            Subtitle49BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 25)
        {
            Subtitle51.gameObject.SetActive(false);
            Subtitle51BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 26)
        {
            Subtitle53.gameObject.SetActive(false);
            Subtitle53BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 27)
        {
            Subtitle55.gameObject.SetActive(false);
            Subtitle55BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 28)
        {
            Subtitle57.gameObject.SetActive(false);
            Subtitle57BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 29)
        {
            Subtitle59.gameObject.SetActive(false);
            Subtitle59BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 30)
        {
            Subtitle75.gameObject.SetActive(false);
            Subtitle75BG.gameObject.SetActive(false);
            PH.ShowGUIS();
            if (NewPlayer == false)
            {
                FPC.Look = true;
                FPC.Walk = true;
                WMS.Move = true;
                PA.Look = true;
            }
            else if (NewPlayer == true)
            {

                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
            SkipButton2.gameObject.SetActive(false);
        }
    }

    IEnumerator PlaySubtitles73()
    {
        SkipButton2.gameObject.SetActive(true);
        Subtitle75BG.gameObject.SetActive(true);
        Subtitle75.gameObject.SetActive(true);

        yield return new WaitForSeconds(6.0f);
        SkipButton2.gameObject.SetActive(false);
        Subtitle75.gameObject.SetActive(false);
        Subtitle75BG.gameObject.SetActive(false);
        PH.ShowGUIS();
        PH.LockTakeDamage = false;
        if (NewPlayer == false)
        {
            FPC.Look = true;
            FPC.Walk = true;
            WMS.Move = true;
            PA.Look = true;
        }
        else if (NewPlayer == true)
        {
            if (Pausescript.MissionEnded == false)
            {
                if (gameObject.GetComponentInChildren<ThirdPersonUserControl>())
                    gameObject.GetComponentInChildren<ThirdPersonUserControl>().Walk = true;
                CC.Look = true;
            }
        }
    }

    IEnumerator PlaySubtitles74()
    {

        Subtitle76.gameObject.SetActive(true);
        Subtitle76BG.gameObject.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        Subtitle76.gameObject.SetActive(false);
        Subtitle76BG.gameObject.SetActive(false);
    }

}
