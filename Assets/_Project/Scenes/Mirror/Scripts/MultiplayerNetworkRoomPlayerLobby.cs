using System.Collections;
using Mirror;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

namespace Scenes.Mirror.Scripts
{
    public class MultiplayerNetworkRoomPlayerLobby : NetworkBehaviour
    {
        [SerializeField] private GameObject lobbyUI = null;
        [SerializeField] private TMP_Text[] playerNameTexts = new TMP_Text[5];
        [SerializeField] private TMP_Text[] playerReadyTexts = new TMP_Text[5];
        [SerializeField] private Button startGameButton = null;
        public GameObject HostLobbyExit;
        public GameObject PleaseWaitMessage;

        public GameObject landingPagePanel;
        public GameObject UIPanel;
        public GameObject ConfirmExitToLobby;
        public GameObject ConfirmExitToWeaponsScreen;
        public GameObject ConfirmExitToMissionsScreen;
        public GameObject ConfirmQuitGame;
        public GameObject NM;
        public Button CETLPLNISButton;
        public Button CETWSButton;
        public Button CETMSButton;
        public Button CQGButton;
        public Button ETLPLNISButton;
        public Button ETWSButton;
        public Button ETMSButton;
        public Button QGButton;
        public Button DETLPLNISButton;
        public Button DETWSButton;
        public Button DETMSButton;
        public Button DQGButton;
        public GameObject LoadingBG;
        public GameObject TutorialGO;

        [SyncVar(hook = nameof(HandleDisplayNameChanged))]
        public string DisplayName = "Loading...";
        [SyncVar(hook = nameof(HandleReadyStatusChanged))]
        public bool IsReady = false;

        private bool isLeader;

        public bool IsLeader
        {
            set
            {
                isLeader = value;
                startGameButton.gameObject.SetActive(value);

            }
        }

        private ImmunocalypseNetworkManager room;

        private ImmunocalypseNetworkManager Room
        {
            get
            {
                if (room != null) { return room; }
                return room = NetworkManager.singleton as ImmunocalypseNetworkManager;
            }
        }
        void Awake()
        {
            NM = GameObject.FindGameObjectWithTag("NM");
        }

        void Start()
        {

            LoadingBG = GameObject.FindGameObjectWithTag("LBG");
            NM = GameObject.FindGameObjectWithTag("NM");

            UIPanel.gameObject.SetActive(false);
            ConfirmExitToLobby.gameObject.SetActive(false);
            ConfirmExitToWeaponsScreen.gameObject.SetActive(false);
            ConfirmExitToMissionsScreen.gameObject.SetActive(false);
            ConfirmQuitGame.gameObject.SetActive(false);
            LoadingBG.gameObject.SetActive(false);

            if (PlayerPrefs.GetInt("RESTART") == 1)
            {
                room.OnStopServer();
                PlayerPrefs.SetInt("RESTART", 0);
            }

           if (!PlayerPrefs.HasKey("LobbyFirstTime"))
            {
                PlayerPrefs.SetInt("LobbyFirstTime",1);
                TutorialGO.gameObject.SetActive(true);
            }
        }

        public void CloseTut()
        {
            TutorialGO.gameObject.SetActive(false);
        }

        public override void OnStartAuthority()
        {
            CmdSetDisplayName(MultiplayerPlayerNameInput.DisplayName);
            lobbyUI.SetActive(true);
            StartCoroutine(UndoRemoveInt());

        }

        public void ClosePanel()
        {
            UIPanel.gameObject.SetActive(false);
        }

        public void ExitLobby()
        {
            UIPanel.gameObject.SetActive(true);
        }

        public void ExitToPlayerNameInputScreen()
        {
            StartCoroutine(ExitToPNIS());
        }
        public IEnumerator ExitToPNIS()
        {

            PleaseWaitMessage.gameObject.SetActive(true);

            yield return new WaitForSeconds(2.0f);
            PleaseWaitMessage.gameObject.SetActive(false);

            NetworkClient.Shutdown();
            NetworkClient.Disconnect();
            NetworkServer.Shutdown();
            lobbyUI.gameObject.SetActive(false);
            landingPagePanel.gameObject.SetActive(true);

            Transport.activeTransport.ServerStop();
            room.OnStopServer();

        }

        public IEnumerator QG()
        {

            PleaseWaitMessage.gameObject.SetActive(true);

            yield return new WaitForSeconds(2.0f);

            Application.Quit();
        }

        public void ConfirmETLPLNIS()
        {
            ConfirmExitToLobby.gameObject.SetActive(true);
        }

