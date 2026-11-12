using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mirror;

namespace Scenes.Mirror.Scripts
{
    public class MultiplayerEnemySpawnScript : NetworkBehaviour
    {
        [SerializeField] private GameObject EnemyPrefab = null;
        [SerializeField] private GameObject EnemyPrefab2 = null;
        [SerializeField] private GameObject EnemyPrefab3 = null;
        [SerializeField] private GameObject EnemyPrefab4 = null;
        [SerializeField] private GameObject EnemyPrefab5 = null;
        [SerializeField] private GameObject EnemyPrefab6 = null;
        public GameObject enemyInstance;
        public GameObject enemyInstance2;
        public GameObject enemyInstance3;
        public GameObject enemyInstance4;
        public GameObject enemyInstance5;
        public GameObject enemyInstance6;
        public GameObject enemyInstance7;
        public GameObject enemyInstance8;
        public GameObject enemyInstance9;
        public GameObject enemyInstance10;
        public GameObject enemyInstance11;
        public GameObject enemyInstance12;
        public GameObject enemyInstance13;
        public GameObject enemyInstance14;
        public GameObject enemyInstance15;
        public GameObject enemyInstance16;
        public GameObject enemyInstance17;
        public GameObject enemyInstance18;
        public GameObject enemyInstance19;
        public GameObject enemyInstance20;
        public PlayerControllers PC;
        public TimerScript TS;
        public AudioSource music;
        public AudioSource IntenseMusic;
        public GameObject MissionComplete;
        public GameObject GameCompleteGO;
        public GameObject RewardHolder;
        public GameObject BgUI2;
        public pausescript PS;
        public GameObject NM;
        public GameObject NGPGO;
        public MultiplayerNetworkGamePlayerLobby MNGPL;

        private static List<Transform> spawnPoints = new List<Transform>();
        private int nextIndex = 0;
        private ImmunocalypseNetworkManager room;

        public BoxCollider Mission1col;
        public BoxCollider OUTPOSTMission1col;
        public Animator HeliAnim;
        public AudioSource HeliAudio;

        public SphereCollider col;
        public SphereCollider col2;
        public SphereCollider col3;
        public SphereCollider col4;
        public SphereCollider col5;

        public AudioSource SoldierAllClearVoice;
        public PlayerHealth PH;

        public float SACVCall = 0f;
        public int TG;
        public int TC;

        public Text TGText;
        public Text TCText;

        public int MissionsCompletedData;
        public int GemValue;
        public int CoinValue;
        public bool MC = false;
        public MiniMapComponent MMC;
        public MiniMapComponent MMC2;
        public PlayerCompass2 PC2;
        public PlayerCompass2 OUTPOSTPC2;
        public WASDMovementScript WMS;
        public PlayerAiming PA;
        public FirstPersonControls FPC;
        public bool Allow = false;
        public typewriter2 TW2;
        public float Type = 0f;
        public GameObject PlayerGO;
        public GameObject[] EnemyGO;
        public GameObject[] TitanGO;
        public ThirdPersonUserControl TPUC;
        public GameObject[] Players;

        public bool DeathMatch;
        public bool StartPlayerCheck;
        public GameObject[] PlayerCounter;
        public int LMCalled;

        public AudioClip bgMusic;
        public AudioClip finaleMusic;

