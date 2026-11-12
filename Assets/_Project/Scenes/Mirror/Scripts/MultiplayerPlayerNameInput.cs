using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Scenes.Mirror.Scripts
{
    public class MultiplayerPlayerNameInput : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private TMP_InputField nameInputField = null;
        [SerializeField] private Button continueButton = null;
        [SerializeField] private GameObject InputAndButtonGO = null;
        [SerializeField] private GameObject landingPagePanel = null;
        public static string DisplayName { get; private set; }
        private const string PlayerPrefsNameKey = "PlayerName";
        public ImmunocalypseNetworkManager networkManager;

        public GameObject TutorialGO;

        private void Start()
        {
            networkManager = GameObject.FindGameObjectWithTag("NM").GetComponent<ImmunocalypseNetworkManager>();
            SetUpInputField();
        }
        private void SetUpInputField()
        {
            if (!PlayerPrefs.HasKey(PlayerPrefsNameKey))
            {
                continueButton.interactable = false;
                return;
            }
            else if (!PlayerPrefs.HasKey(PlayerPrefsNameKey))
            {
                continueButton.interactable = true;
            }
            string defaultName = PlayerPrefs.GetString(PlayerPrefsNameKey);
            nameInputField.text = defaultName;
            SetPlayerName(defaultName);
            networkManager.StopHost();
        }
        public void SetPlayerName(string name)
        {
            continueButton.interactable = string.IsNullOrEmpty(name);
        }
        public void SavePlayerName()
        {
            DisplayName = nameInputField.text;
            PlayerPrefs.SetString(PlayerPrefsNameKey, DisplayName);
            if (!PlayerPrefs.HasKey("MainMenuFirstTime"))
            {
                PlayerPrefs.SetInt("MainMenuFirstTime",1);
                TutorialGO.gameObject.SetActive(true);
            }
        }

        public void CloseTut()
        {
            TutorialGO.gameObject.SetActive(false);
        }

        void Update()
        {
            if (string.IsNullOrEmpty(nameInputField.text))
            {
                continueButton.interactable = false;
            }
            else
            {
                continueButton.interactable = true;
            }
        }
    }
}
