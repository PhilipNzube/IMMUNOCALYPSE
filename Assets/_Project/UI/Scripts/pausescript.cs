using Mirror;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
public class pausescript : NetworkBehaviour
{
    public Transform MainMenu;
    public Transform RGamePanel;
    public Transform VolumePanel;
    public Transform QuitGamePanel;
    public Text MenuLoader;
    public Button Pause;
    public Button RestartG;
    public Button ConfirmRestart;
    public Button DontConfirmRestart;
    public Button Quit;
    public Button ConfirmQ;
    public Button DontConfirmQuit;
    public Button Volume;
    public Button CancelVolume;
    public Button Resume;
    public Transform UIPanel;
    public Transform UIPanel2;
    public Text timeText;
    bool isPaused;
    bool QuitGamePanelVisible;
    bool VPVisible;
    bool RGamePanelVisible;
    public FirstPersonControls FPC;
    public WASDMovementScript WMS;
    public PlayerAiming PA;
    public PlayerHealth PH;
    public GameObject PlayerGO;
    public GameObject NM;
    public int CLICKED = 0;
    public bool Locked;

    public bool NewPlayer;

    public CameraController CC;
    public GunManager GM;
    public GameObject UIRestartButton;
    public GameObject UIQuitButton;
    public PlayerCollision PC;

    public GameObject PleaseWaitMessage;
    public bool MissionEnded;
    public GameObject ConfirmUIQuitGamePanel;
    public GameObject ConfirmUIQuitToMenuPanel;
    public bool ConfirmUIQuitGamePanelVisible;
    public bool ConfirmUIQuitToMenuPanelVisible;

    public AudioSource music;

    public GameObject SelectLanguage;

    public Button English;
    public Button Spanish;
    public Button Chinese;
    public Button French;
    public Button Arabic;
    public Button German;
    public Button Italian;
    public Button Japanese;
    public Button Korean;
    public Button Portuguese;
    public Button Russian;

    public GameObject EnglishFlag;
    public GameObject SpanishFlag;
    public GameObject ChineseFlag;
    public GameObject FrenchFlag;
    public GameObject ArabicFlag;
    public GameObject GermanFlag;
    public GameObject ItalianFlag;
    public GameObject JapaneseFlag;
    public GameObject KoreanFlag;
    public GameObject PortugueseFlag;
    public GameObject RussianFlag;

    void Awake()
    {
        Locked = true;
    }

