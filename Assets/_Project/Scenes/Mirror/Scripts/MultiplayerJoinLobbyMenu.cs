using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Mirror.Scripts
{
    public class MultiplayerJoinLobbyMenu : MonoBehaviour
    {
        [SerializeField] private ImmunocalypseNetworkManager networkManager = null;

        [Header("UI")]
        [SerializeField] private GameObject landingPagePanel = null;
        [SerializeField] private TMP_InputField ipAddressInputField = null;
        [SerializeField] private Button joinButton = null;
        public GameObject LoadingBG;

        private void OnEnable()
        {
            ImmunocalypseNetworkManager.OnClientConnected += HandleClientConnected;
            ImmunocalypseNetworkManager.OnClientDisconnected += HandleClientDisconnected;
            LoadingBG.gameObject.SetActive(false);
        }

        private void OnDisable()
        {
            ImmunocalypseNetworkManager.OnClientConnected -= HandleClientConnected;
            ImmunocalypseNetworkManager.OnClientDisconnected -= HandleClientDisconnected;

        }
        public void JoinLobby()
        {
            string ipAddress = ipAddressInputField.text;
            networkManager.networkAddress = ipAddress;
            networkManager.StartClient();
            joinButton.interactable = false;
            StartCoroutine(JoinTimeOut());
        }
        public void HandleClientConnected()
        {
            joinButton.interactable = true;
            gameObject.SetActive(false);
            LoadingBG.gameObject.SetActive(true);

        }
        public void HandleClientDisconnected()
        {
            joinButton.interactable = true;
        }

        public IEnumerator JoinTimeOut()
        {
            yield return new WaitForSeconds(600000.0f);
            Debug.Log("JoinTimedOut");
            networkManager.StopClient();
            HandleClientDisconnected();
        }
    }
}
