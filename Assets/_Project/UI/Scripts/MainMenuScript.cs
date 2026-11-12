using System;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_ANDROID
using Unity.Notifications.Android;
#endif
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject AK47U;
    public GameObject AK47;
    public GameObject AK47UAMOD;
    public GameObject AK47UKS;
    public GameObject MEGASHOT;

    public GameObject BottomTabGO;
    public GameObject AK47UPriceTab;
    public GameObject AK47PriceTab;
    public GameObject AK47UAMODPriceTab;
    public GameObject AK47UKSPriceTab;
    public GameObject MEGASHOTPriceTab;

    public GameObject AK47UWeaponDetails;
    public GameObject AK47WeaponDetails;
    public GameObject AK47UAMODWeaponDetails;
    public GameObject AK47UKSWeaponDetails;
    public GameObject MEGASHOTWeaponDetails;

    public GameObject AK47UID;
    public GameObject AK47ID;
    public GameObject AK47UAMODID;
    public GameObject AK47UKSID;
    public GameObject MEGASHOTID;

    public GameObject AK47EquippedTab;
    public GameObject AK47UAMODEquippedTab;
    public GameObject AK47UKSEquippedTab;
    public GameObject MEGASHOTEquippedTab;

    public GameObject AssultWeaponSwitchImg;

    public GameObject SVD;
    public GameObject SLP;
    public GameObject M40a3;
    public GameObject Ksvk;
    public GameObject ALPHARIFLE;

    public GameObject SVDPriceTab;
    public GameObject SLPPriceTab;
    public GameObject M40a3PriceTab;
    public GameObject KsvkPriceTab;
    public GameObject ALPHARIFLEPriceTab;

    public GameObject SVDWeaponDetails;
    public GameObject SLPWeaponDetails;
    public GameObject M40a3WeaponDetails;
    public GameObject KsvkWeaponDetails;
    public GameObject ALPHARIFLEWeaponDetails;

    public GameObject SVDID;
    public GameObject SLPID;
    public GameObject M40a3ID;
    public GameObject KsvkID;
    public GameObject ALPHARIFLEID;

    public GameObject SLPEquippedTab;
    public GameObject M40a3EquippedTab;
    public GameObject KsvkEquippedTab;
    public GameObject ALPHARIFLEEquippedTab;

    public GameObject SniperWeaponSwitchImg;

    public GameObject Glock;
    public GameObject M1911;
    public GameObject M1323;
    public GameObject WP01;
    public GameObject ULTRA;

    public GameObject GlockPriceTab;
    public GameObject M1911PriceTab;
    public GameObject M1323PriceTab;
    public GameObject WP01PriceTab;
    public GameObject ULTRAPriceTab;

    public GameObject GlockWeaponDetails;
    public GameObject M1911WeaponDetails;
    public GameObject M1323WeaponDetails;
    public GameObject WP01WeaponDetails;
    public GameObject ULTRAWeaponDetails;

    public GameObject GlockID;
    public GameObject M1911ID;
    public GameObject M1323ID;
    public GameObject WP01ID;
    public GameObject ULTRAID;

    public GameObject M1911EquippedTab;
    public GameObject M1323EquippedTab;
    public GameObject WP01EquippedTab;
    public GameObject ULTRAEquippedTab;

    public GameObject PistolWeaponSwitchImg;

    public int WeaponSwitchNo = 1;
    public int SniperWeaponSwitchNo = 1;
    public int PistolWeaponSwitchNo = 1;

    public SceneLoader1 SL1;

    public int EnergyValue = 100;
    public int CoinValue = 20000;
    public int GemValue = 1000;

    public Text EnergyDisplay;
    public Text CoinDisplay;
    public Text GemDisplay;

    public Transform QuitGamePanel;
    public bool QuitGamePanelVisible;

    public GameObject ExitBackButton;
    public GameObject AssultBackButton;
    public GameObject SniperBackButton;
    public GameObject PistolBackButton;
    public GameObject PurchaseBackButton;
    public GameObject RewardsBackButton;

    public GameObject AK47UEquipTab;
    public GameObject AK47EquipTab;
    public GameObject AK47UAMODEquipTab;
    public GameObject AK47UKSEquipTab;
    public GameObject MEGASHOTEquipTab;

    public GameObject SVDEquipTab;
    public GameObject SLPEquipTab;
    public GameObject M40a3EquipTab;
    public GameObject KsvkEquipTab;
    public GameObject ALPHARIFLEEquipTab;

    public GameObject GlockEquipTab;
    public GameObject M1911EquipTab;
    public GameObject M1323EquipTab;
    public GameObject WP01EquipTab;
    public GameObject ULTRAEquipTab;

    public bool IsInAssultScreenCantExit = false;
    public bool IsInSniperScreenCantExit = false;
    public bool IsInPistolScreenCantExit = false;
    public bool IsInDailyRewards = false;
    public bool IsInTutorialPanel = false;
    public bool IsInWeaponTutorialPanel = false;
    public bool IsInConsumablesPanel = false;
    public bool IsInDailyRewardsPanel = false;

    public bool IsAK47UActive = false;
    public bool IsAK47Active = false;
    public bool IsAK47UAMODActive = false;
    public bool IsAK47UKSActive = false;
    public bool IsMEGASHOTActive = false;

    public bool IsSVDActive = false;
    public bool IsSLPActive = false;
    public bool IsM40a3Active = false;
    public bool IsKsvkActive = false;
    public bool IsALPHARIFLEActive = false;

    public bool IsGlockActive = false;
    public bool IsM1911Active = false;
    public bool IsM1323Active = false;
    public bool IsWP01Active = false;
    public bool IsULTRAActive = false;

    public bool FirstTime = true;
    public bool SniperFirstTime = true;
    public bool PistolFirstTime = true;

    public GameObject BuyConsumablesCanvas;
    public GameObject CoinsPanel;
    public GameObject GemsPanel;
    public GameObject EnergyPanel;
    public GameObject CoinTabButton;
    public GameObject GemTabButton;
    public GameObject EnergyTabButton;
    public Image CoinTabButtonImg;
    public Image GemTabButtonImg;
    public Image EnergyTabButtonImg;

    public GameObject DailyRewardsCanvas;
    public GameObject BasicPanel;
    public GameObject AchievementPanel;
    public GameObject DailyTaskPanel;
    public GameObject BasicTabButton;
    public GameObject AchievementTabButton;
    public GameObject DailyTaskTabButton;
    public Image BasicTabButtonImg;
    public Image AchievementTabButtonImg;
    public Image DailyTaskTabButtonImg;

    public Text TotalKilledOutput;
    public int TotalKilledData;
    public Text AssultKilledOutput;
    public int AssultKilledData;
    public Text SniperKilledOuput;
    public int SniperKilledData;
    public Text PistolKilledOutput;
    public int PistolKilledData;
    public Text HeadshotKilledOutput;
    public int HeadshotKilledData;
    public Text GrenadeKilledOutput;
    public int GrenadeKilledData;
    public Text MeleeKillsOutput;
    public int MeleeKillsData;
    public Text MissionsCompletedOutput;
    public int MissionsCompletedData;
    public Text CoinsEarnedOutput;
    public int CoinsEarnedData;
    public Text GemsEarnedOutput;
    public int GemsEarnedData;
    public Text WeaponsOwnedOutput;
    public int WeaponsOwnedData;
    public Text WeaponsBoughtOutput;
    public int WeaponsBoughtData;

    public Slider FiveHundredMeleeKills;
    public Button FiveHundredMeleeKillsCollect;
    public GameObject FiveHundredMeleeKillsReward;
    public int FiveHundredMeleeKillsData;
    public Text FiveHundredMeleeKillsCollectedText;
    public Slider Kill500Enemies;
    public Button Kill500EnemiesCollect;
    public GameObject Kill500EnemiesReward;
    public int Kill500EnemiesData;
    public Text Kill500EnemiesCollectedText;
    public Slider CompleteChapter1;
    public Button CompleteChapter1Collect;
    public GameObject CompleteChapter1Reward;
    public int CompleteChapter1Data;
    public Text CompleteChapter1CollectedText;
    public Slider CompleteChapter2;
    public Button CompleteChapter2Collect;
    public GameObject CompleteChapter2Reward;
    public int CompleteChapter2Data;
    public Text CompleteChapter2CollectedText;
    public Slider CompleteChapter3;
    public Button CompleteChapter3Collect;
    public GameObject CompleteChapter3Reward;
    public int CompleteChapter3Data;
    public Text CompleteChapter3CollectedText;
    public Slider CompleteChapter4;
    public Button CompleteChapter4Collect;
    public GameObject CompleteChapter4Reward;
    public int CompleteChapter4Data;
    public Text CompleteChapter4CollectedText;

    public Slider TwentyHeadShots;
    public Button TwentyHeadShotsCollect;
    public GameObject TwentyHeadShotsReward;
    public int TwentyHeadShotsData;
    public Text TwentyHeadShotsCollectedText;
    public Slider Complete5Missions;
    public Button Complete5MissionsCollect;
    public GameObject Complete5MissionsReward;
    public int Complete5MissionsData;
    public Text Complete5MissionsCollectedText;
    public Slider TenEnemyKills;
    public Button TenEnemyKillsCollect;
    public GameObject TenEnemyKillsReward;
    public int TenEnemyKillsData;
    public Text TenEnemyKillsCollectedText;
    public Slider UseConsumables5Times;
    public Button UseConsumables5TimesCollect;
    public GameObject UseConsumables5TimesReward;
    public int UseConsumables5TimesData;
    public Text UseConsumables5TimesCollectedText;
    public Slider Buy5000Coins;
    public Button Buy5000CoinsCollect;
    public GameObject Buy5000CoinsReward;
    public int Buy5000CoinsData;
    public Text Buy5000CoinsCollectedText;
    public Slider Buy500Gems;
    public Button Buy500GemsCollect;
    public GameObject Buy500GemsReward;
    public int Buy500GemsData;
    public Text Buy5000GemsCollectedText;

    public Slider CompleteAllDailyTask;
    public Button CompleteAllDailyTaskCollect;
    public GameObject CompleteAllDailyTaskReward;
    public int CompleteAllDailyTaskData;
    public Text CompleteAllDailyTaskCollectedText;

    public GameObject DailyRewardsPanel;

    public GameObject DailyRewardsPanelExitButton;

    public RewardScript RS;

    public GameObject AssultWeaponHolder;
    public GameObject SniperWeaponHolder;
    public GameObject PistolWeaponHolder;

    public GameObject Message;
    public GameObject AssultMessage;
    public GameObject SniperMessage;
    public GameObject PistolMessage;

    public GameObject Message2;

    public float EnergytimeRemaining = 120.0f;
    public bool EnergytimerIsRunning = false;
    public Text EnergytimeText;

    private ulong lastEnergyFill;
    public float msToWait = 100020.0f;
    public Text EnergyTimer;

    public bool IsTimerRunning = false;

    public bool IsReallyTime = false;

    public bool STFN = false;

    public int NextTime = 0;

    public GameObject TutorialPanel;

    public GameObject TutorialButton;

    public GameObject WeaponsTut;

    public GameObject WeaponsTutButton;

    public float AWT = 0f;

    public float SWT = 0f;

    public float PWT = 0f;

    public int UCFT;

    public string[] names;

    public Text GraphicsButtonText;

    public int Change = 0;

    public float SFT = 0f;

    public float PFT = 0f;
    public GameObject ControlsSettingsPanel;
    public GameObject ControlsButton;
    public int THSNum;
    public int C5MNum;
    public int TEKNum;
    public int UC5TNum;
    public int B5CNum;
    public int B5GNum;

    public int GrenadeNo = 5;
    public int GrenadeBoughtData;
    public Text OwnedGrenadeText;
    public GameObject GrenadePanel;

    public GameObject PleaseWaitUI;
    public GameObject NM;
    public Button EnergyGemRefiller;
    public int NotificationTimerValue;
#if UNITY_ANDROID
    public AndroidNotification notification;