    void Start()
    {

        NM = GameObject.FindGameObjectWithTag("NM");
        PlayerGO = GameObject.FindGameObjectWithTag("Player");
        if (isServer)
        {
            PlayerPrefs.SetInt("CurrentLevel", SceneManager.GetActiveScene().buildIndex);
        }
        UIPanel.gameObject.SetActive(false);
        RGamePanel.gameObject.SetActive(false);
        VolumePanel.gameObject.SetActive(false);
        QuitGamePanel.gameObject.SetActive(false);

        isPaused = false;
        QuitGamePanelVisible = false;
        VPVisible = false;
        RGamePanelVisible = false;

        if (PlayerPrefs.GetInt("English") == 1)
        {
            EnglishFlag.gameObject.SetActive(true);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);

            English.interactable = false;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Spanish") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(true);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);

            English.interactable = true;
            Spanish.interactable = false;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Chinese") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(true);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);

            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = false;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("French") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(true);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);

            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = false;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Arabic") == 1)
        {

            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(true);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);

            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = false;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("German") == 1)
        {

            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(true);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);

            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = false;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Italian") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(true);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);

            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = false;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Japanese") == 1)
        {

            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(true);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);

            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = false;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Korean") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(true);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);

            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = false;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Portuguese") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(true);
            RussianFlag.gameObject.SetActive(false);

            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = false;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Russian") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(true);

            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = false;
        }
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Locked == false)
                {
                    PGame();
                }
            }
        }

    }

    public void MC()
    {
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
            PC.enabled = false;
        }
    }

    public void ShowUI()
    {
        UIPanel2.gameObject.SetActive(true);
        if (GM.DeathMatch == false)
        {
            StartCoroutine(AutoRestartGame());
        }
        else
        {
            UIRestartButton.gameObject.SetActive(false);
            UIQuitButton.gameObject.SetActive(false);
        }
    }

    private IEnumerator AutoRestartGame()
    {
        yield return new WaitForSeconds(20.0f);
        ConfirmUIRestart();
    }

    public void UIRestart()
    {
        if (ConfirmUIQuitToMenuPanelVisible == false)
        {
            ConfirmUIQuitToMenuPanelVisible = true;
            ConfirmUIQuitToMenuPanel.gameObject.SetActive(true);
        }
        else if (ConfirmUIQuitToMenuPanelVisible == true)
        {
            ConfirmUIQuitToMenuPanelVisible = false;
            ConfirmUIQuitToMenuPanel.gameObject.SetActive(false);
        }
    }

    public void UIQuit()
    {
        if (ConfirmUIQuitGamePanelVisible == false)
        {
            ConfirmUIQuitGamePanelVisible = true;
            ConfirmUIQuitGamePanel.gameObject.SetActive(true);
        }
        else if (ConfirmUIQuitGamePanelVisible == true)
        {
            ConfirmUIQuitGamePanelVisible = false;
            ConfirmUIQuitGamePanel.gameObject.SetActive(false);
        }
    }

    public void ConfirmUIRestart()
    {
        CLICKED++;
        if (CLICKED == 1)
        {
            GameObject.FindGameObjectWithTag("BGMusicGO").GetComponent<AudioSource>().Play();
            PleaseWaitMessage.gameObject.SetActive(true);
            NetworkManager.singleton.ServerChangeScene("ImmunocalypseGameLobbyScene");
            if (NetworkServer.active && NetworkClient.isConnected)
            {
                NetworkManager.singleton.StopHost();
            }

            else if (NetworkClient.isConnected)
            {
                NetworkManager.singleton.StopClient();
            }

            else if (NetworkServer.active)
            {
                NetworkManager.singleton.StopServer();
            }
        }

    }

    public void ConfirmUIQuit()
    {
        PleaseWaitMessage.gameObject.SetActive(true);
        Application.Quit();
    }

    public void PGame()
    {
        if (isPaused == false)
        {
            isPaused = true;
            if (NewPlayer == false)
            {
                FPC.Walk = false;
                FPC.Look = false;
                WMS.Move = false;
                PA.Look = false;
            }
            else
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
            UIPanel.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (isPaused == true)
        {
            isPaused = false;
            if (PH.GUIRemoved == false)
            {
                if (PH.DontPlay == false)
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
                }
            }
            UIPanel.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    public void QuitGame()
    {
        Locked = true;
        QuitGamePanel.gameObject.SetActive(true);
    }

    public void DoNotConfirmQuit()
    {
        Locked = false;
        QuitGamePanel.gameObject.SetActive(false);
    }

    public void Restart()
    {
        CLICKED++;
        if (CLICKED == 1)
        {
            GameObject.FindGameObjectWithTag("BGMusicGO").GetComponent<AudioSource>().Play();
            Time.timeScale = 1f;
            NetworkManager.singleton.ServerChangeScene("ImmunocalypseGameLobbyScene");
            if (NetworkServer.active && NetworkClient.isConnected)
            {
                NetworkManager.singleton.StopHost();
            }

            else if (NetworkClient.isConnected)
            {
                NetworkManager.singleton.StopClient();
            }

            else if (NetworkServer.active)
            {
                NetworkManager.singleton.StopServer();
            }
        }
    }
    public void VolumeSettings()
    {
        Locked = true;
        VolumePanel.gameObject.SetActive(true);
    }

    public void CloseVolumeSettings()
    {
        Locked = false;
        VolumePanel.gameObject.SetActive(false);
    }
    public void ConfirmQuit()
    {
        PleaseWaitMessage.gameObject.SetActive(true);
        Application.Quit();
    }
    public void RestartGamePanel()
    {
        Locked = true;
        RGamePanel.gameObject.SetActive(true);
    }

    public void DoNotConfirmRestart()
    {
        Locked = false;
        RGamePanel.gameObject.SetActive(false);
        if (Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
        }
    }

    public void ShowLanguages()
    {
        SelectLanguage.gameObject.SetActive(true);
    }

    public void CloseLanguages()
    {
        if (PlayerPrefs.GetInt("English") == 1)
        {
            EnglishFlag.gameObject.SetActive(true);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);
        }
        else
        if (PlayerPrefs.GetInt("Spanish") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(true);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);
        }
        else
        if (PlayerPrefs.GetInt("Chinese") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(true);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);
        }
        else
        if (PlayerPrefs.GetInt("French") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(true);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);
        }
        else
        if (PlayerPrefs.GetInt("Arabic") == 1)
        {

            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(true);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);
        }
        else
        if (PlayerPrefs.GetInt("German") == 1)
        {

            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(true);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);
        }
        else
        if (PlayerPrefs.GetInt("Italian") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(true);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);
        }
        else
        if (PlayerPrefs.GetInt("Japanese") == 1)
        {

            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(true);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);
        }
        else
        if (PlayerPrefs.GetInt("Korean") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(true);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(false);
        }
        else
        if (PlayerPrefs.GetInt("Portuguese") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(true);
            RussianFlag.gameObject.SetActive(false);
        }
        else
        if (PlayerPrefs.GetInt("Russian") == 1)
        {
            EnglishFlag.gameObject.SetActive(false);
            SpanishFlag.gameObject.SetActive(false);
            ChineseFlag.gameObject.SetActive(false);
            FrenchFlag.gameObject.SetActive(false);
            ArabicFlag.gameObject.SetActive(false);
            GermanFlag.gameObject.SetActive(false);
            ItalianFlag.gameObject.SetActive(false);
            JapaneseFlag.gameObject.SetActive(false);
            KoreanFlag.gameObject.SetActive(false);
            PortugueseFlag.gameObject.SetActive(false);
            RussianFlag.gameObject.SetActive(true);
        }
        SelectLanguage.gameObject.SetActive(false);
    }

    public void ChangeLangToEnglish()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("English");
        English.interactable = false;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 1);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToSpanish()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Spanish");
        English.interactable = true;
        Spanish.interactable = false;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 1);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToChinese()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Chinese");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = false;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 1);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToFrench()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("French");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = false;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 1);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToArabic()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Arabic");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = false;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 1);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToGerman()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("German");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = false;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 1);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToItalian()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Italian");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = false;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 1);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToJapanese()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Japanese");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = false;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 1);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToKorean()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Korean");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = false;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 1);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToPortuguese()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Portuguese");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = false;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 1);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToRussian()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Russian");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = false;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 1);
    }

    void OnApplicationQuit()
    {
        if (isServer)
        {
            PlayerPrefs.SetInt("CurrentLevel", SceneManager.GetActiveScene().buildIndex);
        }
    }
}

