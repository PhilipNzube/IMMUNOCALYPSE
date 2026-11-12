using Mirror;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.Mirror.Scripts
{
    public class ImmunocalypseNetworkManager : NetworkManager
    {
        [SerializeField] private int minPlayers = 2;
        [Scene][SerializeField] private string menuScene = string.Empty;
        [Header("Room")]
        [SerializeField] private MultiplayerNetworkRoomPlayerLobby roomPlayerPrefab = null;

        [Header("Game")]
        [SerializeField] private MultiplayerNetworkGamePlayerLobby gamePlayerPrefab = null;
        [SerializeField] private GameObject playerSpawnSystem = null;
        [SerializeField] private GameObject enemySpawnSystem = null;
        [SerializeField] private GameObject weaponSpawnSystem = null;
        [SerializeField] private GameObject playerPrefab = null;
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

        public GameObject BgUI;
        public GameObject PlayerGO;
        public PlayerHealth PH;

        public static event Action OnClientConnected;
        public static event Action OnClientDisconnected;
        public static event Action<NetworkConnection> OnServerReadied;

        public List<MultiplayerNetworkRoomPlayerLobby> RoomPlayers { get; } = new List<MultiplayerNetworkRoomPlayerLobby>();

        public List<MultiplayerNetworkGamePlayerLobby> GamePlayers { get; } = new List<MultiplayerNetworkGamePlayerLobby>();

        public bool Loaded = false;

        private static List<Transform> spawnPoints = new List<Transform>();
        private int nextIndex = 0;
        public bool IAMTHEHOST;
        public bool DeathMatch;

        public GameObject ESS;
        public MultiplayerEnemySpawnScript MESS;
        public GameObject InstructionUI;

        public static void AddSpawnPoint(Transform transform)
        {
            spawnPoints.Add(transform);
            spawnPoints = spawnPoints.OrderBy(x => x.GetSiblingIndex()).ToList();
        }
        public static void RemoveSpawnPoint(Transform transform) => spawnPoints.Remove(transform);

        private static List<Transform> EnemyspawnPoints = new List<Transform>();
        private int EnemynextIndex = 0;

        public static void AddEnemySpawnPoint(Transform transform)
        {
            EnemyspawnPoints.Add(transform);
            EnemyspawnPoints = EnemyspawnPoints.OrderBy(x => x.GetSiblingIndex()).ToList();
        }
        public static void RemoveEnemySpawnPoint(Transform transform) => EnemyspawnPoints.Remove(transform);

        void Start()
        {

            BgUI.gameObject.SetActive(false);
        }

        void Update()
        {
            if (MESS == null)
            {
                ESS = GameObject.FindGameObjectWithTag("ESS");
                MESS = ESS.GetComponent<MultiplayerEnemySpawnScript>();
            }
            else
            if (MESS != null)
            {
                if (MESS.DeathMatch == true)
                {
                    DeathMatch = true;
                }
            }
        }

        public override void OnStartServer() => spawnPrefabs = Resources.LoadAll<GameObject>("SpawnablePrefabs").ToList();

        public override void OnStartClient()
        {
            var spawnablePrefabs = Resources.LoadAll<GameObject>("SpawnablePrefabs");
            foreach (var prefab in spawnablePrefabs)
            {
                NetworkClient.RegisterPrefab(prefab);
            }
        }
        public override void OnClientConnect(NetworkConnection conn)
        {
            base.OnClientConnect(conn);
            OnClientConnected?.Invoke();
        }
        public override void OnClientDisconnect(NetworkConnection conn)
        {
            if (DeathMatch == true)
            {
                NetworkManager.singleton.ServerChangeScene("ImmunocalypseGameLobbyScene");
            }
            Destroy(this.gameObject);
            if (conn.identity != null)
            {
                var player = conn.identity.GetComponent<MultiplayerNetworkRoomPlayerLobby>();
                RoomPlayers.Remove(player);
                NotifyPlayersOfReadyState();
            }
            base.OnClientDisconnect(conn);
            OnClientDisconnected?.Invoke();
        }
        public override void OnServerConnect(NetworkConnectionToClient conn)
        {
            if (numPlayers >= maxConnections)
            {
                conn.Disconnect();
                return;
            }
            if (SceneManager.GetActiveScene().name != "ImmunocalypseGameLobbyScene")
            {

                conn.Disconnect();
                return;

            }
        }
        public override void OnServerAddPlayer(NetworkConnectionToClient conn)
        {
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                bool isLeader = RoomPlayers.Count == 0;
                MultiplayerNetworkRoomPlayerLobby roomPlayerInstance = Instantiate(roomPlayerPrefab);
                roomPlayerInstance.IsLeader = isLeader;
                NetworkServer.AddPlayerForConnection(conn, roomPlayerInstance.gameObject);
            }
            else if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene2")
            {
                bool isLeader = RoomPlayers.Count == 0;
                MultiplayerNetworkRoomPlayerLobby roomPlayerInstance = Instantiate(roomPlayerPrefab);
                roomPlayerInstance.IsLeader = isLeader;
                NetworkServer.AddPlayerForConnection(conn, roomPlayerInstance.gameObject);
            }
        }

        public override void OnServerDisconnect(NetworkConnectionToClient conn)
        {
            if (conn.identity != null)
            {
                var player = conn.identity.GetComponent<MultiplayerNetworkRoomPlayerLobby>();
                RoomPlayers.Remove(player);

                NotifyPlayersOfReadyState();
            }
            base.OnServerDisconnect(conn);
        }
        public override void OnStopServer()
        {
            RoomPlayers.Clear();
            GamePlayers.Clear();

        }
        public void NotifyPlayersOfReadyState()
        {
            foreach (var player in RoomPlayers)
            {
                player.HandleReadyToStart(IsReadyToStart());
            }
        }
        private bool IsReadyToStart()
        {
            if (numPlayers < minPlayers) { return false; }
            foreach (var player in RoomPlayers)
            {
                if (!player.IsReady)
                {
                    return false;
                }
            }
            return true;
        }

        public void removelobby()
        {

        }

        public void CloseInstructionUI()
        {
            InstructionUI.gameObject.SetActive(false);
        }

        public void StartGame()
        {

            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                if (IsReadyToStart())
                {
                    BgUI.gameObject.SetActive(true);
                    if (!PlayerPrefs.HasKey("CurrentLevel"))
                    {
                        ServerChangeScene("Immunocalypse1");
                    }

                    if (PlayerPrefs.GetInt("CurrentLevel") == 3)
                    {
                        ServerChangeScene("Immunocalypse1");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
                    {
                        ServerChangeScene("Immunocalypse2");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
                    {
                        ServerChangeScene("Immunocalypse3");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
                    {
                        ServerChangeScene("Immunocalypse4");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 7)
                    {
                        ServerChangeScene("Immunocalypse5");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 8)
                    {
                        ServerChangeScene("Immunocalypse6");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 9)
                    {
                        ServerChangeScene("Immunocalypse7");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 10)
                    {
                        ServerChangeScene("Immunocalypse8");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 11)
                    {
                        ServerChangeScene("Immunocalypse9");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 12)
                    {
                        ServerChangeScene("Immunocalypse10");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 13)
                    {
                        ServerChangeScene("Immunocalypse11");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 14)
                    {
                        ServerChangeScene("Immunocalypse12");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 15)
                    {
                        ServerChangeScene("Immunocalypse13");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 16)
                    {
                        ServerChangeScene("Immunocalypse14");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 17)
                    {
                        ServerChangeScene("Immunocalypse15");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 18)
                    {
                        ServerChangeScene("Immunocalypse16");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 19)
                    {
                        ServerChangeScene("Immunocalypse17");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 20)
                    {
                        ServerChangeScene("Immunocalypse18");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 21)
                    {
                        ServerChangeScene("Immunocalypse19");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 22)
                    {
                        ServerChangeScene("Immunocalypse20");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 23)
                    {
                        ServerChangeScene("Immunocalypse21");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 24)
                    {
                        ServerChangeScene("Immunocalypse22");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 25)
                    {
                        ServerChangeScene("Immunocalypse23");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 26)
                    {
                        ServerChangeScene("Immunocalypse24");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 27)
                    {
                        ServerChangeScene("Immunocalypse25");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 28)
                    {
                        ServerChangeScene("Immunocalypse26");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 29)
                    {
                        ServerChangeScene("Immunocalypse27");
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 30)
                    {
                        ServerChangeScene("Immunocalypse28");
                    }
                }
                else
                {
                    InstructionUI.gameObject.SetActive(true);
                }
            }
        }

        public override void ServerChangeScene(string newSceneName)
        {

            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene" && newSceneName.Contains("Immunocalypse"))
            {
                for (int i = RoomPlayers.Count - 1; i >= 0; i--)
                {
                    var conn = RoomPlayers[i].connectionToClient;
                    var gameplayerInstance = Instantiate(gamePlayerPrefab);
                    gameplayerInstance.SetDisplayName(RoomPlayers[i].DisplayName);

                    NetworkServer.ReplacePlayerForConnection(conn, gameplayerInstance.gameObject, true);

                }
            }
            else if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene2" && newSceneName.Contains("Immunocalypse"))
            {
                for (int i = RoomPlayers.Count - 1; i >= 0; i--)
                {
                    var conn = RoomPlayers[i].connectionToClient;
                    var gameplayerInstance = Instantiate(gamePlayerPrefab);
                    gameplayerInstance.SetDisplayName(RoomPlayers[i].DisplayName);

                    NetworkServer.ReplacePlayerForConnection(conn, gameplayerInstance.gameObject, true);

                }
            }

            base.ServerChangeScene(newSceneName);
        }

        public override void OnServerSceneChanged(string sceneName)
        {
            if (sceneName.Contains("Immunocalypse"))
            {

                GameObject enemySpawnSystemInstance = Instantiate(enemySpawnSystem);

                NetworkServer.Spawn(enemySpawnSystemInstance);

            }
        }

        public override void OnClientSceneChanged(NetworkConnection conn)
        {

            if (!NetworkClient.ready)
            {

            }

            base.OnClientSceneChanged(conn);
        }

        public void SpawnEnemy(NetworkConnection conn)
        {
            Transform EnemyspawnPoint = EnemyspawnPoints.ElementAtOrDefault(EnemynextIndex);
            if (EnemyspawnPoint == null)
            {
                Debug.LogError($"Missing spawn point for Enemy {EnemynextIndex}");
                return;
            }

            if (!PlayerPrefs.HasKey("CurrentLevel"))
            {
                enemyInstance = Instantiate(EnemyPrefab, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }

            if (PlayerPrefs.GetInt("CurrentLevel") == 3)
            {
                enemyInstance = Instantiate(EnemyPrefab, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
            {
                enemyInstance = Instantiate(EnemyPrefab, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab2, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
            {
                enemyInstance = Instantiate(EnemyPrefab, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
            {
                enemyInstance = Instantiate(EnemyPrefab, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab2, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 7)
            {
                enemyInstance = Instantiate(EnemyPrefab, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab2, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 8)
            {
                enemyInstance = Instantiate(EnemyPrefab, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab2, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 9)
            {
                enemyInstance = Instantiate(EnemyPrefab3, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab3, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab3, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab3, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab3, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab3, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab3, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 10)
            {
                enemyInstance = Instantiate(EnemyPrefab3, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab3, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab3, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab3, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 11)
            {
                enemyInstance = Instantiate(EnemyPrefab2, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 12)
            {
                enemyInstance = Instantiate(EnemyPrefab3, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab3, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab3, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab3, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab3, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab3, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab3, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 13)
            {
                enemyInstance = Instantiate(EnemyPrefab3, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab3, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab3, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab3, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 14)
            {
                enemyInstance = Instantiate(EnemyPrefab2, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 15)
            {
                enemyInstance = Instantiate(EnemyPrefab3, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab3, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab3, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab3, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab3, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab3, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab3, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 16)
            {
                enemyInstance = Instantiate(EnemyPrefab3, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab3, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab3, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab3, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab3, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab3, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab3, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 17)
            {
                enemyInstance = Instantiate(EnemyPrefab2, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 18)
            {
                enemyInstance = Instantiate(EnemyPrefab2, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 19)
            {
                enemyInstance = Instantiate(EnemyPrefab2, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 20)
            {
                enemyInstance = Instantiate(EnemyPrefab2, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 21)
            {
                enemyInstance = Instantiate(EnemyPrefab3, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab3, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab3, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab3, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab3, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab3, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab3, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 22)
            {
                enemyInstance = Instantiate(EnemyPrefab3, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab3, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab3, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab3, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab3, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab3, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab3, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab3, EnemyspawnPoints[8].position, EnemyspawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);

                enemyInstance9 = Instantiate(EnemyPrefab3, EnemyspawnPoints[9].position, EnemyspawnPoints[9].rotation);
                NetworkServer.Spawn(enemyInstance9, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 23)
            {
                enemyInstance = Instantiate(EnemyPrefab2, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab2, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 24)
            {
                enemyInstance = Instantiate(EnemyPrefab2, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab3, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab3, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 25)
            {
                enemyInstance = Instantiate(EnemyPrefab3, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab3, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab3, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab3, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 26)
            {
                enemyInstance = Instantiate(EnemyPrefab, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab2, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab3, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab3, EnemyspawnPoints[8].position, EnemyspawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);

                enemyInstance9 = Instantiate(EnemyPrefab3, EnemyspawnPoints[9].position, EnemyspawnPoints[9].rotation);
                NetworkServer.Spawn(enemyInstance9, conn);

                enemyInstance10 = Instantiate(EnemyPrefab3, EnemyspawnPoints[10].position, EnemyspawnPoints[10].rotation);
                NetworkServer.Spawn(enemyInstance10, conn);

                enemyInstance11 = Instantiate(EnemyPrefab3, EnemyspawnPoints[11].position, EnemyspawnPoints[11].rotation);
                NetworkServer.Spawn(enemyInstance11, conn);

                enemyInstance12 = Instantiate(EnemyPrefab3, EnemyspawnPoints[12].position, EnemyspawnPoints[12].rotation);
                NetworkServer.Spawn(enemyInstance12, conn);

                enemyInstance13 = Instantiate(EnemyPrefab3, EnemyspawnPoints[13].position, EnemyspawnPoints[13].rotation);
                NetworkServer.Spawn(enemyInstance13, conn);

                enemyInstance14 = Instantiate(EnemyPrefab3, EnemyspawnPoints[14].position, EnemyspawnPoints[14].rotation);
                NetworkServer.Spawn(enemyInstance14, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 27)
            {
                enemyInstance = Instantiate(EnemyPrefab4, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab4, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab4, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab4, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab4, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab4, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab4, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab4, EnemyspawnPoints[8].position, EnemyspawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);

                enemyInstance9 = Instantiate(EnemyPrefab4, EnemyspawnPoints[9].position, EnemyspawnPoints[9].rotation);
                NetworkServer.Spawn(enemyInstance9, conn);

                enemyInstance10 = Instantiate(EnemyPrefab4, EnemyspawnPoints[10].position, EnemyspawnPoints[10].rotation);
                NetworkServer.Spawn(enemyInstance10, conn);

                enemyInstance11 = Instantiate(EnemyPrefab4, EnemyspawnPoints[11].position, EnemyspawnPoints[11].rotation);
                NetworkServer.Spawn(enemyInstance11, conn);

                enemyInstance12 = Instantiate(EnemyPrefab4, EnemyspawnPoints[12].position, EnemyspawnPoints[12].rotation);
                NetworkServer.Spawn(enemyInstance12, conn);

                enemyInstance13 = Instantiate(EnemyPrefab4, EnemyspawnPoints[13].position, EnemyspawnPoints[13].rotation);
                NetworkServer.Spawn(enemyInstance13, conn);

                enemyInstance14 = Instantiate(EnemyPrefab4, EnemyspawnPoints[14].position, EnemyspawnPoints[14].rotation);
                NetworkServer.Spawn(enemyInstance14, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 28)
            {
                enemyInstance = Instantiate(EnemyPrefab, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

                enemyInstance5 = Instantiate(EnemyPrefab2, EnemyspawnPoints[5].position, EnemyspawnPoints[5].rotation);
                NetworkServer.Spawn(enemyInstance5, conn);

                enemyInstance6 = Instantiate(EnemyPrefab2, EnemyspawnPoints[6].position, EnemyspawnPoints[6].rotation);
                NetworkServer.Spawn(enemyInstance6, conn);

                enemyInstance7 = Instantiate(EnemyPrefab3, EnemyspawnPoints[7].position, EnemyspawnPoints[7].rotation);
                NetworkServer.Spawn(enemyInstance7, conn);

                enemyInstance8 = Instantiate(EnemyPrefab3, EnemyspawnPoints[8].position, EnemyspawnPoints[8].rotation);
                NetworkServer.Spawn(enemyInstance8, conn);

                enemyInstance9 = Instantiate(EnemyPrefab3, EnemyspawnPoints[9].position, EnemyspawnPoints[9].rotation);
                NetworkServer.Spawn(enemyInstance9, conn);

                enemyInstance10 = Instantiate(EnemyPrefab3, EnemyspawnPoints[10].position, EnemyspawnPoints[10].rotation);
                NetworkServer.Spawn(enemyInstance10, conn);

                enemyInstance11 = Instantiate(EnemyPrefab3, EnemyspawnPoints[11].position, EnemyspawnPoints[11].rotation);
                NetworkServer.Spawn(enemyInstance11, conn);

                enemyInstance12 = Instantiate(EnemyPrefab3, EnemyspawnPoints[12].position, EnemyspawnPoints[12].rotation);
                NetworkServer.Spawn(enemyInstance12, conn);

                enemyInstance13 = Instantiate(EnemyPrefab3, EnemyspawnPoints[13].position, EnemyspawnPoints[13].rotation);
                NetworkServer.Spawn(enemyInstance13, conn);

                enemyInstance14 = Instantiate(EnemyPrefab4, EnemyspawnPoints[14].position, EnemyspawnPoints[14].rotation);
                NetworkServer.Spawn(enemyInstance14, conn);

                enemyInstance15 = Instantiate(EnemyPrefab4, EnemyspawnPoints[15].position, EnemyspawnPoints[15].rotation);
                NetworkServer.Spawn(enemyInstance15, conn);

                enemyInstance16 = Instantiate(EnemyPrefab4, EnemyspawnPoints[16].position, EnemyspawnPoints[16].rotation);
                NetworkServer.Spawn(enemyInstance16, conn);

                enemyInstance17 = Instantiate(EnemyPrefab4, EnemyspawnPoints[17].position, EnemyspawnPoints[17].rotation);
                NetworkServer.Spawn(enemyInstance17, conn);

                enemyInstance18 = Instantiate(EnemyPrefab4, EnemyspawnPoints[18].position, EnemyspawnPoints[18].rotation);
                NetworkServer.Spawn(enemyInstance18, conn);

                enemyInstance19 = Instantiate(EnemyPrefab4, EnemyspawnPoints[19].position, EnemyspawnPoints[19].rotation);
                NetworkServer.Spawn(enemyInstance19, conn);

                enemyInstance20 = Instantiate(EnemyPrefab4, EnemyspawnPoints[20].position, EnemyspawnPoints[20].rotation);
                NetworkServer.Spawn(enemyInstance20, conn);
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 29)
            {
                enemyInstance = Instantiate(EnemyPrefab5, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab5, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 30)
            {
                enemyInstance = Instantiate(EnemyPrefab6, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 31)
            {
                enemyInstance = Instantiate(EnemyPrefab2, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 32)
            {
                enemyInstance = Instantiate(EnemyPrefab2, EnemyspawnPoints[1].position, EnemyspawnPoints[1].rotation);
                NetworkServer.Spawn(enemyInstance, conn);

                enemyInstance2 = Instantiate(EnemyPrefab2, EnemyspawnPoints[2].position, EnemyspawnPoints[2].rotation);
                NetworkServer.Spawn(enemyInstance2, conn);

                enemyInstance3 = Instantiate(EnemyPrefab2, EnemyspawnPoints[3].position, EnemyspawnPoints[3].rotation);
                NetworkServer.Spawn(enemyInstance3, conn);

                enemyInstance4 = Instantiate(EnemyPrefab2, EnemyspawnPoints[4].position, EnemyspawnPoints[4].rotation);
                NetworkServer.Spawn(enemyInstance4, conn);

            }
        }

        public override void OnServerReady(NetworkConnectionToClient conn)
        {

            if (nextIndex == 0)
            {
                DeathMatch = false;
                SpawnEnemy(conn);
            }

            Transform spawnPoint = spawnPoints.ElementAtOrDefault(nextIndex);
            if (spawnPoint == null)
            {
                Debug.LogError($"Missing spawn point for player {nextIndex}");
                return;
            }
            GameObject playerInstance = Instantiate(playerPrefab, spawnPoints[nextIndex].position, spawnPoints[nextIndex].rotation);
            NetworkServer.Spawn(playerInstance, conn);

            nextIndex++;

            base.OnServerReady(conn);
            OnServerReadied?.Invoke(conn);

        }

    }
}