        void Awake()
        {

            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();

            }
            else if (SceneManager.GetActiveScene().buildIndex == 11)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 12)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 13)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 14)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 15)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 16)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 17)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 18)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 19)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 20)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 21)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 22)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 23)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 24)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 25)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 26)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 27)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 28)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 29)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 30)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 31)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 32)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }

        }

        void Start()
        {
            PlayerPrefs.SetInt("TempCoin", 0);
            PlayerPrefs.SetInt("TempGem", 0);

            CoinValue = PlayerPrefs.GetInt("CoinValue");
            GemValue = PlayerPrefs.GetInt("GemValue");

            StartCoroutine(WaitForIM());

            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();

            }
            else if (SceneManager.GetActiveScene().buildIndex == 11)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 12)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 13)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 14)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 15)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 16)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 17)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 18)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 19)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 20)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 21)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 22)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 23)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 24)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 25)
            {
                MMC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<MiniMapComponent>();
                OUTPOSTPC2 = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<PlayerCompass2>();

                MMC2.enabled = false;
                OUTPOSTPC2.enabled = false;
                OUTPOSTMission1col = GameObject.FindGameObjectWithTag("OUTPOST").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 26)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 27)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 28)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 29)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 30)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 31)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 32)
            {
                MMC = GameObject.FindGameObjectWithTag("HELI").GetComponent<MiniMapComponent>();

                PC2 = GameObject.FindGameObjectWithTag("HELI").GetComponent<PlayerCompass2>();
                HeliAnim = GameObject.FindGameObjectWithTag("HELI").GetComponent<Animator>();
                HeliAudio = GameObject.FindGameObjectWithTag("HeliAudio").GetComponent<AudioSource>();

                MMC.enabled = false;
                PC2.enabled = false;
                Mission1col = GameObject.FindGameObjectWithTag("HELI").GetComponent<BoxCollider>();
            }
            NGPGO = GameObject.FindGameObjectWithTag("NGP");
            MNGPL = NGPGO.GetComponent<MultiplayerNetworkGamePlayerLobby>();
            NM = GameObject.FindGameObjectWithTag("NM");

            music = GameObject.FindGameObjectWithTag("BGMusicGO").GetComponent<AudioSource>();
            MissionComplete = GameObject.FindGameObjectWithTag("MissionComplete");
            GameCompleteGO = GameObject.FindGameObjectWithTag("Finish");
            BgUI2 = GameObject.FindGameObjectWithTag("BGCanvas2");
            RewardHolder = GameObject.FindGameObjectWithTag("RH");
            TGText = GameObject.FindGameObjectWithTag("TG").GetComponent<Text>();
            TCText = GameObject.FindGameObjectWithTag("TC").GetComponent<Text>();
            RewardHolder.gameObject.SetActive(false);
            MissionComplete.gameObject.SetActive(false);
            GameCompleteGO.gameObject.SetActive(false);
            room = NM.GetComponent<ImmunocalypseNetworkManager>();
            music.clip = bgMusic;
        }

        public override void OnStartAuthority()
        {

        }

        public IEnumerator WaitForIM()
        {
            if (PlayerPrefs.HasKey("CurrentLevel"))
            {
                yield return new WaitForSeconds(5.0f);
            }
            else if (!PlayerPrefs.HasKey("CurrentLevel"))
            {
                yield return new WaitForSeconds(2.0f);
            }
            Players = GameObject.FindGameObjectsWithTag("Player");
            PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllers>();
            PH = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

            PS = GameObject.FindGameObjectWithTag("Player").GetComponent<pausescript>();
            IntenseMusic = GameObject.FindGameObjectWithTag("IMGO").GetComponent<AudioSource>();
            WMS = GameObject.FindGameObjectWithTag("Player").GetComponent<WASDMovementScript>();
            PA = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAiming>();
            FPC = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonControls>();
            TW2 = GameObject.FindGameObjectWithTag("Player").GetComponent<typewriter2>();
            TPUC = GameObject.FindGameObjectWithTag("Player").GetComponent<ThirdPersonUserControl>();

            BgUI2.gameObject.SetActive(false);
            PS.Locked = false;
            foreach (GameObject PlayerGM in Players)
            {
                PlayerGM.GetComponent<GunManager>().FirstLoad();
                StartPlayerCheck = true;
            }
            if (!PlayerPrefs.HasKey("CurrentLevel"))
            {

            }
            else if (SceneManager.GetActiveScene().buildIndex == 3)
            {

            }
            else if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                PH.RemoveGUIS();
                TW2.PS6();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 5)
            {

            }
            else if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                PH.RemoveGUIS();
                TW2.PS10();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                PH.RemoveGUIS();
                TW2.PS12();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                PH.RemoveGUIS();
                TW2.PS14();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                PH.RemoveGUIS();
                TW2.PS16();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                PH.RemoveGUIS();
                TW2.PS18();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 11)
            {
                PH.RemoveGUIS();
                TW2.PS20();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 12)
            {
                PH.RemoveGUIS();
                TW2.PS22();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 13)
            {
                PH.RemoveGUIS();
                TW2.PS24();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 14)
            {
                PH.RemoveGUIS();
                TW2.PS26();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 15)
            {
                PH.RemoveGUIS();
                TW2.PS28();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 16)
            {
                PH.RemoveGUIS();
                TW2.PS30();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 17)
            {
                PH.RemoveGUIS();
                TW2.PS32();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 18)
            {
                PH.RemoveGUIS();
                TW2.PS34();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 19)
            {
                PH.RemoveGUIS();
                TW2.PS36();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 20)
            {
                PH.RemoveGUIS();
                TW2.PS38();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 21)
            {
                PH.RemoveGUIS();
                TW2.PS40();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 22)
            {
                PH.RemoveGUIS();
                TW2.PS42();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 23)
            {
                PH.RemoveGUIS();
                TW2.PS44();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 24)
            {
                PH.RemoveGUIS();
                TW2.PS46();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 25)
            {
                PH.RemoveGUIS();
                TW2.PS48();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 26)
            {
                PH.RemoveGUIS();
                TW2.PS50();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 27)
            {
                PH.RemoveGUIS();
                TW2.PS52();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 28)
            {
                PH.RemoveGUIS();
                TW2.PS54();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 29)
            {
                PH.RemoveGUIS();
                TW2.PS56();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 30)
            {
                PH.RemoveGUIS();
                TW2.PS58();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 31)
            {

            }
            else if (SceneManager.GetActiveScene().buildIndex == 32)
            {

            }
            Allow = true;
        }

        public static void AddSpawnPoint(Transform transform)
        {
            spawnPoints.Add(transform);
            spawnPoints = spawnPoints.OrderBy(x => x.GetSiblingIndex()).ToList();
        }

        [ServerCallback]
        private void OnDestroy() => ImmunocalypseNetworkManager.OnServerReadied -= SpawnEnemy;

        [Server]
        public void SpawnEnemy(NetworkConnection conn)
        {
            Transform spawnPoint = spawnPoints.ElementAtOrDefault(nextIndex);
            if (spawnPoint == null)
            {
                Debug.LogError($"Missing spawn point for Enemy {nextIndex}");
                return;
            }

            if (!PlayerPrefs.HasKey("CurrentLevel"))
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }

            if (PlayerPrefs.GetInt("CurrentLevel") == 3)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab2, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab3, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab2, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab3, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab3, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab3, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 7)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab3, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab3, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab3, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab4, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 8)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab3, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab3, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab3, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab4, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab4, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 9)
            {
                enemyInstance = Instantiate(EnemyPrefab3, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab3, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab4, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab4, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 10)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 11)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 12)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 13)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 14)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 15)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 16)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 17)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 18)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 19)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 20)
            {
                enemyInstance = Instantiate(EnemyPrefab, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 21)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 22)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, spawnPoints[5].position, spawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab, spawnPoints[6].position, spawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab, spawnPoints[7].position, spawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab, spawnPoints[8].position, spawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 23)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 24)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 25)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 26)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 27)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 28)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 29)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 30)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 31)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 32)
            {
                enemyInstance = Instantiate(EnemyPrefab2, spawnPoints[1].position, spawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, spawnPoints[2].position, spawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, spawnPoints[3].position, spawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, spawnPoints[4].position, spawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }

        }
        void Update()
        {
            PlayerCounter = GameObject.FindGameObjectsWithTag("PC");
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
            if (Players.Length >= 2)
            {
                DeathMatch = true;
                if (EnemyGO.Length != 0)
                {
                    foreach (GameObject EnemyGM in EnemyGO)
                    {
                        Destroy(EnemyGM);
                    }
                }
                foreach (GameObject PlayerGM in Players)
                {
                    PlayerGM.GetComponent<GunManager>().DeathMatch = true;
                }
            }

            if (DeathMatch == true)
            {
                if (PlayerCounter.Length == 1)
                {
                    foreach (GameObject PlayerGM in Players)
                    {
                        if (StartPlayerCheck == true)
                        {
                            PlayerGM.GetComponent<GunManager>().DisplayDeathMatchCompleteDisplay();
                        }
                    }
                }

            }

            if (PH.RGame == true)
            {

                if (!NetworkClient.isConnected && !NetworkServer.active && !NetworkClient.active)
                {
                    NetworkManager.singleton.ServerChangeScene("ImmunocalypseGameLobbyScene");
                }
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

            if (DeathMatch == false)
            {
                if (EnemyGO.Length == 0)
                {
                    if (isServer)
                    {
                        room.OnStopServer();

                        IntenseMusic.Stop();
                        SACVCall += 1.0f;
                        if (SACVCall == 1.0f)
                        {
                            PH.SACV();
                        }
                        PlayerPrefs.SetInt("MissionComplete1", 1);

                        if (!PlayerPrefs.HasKey("CurrentLevel"))
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS5();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 3)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS5();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 4)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS7();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 5)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS9();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 6)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS11();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 7)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS13();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 8)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS15();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 9)
                        {
                            MMC2.enabled = true;
                            OUTPOSTPC2.enabled = true;
                            OUTPOSTMission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                TW2.PS17();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 10)
                        {
                            MMC2.enabled = true;
                            OUTPOSTPC2.enabled = true;
                            OUTPOSTMission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                TW2.PS19();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 11)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS21();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 12)
                        {
                            MMC2.enabled = true;
                            OUTPOSTPC2.enabled = true;
                            OUTPOSTMission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                TW2.PS23();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 13)
                        {
                            MMC2.enabled = true;
                            OUTPOSTPC2.enabled = true;
                            OUTPOSTMission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                TW2.PS25();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 14)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS27();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 15)
                        {
                            MMC2.enabled = true;
                            OUTPOSTPC2.enabled = true;
                            OUTPOSTMission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                TW2.PS29();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 16)
                        {
                            MMC2.enabled = true;
                            OUTPOSTPC2.enabled = true;
                            OUTPOSTMission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                TW2.PS31();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 17)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS33();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 18)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS35();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 19)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS37();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 20)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS39();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 21)
                        {
                            MMC2.enabled = true;
                            OUTPOSTPC2.enabled = true;
                            OUTPOSTMission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                TW2.PS41();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 22)
                        {
                            MMC2.enabled = true;
                            OUTPOSTPC2.enabled = true;
                            OUTPOSTMission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                TW2.PS43();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 23)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS45();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 24)
                        {
                            MMC2.enabled = true;
                            OUTPOSTPC2.enabled = true;
                            OUTPOSTMission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                TW2.PS47();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 25)
                        {
                            MMC2.enabled = true;
                            OUTPOSTPC2.enabled = true;
                            OUTPOSTMission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                TW2.PS49();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 26)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS51();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 27)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS53();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 28)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS55();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 29)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS57();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();
                                TW2.PS73();
                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 31)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();

                            }
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 32)
                        {
                            MMC.enabled = true;
                            PC2.enabled = true;
                            HeliAnim.enabled = true;
                            Mission1col.enabled = true;
                            Type += 1.0f;
                            if (Type == 1.0f)
                            {
                                HeliAudio.Play();

                            }
                        }

                        if (MC == true)
                        {

                        }
                    }
                }
            }
        }

        public void LM()
        {
            LMCalled++;
            if (LMCalled == 1)
            {
                PS.MissionEnded = true;
                PS.Locked = true;

                if (!PlayerPrefs.HasKey("GameComplete"))
                {
                    MissionsCompletedData += 1;
                    PlayerPrefs.SetInt("MissionsCompleted", PlayerPrefs.GetInt("MissionsCompleted") + MissionsCompletedData);
                    PlayerPrefs.SetInt("Complete5Missions", PlayerPrefs.GetInt("Complete5Missions") + MissionsCompletedData);
                    if (SceneManager.GetActiveScene().buildIndex == 3)
                    {
                        PlayerPrefs.SetInt("CompleteChapter1", PlayerPrefs.GetInt("CompleteChapter1") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 4)
                    {
                        PlayerPrefs.SetInt("CompleteChapter1", PlayerPrefs.GetInt("CompleteChapter1") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 5)
                    {
                        PlayerPrefs.SetInt("CompleteChapter1", PlayerPrefs.GetInt("CompleteChapter1") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 6)
                    {
                        PlayerPrefs.SetInt("CompleteChapter1", PlayerPrefs.GetInt("CompleteChapter1") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 7)
                    {
                        PlayerPrefs.SetInt("CompleteChapter1", PlayerPrefs.GetInt("CompleteChapter1") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 8)
                    {
                        PlayerPrefs.SetInt("CompleteChapter1", PlayerPrefs.GetInt("CompleteChapter1") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 9)
                    {
                        PlayerPrefs.SetInt("CompleteChapter1", PlayerPrefs.GetInt("CompleteChapter1") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 10)
                    {
                        PlayerPrefs.SetInt("CompleteChapter2", PlayerPrefs.GetInt("CompleteChapter2") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 11)
                    {
                        PlayerPrefs.SetInt("CompleteChapter2", PlayerPrefs.GetInt("CompleteChapter2") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 12)
                    {
                        PlayerPrefs.SetInt("CompleteChapter2", PlayerPrefs.GetInt("CompleteChapter2") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 13)
                    {
                        PlayerPrefs.SetInt("CompleteChapter2", PlayerPrefs.GetInt("CompleteChapter2") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 14)
                    {
                        PlayerPrefs.SetInt("CompleteChapter2", PlayerPrefs.GetInt("CompleteChapter2") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 15)
                    {
                        PlayerPrefs.SetInt("CompleteChapter2", PlayerPrefs.GetInt("CompleteChapter2") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 16)
                    {
                        PlayerPrefs.SetInt("CompleteChapter2", PlayerPrefs.GetInt("CompleteChapter2") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 17)
                    {
                        PlayerPrefs.SetInt("CompleteChapter3", PlayerPrefs.GetInt("CompleteChapter3") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 18)
                    {
                        PlayerPrefs.SetInt("CompleteChapter3", PlayerPrefs.GetInt("CompleteChapter3") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 19)
                    {
                        PlayerPrefs.SetInt("CompleteChapter3", PlayerPrefs.GetInt("CompleteChapter3") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 20)
                    {
                        PlayerPrefs.SetInt("CompleteChapter3", PlayerPrefs.GetInt("CompleteChapter3") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 21)
                    {
                        PlayerPrefs.SetInt("CompleteChapter3", PlayerPrefs.GetInt("CompleteChapter3") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 22)
                    {
                        PlayerPrefs.SetInt("CompleteChapter3", PlayerPrefs.GetInt("CompleteChapter3") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 23)
                    {
                        PlayerPrefs.SetInt("CompleteChapter3", PlayerPrefs.GetInt("CompleteChapter3") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 24)
                    {
                        PlayerPrefs.SetInt("CompleteChapter4", PlayerPrefs.GetInt("CompleteChapter4") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 25)
                    {
                        PlayerPrefs.SetInt("CompleteChapter4", PlayerPrefs.GetInt("CompleteChapter4") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 26)
                    {
                        PlayerPrefs.SetInt("CompleteChapter4", PlayerPrefs.GetInt("CompleteChapter4") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 27)
                    {
                        PlayerPrefs.SetInt("CompleteChapter4", PlayerPrefs.GetInt("CompleteChapter4") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 28)
                    {
                        PlayerPrefs.SetInt("CompleteChapter4", PlayerPrefs.GetInt("CompleteChapter4") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 29)
                    {
                        PlayerPrefs.SetInt("CompleteChapter4", PlayerPrefs.GetInt("CompleteChapter4") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 30)
                    {
                        PlayerPrefs.SetInt("CompleteChapter4", PlayerPrefs.GetInt("CompleteChapter4") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 31)
                    {
                        PlayerPrefs.SetInt("CompleteChapter4", PlayerPrefs.GetInt("CompleteChapter4") + MissionsCompletedData);
                    }
                    else if (SceneManager.GetActiveScene().buildIndex == 32)
                    {
                        PlayerPrefs.SetInt("CompleteChapter4", PlayerPrefs.GetInt("CompleteChapter4") + MissionsCompletedData);
                    }
                }
                if (PlayerPrefs.GetInt("CurrentLevel") == 30)
                {
                    if (!PlayerPrefs.HasKey("GameComplete"))
                    {
                        music.clip = finaleMusic;
                        PlayerPrefs.SetInt("GameComplete", 1);
                        StartCoroutine(End());
                    }
                    else if (PlayerPrefs.GetInt("GameComplete") == 1)
                    {
                        PlayerPrefs.SetInt("TempCoin", PlayerPrefs.GetInt("TempCoin") + 500);
                        MissionComplete.gameObject.SetActive(true);
                        StartCoroutine(LoadMission());
                    }
                }
                else
                {
                    PlayerPrefs.SetInt("CurrentLevel", SceneManager.GetActiveScene().buildIndex + 1);
                    MissionComplete.gameObject.SetActive(true);
                    StartCoroutine(LoadMission());
                }
                music.Play();
                PS.MC();
            }
        }

        public void Collect()
        {
            PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + PlayerPrefs.GetInt("TempGem") + 2);
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + PlayerPrefs.GetInt("TempCoin") + 10);
            MC = true;
            PlayerPrefs.SetInt("GemsEarned", PlayerPrefs.GetInt("GemsEarned") + 2);
            PlayerPrefs.SetInt("CoinsEarned", PlayerPrefs.GetInt("CoinsEarned") + 10);
            if (DeathMatch == false)
            {
                NetworkManager.singleton.ServerChangeScene("MissionsScene");
            }
            else
            {
                NetworkManager.singleton.ServerChangeScene("ImmunocalypseGameLobbyScene");
            }
            if (NetworkServer.active && NetworkClient.isConnected)
            {
                NetworkManager.singleton.StopHost();
                Destroy(NM);
            }

            else if (NetworkClient.isConnected)
            {
                NetworkManager.singleton.StopClient();
                Destroy(NM);
            }

            else if (NetworkServer.active)
            {
                NetworkManager.singleton.StopServer();
                Destroy(NM);
            }
        }

        IEnumerator LoadMission()
        {
            yield return new WaitForSeconds(2f);
            RewardHolder.gameObject.SetActive(true);
            TGText.text = PlayerPrefs.GetInt("TempGem").ToString();
            TCText.text = PlayerPrefs.GetInt("TempCoin").ToString();

        }

        public IEnumerator End()
        {
            PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + PlayerPrefs.GetInt("TempGem") + 1000);
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + PlayerPrefs.GetInt("TempCoin") + 5000);
            PlayerPrefs.SetInt("GemsEarned", PlayerPrefs.GetInt("GemsEarned") + 1000);
            PlayerPrefs.SetInt("CoinsEarned", PlayerPrefs.GetInt("CoinsEarned") + 5000);
            GameCompleteGO.gameObject.SetActive(true);
            yield return new WaitForSeconds(30.0f);
            NetworkManager.singleton.ServerChangeScene("MissionsScene");
            if (NetworkServer.active && NetworkClient.isConnected)
            {
                NetworkManager.singleton.StopHost();
                Destroy(NM);
            }

            else if (NetworkClient.isConnected)
            {
                NetworkManager.singleton.StopClient();
                Destroy(NM);
            }

            else if (NetworkServer.active)
            {
                NetworkManager.singleton.StopServer();
                Destroy(NM);
            }
        }

    }
}