        public void ConfirmETWS()
        {
            ConfirmExitToWeaponsScreen.gameObject.SetActive(true);
        }

        public void ConfirmETMS()
        {
            ConfirmExitToMissionsScreen.gameObject.SetActive(true);
        }

        public void ConfirmQG()
        {
            ConfirmQuitGame.gameObject.SetActive(true);
        }

        public void ExitToWeaponsScreen()
        {

            LoadingBG.gameObject.SetActive(true);

            if (!NetworkClient.isConnected && !NetworkServer.active && !NetworkClient.active)
            {
                NetworkManager.singleton.ServerChangeScene("MainMenu 1");
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

        public void ExitToMissionsScreen()
        {
            LoadingBG.gameObject.SetActive(true);
            if (!NetworkClient.isConnected && !NetworkServer.active && !NetworkClient.active)
            {
                NetworkManager.singleton.ServerChangeScene("MissionsScene");
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

        public void QuitG()
        {
            StartCoroutine(QG());
        }

        public void DontExitToLobbyPlayerNameInput()
        {
            ConfirmExitToLobby.gameObject.SetActive(false);
        }

        public void DontExitToWeaponsScreen()
        {
            ConfirmExitToWeaponsScreen.gameObject.SetActive(false);
        }

        public void DontExitToMissionsScreen()
        {
            ConfirmExitToMissionsScreen.gameObject.SetActive(false);
        }

        public void DontQuitG()
        {
            ConfirmQuitGame.gameObject.SetActive(false);
        }

        public IEnumerator UndoRemoveInt()
        {
            yield return new WaitForSeconds(3.0f);
            PlayerPrefs.SetInt("Remove", 1);
        }
        public override void OnStartClient()
        {
            Room.RoomPlayers.Add(this);
            UpdateDisplay();
        }

        public override void OnStopClient()
        {
            Room.RoomPlayers.Remove(this);
            UpdateDisplay();
        }

        public void HandleReadyStatusChanged(bool oldValue, bool newValue) => UpdateDisplay();
        public void HandleDisplayNameChanged(string oldValue, string newValue) => UpdateDisplay();

        private void UpdateDisplay()
        {
            if (!hasAuthority)
            {
                foreach (var player in Room.RoomPlayers)
                {
                    if (player.hasAuthority)
                    {
                        player.UpdateDisplay();
                        break;
                    }
                }
                return;
            }
            for (int i = 0; i < playerNameTexts.Length; i++)
            {
                playerNameTexts[i].text = "Waiting For Player...";
                playerReadyTexts[i].text = string.Empty;
            }
            for (int i = 0; i < Room.RoomPlayers.Count; i++)
            {
                playerNameTexts[i].text = Room.RoomPlayers[i].DisplayName;
                playerReadyTexts[i].text = Room.RoomPlayers[i].IsReady ?
                "<color=green>Ready</color>" : "<color=red>Not Ready</color>";
            }
        }
        public void HandleReadyToStart(bool readyToStart)
        {
            if (!isLeader) { return; }
            startGameButton.interactable = readyToStart;
        }

        [Command]
        public void CmdSetDisplayName(string displayName)
        {
            DisplayName = displayName;
        }

        [Command]
        public void CmdReadyUp()
        {
            IsReady = !IsReady;
            Room.NotifyPlayersOfReadyState();
        }

        [Command]
        public void CmdStartGame()
        {

            if (Room.RoomPlayers[0].connectionToClient != connectionToClient) { return; }
            Room.StartGame();
        }

        void Update()
        {
            CETLPLNISButton.onClick.AddListener(ConfirmETLPLNIS);
            CETWSButton.onClick.AddListener(ConfirmETWS);
            CETMSButton.onClick.AddListener(ConfirmETMS);
            CQGButton.onClick.AddListener(ConfirmQG);
            ETLPLNISButton.onClick.AddListener(ExitToPlayerNameInputScreen);
            ETWSButton.onClick.AddListener(ExitToWeaponsScreen);
            ETMSButton.onClick.AddListener(ExitToMissionsScreen);
            QGButton.onClick.AddListener(QuitG);
            DETLPLNISButton.onClick.AddListener(DontExitToLobbyPlayerNameInput);
            DETWSButton.onClick.AddListener(DontExitToWeaponsScreen);
            DETMSButton.onClick.AddListener(DontExitToMissionsScreen);
            DQGButton.onClick.AddListener(DontQuitG);
            landingPagePanel = GameObject.FindGameObjectWithTag("LPP");
        }
    }
}