#endif

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

    public GameObject LanguageBut;

    void Start()
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

        if (PlayerPrefs.HasKey("EnableControls"))
        {
            ControlsButton.gameObject.SetActive(true);
        }
        NM = GameObject.FindGameObjectWithTag("NM");

        if (NM != null)
        {
            Destroy(NM);
        }

        if (PlayerPrefs.GetInt("FMKC") == 1)
        {
            FiveHundredMeleeKillsCollect.interactable = false;
            FiveHundredMeleeKillsCollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("K5EC") == 1)
        {
            Kill500EnemiesCollect.interactable = false;
            Kill500EnemiesCollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("CC1") == 1)
        {
            CompleteChapter1Collect.interactable = false;
            CompleteChapter1CollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("CC2") == 1)
        {
            CompleteChapter2Collect.interactable = false;
            CompleteChapter2CollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("CC3") == 1)
        {
            CompleteChapter3Collect.interactable = false;
            CompleteChapter3CollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("CC4") == 1)
        {
            CompleteChapter4Collect.interactable = false;
            CompleteChapter4CollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("THSC") == 1)
        {
            TwentyHeadShotsCollect.interactable = false;
            TwentyHeadShotsCollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("C5MC") == 1)
        {
            Complete5MissionsCollect.interactable = false;
            Complete5MissionsCollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("TEKC") == 1)
        {
            TenEnemyKillsCollect.interactable = false;
            TenEnemyKillsCollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("UC5TC") == 1)
        {
            UseConsumables5TimesCollect.interactable = false;
            UseConsumables5TimesCollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("B5CC") == 1)
        {
            Buy5000CoinsCollect.interactable = false;
            Buy5000CoinsCollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("B5GC") == 1)
        {
            Buy500GemsCollect.interactable = false;
            Buy5000GemsCollectedText.text = "COLLECTED";
        }

        if (PlayerPrefs.GetInt("CADTC") == 1)
        {
            CompleteAllDailyTaskCollect.interactable = false;
            CompleteAllDailyTaskCollectedText.text = "COLLECTED";
        }

        names = QualitySettings.names;
        if (PlayerPrefs.GetInt("Graphics") == 1)
        {
            QualitySettings.SetQualityLevel(0, true);
            GraphicsButtonText.text = "LOW";
            Change = 1;
        }
        else if (PlayerPrefs.GetInt("Graphics") == 2)
        {
            QualitySettings.SetQualityLevel(3, true);
            GraphicsButtonText.text = "MEDIUM";
            Change = 2;
        }
        else if (PlayerPrefs.GetInt("Graphics") == 3)
        {
            QualitySettings.SetQualityLevel(5, true);
            GraphicsButtonText.text = "HIGH";
            Change = 0;
        }

        BasicData();
        AchievementData();
        DailyTaskData();

        if (PlayerPrefs.GetInt("FirstTime") == 1)
        {
            FirstTime = false;
        }

        if (PlayerPrefs.GetInt("SniperFirstTime") == 1)
        {
            SniperFirstTime = false;
        }

        if (PlayerPrefs.GetInt("PistolFirstTime") == 1)
        {
            PistolFirstTime = false;
        }

        if (FirstTime == true)
        {

            if (Screen.currentResolution.refreshRate >= 30)
            {
                if (Screen.currentResolution.refreshRate < 60)
                {
                    PlayerPrefs.SetInt("Graphics", 2);
                    QualitySettings.SetQualityLevel(3, true);
                    GraphicsButtonText.text = "MEDIUM";
                    Change = 2;
                }
            }

            if (Screen.currentResolution.refreshRate >= 60)
            {
                PlayerPrefs.SetInt("Graphics", 3);
                QualitySettings.SetQualityLevel(5, true);
                GraphicsButtonText.text = "HIGH";
                Change = 0;
            }

            PlayerPrefs.SetInt("AutoReloadValue", 2);

            PlayerPrefs.SetInt("EnergyValue", EnergyValue);
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("GemValue", GemValue);

            EnergyValue = PlayerPrefs.GetInt("EnergyValue");
            CoinValue = PlayerPrefs.GetInt("CoinValue");
            GemValue = PlayerPrefs.GetInt("GemValue");

            PlayerPrefs.SetInt("GrenadesOwned", 5);

            PlayerPrefs.SetInt("TotalKilled", 0);
            PlayerPrefs.SetInt("AssultKilled", 0);
            PlayerPrefs.SetInt("SniperKilled", 0);
            PlayerPrefs.SetInt("PistolKilled", 0);
            PlayerPrefs.SetInt("HeadshotKilled", 0);
            PlayerPrefs.SetInt("GrenadeKilled", 0);
            PlayerPrefs.SetInt("MeleeKills", 0);
            PlayerPrefs.SetInt("MissionsCompleted", 0);
            PlayerPrefs.SetInt("CoinsEarned", 0);
            PlayerPrefs.SetInt("GemsEarned", 0);
            PlayerPrefs.SetInt("WeaponsOwned", 3);
            PlayerPrefs.SetInt("WeaponsBought", 0);
            PlayerPrefs.SetInt("BoughtAK47U", 1);

            PlayerPrefs.SetInt("500MeleeKills", 0);
            PlayerPrefs.SetInt("Kill500Enemies", 0);
            PlayerPrefs.SetInt("CompleteChapter1", 0);
            PlayerPrefs.SetInt("CompleteChapter2", 0);
            PlayerPrefs.SetInt("CompleteChapter3", 0);
            PlayerPrefs.SetInt("CompleteChapter4", 0);

            PlayerPrefs.SetInt("20HeadShots", 0);
            PlayerPrefs.SetInt("Complete5Missions", 0);
            PlayerPrefs.SetInt("10EnemyKills", 0);
            PlayerPrefs.SetInt("UseConsumables5Times", 0);
            PlayerPrefs.SetInt("Buy5000Coins", 0);
            PlayerPrefs.SetInt("Buy500Gems", 0);
            PlayerPrefs.SetInt("CompleteAllDailyTask", 0);

            PlayerPrefs.SetInt("FMKC", 0);
            PlayerPrefs.SetInt("K5EC", 0);
            PlayerPrefs.SetInt("CC1", 0);
            PlayerPrefs.SetInt("CC2", 0);
            PlayerPrefs.SetInt("CC3", 0);
            PlayerPrefs.SetInt("CC4", 0);
            PlayerPrefs.SetInt("THSC", 0);
            PlayerPrefs.SetInt("C5MC", 0);
            PlayerPrefs.SetInt("TEKC", 0);
            PlayerPrefs.SetInt("UC5TC", 0);
            PlayerPrefs.SetInt("B5CC", 0);
            PlayerPrefs.SetInt("B5GC", 0);
            PlayerPrefs.SetInt("CADTC", 0);
            IsAK47UActive = true;
            AK47U.gameObject.SetActive(true);
            TutorialPanel.gameObject.SetActive(true);

        }

        if (FirstTime == false)
        {

            ControlsButton.gameObject.SetActive(true);
            TutorialButton.gameObject.SetActive(true);
            EnergyValue = PlayerPrefs.GetInt("EnergyValue");
            CoinValue = PlayerPrefs.GetInt("CoinValue");
            GemValue = PlayerPrefs.GetInt("GemValue");
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
            {
                IsAK47UActive = true;
                IsAK47Active = false;
                IsAK47UAMODActive = false;
                IsAK47UKSActive = false;
                IsMEGASHOTActive = false;
                WeaponSwitchNo = 1;
                AK47U.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
            {
                IsAK47Active = true;
                IsAK47UActive = false;
                IsAK47UAMODActive = false;
                IsAK47UKSActive = false;
                IsMEGASHOTActive = false;
                WeaponSwitchNo = 2;
                AK47.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
            {
                IsAK47UAMODActive = true;
                IsAK47Active = false;
                IsAK47UActive = false;
                IsAK47UKSActive = false;
                IsMEGASHOTActive = false;
                WeaponSwitchNo = 3;
                AK47UAMOD.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
            {
                IsAK47UKSActive = true;
                IsAK47Active = false;
                IsAK47UAMODActive = false;
                IsAK47UActive = false;
                IsMEGASHOTActive = false;
                WeaponSwitchNo = 4;
                AK47UKS.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
            {
                IsMEGASHOTActive = true;
                IsAK47Active = false;
                IsAK47UAMODActive = false;
                IsAK47UKSActive = false;
                IsAK47UActive = false;
                WeaponSwitchNo = 5;

                MEGASHOT.gameObject.SetActive(true);
            }
        }

        if (EnergyValue < 3)
        {
            if (!PlayerPrefs.HasKey("LastEnergyFill"))
            {
                lastEnergyFill = (ulong)DateTime.Now.Ticks;
                PlayerPrefs.SetString("LastEnergyFill", lastEnergyFill.ToString());
                lastEnergyFill = ulong.Parse(PlayerPrefs.GetString("LastEnergyFill"));
                IsTimerRunning = true;
                ActivateEnergyPurchase();

            }
            else
            if (PlayerPrefs.HasKey("LastEnergyFill"))
            {
                lastEnergyFill = ulong.Parse(PlayerPrefs.GetString("LastEnergyFill"));
                IsTimerRunning = true;
                ActivateEnergyPurchase();

            }
        }

    }

    public void ActivateAssultRifles()
    {
        if (FirstTime == true)
        {
            AWT += 1.0f;
            if (AWT == 1.0f)
            {
                WeaponsTut.gameObject.SetActive(true);

                AssultWeaponHolder.gameObject.SetActive(true);
            }
            LanguageBut.gameObject.SetActive(false);
            GrenadePanel.gameObject.SetActive(false);
            TutorialButton.gameObject.SetActive(false);
        }
        else if (FirstTime == false)
        {
            WeaponsTutButton.gameObject.SetActive(true);
            TutorialButton.gameObject.SetActive(false);
            GrenadePanel.gameObject.SetActive(false);
            LanguageBut.gameObject.SetActive(false);
        }
        IsInAssultScreenCantExit = true;
        BottomTabGO.gameObject.SetActive(false);
        SniperWeaponHolder.gameObject.SetActive(false);
        PistolWeaponHolder.gameObject.SetActive(false);
        AssultWeaponHolder.gameObject.SetActive(true);
        ExitBackButton.gameObject.SetActive(false);
        AssultBackButton.gameObject.SetActive(true);
        AssultWeaponSwitchImg.gameObject.SetActive(true);
        if (WeaponSwitchNo == 2)
        {
            if (PlayerPrefs.GetInt("BoughtAK47") == 0)
            {
                AK47PriceTab.gameObject.SetActive(true);
                AK47WeaponDetails.gameObject.SetActive(true);
                AK47ID.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("BoughtAK47") == 1)
            {
                AK47EquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
            {
                AK47EquippedTab.gameObject.SetActive(true);
            }

        }

        if (WeaponSwitchNo == 3)
        {
            if (PlayerPrefs.GetInt("BoughtAK47UAMOD") == 0)
            {
                AK47UAMODPriceTab.gameObject.SetActive(true);
                AK47UAMODWeaponDetails.gameObject.SetActive(true);
                AK47UAMODID.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("BoughtAK47UAMOD") == 1)
            {
                AK47UAMODEquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
            {
                AK47UAMODEquippedTab.gameObject.SetActive(true);
            }

        }

        if (WeaponSwitchNo == 4)
        {
            if (PlayerPrefs.GetInt("BoughtAK47UKS") == 0)
            {
                AK47UKSPriceTab.gameObject.SetActive(true);
                AK47UKSWeaponDetails.gameObject.SetActive(true);
                AK47UKSID.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("BoughtAK47UKS") == 1)
            {
                AK47UKSEquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
            {
                AK47UKSEquippedTab.gameObject.SetActive(true);
            }

        }

        if (WeaponSwitchNo == 5)
        {
            if (PlayerPrefs.GetInt("BoughtMEGASHOT") == 0)
            {
                MEGASHOTPriceTab.gameObject.SetActive(true);
                MEGASHOTWeaponDetails.gameObject.SetActive(true);
                MEGASHOTID.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("BoughtMEGASHOT") == 1)
            {
                MEGASHOTEquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
            {
                MEGASHOTEquippedTab.gameObject.SetActive(true);
            }

        }

        if (PlayerPrefs.GetInt("BoughtAK47U") == 1)
        {
            if (IsAK47UActive == true)
            {
                AK47UWeaponDetails.gameObject.SetActive(true);
                AK47UID.gameObject.SetActive(true);
                AssultWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                AssultBackButton.gameObject.SetActive(true);
                AK47UEquipTab.gameObject.SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("BoughtAK47") == 1)
        {
            if (IsAK47Active == true)
            {
                AK47PriceTab.gameObject.SetActive(false);
                AK47WeaponDetails.gameObject.SetActive(true);
                AK47ID.gameObject.SetActive(true);
                AssultWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                AssultBackButton.gameObject.SetActive(true);
                AK47EquipTab.gameObject.SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("BoughtAK47UAMOD") == 1)
        {
            if (IsAK47UAMODActive == true)
            {
                AK47UAMODPriceTab.gameObject.SetActive(false);
                AK47UAMODWeaponDetails.gameObject.SetActive(true);
                AK47UAMODID.gameObject.SetActive(true);
                AssultWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                AssultBackButton.gameObject.SetActive(true);
                AK47UAMODEquipTab.gameObject.SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("BoughtAK47UKS") == 1)
        {
            if (IsAK47UKSActive == true)
            {
                AK47UKSPriceTab.gameObject.SetActive(false);
                AK47UKSWeaponDetails.gameObject.SetActive(true);
                AK47UKSID.gameObject.SetActive(true);
                AssultWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                AssultBackButton.gameObject.SetActive(true);
                AK47UKSEquipTab.gameObject.SetActive(true);
                AK47UKSEquippedTab.gameObject.SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("BoughtMEGASHOT") == 1)
        {
            if (IsMEGASHOTActive == true)
            {
                MEGASHOTPriceTab.gameObject.SetActive(false);
                MEGASHOTWeaponDetails.gameObject.SetActive(true);
                MEGASHOTID.gameObject.SetActive(true);
                AssultWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                AssultBackButton.gameObject.SetActive(true);
                MEGASHOTEquipTab.gameObject.SetActive(true);
                MEGASHOTEquippedTab.gameObject.SetActive(false);
            }
        }

        if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
        {
            if (IsAK47UActive == true)
            {
                AK47UPriceTab.gameObject.SetActive(true);
                AK47UWeaponDetails.gameObject.SetActive(true);
                AK47UID.gameObject.SetActive(true);
                AssultWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                AssultBackButton.gameObject.SetActive(true);
                AK47UEquipTab.gameObject.SetActive(false);
            }
        }
        else if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
        {
            if (IsAK47Active == true)
            {
                AK47EquippedTab.gameObject.SetActive(true);
                AK47PriceTab.gameObject.SetActive(false);
                AK47WeaponDetails.gameObject.SetActive(true);
                AK47ID.gameObject.SetActive(true);
                AssultWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                AssultBackButton.gameObject.SetActive(true);
                AK47EquipTab.gameObject.SetActive(false);
                AK47EquippedTab.gameObject.SetActive(true);
            }
        }
        else if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
        {
            if (IsAK47UAMODActive == true)
            {
                AK47UAMODEquippedTab.gameObject.SetActive(true);
                AK47UAMODPriceTab.gameObject.SetActive(false);
                AK47UAMODWeaponDetails.gameObject.SetActive(true);
                AK47UAMODID.gameObject.SetActive(true);
                AssultWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                AssultBackButton.gameObject.SetActive(true);
                AK47UAMODEquipTab.gameObject.SetActive(false);
                AK47UAMODEquippedTab.gameObject.SetActive(true);
            }
        }
        else if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
        {
            if (IsAK47UKSActive == true)
            {
                AK47UKSEquippedTab.gameObject.SetActive(true);
                AK47UKSPriceTab.gameObject.SetActive(false);
                AK47UKSWeaponDetails.gameObject.SetActive(true);
                AK47UKSID.gameObject.SetActive(true);
                AssultWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                AssultBackButton.gameObject.SetActive(true);
                AK47UKSEquipTab.gameObject.SetActive(false);
                AK47UKSEquippedTab.gameObject.SetActive(true);
            }
        }
        else if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
        {
            if (IsMEGASHOTActive == true)
            {
                MEGASHOTEquippedTab.gameObject.SetActive(true);
                MEGASHOTPriceTab.gameObject.SetActive(false);
                MEGASHOTWeaponDetails.gameObject.SetActive(true);
                MEGASHOTID.gameObject.SetActive(true);
                AssultWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                AssultBackButton.gameObject.SetActive(true);
                MEGASHOTEquipTab.gameObject.SetActive(false);
                MEGASHOTEquippedTab.gameObject.SetActive(true);
            }
        }

    }

    public void ActivateSniperRifles()
    {

        if (SniperFirstTime == true)
        {
            IsSVDActive = true;
            SVDWeaponDetails.gameObject.SetActive(true);
            SVDID.gameObject.SetActive(true);
            SniperWeaponSwitchImg.gameObject.SetActive(true);
            ExitBackButton.gameObject.SetActive(false);
            SniperBackButton.gameObject.SetActive(true);
            SVDEquipTab.gameObject.SetActive(true);
            SVD.gameObject.SetActive(true);
            PlayerPrefs.SetInt("BoughtSVD", 1);
            SniperFirstTime = false;
        }

        SFT += 1.0f;
        if (SFT == 1.0f)
        {
            if (SniperFirstTime == false)
            {
                if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
                {
                    IsSVDActive = true;
                    IsSLPActive = false;
                    IsM40a3Active = false;
                    IsKsvkActive = false;
                    IsALPHARIFLEActive = false;
                    SniperWeaponSwitchNo = 1;
                    SVD.gameObject.SetActive(true);
                }
                else if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
                {
                    IsSVDActive = false;
                    IsSLPActive = true;
                    IsM40a3Active = false;
                    IsKsvkActive = false;
                    IsALPHARIFLEActive = false;
                    SniperWeaponSwitchNo = 2;
                    SLP.gameObject.SetActive(true);
                }
                else if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
                {
                    IsSVDActive = false;
                    IsSLPActive = false;
                    IsM40a3Active = true;
                    IsKsvkActive = false;
                    IsALPHARIFLEActive = false;
                    SniperWeaponSwitchNo = 3;
                    M40a3.gameObject.SetActive(true);
                }
                else if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
                {
                    IsSVDActive = false;
                    IsSLPActive = false;
                    IsM40a3Active = false;
                    IsKsvkActive = true;
                    IsALPHARIFLEActive = false;
                    SniperWeaponSwitchNo = 4;
                    Ksvk.gameObject.SetActive(true);
                }
                else if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
                {
                    IsSVDActive = false;
                    IsSLPActive = false;
                    IsM40a3Active = false;
                    IsKsvkActive = false;
                    IsALPHARIFLEActive = true;
                    SniperWeaponSwitchNo = 5;
                    ALPHARIFLE.gameObject.SetActive(true);
                }
            }
        }

        if (FirstTime == true)
        {
            SWT += 1.0f;
            if (SWT == 1.0f)
            {
                WeaponsTut.gameObject.SetActive(true);
            }
            TutorialButton.gameObject.SetActive(false);
        }
        else if (FirstTime == false)
        {
            WeaponsTutButton.gameObject.SetActive(true);
            TutorialButton.gameObject.SetActive(false);
        }
        IsInSniperScreenCantExit = true;
        LanguageBut.gameObject.SetActive(false);
        GrenadePanel.gameObject.SetActive(false);
        BottomTabGO.gameObject.SetActive(false);
        SniperWeaponHolder.gameObject.SetActive(true);
        PistolWeaponHolder.gameObject.SetActive(false);
        AssultWeaponHolder.gameObject.SetActive(false);
        ExitBackButton.gameObject.SetActive(false);
        SniperBackButton.gameObject.SetActive(true);
        SniperWeaponSwitchImg.gameObject.SetActive(true);

        if (SniperWeaponSwitchNo == 2)
        {
            SVD.gameObject.SetActive(false);
            M40a3.gameObject.SetActive(false);
            Ksvk.gameObject.SetActive(false);
            ALPHARIFLE.gameObject.SetActive(false);
            if (PlayerPrefs.GetInt("BoughtSLP") == 0)
            {
                SLPPriceTab.gameObject.SetActive(true);
                SLPWeaponDetails.gameObject.SetActive(true);
                SLPID.gameObject.SetActive(true);
                SVD.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("BoughtSLP") == 1)
            {
                SLPEquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
            {
                SLPEquippedTab.gameObject.SetActive(true);
            }

        }

        if (SniperWeaponSwitchNo == 3)
        {
            SVD.gameObject.SetActive(false);
            SLP.gameObject.SetActive(false);
            Ksvk.gameObject.SetActive(false);
            ALPHARIFLE.gameObject.SetActive(false);
            if (PlayerPrefs.GetInt("BoughtM40a3") == 0)
            {
                M40a3PriceTab.gameObject.SetActive(true);
                M40a3WeaponDetails.gameObject.SetActive(true);
                M40a3ID.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("BoughtM40a3") == 1)
            {
                M40a3EquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
            {
                M40a3EquippedTab.gameObject.SetActive(true);
            }

        }

        if (SniperWeaponSwitchNo == 4)
        {
            SVD.gameObject.SetActive(false);
            SLP.gameObject.SetActive(false);
            M40a3.gameObject.SetActive(false);
            ALPHARIFLE.gameObject.SetActive(false);
            if (PlayerPrefs.GetInt("BoughtKsvk") == 0)
            {
                KsvkPriceTab.gameObject.SetActive(true);
                KsvkWeaponDetails.gameObject.SetActive(true);
                KsvkID.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("BoughtKsvk") == 1)
            {
                KsvkEquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
            {
                KsvkEquippedTab.gameObject.SetActive(true);
            }

        }

        if (SniperWeaponSwitchNo == 5)
        {
            SVD.gameObject.SetActive(false);
            SLP.gameObject.SetActive(false);
            M40a3.gameObject.SetActive(false);
            Ksvk.gameObject.SetActive(false);
            if (PlayerPrefs.GetInt("BoughtALPHARIFLE") == 0)
            {
                ALPHARIFLEPriceTab.gameObject.SetActive(true);
                ALPHARIFLEWeaponDetails.gameObject.SetActive(true);
                ALPHARIFLEID.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("BoughtALPHARIFLE") == 1)
            {
                ALPHARIFLEEquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
            {
                ALPHARIFLEEquippedTab.gameObject.SetActive(true);
            }

        }

        if (PlayerPrefs.GetInt("BoughtSVD") == 1)
        {
            if (IsSVDActive == true)
            {
                if (SniperFirstTime == false)
                {
                    SVDWeaponDetails.gameObject.SetActive(true);
                    SVDID.gameObject.SetActive(true);
                    SniperWeaponSwitchImg.gameObject.SetActive(true);
                    ExitBackButton.gameObject.SetActive(false);
                    SniperBackButton.gameObject.SetActive(true);
                    SVDEquipTab.gameObject.SetActive(true);
                }
            }
        }
        if (PlayerPrefs.GetInt("BoughtSLP") == 1)
        {
            if (IsSLPActive == true)
            {
                SLPPriceTab.gameObject.SetActive(false);
                SLPWeaponDetails.gameObject.SetActive(true);
                SLPID.gameObject.SetActive(true);
                SniperWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                SniperBackButton.gameObject.SetActive(true);
                SLPEquipTab.gameObject.SetActive(true);
            }
        }

        if (PlayerPrefs.GetInt("BoughtM40a3") == 1)
        {
            if (IsM40a3Active == true)
            {
                M40a3PriceTab.gameObject.SetActive(false);
                M40a3WeaponDetails.gameObject.SetActive(true);
                M40a3ID.gameObject.SetActive(true);
                SniperWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                SniperBackButton.gameObject.SetActive(true);
                M40a3EquipTab.gameObject.SetActive(true);
            }
        }

        if (PlayerPrefs.GetInt("BoughtKsvk") == 1)
        {
            if (IsKsvkActive == true)
            {
                KsvkPriceTab.gameObject.SetActive(false);
                KsvkWeaponDetails.gameObject.SetActive(true);
                KsvkID.gameObject.SetActive(true);
                SniperWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                SniperBackButton.gameObject.SetActive(true);
                KsvkEquipTab.gameObject.SetActive(true);
            }
        }

        if (PlayerPrefs.GetInt("BoughtALPHARIFLE") == 1)
        {
            if (IsALPHARIFLEActive == true)
            {
                ALPHARIFLEPriceTab.gameObject.SetActive(false);
                ALPHARIFLEWeaponDetails.gameObject.SetActive(true);
                ALPHARIFLEID.gameObject.SetActive(true);
                SniperWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                SniperBackButton.gameObject.SetActive(true);
                ALPHARIFLEEquipTab.gameObject.SetActive(true);
            }
        }

        if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
        {
            if (IsSVDActive == true)
            {
                if (SniperFirstTime == false)
                {
                    SVDPriceTab.gameObject.SetActive(true);
                    SVDWeaponDetails.gameObject.SetActive(true);
                    SVDID.gameObject.SetActive(true);
                    SniperWeaponSwitchImg.gameObject.SetActive(true);
                    ExitBackButton.gameObject.SetActive(false);
                    SniperBackButton.gameObject.SetActive(true);
                    SVDEquipTab.gameObject.SetActive(false);
                }
            }
        }
        else if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
        {
            if (IsSLPActive == true)
            {
                SLPEquippedTab.gameObject.SetActive(true);
                SLPPriceTab.gameObject.SetActive(false);
                SLPWeaponDetails.gameObject.SetActive(true);
                SLPID.gameObject.SetActive(true);
                SniperWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                SniperBackButton.gameObject.SetActive(true);
                SLPEquipTab.gameObject.SetActive(false);
                SLPEquippedTab.gameObject.SetActive(true);
            }
        }
        else if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
        {
            if (IsM40a3Active == true)
            {
                M40a3EquippedTab.gameObject.SetActive(true);
                M40a3PriceTab.gameObject.SetActive(false);
                M40a3WeaponDetails.gameObject.SetActive(true);
                M40a3ID.gameObject.SetActive(true);
                SniperWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                SniperBackButton.gameObject.SetActive(true);
                M40a3EquipTab.gameObject.SetActive(false);
                M40a3EquippedTab.gameObject.SetActive(true);
            }
        }
        else if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
        {
            if (IsKsvkActive == true)
            {
                KsvkEquippedTab.gameObject.SetActive(true);
                KsvkPriceTab.gameObject.SetActive(false);
                KsvkWeaponDetails.gameObject.SetActive(true);
                KsvkID.gameObject.SetActive(true);
                SniperWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                SniperBackButton.gameObject.SetActive(true);
                KsvkEquipTab.gameObject.SetActive(false);
                KsvkEquippedTab.gameObject.SetActive(true);
            }
        }
        else if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
        {
            if (IsALPHARIFLEActive == true)
            {
                ALPHARIFLEEquippedTab.gameObject.SetActive(true);
                ALPHARIFLEPriceTab.gameObject.SetActive(false);
                ALPHARIFLEWeaponDetails.gameObject.SetActive(true);
                ALPHARIFLEID.gameObject.SetActive(true);
                SniperWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                SniperBackButton.gameObject.SetActive(true);
                ALPHARIFLEEquipTab.gameObject.SetActive(false);
                ALPHARIFLEEquippedTab.gameObject.SetActive(true);
            }
        }

    }

    public void ActivatePistol()
    {

        if (PistolFirstTime == true)
        {
            IsGlockActive = true;
            GlockWeaponDetails.gameObject.SetActive(true);
            GlockID.gameObject.SetActive(true);
            PistolWeaponSwitchImg.gameObject.SetActive(true);
            ExitBackButton.gameObject.SetActive(false);
            PistolBackButton.gameObject.SetActive(true);
            GlockEquipTab.gameObject.SetActive(true);
            Glock.gameObject.SetActive(true);
            PistolFirstTime = false;
            PlayerPrefs.SetInt("BoughtGlock", 1);
        }

        PFT += 1.0f;
        if (PFT == 1.0f)
        {
            if (PistolFirstTime == false)
            {
                if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
                {
                    IsGlockActive = true;
                    IsM1911Active = false;
                    IsM1323Active = false;
                    IsWP01Active = false;
                    IsULTRAActive = false;
                    PistolWeaponSwitchNo = 1;
                    Glock.gameObject.SetActive(true);
                }
                else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
                {
                    IsGlockActive = false;
                    IsM1911Active = true;
                    IsM1323Active = false;
                    IsWP01Active = false;
                    IsULTRAActive = false;
                    PistolWeaponSwitchNo = 2;
                    M1911.gameObject.SetActive(true);
                }
                else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
                {
                    IsGlockActive = false;
                    IsM1911Active = false;
                    IsM1323Active = true;
                    IsWP01Active = false;
                    IsULTRAActive = false;
                    PistolWeaponSwitchNo = 3;
                    M1323.gameObject.SetActive(true);
                }
                else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
                {
                    IsGlockActive = false;
                    IsM1911Active = false;
                    IsM1323Active = false;
                    IsWP01Active = true;
                    IsULTRAActive = false;
                    PistolWeaponSwitchNo = 4;
                    WP01.gameObject.SetActive(true);
                }
                else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
                {
                    IsGlockActive = false;
                    IsM1911Active = false;
                    IsM1323Active = false;
                    IsWP01Active = false;
                    IsULTRAActive = true;
                    PistolWeaponSwitchNo = 5;
                    ULTRA.gameObject.SetActive(true);
                }
            }
        }

        if (FirstTime == true)
        {
            PWT += 1.0f;
            if (PWT == 1.0f)
            {
                WeaponsTut.gameObject.SetActive(true);
            }
            TutorialButton.gameObject.SetActive(false);
        }
        else if (FirstTime == false)
        {
            WeaponsTutButton.gameObject.SetActive(true);
            TutorialButton.gameObject.SetActive(false);
        }
        IsInSniperScreenCantExit = true;
        LanguageBut.gameObject.SetActive(false);
        GrenadePanel.gameObject.SetActive(false);
        BottomTabGO.gameObject.SetActive(false);
        SniperWeaponHolder.gameObject.SetActive(false);
        PistolWeaponHolder.gameObject.SetActive(true);
        AssultWeaponHolder.gameObject.SetActive(false);
        ExitBackButton.gameObject.SetActive(false);
        PistolBackButton.gameObject.SetActive(true);
        PistolWeaponSwitchImg.gameObject.SetActive(true);

        if (PistolWeaponSwitchNo == 2)
        {
            Glock.gameObject.SetActive(false);
            M1323.gameObject.SetActive(false);
            WP01.gameObject.SetActive(false);
            ULTRA.gameObject.SetActive(false);
            if (PlayerPrefs.GetInt("BoughtM1911") == 0)
            {
                M1911PriceTab.gameObject.SetActive(true);
                M1911WeaponDetails.gameObject.SetActive(true);
                M1911ID.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("BoughtM1911") == 1)
            {
                M1911EquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
            {
                M1911EquippedTab.gameObject.SetActive(true);
            }

        }

        if (PistolWeaponSwitchNo == 3)
        {
            Glock.gameObject.SetActive(false);
            M1911.gameObject.SetActive(false);
            WP01.gameObject.SetActive(false);
            ULTRA.gameObject.SetActive(false);
            if (PlayerPrefs.GetInt("BoughtM1911") == 0)
            {
                M1323PriceTab.gameObject.SetActive(true);
                M1323WeaponDetails.gameObject.SetActive(true);
                M1323ID.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("BoughtM1911") == 1)
            {
                M1323EquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
            {
                M1323EquippedTab.gameObject.SetActive(true);
            }

        }

        if (PistolWeaponSwitchNo == 4)
        {
            Glock.gameObject.SetActive(false);
            M1323.gameObject.SetActive(false);
            M1911.gameObject.SetActive(false);
            ULTRA.gameObject.SetActive(false);
            if (PlayerPrefs.GetInt("BoughtM1911") == 0)
            {
                WP01PriceTab.gameObject.SetActive(true);
                WP01WeaponDetails.gameObject.SetActive(true);
                WP01ID.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("BoughtM1911") == 1)
            {
                WP01EquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
            {
                WP01EquippedTab.gameObject.SetActive(true);
            }

        }

        if (PistolWeaponSwitchNo == 5)
        {
            Glock.gameObject.SetActive(false);
            M1323.gameObject.SetActive(false);
            WP01.gameObject.SetActive(false);
            M1911.gameObject.SetActive(false);
            if (PlayerPrefs.GetInt("BoughtM1911") == 0)
            {
                ULTRAPriceTab.gameObject.SetActive(true);
                ULTRAWeaponDetails.gameObject.SetActive(true);
                ULTRAID.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("BoughtM1911") == 1)
            {
                ULTRAEquipTab.gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
            {
                ULTRAEquippedTab.gameObject.SetActive(true);
            }

        }

        if (PlayerPrefs.GetInt("BoughtGlock") == 1)
        {
            if (IsGlockActive == true)
            {
                if (PistolFirstTime == false)
                {
                    GlockWeaponDetails.gameObject.SetActive(true);
                    GlockID.gameObject.SetActive(true);
                    PistolWeaponSwitchImg.gameObject.SetActive(true);
                    ExitBackButton.gameObject.SetActive(false);
                    PistolBackButton.gameObject.SetActive(true);
                    GlockEquipTab.gameObject.SetActive(true);
                }
            }
        }
        if (PlayerPrefs.GetInt("BoughtM1911") == 1)
        {
            if (IsM1911Active == true)
            {
                M1911PriceTab.gameObject.SetActive(false);
                M1911WeaponDetails.gameObject.SetActive(true);
                M1911ID.gameObject.SetActive(true);
                PistolWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                PistolBackButton.gameObject.SetActive(true);
                M1911EquipTab.gameObject.SetActive(true);
            }
        }

        if (PlayerPrefs.GetInt("BoughtM1323") == 1)
        {
            if (IsM1323Active == true)
            {
                M1323PriceTab.gameObject.SetActive(false);
                M1323WeaponDetails.gameObject.SetActive(true);
                M1323ID.gameObject.SetActive(true);
                PistolWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                PistolBackButton.gameObject.SetActive(true);
                M1323EquipTab.gameObject.SetActive(true);
            }
        }

        if (PlayerPrefs.GetInt("BoughtWP01") == 1)
        {
            if (IsWP01Active == true)
            {
                WP01PriceTab.gameObject.SetActive(false);
                WP01WeaponDetails.gameObject.SetActive(true);
                WP01ID.gameObject.SetActive(true);
                PistolWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                PistolBackButton.gameObject.SetActive(true);
                WP01EquipTab.gameObject.SetActive(true);
            }
        }

        if (PlayerPrefs.GetInt("BoughtULTRA") == 1)
        {
            if (IsULTRAActive == true)
            {
                ULTRAPriceTab.gameObject.SetActive(false);
                ULTRAWeaponDetails.gameObject.SetActive(true);
                ULTRAID.gameObject.SetActive(true);
                PistolWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                PistolBackButton.gameObject.SetActive(true);
                ULTRAEquipTab.gameObject.SetActive(true);
            }
        }

        if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
        {
            if (IsGlockActive == true)
            {
                if (PistolFirstTime == false)
                {
                    GlockPriceTab.gameObject.SetActive(true);
                    GlockWeaponDetails.gameObject.SetActive(true);
                    GlockID.gameObject.SetActive(true);
                    PistolWeaponSwitchImg.gameObject.SetActive(true);
                    ExitBackButton.gameObject.SetActive(false);
                    PistolBackButton.gameObject.SetActive(true);
                    GlockEquipTab.gameObject.SetActive(false);
                }
            }
        }
        else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
        {
            if (IsM1911Active == true)
            {
                M1911EquippedTab.gameObject.SetActive(true);
                M1911PriceTab.gameObject.SetActive(false);
                M1911WeaponDetails.gameObject.SetActive(true);
                M1911ID.gameObject.SetActive(true);
                PistolWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                PistolBackButton.gameObject.SetActive(true);
                M1911EquipTab.gameObject.SetActive(false);
                M1911EquippedTab.gameObject.SetActive(true);
            }
        }
        else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
        {
            if (IsM1323Active == true)
            {
                M1323EquippedTab.gameObject.SetActive(true);
                M1323PriceTab.gameObject.SetActive(false);
                M1323WeaponDetails.gameObject.SetActive(true);
                M1323ID.gameObject.SetActive(true);
                PistolWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                PistolBackButton.gameObject.SetActive(true);
                M1323EquipTab.gameObject.SetActive(false);
                M1323EquippedTab.gameObject.SetActive(true);
            }
        }
        else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
        {
            if (IsWP01Active == true)
            {
                WP01EquippedTab.gameObject.SetActive(true);
                WP01PriceTab.gameObject.SetActive(false);
                WP01WeaponDetails.gameObject.SetActive(true);
                WP01ID.gameObject.SetActive(true);
                PistolWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                PistolBackButton.gameObject.SetActive(true);
                WP01EquipTab.gameObject.SetActive(false);
                WP01EquippedTab.gameObject.SetActive(true);
            }
        }
        else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
        {
            if (IsULTRAActive == true)
            {
                ULTRAEquippedTab.gameObject.SetActive(true);
                ULTRAPriceTab.gameObject.SetActive(false);
                ULTRAWeaponDetails.gameObject.SetActive(true);
                ULTRAID.gameObject.SetActive(true);
                PistolWeaponSwitchImg.gameObject.SetActive(true);
                ExitBackButton.gameObject.SetActive(false);
                PistolBackButton.gameObject.SetActive(true);
                ULTRAEquipTab.gameObject.SetActive(false);
                ULTRAEquippedTab.gameObject.SetActive(true);
            }
        }

    }

    public void SwitchAssultWeapons()
    {
        WeaponSwitchNo++;
        if (WeaponSwitchNo == 2)
        {
            IsAK47UActive = false;
            if (PlayerPrefs.GetInt("BoughtAK47U") == 1)
            {
                AK47UPriceTab.gameObject.SetActive(false);
                AK47UEquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
            {
                AK47UPriceTab.gameObject.SetActive(false);
                AK47UKSEquippedTab.gameObject.SetActive(false);
            }
            AK47U.gameObject.SetActive(false);
            AK47UWeaponDetails.gameObject.SetActive(false);
            AK47UID.gameObject.SetActive(false);
            AK47UPriceTab.gameObject.SetActive(false);
            IsAK47Active = true;
            AK47.gameObject.SetActive(true);
            AK47PriceTab.gameObject.SetActive(true);
            AK47WeaponDetails.gameObject.SetActive(true);
            AK47ID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtAK47") == 1)
            {
                AK47PriceTab.gameObject.SetActive(false);
                AK47EquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtAK47") == 0)
            {
                AK47EquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
            {
                AK47EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
            {
                AK47EquippedTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
            {
                AK47EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
            {
                AK47EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
            {
                AK47EquippedTab.gameObject.SetActive(false);
            }
        }
        else if (WeaponSwitchNo == 3)
        {
            IsAK47Active = false;
            AK47.gameObject.SetActive(false);
            AK47PriceTab.gameObject.SetActive(false);
            AK47WeaponDetails.gameObject.SetActive(false);
            AK47ID.gameObject.SetActive(false);
            AK47EquipTab.gameObject.SetActive(false);
            AK47EquippedTab.gameObject.SetActive(false);
            IsAK47UAMODActive = true;

            AK47UAMOD.gameObject.SetActive(true);
            AK47UAMODPriceTab.gameObject.SetActive(true);
            AK47UAMODWeaponDetails.gameObject.SetActive(true);
            AK47UAMODID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtAK47UAMOD") == 1)
            {
                AK47UAMODPriceTab.gameObject.SetActive(false);
                AK47UAMODEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtAK47UAMOD") == 0)
            {
                AK47UAMODEquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
            {
                AK47UAMODEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
            {
                AK47UAMODEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
            {
                AK47UAMODEquippedTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
            {
                AK47UAMODEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
            {
                AK47UAMODEquippedTab.gameObject.SetActive(false);
            }
        }
        else if (WeaponSwitchNo == 4)
        {
            IsAK47UAMODActive = false;

            AK47UAMOD.gameObject.SetActive(false);
            AK47UAMODPriceTab.gameObject.SetActive(false);
            AK47UAMODWeaponDetails.gameObject.SetActive(false);
            AK47UAMODID.gameObject.SetActive(false);
            AK47UAMODEquipTab.gameObject.SetActive(false);
            AK47UAMODEquippedTab.gameObject.SetActive(false);
            IsAK47UKSActive = true;
            AK47UKS.gameObject.SetActive(true);
            AK47UKSPriceTab.gameObject.SetActive(true);
            AK47UKSWeaponDetails.gameObject.SetActive(true);
            AK47UKSID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtAK47UKS") == 1)
            {
                AK47UKSPriceTab.gameObject.SetActive(false);
                AK47UKSEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtAK47UKS") == 0)
            {
                AK47UKSEquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
            {
                AK47UKSEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
            {
                AK47UKSEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
            {
                AK47UKSEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
            {
                AK47UKSEquippedTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
            {
                AK47UKSEquippedTab.gameObject.SetActive(false);
            }
        }
        else if (WeaponSwitchNo == 5)
        {
            IsAK47UKSActive = false;
            AK47UKS.gameObject.SetActive(false);
            AK47UKSPriceTab.gameObject.SetActive(false);
            AK47UKSWeaponDetails.gameObject.SetActive(false);
            AK47UKSID.gameObject.SetActive(false);
            AK47UKSEquipTab.gameObject.SetActive(false);
            AK47UKSEquippedTab.gameObject.SetActive(false);
            IsMEGASHOTActive = true;
            MEGASHOT.gameObject.SetActive(true);
            MEGASHOTPriceTab.gameObject.SetActive(true);
            MEGASHOTWeaponDetails.gameObject.SetActive(true);
            MEGASHOTID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtMEGASHOT") == 1)
            {
                MEGASHOTPriceTab.gameObject.SetActive(false);
                MEGASHOTEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtMEGASHOT") == 0)
            {
                MEGASHOTEquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
            {
                MEGASHOTEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
            {
                MEGASHOTEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
            {
                MEGASHOTEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
            {
                MEGASHOTEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
            {
                MEGASHOTEquippedTab.gameObject.SetActive(true);
            }
        }
        else if (WeaponSwitchNo == 6)
        {
            IsMEGASHOTActive = false;
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
            {
                MEGASHOTEquippedTab.gameObject.SetActive(false);
            }
            MEGASHOT.gameObject.SetActive(false);
            MEGASHOTPriceTab.gameObject.SetActive(false);
            MEGASHOTWeaponDetails.gameObject.SetActive(false);
            MEGASHOTID.gameObject.SetActive(false);
            MEGASHOTEquipTab.gameObject.SetActive(false);
            MEGASHOTEquippedTab.gameObject.SetActive(false);
            IsAK47UActive = true;
            if (PlayerPrefs.GetInt("BoughtAK47U") == 1)
            {
                AK47UEquipTab.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("EquippedAssultNo") == 1)
            {
                AK47UPriceTab.gameObject.SetActive(true);
                AK47UEquipTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 2)
            {
                AK47UPriceTab.gameObject.SetActive(false);
                AK47UEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 3)
            {
                AK47UPriceTab.gameObject.SetActive(false);
                AK47UEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 4)
            {
                AK47UPriceTab.gameObject.SetActive(false);
                AK47UEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedAssultNo") == 5)
            {
                AK47UPriceTab.gameObject.SetActive(false);
                AK47UEquipTab.gameObject.SetActive(true);
            }
            AK47U.gameObject.SetActive(true);
            AK47UWeaponDetails.gameObject.SetActive(true);
            AK47UID.gameObject.SetActive(true);
            WeaponSwitchNo = 1;
        }
    }

    public void SwitchSniperWeapons()
    {
        SniperWeaponSwitchNo++;
        if (SniperWeaponSwitchNo == 2)
        {
            IsSVDActive = false;
            if (PlayerPrefs.GetInt("BoughtSVD") == 1)
            {
                SVDPriceTab.gameObject.SetActive(false);
                SVDEquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
            {
                SVDPriceTab.gameObject.SetActive(false);

            }
            SVD.gameObject.SetActive(false);
            SVDWeaponDetails.gameObject.SetActive(false);
            SVDID.gameObject.SetActive(false);
            SVDPriceTab.gameObject.SetActive(false);
            IsSLPActive = true;
            SLP.gameObject.SetActive(true);
            SLPPriceTab.gameObject.SetActive(true);
            SLPWeaponDetails.gameObject.SetActive(true);
            SLPID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtSLP") == 1)
            {
                SLPPriceTab.gameObject.SetActive(false);
                SLPEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtSLP") == 0)
            {
                SLPEquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
            {
                SLPEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
            {
                SLPEquippedTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
            {
                SLPEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
            {
                SLPEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
            {
                SLPEquippedTab.gameObject.SetActive(false);
            }
        }
        else if (SniperWeaponSwitchNo == 3)
        {
            IsSLPActive = false;
            SLP.gameObject.SetActive(false);
            SLPPriceTab.gameObject.SetActive(false);
            SLPWeaponDetails.gameObject.SetActive(false);
            SLPID.gameObject.SetActive(false);
            SLPEquipTab.gameObject.SetActive(false);
            SLPEquippedTab.gameObject.SetActive(false);
            IsM40a3Active = true;
            M40a3.gameObject.SetActive(true);
            M40a3PriceTab.gameObject.SetActive(true);
            M40a3WeaponDetails.gameObject.SetActive(true);
            M40a3ID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtM40a3") == 1)
            {
                M40a3PriceTab.gameObject.SetActive(false);
                M40a3EquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtM40a3") == 0)
            {
                M40a3EquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
            {
                M40a3EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
            {
                M40a3EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
            {
                M40a3EquippedTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
            {
                M40a3EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
            {
                M40a3EquippedTab.gameObject.SetActive(false);
            }
        }
        else if (SniperWeaponSwitchNo == 4)
        {
            IsM40a3Active = false;
            M40a3.gameObject.SetActive(false);
            M40a3PriceTab.gameObject.SetActive(false);
            M40a3WeaponDetails.gameObject.SetActive(false);
            M40a3ID.gameObject.SetActive(false);
            M40a3EquipTab.gameObject.SetActive(false);
            M40a3EquippedTab.gameObject.SetActive(false);
            IsKsvkActive = true;
            Ksvk.gameObject.SetActive(true);
            KsvkPriceTab.gameObject.SetActive(true);
            KsvkWeaponDetails.gameObject.SetActive(true);
            KsvkID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtKsvk") == 1)
            {
                KsvkPriceTab.gameObject.SetActive(false);
                KsvkEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtKsvk") == 0)
            {
                KsvkEquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
            {
                KsvkEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
            {
                KsvkEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
            {
                KsvkEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
            {
                KsvkEquippedTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
            {
                KsvkEquippedTab.gameObject.SetActive(false);
            }
        }
        else if (SniperWeaponSwitchNo == 5)
        {
            IsKsvkActive = false;
            Ksvk.gameObject.SetActive(false);
            KsvkPriceTab.gameObject.SetActive(false);
            KsvkWeaponDetails.gameObject.SetActive(false);
            KsvkID.gameObject.SetActive(false);
            KsvkEquipTab.gameObject.SetActive(false);
            KsvkEquippedTab.gameObject.SetActive(false);
            IsALPHARIFLEActive = true;
            ALPHARIFLE.gameObject.SetActive(true);
            ALPHARIFLEPriceTab.gameObject.SetActive(true);
            ALPHARIFLEWeaponDetails.gameObject.SetActive(true);
            ALPHARIFLEID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtALPHARIFLE") == 1)
            {
                ALPHARIFLEPriceTab.gameObject.SetActive(false);
                ALPHARIFLEEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtALPHARIFLE") == 0)
            {
                ALPHARIFLEEquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
            {
                ALPHARIFLEEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
            {
                ALPHARIFLEEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
            {
                ALPHARIFLEEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
            {
                ALPHARIFLEEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
            {
                ALPHARIFLEEquippedTab.gameObject.SetActive(true);
            }
        }
        else if (SniperWeaponSwitchNo == 6)
        {
            IsALPHARIFLEActive = false;
            if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
            {
                SVDPriceTab.gameObject.SetActive(false);
            }
            ALPHARIFLE.gameObject.SetActive(false);
            ALPHARIFLEPriceTab.gameObject.SetActive(false);
            ALPHARIFLEWeaponDetails.gameObject.SetActive(false);
            ALPHARIFLEID.gameObject.SetActive(false);
            ALPHARIFLEEquipTab.gameObject.SetActive(false);
            ALPHARIFLEEquippedTab.gameObject.SetActive(false);
            IsSVDActive = true;
            if (PlayerPrefs.GetInt("BoughtAK47U") == 1)
            {
                SVDEquipTab.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("EquippedSniperNo") == 1)
            {
                SVDPriceTab.gameObject.SetActive(true);
                SVDEquipTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 2)
            {
                SVDPriceTab.gameObject.SetActive(false);
                SVDEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 3)
            {
                SVDPriceTab.gameObject.SetActive(false);
                SVDEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 4)
            {
                SVDPriceTab.gameObject.SetActive(false);
                SVDEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedSniperNo") == 5)
            {
                SVDPriceTab.gameObject.SetActive(false);
                SVDEquipTab.gameObject.SetActive(true);
            }
            SVD.gameObject.SetActive(true);
            SVDWeaponDetails.gameObject.SetActive(true);
            SVDID.gameObject.SetActive(true);
            SniperWeaponSwitchNo = 1;
        }
    }

    public void SwitchPistolWeapons()
    {
        PistolWeaponSwitchNo++;
        if (PistolWeaponSwitchNo == 2)
        {
            IsGlockActive = false;
            if (PlayerPrefs.GetInt("BoughtGlock") == 1)
            {
                GlockPriceTab.gameObject.SetActive(false);
                GlockEquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
            {
                GlockPriceTab.gameObject.SetActive(false);

            }
            Glock.gameObject.SetActive(false);
            GlockWeaponDetails.gameObject.SetActive(false);
            GlockID.gameObject.SetActive(false);
            GlockPriceTab.gameObject.SetActive(false);
            IsM1911Active = true;
            M1911.gameObject.SetActive(true);
            M1911PriceTab.gameObject.SetActive(true);
            M1911WeaponDetails.gameObject.SetActive(true);
            M1911ID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtM1911") == 1)
            {
                M1911PriceTab.gameObject.SetActive(false);
                M1911EquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtM1911") == 0)
            {
                M1911EquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
            {
                M1911EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
            {
                M1911EquippedTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
            {
                M1911EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
            {
                M1911EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
            {
                M1911EquippedTab.gameObject.SetActive(false);
            }
        }
        else if (PistolWeaponSwitchNo == 3)
        {
            IsM1911Active = false;
            if (PlayerPrefs.GetInt("BoughtM1911") == 1)
            {
                M1911PriceTab.gameObject.SetActive(false);
                M1911EquipTab.gameObject.SetActive(false);
            }
            M1911.gameObject.SetActive(false);
            M1911WeaponDetails.gameObject.SetActive(false);
            M1911ID.gameObject.SetActive(false);
            M1911PriceTab.gameObject.SetActive(false);
            M1911EquippedTab.gameObject.SetActive(false);
            IsM1323Active = true;
            M1323.gameObject.SetActive(true);
            M1323PriceTab.gameObject.SetActive(true);
            M1323WeaponDetails.gameObject.SetActive(true);
            M1323ID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtM1323") == 1)
            {
                M1323PriceTab.gameObject.SetActive(false);
                M1323EquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtM1323") == 0)
            {
                M1323EquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
            {
                M1323EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
            {
                M1323EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
            {
                M1323EquippedTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
            {
                M1323EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
            {
                M1323EquippedTab.gameObject.SetActive(false);
            }
        }
        else if (PistolWeaponSwitchNo == 4)
        {
            IsM1323Active = false;
            if (PlayerPrefs.GetInt("BoughtM1323") == 1)
            {
                M1323PriceTab.gameObject.SetActive(false);
                M1323EquipTab.gameObject.SetActive(false);
            }
            M1323.gameObject.SetActive(false);
            M1323WeaponDetails.gameObject.SetActive(false);
            M1323ID.gameObject.SetActive(false);
            M1323PriceTab.gameObject.SetActive(false);
            M1323EquippedTab.gameObject.SetActive(false);
            IsWP01Active = true;
            WP01.gameObject.SetActive(true);
            WP01PriceTab.gameObject.SetActive(true);
            WP01WeaponDetails.gameObject.SetActive(true);
            WP01ID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtWP01") == 1)
            {
                WP01PriceTab.gameObject.SetActive(false);
                WP01EquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtWP01") == 0)
            {
                WP01EquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
            {
                WP01EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
            {
                WP01EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
            {
                WP01EquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
            {
                WP01EquippedTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
            {
                WP01EquippedTab.gameObject.SetActive(false);
            }
        }
        else if (PistolWeaponSwitchNo == 5)
        {
            IsWP01Active = false;
            if (PlayerPrefs.GetInt("BoughtWP01") == 1)
            {
                WP01PriceTab.gameObject.SetActive(false);
                WP01EquipTab.gameObject.SetActive(false);
            }
            WP01.gameObject.SetActive(false);
            WP01WeaponDetails.gameObject.SetActive(false);
            WP01ID.gameObject.SetActive(false);
            WP01PriceTab.gameObject.SetActive(false);
            WP01EquippedTab.gameObject.SetActive(false);
            IsULTRAActive = true;
            ULTRA.gameObject.SetActive(true);
            ULTRAPriceTab.gameObject.SetActive(true);
            ULTRAWeaponDetails.gameObject.SetActive(true);
            ULTRAID.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("BoughtULTRA") == 1)
            {
                ULTRAPriceTab.gameObject.SetActive(false);
                ULTRAEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("BoughtULTRA") == 0)
            {
                ULTRAEquipTab.gameObject.SetActive(false);
            }
            if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
            {
                ULTRAEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
            {
                ULTRAEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
            {
                ULTRAEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
            {
                ULTRAEquippedTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
            {
                ULTRAEquippedTab.gameObject.SetActive(true);
            }
        }
        else if (PistolWeaponSwitchNo == 6)
        {
            IsULTRAActive = false;
            if (PlayerPrefs.GetInt("EquippedPistoltNo") == 5)
            {
                ULTRAEquippedTab.gameObject.SetActive(false);
            }
            ULTRA.gameObject.SetActive(false);
            ULTRAPriceTab.gameObject.SetActive(false);
            ULTRAWeaponDetails.gameObject.SetActive(false);
            ULTRAID.gameObject.SetActive(false);
            ULTRAEquipTab.gameObject.SetActive(false);
            ULTRAEquippedTab.gameObject.SetActive(false);
            IsGlockActive = true;
            if (PlayerPrefs.GetInt("BoughtGlock") == 1)
            {
                GlockEquipTab.gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetInt("EquippedPistolNo") == 1)
            {
                GlockPriceTab.gameObject.SetActive(true);
                GlockEquipTab.gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 2)
            {
                GlockPriceTab.gameObject.SetActive(false);
                GlockEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 3)
            {
                GlockPriceTab.gameObject.SetActive(false);
                GlockEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 4)
            {
                GlockPriceTab.gameObject.SetActive(false);
                GlockEquipTab.gameObject.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("EquippedPistolNo") == 5)
            {
                GlockPriceTab.gameObject.SetActive(false);
                GlockEquipTab.gameObject.SetActive(true);
            }
            Glock.gameObject.SetActive(true);
            GlockWeaponDetails.gameObject.SetActive(true);
            GlockID.gameObject.SetActive(true);
            PistolWeaponSwitchNo = 1;
        }
    }

    public void StartGame()
    {
        if (PlayerPrefs.HasKey("EquippedAssultNo") && PlayerPrefs.HasKey("EquippedSniperNo") && PlayerPrefs.HasKey("EquippedPistolNo"))
        {
            if (EnergyValue >= 3)
            {
                PleaseWaitUI.gameObject.SetActive(true);
                EnergyValue -= 3;
                PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + 1);

                PlayerPrefs.SetInt("EnergyValue", EnergyValue);
                SL1.LoadGame2();
            }
            else if (EnergyValue < 3)
            {
                Message2.gameObject.SetActive(true);
            }
        }
        else if (!PlayerPrefs.HasKey("EquippedAssultNo") && !PlayerPrefs.HasKey("EquippedSniperNo") && !PlayerPrefs.HasKey("EquippedPistolNo"))
        {
            Message.gameObject.SetActive(true);
        }
        else if (!PlayerPrefs.HasKey("EquippedAssultNo"))
        {
            AssultMessage.gameObject.SetActive(true);
        }
        else if (!PlayerPrefs.HasKey("EquippedSniperNo"))
        {
            SniperMessage.gameObject.SetActive(true);
        }
        else if (!PlayerPrefs.HasKey("EquippedPistolNo"))
        {
            PistolMessage.gameObject.SetActive(true);
        }
    }

    public void CloseMessage()
    {
        Message.gameObject.SetActive(false);
    }

    public void AssultCloseMessage()
    {
        AssultMessage.gameObject.SetActive(false);
    }

    public void SniperCloseMessage()
    {
        SniperMessage.gameObject.SetActive(false);
    }

    public void PistolCloseMessage()
    {
        PistolMessage.gameObject.SetActive(false);
    }

    public void CloseMessage2()
    {
        Message2.gameObject.SetActive(false);
    }

    public void AK47UEquip()
    {
        PlayerPrefs.SetInt("FirstTime", 1);
        PlayerPrefs.SetInt("EquippedAssultNo", 1);
        AK47UEquipTab.gameObject.SetActive(false);
        AK47UPriceTab.gameObject.SetActive(true);
    }

    public void AK47Equip()
    {
        PlayerPrefs.SetInt("FirstTime", 1);
        PlayerPrefs.SetInt("EquippedAssultNo", 2);
        AK47EquipTab.gameObject.SetActive(false);
        AK47EquippedTab.gameObject.SetActive(true);
    }

    public void AK47UAMODEquip()
    {
        PlayerPrefs.SetInt("FirstTime", 1);
        PlayerPrefs.SetInt("EquippedAssultNo", 3);
        AK47UAMODEquipTab.gameObject.SetActive(false);
        AK47UAMODEquippedTab.gameObject.SetActive(true);
    }

    public void AK47UKSEquip()
    {
        PlayerPrefs.SetInt("FirstTime", 1);
        PlayerPrefs.SetInt("EquippedAssultNo", 4);
        AK47UKSEquipTab.gameObject.SetActive(false);
        AK47UKSEquippedTab.gameObject.SetActive(true);
    }

    public void MEGASHOTEquip()
    {
        PlayerPrefs.SetInt("FirstTime", 1);
        PlayerPrefs.SetInt("EquippedAssultNo", 5);
        MEGASHOTEquipTab.gameObject.SetActive(false);
        MEGASHOTEquippedTab.gameObject.SetActive(true);
    }

    public void BuyAK47InCoins()
    {
        if (CoinValue >= 700)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);

            CoinValue -= 700;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtAK47", 1);
            AK47PriceTab.gameObject.SetActive(false);
            AK47EquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 700)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuyAK47InGems()
    {
        if (GemValue >= 70)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 70;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtAK47", 1);
            AK47PriceTab.gameObject.SetActive(false);
            AK47EquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 70)
        {
            ActivateGemPurchase();
        }
    }
    public void BuyAK47UAMODInCoins()
    {
        if (CoinValue >= 1000)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            CoinValue -= 1000;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtAK47UAMOD", 1);
            AK47UAMODPriceTab.gameObject.SetActive(false);
            AK47UAMODEquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 1000)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuyAK47UAMODInGems()
    {
        if (GemValue >= 100)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 100;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtAK47UAMOD", 1);
            AK47UAMODPriceTab.gameObject.SetActive(false);
            AK47UAMODEquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 100)
        {
            ActivateGemPurchase();
        }
    }
    public void BuyAK47UKSInCoins()
    {
        if (CoinValue >= 1500)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            CoinValue -= 1500;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtAK47UKS", 1);
            AK47UKSPriceTab.gameObject.SetActive(false);
            AK47UKSEquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 1500)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuyAK47UKSInGems()
    {
        if (GemValue >= 150)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 150;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtAK47UKS", 1);
            AK47UKSPriceTab.gameObject.SetActive(false);
            AK47UKSEquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 150)
        {
            ActivateGemPurchase();
        }
    }
    public void BuyMEGASHOTInCoins()
    {
        if (CoinValue >= 3500)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            CoinValue -= 3500;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtMEGASHOT", 1);
            MEGASHOTPriceTab.gameObject.SetActive(false);
            MEGASHOTEquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 3500)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuyMEGASHOTInGems()
    {
        if (GemValue >= 700)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 700;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtMEGASHOT", 1);
            MEGASHOTPriceTab.gameObject.SetActive(false);
            MEGASHOTEquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 700)
        {
            ActivateGemPurchase();
        }
    }

    public void SVDEquip()
    {
        PlayerPrefs.SetInt("SniperFirstTime", 1);
        PlayerPrefs.SetInt("EquippedSniperNo", 1);
        SVDEquipTab.gameObject.SetActive(false);
        SVDPriceTab.gameObject.SetActive(true);
    }

    public void SLPEquip()
    {
        PlayerPrefs.SetInt("SniperFirstTime", 1);
        PlayerPrefs.SetInt("EquippedSniperNo", 2);
        SLPEquipTab.gameObject.SetActive(false);
        SLPEquippedTab.gameObject.SetActive(true);
    }

    public void M40a3Equip()
    {
        PlayerPrefs.SetInt("SniperFirstTime", 1);
        PlayerPrefs.SetInt("EquippedSniperNo", 3);
        M40a3EquipTab.gameObject.SetActive(false);
        M40a3EquippedTab.gameObject.SetActive(true);
    }

    public void KsvkEquip()
    {
        PlayerPrefs.SetInt("SniperFirstTime", 1);
        PlayerPrefs.SetInt("EquippedSniperNo", 4);
        KsvkEquipTab.gameObject.SetActive(false);
        KsvkEquippedTab.gameObject.SetActive(true);
    }

    public void ALPHARIFLEEquip()
    {
        PlayerPrefs.SetInt("SniperFirstTime", 1);
        PlayerPrefs.SetInt("EquippedSniperNo", 5);
        ALPHARIFLEEquipTab.gameObject.SetActive(false);
        ALPHARIFLEEquippedTab.gameObject.SetActive(true);
    }
    public void BuySLPInCoins()
    {
        if (CoinValue >= 800)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            CoinValue -= 800;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtSLP", 1);
            SLPPriceTab.gameObject.SetActive(false);
            SLPEquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 800)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuySLPInGems()
    {
        if (GemValue >= 80)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 80;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtSLP", 1);
            SLPPriceTab.gameObject.SetActive(false);
            SLPEquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 80)
        {
            ActivateGemPurchase();
        }
    }

    public void BuyM40a3InCoins()
    {
        if (CoinValue >= 1000)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            CoinValue -= 1000;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtM40a3", 1);
            M40a3PriceTab.gameObject.SetActive(false);
            M40a3EquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 1000)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuyM40a3InGems()
    {
        if (GemValue >= 100)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 100;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtM40a3", 1);
            M40a3PriceTab.gameObject.SetActive(false);
            M40a3EquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 100)
        {
            ActivateGemPurchase();
        }
    }

    public void BuyKsvkInCoins()
    {
        if (CoinValue >= 2000)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            CoinValue -= 2000;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtKsvk", 1);
            KsvkPriceTab.gameObject.SetActive(false);
            KsvkEquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 2000)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuyKsvkInGems()
    {
        if (GemValue >= 200)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 200;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtKsvk", 1);
            KsvkPriceTab.gameObject.SetActive(false);
            KsvkEquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 200)
        {
            ActivateGemPurchase();
        }
    }

    public void BuyALPHARIFLEInCoins()
    {
        if (CoinValue >= 3000)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            CoinValue -= 3000;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtALPHARIFLE", 1);
            ALPHARIFLEPriceTab.gameObject.SetActive(false);
            ALPHARIFLEEquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 3000)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuyALPHARIFLEInGems()
    {
        if (GemValue >= 500)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 500;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtALPHARIFLE", 1);
            ALPHARIFLEPriceTab.gameObject.SetActive(false);
            ALPHARIFLEEquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 500)
        {
            ActivateGemPurchase();
        }
    }

    public void GlockEquip()
    {
        PlayerPrefs.SetInt("PistolFirstTime", 1);
        PlayerPrefs.SetInt("EquippedPistolNo", 1);
        GlockEquipTab.gameObject.SetActive(false);
        GlockPriceTab.gameObject.SetActive(true);
    }

    public void M1911Equip()
    {
        PlayerPrefs.SetInt("PistolFirstTime", 1);
        PlayerPrefs.SetInt("EquippedPistolNo", 2);
        M1911EquipTab.gameObject.SetActive(false);
        M1911EquippedTab.gameObject.SetActive(true);
    }

    public void M1323Equip()
    {
        PlayerPrefs.SetInt("PistolFirstTime", 1);
        PlayerPrefs.SetInt("EquippedPistolNo", 3);
        M1323EquipTab.gameObject.SetActive(false);
        M1323EquippedTab.gameObject.SetActive(true);
    }

    public void WP01Equip()
    {
        PlayerPrefs.SetInt("PistolFirstTime", 1);
        PlayerPrefs.SetInt("EquippedPistolNo", 4);
        WP01EquipTab.gameObject.SetActive(false);
        WP01EquippedTab.gameObject.SetActive(true);
    }

    public void ULTRAEquip()
    {
        PlayerPrefs.SetInt("PistolFirstTime", 1);
        PlayerPrefs.SetInt("EquippedPistolNo", 5);
        ULTRAEquipTab.gameObject.SetActive(false);
        ULTRAEquippedTab.gameObject.SetActive(true);
    }
    public void BuyM1911InCoins()
    {
        if (CoinValue >= 800)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            CoinValue -= 800;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtM1911", 1);
            M1911PriceTab.gameObject.SetActive(false);
            M1911EquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 800)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuyM1911InGems()
    {
        if (GemValue >= 80)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 80;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtM1911", 1);
            M1911PriceTab.gameObject.SetActive(false);
            M1911EquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 80)
        {
            ActivateGemPurchase();
        }
    }

    public void BuyM1323InCoins()
    {
        if (CoinValue >= 1000)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            CoinValue -= 1000;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtM1323", 1);
            M1323PriceTab.gameObject.SetActive(false);
            M1323EquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 1000)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuyM1323InGems()
    {
        if (GemValue >= 100)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 100;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtM1323", 1);
            M1323PriceTab.gameObject.SetActive(false);
            M1323EquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 100)
        {
            ActivateGemPurchase();
        }
    }

    public void BuyWP01InCoins()
    {
        if (CoinValue >= 1500)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            CoinValue -= 1500;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtWP01", 1);
            WP01PriceTab.gameObject.SetActive(false);
            WP01EquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 1500)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuyWP01InGems()
    {
        if (GemValue >= 150)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 150;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtWP01", 1);
            WP01PriceTab.gameObject.SetActive(false);
            WP01EquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 150)
        {
            ActivateGemPurchase();
        }
    }

    public void BuyULTRAInCoins()
    {
        if (CoinValue >= 2500)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            CoinValue -= 2500;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
            PlayerPrefs.SetInt("BoughtULTRA", 1);
            ULTRAPriceTab.gameObject.SetActive(false);
            ULTRAEquipTab.gameObject.SetActive(true);
        }
        else if (CoinValue < 2500)
        {
            ActivateCoinPurchase();
        }
    }
    public void BuyULTRAInGems()
    {
        if (GemValue >= 300)
        {
            WeaponsBoughtData += 1;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            PlayerPrefs.SetInt("WeaponsBought", WeaponsBoughtData);
            GemValue -= 300;
            PlayerPrefs.SetInt("GemValue", GemValue);
            PlayerPrefs.SetInt("BoughtULTRA", 1);
            ULTRAPriceTab.gameObject.SetActive(false);
            ULTRAEquipTab.gameObject.SetActive(true);
        }
        else if (GemValue < 300)
        {
            ActivateGemPurchase();
        }
    }

    public void QuitGame()
    {
        if (QuitGamePanelVisible == false)
        {
            QuitGamePanelVisible = true;
            QuitGamePanel.gameObject.SetActive(true);
        }
        else if (QuitGamePanelVisible == true)
        {
            QuitGamePanelVisible = false;
            QuitGamePanel.gameObject.SetActive(false);
        }
    }
    public void Back()
    {
        QuitGame();
    }

    public void AssultWeaponBack()
    {
        IsInAssultScreenCantExit = false;
        LanguageBut.gameObject.SetActive(true);
        GrenadePanel.gameObject.SetActive(true);
        BottomTabGO.gameObject.SetActive(true);
        SniperWeaponHolder.gameObject.SetActive(false);
        PistolWeaponHolder.gameObject.SetActive(false);
        AssultWeaponHolder.gameObject.SetActive(true);
        SniperBackButton.gameObject.SetActive(false);
        PistolBackButton.gameObject.SetActive(false);
        WeaponsTutButton.gameObject.SetActive(false);
        TutorialButton.gameObject.SetActive(true);
        if (IsAK47UActive == true)
        {
            AK47UPriceTab.gameObject.SetActive(false);
            AK47UWeaponDetails.gameObject.SetActive(false);
            AK47UID.gameObject.SetActive(false);
            AssultWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            AssultBackButton.gameObject.SetActive(false);
            AK47UEquipTab.gameObject.SetActive(false);
        }
        else if (IsAK47Active == true)
        {
            AK47PriceTab.gameObject.SetActive(false);
            AK47WeaponDetails.gameObject.SetActive(false);
            AK47ID.gameObject.SetActive(false);
            AssultWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            AssultBackButton.gameObject.SetActive(false);
            AK47EquipTab.gameObject.SetActive(false);
            AK47EquippedTab.gameObject.SetActive(false);
        }
        else if (IsAK47UAMODActive == true)
        {
            AK47UAMODPriceTab.gameObject.SetActive(false);
            AK47UAMODWeaponDetails.gameObject.SetActive(false);
            AK47UAMODID.gameObject.SetActive(false);
            AssultWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            AssultBackButton.gameObject.SetActive(false);
            AK47UAMODEquipTab.gameObject.SetActive(false);
            AK47UAMODEquippedTab.gameObject.SetActive(false);
        }
        else if (IsAK47UKSActive == true)
        {
            AK47UKSPriceTab.gameObject.SetActive(false);
            AK47UKSWeaponDetails.gameObject.SetActive(false);
            AK47UKSID.gameObject.SetActive(false);
            AssultWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            AssultBackButton.gameObject.SetActive(false);
            AK47UKSEquipTab.gameObject.SetActive(false);
            AK47UKSEquippedTab.gameObject.SetActive(false);
        }
        else if (IsMEGASHOTActive == true)
        {
            MEGASHOTPriceTab.gameObject.SetActive(false);
            MEGASHOTWeaponDetails.gameObject.SetActive(false);
            MEGASHOTID.gameObject.SetActive(false);
            AssultWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            AssultBackButton.gameObject.SetActive(false);
            MEGASHOTEquipTab.gameObject.SetActive(false);
            MEGASHOTEquippedTab.gameObject.SetActive(false);
        }
    }

    public void SniperWeaponBack()
    {
        IsInSniperScreenCantExit = false;
        BottomTabGO.gameObject.SetActive(true);
        LanguageBut.gameObject.SetActive(true);
        GrenadePanel.gameObject.SetActive(true);
        SniperWeaponHolder.gameObject.SetActive(true);
        PistolWeaponHolder.gameObject.SetActive(false);
        AssultWeaponHolder.gameObject.SetActive(false);
        SniperBackButton.gameObject.SetActive(false);
        AssultBackButton.gameObject.SetActive(false);
        PistolBackButton.gameObject.SetActive(false);
        ExitBackButton.gameObject.SetActive(true);
        WeaponsTutButton.gameObject.SetActive(false);
        TutorialButton.gameObject.SetActive(true);
        if (IsSVDActive == true)
        {
            SVDPriceTab.gameObject.SetActive(false);
            SVDWeaponDetails.gameObject.SetActive(false);
            SVDID.gameObject.SetActive(false);
            SniperWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            SniperBackButton.gameObject.SetActive(false);
            SVDEquipTab.gameObject.SetActive(false);
        }
        else if (IsSLPActive == true)
        {
            SLPPriceTab.gameObject.SetActive(false);
            SLPWeaponDetails.gameObject.SetActive(false);
            SLPID.gameObject.SetActive(false);
            SniperWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            SniperBackButton.gameObject.SetActive(false);
            SLPEquipTab.gameObject.SetActive(false);
            SLPEquippedTab.gameObject.SetActive(false);
        }
        else if (IsM40a3Active == true)
        {
            M40a3PriceTab.gameObject.SetActive(false);
            M40a3WeaponDetails.gameObject.SetActive(false);
            M40a3ID.gameObject.SetActive(false);
            SniperWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            SniperBackButton.gameObject.SetActive(false);
            M40a3EquipTab.gameObject.SetActive(false);
            M40a3EquippedTab.gameObject.SetActive(false);
        }
        else if (IsKsvkActive == true)
        {
            KsvkPriceTab.gameObject.SetActive(false);
            KsvkWeaponDetails.gameObject.SetActive(false);
            KsvkID.gameObject.SetActive(false);
            SniperWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            SniperBackButton.gameObject.SetActive(false);
            KsvkEquipTab.gameObject.SetActive(false);
            KsvkEquippedTab.gameObject.SetActive(false);
        }
        else if (IsALPHARIFLEActive == true)
        {
            ALPHARIFLEPriceTab.gameObject.SetActive(false);
            ALPHARIFLEWeaponDetails.gameObject.SetActive(false);
            ALPHARIFLEID.gameObject.SetActive(false);
            SniperWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            SniperBackButton.gameObject.SetActive(false);
            ALPHARIFLEEquipTab.gameObject.SetActive(false);
            ALPHARIFLEEquippedTab.gameObject.SetActive(false);
        }
    }

    public void PistolWeaponBack()
    {
        IsInPistolScreenCantExit = false;
        BottomTabGO.gameObject.SetActive(true);
        LanguageBut.gameObject.SetActive(true);
        GrenadePanel.gameObject.SetActive(true);
        SniperWeaponHolder.gameObject.SetActive(false);
        PistolWeaponHolder.gameObject.SetActive(true);
        AssultWeaponHolder.gameObject.SetActive(false);
        PistolBackButton.gameObject.SetActive(false);
        SniperBackButton.gameObject.SetActive(false);
        AssultBackButton.gameObject.SetActive(false);
        ExitBackButton.gameObject.SetActive(true);
        WeaponsTutButton.gameObject.SetActive(false);
        TutorialButton.gameObject.SetActive(true);
        if (IsGlockActive == true)
        {
            GlockPriceTab.gameObject.SetActive(false);
            GlockWeaponDetails.gameObject.SetActive(false);
            GlockID.gameObject.SetActive(false);
            PistolWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            PistolBackButton.gameObject.SetActive(false);
            GlockEquipTab.gameObject.SetActive(false);
        }
        else if (IsM1911Active == true)
        {
            M1911PriceTab.gameObject.SetActive(false);
            M1911WeaponDetails.gameObject.SetActive(false);
            M1911ID.gameObject.SetActive(false);
            PistolWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            PistolBackButton.gameObject.SetActive(false);
            M1911EquipTab.gameObject.SetActive(false);
            M1911EquippedTab.gameObject.SetActive(false);
        }
        else if (IsM1323Active == true)
        {
            M1323PriceTab.gameObject.SetActive(false);
            M1323WeaponDetails.gameObject.SetActive(false);
            M1323ID.gameObject.SetActive(false);
            PistolWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            PistolBackButton.gameObject.SetActive(false);
            M1323EquipTab.gameObject.SetActive(false);
            M1323EquippedTab.gameObject.SetActive(false);
        }
        else if (IsWP01Active == true)
        {
            WP01PriceTab.gameObject.SetActive(false);
            WP01WeaponDetails.gameObject.SetActive(false);
            WP01ID.gameObject.SetActive(false);
            PistolWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            PistolBackButton.gameObject.SetActive(false);
            WP01EquipTab.gameObject.SetActive(false);
            WP01EquippedTab.gameObject.SetActive(false);
        }
        else if (IsULTRAActive == true)
        {
            ULTRAPriceTab.gameObject.SetActive(false);
            ULTRAWeaponDetails.gameObject.SetActive(false);
            ULTRAID.gameObject.SetActive(false);
            PistolWeaponSwitchImg.gameObject.SetActive(false);
            ExitBackButton.gameObject.SetActive(true);
            PistolBackButton.gameObject.SetActive(false);
            ULTRAEquipTab.gameObject.SetActive(false);
            ULTRAEquippedTab.gameObject.SetActive(false);
        }
    }

    public void ConfirmQuit()
    {

        SceneManager.LoadScene("MissionsScene");
    }
    public void ExitConsumablesPanel()
    {
        IsInConsumablesPanel = false;
        BuyConsumablesCanvas.gameObject.SetActive(false);
        PurchaseBackButton.gameObject.SetActive(false);
    }
    public void ExitDailyRewardsPanel()
    {
        IsInDailyRewardsPanel = false;
        DailyRewardsCanvas.gameObject.SetActive(false);
        RewardsBackButton.gameObject.SetActive(false);
    }
    public void ActivateRewardsPanel()
    {
        IsInDailyRewardsPanel = true;
        DailyRewardsCanvas.gameObject.SetActive(true);
        RewardsBackButton.gameObject.SetActive(true);
        BasicPanel.gameObject.SetActive(true);
        AchievementPanel.gameObject.SetActive(false);
        DailyTaskPanel.gameObject.SetActive(false);
        BasicTabButtonImg.color = Color.grey;
        AchievementTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
        DailyTaskTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
    }
    public void ActivateCoinPurchase()
    {
        BuyConsumablesCanvas.gameObject.SetActive(true);
        PurchaseBackButton.gameObject.SetActive(true);
        GemsPanel.gameObject.SetActive(false);
        EnergyPanel.gameObject.SetActive(false);
        CoinsPanel.gameObject.SetActive(true);
        CoinTabButtonImg.color = Color.grey;
        GemTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
        EnergyTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
    }

    public void ActivateGemPurchase()
    {
        BuyConsumablesCanvas.gameObject.SetActive(true);
        PurchaseBackButton.gameObject.SetActive(true);
        CoinsPanel.gameObject.SetActive(false);
        EnergyPanel.gameObject.SetActive(false);
        GemsPanel.gameObject.SetActive(true);
        GemTabButtonImg.color = Color.grey;
        CoinTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
        EnergyTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
    }

    public void ActivateEnergyPurchase()
    {
        BuyConsumablesCanvas.gameObject.SetActive(true);
        PurchaseBackButton.gameObject.SetActive(true);
        GemsPanel.gameObject.SetActive(false);
        CoinsPanel.gameObject.SetActive(false);
        EnergyPanel.gameObject.SetActive(true);
        EnergyTabButtonImg.color = Color.grey;
        CoinTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
        GemTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
    }
    public void ActivateBasicPanel()
    {
        DailyRewardsCanvas.gameObject.SetActive(true);
        RewardsBackButton.gameObject.SetActive(true);
        BasicPanel.gameObject.SetActive(true);
        AchievementPanel.gameObject.SetActive(false);
        DailyTaskPanel.gameObject.SetActive(false);
        BasicTabButtonImg.color = Color.grey;
        AchievementTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
        DailyTaskTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
    }
    public void ActivateAchievementPanel()
    {
        DailyRewardsCanvas.gameObject.SetActive(true);
        RewardsBackButton.gameObject.SetActive(true);
        BasicPanel.gameObject.SetActive(false);
        AchievementPanel.gameObject.SetActive(true);
        DailyTaskPanel.gameObject.SetActive(false);
        AchievementTabButtonImg.color = Color.grey;
        BasicTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
        DailyTaskTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
    }
    public void ActivateDailyTaskPanel()
    {
        DailyRewardsCanvas.gameObject.SetActive(true);
        RewardsBackButton.gameObject.SetActive(true);
        BasicPanel.gameObject.SetActive(false);
        AchievementPanel.gameObject.SetActive(false);
        DailyTaskPanel.gameObject.SetActive(true);
        DailyTaskTabButtonImg.color = Color.grey;
        BasicTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
        AchievementTabButtonImg.color = new Color(0.8962f, 0.8328f, 0.8328f, 0.6666f);
    }
    public void BasicData()
    {
        MeleeKillsData = PlayerPrefs.GetInt("MeleeKills");
        MeleeKillsOutput.text = MeleeKillsData.ToString();
        TotalKilledData = PlayerPrefs.GetInt("TotalKilled");
        TotalKilledOutput.text = TotalKilledData.ToString();
        AssultKilledData = PlayerPrefs.GetInt("AssultKilled");
        AssultKilledOutput.text = AssultKilledData.ToString();
        SniperKilledData = PlayerPrefs.GetInt("SniperKilled");
        SniperKilledOuput.text = SniperKilledData.ToString();
        PistolKilledData = PlayerPrefs.GetInt("PistolKilled");
        PistolKilledOutput.text = PistolKilledData.ToString();
        HeadshotKilledData = PlayerPrefs.GetInt("HeadshotKilled");
        HeadshotKilledOutput.text = HeadshotKilledData.ToString();
        GrenadeKilledData = PlayerPrefs.GetInt("GrenadeKilled");
        GrenadeKilledOutput.text = GrenadeKilledData.ToString();
        MissionsCompletedData = PlayerPrefs.GetInt("MissionsCompleted");
        MissionsCompletedOutput.text = MissionsCompletedData.ToString();
        CoinsEarnedData = PlayerPrefs.GetInt("CoinsEarned");
        CoinsEarnedOutput.text = CoinsEarnedData.ToString();
        GemsEarnedData = PlayerPrefs.GetInt("GemsEarned");
        GemsEarnedOutput.text = GemsEarnedData.ToString();
        WeaponsOwnedData = PlayerPrefs.GetInt("WeaponsBought") + 3;
        WeaponsOwnedOutput.text = WeaponsOwnedData.ToString();
        WeaponsBoughtData = PlayerPrefs.GetInt("WeaponsBought");
        WeaponsBoughtOutput.text = WeaponsBoughtData.ToString();
    }
    public void AchievementData()
    {
        FiveHundredMeleeKills.value = PlayerPrefs.GetInt("500MeleeKills");
        Kill500Enemies.value = PlayerPrefs.GetInt("Kill500Enemies");
        CompleteChapter1.value = PlayerPrefs.GetInt("CompleteChapter1");
        CompleteChapter2.value = PlayerPrefs.GetInt("CompleteChapter2");
        CompleteChapter3.value = PlayerPrefs.GetInt("CompleteChapter3");
        CompleteChapter4.value = PlayerPrefs.GetInt("CompleteChapter4");
    }
    public void DailyTaskData()
    {
        TwentyHeadShots.value = PlayerPrefs.GetInt("20HeadShots");
        Complete5Missions.value = PlayerPrefs.GetInt("Complete5Missions");
        TenEnemyKills.value = PlayerPrefs.GetInt("10EnemyKills");
        UseConsumables5Times.value = PlayerPrefs.GetInt("UseConsumables5Times");
        Buy5000Coins.value = PlayerPrefs.GetInt("Buy5000Coins");
        Buy500Gems.value = PlayerPrefs.GetInt("Buy500Gems");
        CompleteAllDailyTask.value = PlayerPrefs.GetInt("CompleteAllDailyTask");
    }
    public void ActivateDailyRewards()
    {
        IsInDailyRewards = true;
        DailyRewardsPanel.gameObject.SetActive(true);
    }

    public void ExitDailyRewards()
    {
        IsInDailyRewards = false;
        DailyRewardsPanel.gameObject.SetActive(false);
    }

    public void OpenTutorialPanel()
    {
        IsInTutorialPanel = true;
        TutorialPanel.gameObject.SetActive(true);
        TutorialButton.gameObject.SetActive(false);
    }

    public void ExitTutorialPanel()
    {
        IsInTutorialPanel = false;
        TutorialPanel.gameObject.SetActive(false);
        TutorialButton.gameObject.SetActive(true);
    }

    public void OpenWeaponTutorialPanel()
    {
        IsInWeaponTutorialPanel = true;
        WeaponsTut.gameObject.SetActive(true);
        WeaponsTutButton.gameObject.SetActive(false);
        TutorialButton.gameObject.SetActive(false);
    }

    public void ExitWeaponTutorialPanel()
    {
        IsInWeaponTutorialPanel = false;
        WeaponsTut.gameObject.SetActive(false);
        WeaponsTutButton.gameObject.SetActive(true);
        TutorialButton.gameObject.SetActive(false);
    }

    public void UseGemForEnergy()
    {
        if (EnergyValue <= 50)
        {
            if (GemValue >= 20)
            {

                EnergyGemRefiller.interactable = false;
                IsTimerRunning = false;
                EnergyTimer.text = "";
                GemValue -= 20;
                UCFT += 1;
                PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
                UCFT = 0;
                PlayerPrefs.SetInt("GemValue", GemValue);
                EnergyValue = 100;
                PlayerPrefs.SetInt("EnergyValue", EnergyValue);
            }
            else if (GemValue < 20)
            {
                ActivateGemPurchase();
            }
        }
    }

    void EnergyDisplaytime(float EnergytimeToDisplay)
    {
        EnergytimeToDisplay += 1;
        float minutes = Mathf.FloorToInt(EnergytimeToDisplay / 60);
        float seconds = Mathf.FloorToInt(EnergytimeToDisplay % 60);
        EnergytimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private IEnumerator LoopTimer()
    {
        while (EnergytimerIsRunning == true)
        {
            yield return new WaitForSeconds(120.0f);
            if (EnergyValue < 100)
            {
                EnergyValue += 1;
                PlayerPrefs.SetInt("EnergyValue", EnergyValue);
            }
            EnergyDisplay.text = EnergyValue.ToString() + "/" + "100";
            yield return new WaitForSeconds(120.0f);
        }
    }

    private IEnumerator TimerNot()
    {
        EnergyTimer.text = "Filled";
        yield return new WaitForSeconds(0.5f);
        EnergyTimer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        EnergyTimer.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        EnergyTimer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        EnergyTimer.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        EnergyTimer.gameObject.SetActive(false);
    }

    public void FMKC()
    {
        PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + 10);
        PlayerPrefs.SetInt("FMKC", 1);
        FiveHundredMeleeKillsCollect.interactable = false;
        FiveHundredMeleeKillsCollectedText.text = "COLLECTED";
    }

    public void K5EC()
    {
        PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + 100);
        PlayerPrefs.SetInt("K5EC", 1);
        Kill500EnemiesCollect.interactable = false;
        Kill500EnemiesCollectedText.text = "COLLECTED";
    }

    public void CC1()
    {
        PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + 100);
        PlayerPrefs.SetInt("CC1", 1);
        CompleteChapter1Collect.interactable = false;
        CompleteChapter1CollectedText.text = "COLLECTED";
    }

    public void CC2()
    {
        PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + 100);
        PlayerPrefs.SetInt("CC2", 1);
        CompleteChapter2Collect.interactable = false;
        CompleteChapter2CollectedText.text = "COLLECTED";
    }

    public void CC3()
    {
        PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + 100);
        PlayerPrefs.SetInt("CC3", 1);
        CompleteChapter3Collect.interactable = false;
        CompleteChapter3CollectedText.text = "COLLECTED";
    }

    public void CC4()
    {
        PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + 100);
        PlayerPrefs.SetInt("CC4", 1);
        CompleteChapter4Collect.interactable = false;
        CompleteChapter4CollectedText.text = "COLLECTED";
    }

    public void THSC()
    {
        PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + 100);
        PlayerPrefs.SetInt("THSC", 1);
        TwentyHeadShotsCollect.interactable = false;
        TwentyHeadShotsCollectedText.text = "COLLECTED";
    }

    public void C5MC()
    {
        PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + 100);
        PlayerPrefs.SetInt("C5MC", 1);
        Complete5MissionsCollect.interactable = false;
        Complete5MissionsCollectedText.text = "COLLECTED";
    }

    public void TEKC()
    {
        PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + 100);
        PlayerPrefs.SetInt("TEKC", 1);
        TenEnemyKillsCollect.interactable = false;
        TenEnemyKillsCollectedText.text = "COLLECTED";
    }

    public void UC5TC()
    {
        PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + 100);
        PlayerPrefs.SetInt("UC5TC", 1);
        UseConsumables5TimesCollect.interactable = false;
        UseConsumables5TimesCollectedText.text = "COLLECTED";
    }

    public void B5CC()
    {
        PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + 5000);
        PlayerPrefs.SetInt("B5CC", 1);
        Buy5000CoinsCollect.interactable = false;
        Buy5000CoinsCollectedText.text = "COLLECTED";
    }

    public void B5GC()
    {
        PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + 100);
        PlayerPrefs.SetInt("B5GC", 1);
        Buy500GemsCollect.interactable = false;
        Buy5000GemsCollectedText.text = "COLLECTED";
    }

    public void CADTC()
    {
        PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + 400);
        PlayerPrefs.SetInt("CADTC", 1);
        CompleteAllDailyTaskCollect.interactable = false;
        CompleteAllDailyTaskCollectedText.text = "COLLECTED";
    }

    public void ChangeGraphics()
    {
        Change++;
        if (Change == 1)
        {
            PlayerPrefs.SetInt("Graphics", 1);
            QualitySettings.SetQualityLevel(0, true);
            GraphicsButtonText.text = "LOW";
        }
        else if (Change == 2)
        {
            PlayerPrefs.SetInt("Graphics", 2);
            QualitySettings.SetQualityLevel(3, true);
            GraphicsButtonText.text = "MEDIUM";
        }
        else if (Change == 3)
        {
            PlayerPrefs.SetInt("Graphics", 3);
            QualitySettings.SetQualityLevel(5, true);
            GraphicsButtonText.text = "HIGH";
            Change = 0;
        }
    }

    public void ShowControls()
    {
        ControlsSettingsPanel.gameObject.SetActive(true);
    }

    public void DisableControls()
    {
        ControlsSettingsPanel.gameObject.SetActive(false);
    }

    public void ResetDailyTask()
    {
        PlayerPrefs.SetInt("20HeadShots", 0);
        PlayerPrefs.SetInt("Complete5Missions", 0);
        PlayerPrefs.SetInt("10EnemyKills", 0);
        PlayerPrefs.SetInt("UseConsumables5Times", 0);
        PlayerPrefs.SetInt("Buy5000Coins", 0);
        PlayerPrefs.SetInt("Buy500Gems", 0);
        PlayerPrefs.SetInt("CompleteAllDailyTask", 0);

        PlayerPrefs.SetInt("THSC", 0);
        PlayerPrefs.SetInt("C5MC", 0);
        PlayerPrefs.SetInt("TEKC", 0);
        PlayerPrefs.SetInt("UC5TC", 0);
        PlayerPrefs.SetInt("B5CC", 0);
        PlayerPrefs.SetInt("B5GC", 0);
        PlayerPrefs.SetInt("CADTC", 0);

        PlayerPrefs.DeleteKey("AlreadyDidTHSNum");
        PlayerPrefs.DeleteKey("AlreadyDidC5MNum");
        PlayerPrefs.DeleteKey("AlreadyDidTEKNum");
        PlayerPrefs.DeleteKey("AlreadyDidUC5TNum");
        PlayerPrefs.DeleteKey("AlreadyDidB5CNum");
        PlayerPrefs.DeleteKey("AlreadyDidB5GNum");

        TwentyHeadShotsCollect.gameObject.SetActive(false);
        TwentyHeadShotsReward.gameObject.SetActive(true);
        Complete5MissionsCollect.gameObject.SetActive(false);
        Complete5MissionsReward.gameObject.SetActive(true);
        TenEnemyKillsCollect.gameObject.SetActive(false);
        TenEnemyKillsReward.gameObject.SetActive(true);
        UseConsumables5TimesCollect.gameObject.SetActive(false);
        UseConsumables5TimesReward.gameObject.SetActive(true);
        Buy5000CoinsCollect.gameObject.SetActive(false);
        Buy5000CoinsReward.gameObject.SetActive(true);
        Buy500GemsCollect.gameObject.SetActive(false);
        Buy500GemsReward.gameObject.SetActive(true);
        CompleteAllDailyTaskCollect.gameObject.SetActive(false);
        CompleteAllDailyTaskReward.gameObject.SetActive(true);
    }

    public void BuyGrenade()
    {
        if (CoinValue >= 150)
        {
            GrenadeBoughtData += 1;
            PlayerPrefs.SetInt("GrenadesOwned", PlayerPrefs.GetInt("GrenadesOwned") + GrenadeBoughtData);
            GrenadeBoughtData = 0;
            UCFT += 1;
            PlayerPrefs.SetInt("UseConsumables5Times", PlayerPrefs.GetInt("UseConsumables5Times") + UCFT);
            UCFT = 0;
            CoinValue -= 150;
            PlayerPrefs.SetInt("CoinValue", CoinValue);
        }
        else if (CoinValue < 150)
        {
            ActivateCoinPurchase();
        }
    }

    public void ClearEnergyTimerText()
    {
        EnergyTimer.text = "";
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

    void Update()
    {
        BasicData();
        AchievementData();
        DailyTaskData();

        if (STFN == true)
        {
            EnergyTimer.text = "Loading";
        }

        if (IsTimerRunning == true)
        {
            ulong diff = ((ulong)DateTime.Now.Ticks - lastEnergyFill);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
            float secondsLeft = (float)(msToWait - m) / 1000.0f;

            string r = "";

            r += ((int)secondsLeft / 3600).ToString() + "h ";
            secondsLeft -= ((int)secondsLeft / 3600) * 3600;

            r += ((int)secondsLeft / 60).ToString("00") + "m ";

            r += (secondsLeft % 60).ToString("00") + "s ";
            EnergyTimer.text = r;
            if (secondsLeft < 0)
            {

                ExitConsumablesPanel();
                EnergyValue = 100;
                PlayerPrefs.SetInt("EnergyValue", EnergyValue);
                StartCoroutine(TimerNot());
                IsTimerRunning = false;
            }

        }
        else if (IsTimerRunning == false)
        {
            lastEnergyFill = (ulong)DateTime.Now.Ticks;
            PlayerPrefs.SetString("LastEnergyFill", lastEnergyFill.ToString());

        }

        if (FiveHundredMeleeKills.value == 500)
        {
            FiveHundredMeleeKillsCollect.gameObject.SetActive(true);
            FiveHundredMeleeKillsReward.gameObject.SetActive(false);
        }
        if (Kill500Enemies.value == 500)
        {
            Kill500EnemiesCollect.gameObject.SetActive(true);
            Kill500EnemiesReward.gameObject.SetActive(false);
        }
        if (CompleteChapter1.value == 7)
        {
            CompleteChapter1Collect.gameObject.SetActive(true);
            CompleteChapter1Reward.gameObject.SetActive(false);
        }
        if (CompleteChapter2.value == 7)
        {
            CompleteChapter2Collect.gameObject.SetActive(true);
            CompleteChapter2Reward.gameObject.SetActive(false);
        }
        if (CompleteChapter3.value == 7)
        {
            CompleteChapter3Collect.gameObject.SetActive(true);
            CompleteChapter3Reward.gameObject.SetActive(false);
        }
        if (CompleteChapter4.value == 7)
        {
            CompleteChapter4Collect.gameObject.SetActive(true);
            CompleteChapter4Reward.gameObject.SetActive(false);
        }
        if (TwentyHeadShots.value == 20)
        {
            if (!PlayerPrefs.HasKey("AlreadyDidTHSNum"))
            {
                THSNum++;
                if (THSNum == 1)
                {
                    PlayerPrefs.SetInt("CompleteAllDailyTask", PlayerPrefs.GetInt("CompleteAllDailyTask") + 1);
                }
                PlayerPrefs.SetInt("AlreadyDidTHSNum", 1);
            }
            TwentyHeadShotsCollect.gameObject.SetActive(true);
            TwentyHeadShotsReward.gameObject.SetActive(false);
        }
        if (Complete5Missions.value == 5)
        {
            if (!PlayerPrefs.HasKey("AlreadyDidC5MNum"))
            {
                C5MNum++;
                if (C5MNum == 1)
                {
                    PlayerPrefs.SetInt("CompleteAllDailyTask", PlayerPrefs.GetInt("CompleteAllDailyTask") + 1);
                }
                PlayerPrefs.SetInt("AlreadyDidC5MNum", 1);
            }
            Complete5MissionsCollect.gameObject.SetActive(true);
            Complete5MissionsReward.gameObject.SetActive(false);
        }
        if (TenEnemyKills.value == 10)
        {
            if (!PlayerPrefs.HasKey("AlreadyDidTEKNum"))
            {
                TEKNum++;
                if (TEKNum == 1)
                {
                    PlayerPrefs.SetInt("CompleteAllDailyTask", PlayerPrefs.GetInt("CompleteAllDailyTask") + 1);
                }
                PlayerPrefs.SetInt("AlreadyDidTEKNum", 1);
            }
            TenEnemyKillsCollect.gameObject.SetActive(true);
            TenEnemyKillsReward.gameObject.SetActive(false);
        }
        if (UseConsumables5Times.value == 5)
        {
            if (!PlayerPrefs.HasKey("AlreadyDidUC5TNum"))
            {
                UC5TNum++;
                if (UC5TNum == 1)
                {
                    PlayerPrefs.SetInt("CompleteAllDailyTask", PlayerPrefs.GetInt("CompleteAllDailyTask") + 1);
                }
                PlayerPrefs.SetInt("AlreadyDidUC5TNum", 1);
            }
            UseConsumables5TimesCollect.gameObject.SetActive(true);
            UseConsumables5TimesReward.gameObject.SetActive(false);
        }
        if (Buy5000Coins.value == 5000)
        {
            if (!PlayerPrefs.HasKey("AlreadyDidB5CNum"))
            {
                B5CNum++;
                if (B5CNum == 1)
                {
                    PlayerPrefs.SetInt("CompleteAllDailyTask", PlayerPrefs.GetInt("CompleteAllDailyTask") + 1);
                }
                PlayerPrefs.SetInt("AlreadyDidB5CNum", 1);
            }
            Buy5000CoinsCollect.gameObject.SetActive(true);
            Buy5000CoinsReward.gameObject.SetActive(false);
        }
        if (Buy500Gems.value == 500)
        {
            if (!PlayerPrefs.HasKey("AlreadyDidB5GNum"))
            {
                B5GNum++;
                if (B5GNum == 1)
                {
                    PlayerPrefs.SetInt("CompleteAllDailyTask", PlayerPrefs.GetInt("CompleteAllDailyTask") + 1);
                }
                PlayerPrefs.SetInt("AlreadyDidB5GNum", 1);
            }
            Buy500GemsCollect.gameObject.SetActive(true);
            Buy500GemsReward.gameObject.SetActive(false);
        }
        if (CompleteAllDailyTask.value == 6)
        {
            CompleteAllDailyTaskCollect.gameObject.SetActive(true);
            CompleteAllDailyTaskReward.gameObject.SetActive(false);
        }

        EnergyValue = PlayerPrefs.GetInt("EnergyValue");
        if (EnergyValue > 100)
        {
            EnergyValue = 100;
            PlayerPrefs.SetInt("EnergyValue", EnergyValue);
        }

        if (EnergyValue <= 50)
        {
            EnergyGemRefiller.interactable = true;
        }
        else
        if (EnergyValue > 50)
        {
            EnergyGemRefiller.interactable = false;
        }
        CoinValue = PlayerPrefs.GetInt("CoinValue");
        GemValue = PlayerPrefs.GetInt("GemValue");

        GrenadeNo = PlayerPrefs.GetInt("GrenadesOwned");
        EnergyDisplay.text = EnergyValue.ToString() + "/" + "100";
        CoinDisplay.text = CoinValue.ToString();
        GemDisplay.text = GemValue.ToString();

        OwnedGrenadeText.text = GrenadeNo.ToString();
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                QuitGame();

            }
        }
    }
}
