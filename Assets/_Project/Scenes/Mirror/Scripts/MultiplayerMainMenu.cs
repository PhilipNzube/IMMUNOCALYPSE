using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Scenes.Mirror.Scripts
{
    public class MultiplayerMainMenu : MonoBehaviour
    {
        [SerializeField] private ImmunocalypseNetworkManager networkManager = null;
        [Header("UI")]
        [SerializeField] private GameObject landingPagePanel = null;
        public GameObject LoadingBG;

        public void HostLobby()
        {
            LoadingBG.gameObject.SetActive(true);

        }

    }
}
