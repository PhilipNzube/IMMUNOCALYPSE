using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.Networking;
using System.Collections;
using System;

public class RewardedVideoAds : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{

    [Header("Ads Properties")]
    public string _androidGameID;
    public bool _testMode = true;
    public bool _enablePerPlacementMode = true;
    public string _rewardedVideoID = "Rewarded_Android";
    public Button _GemRewardBtn;
    public Button _EnergyRewardBtn;
    public Button _ReviveRewardBtn;
    public GameObject WarningMessage;
    public Text WarningText;
    public GameObject AwardMessage;
    public Text AwardText;
    public bool IsGemReward;
    public bool IsEnergyReward;
    public bool IsReviveReward;
    public int EnergyValue;
    public int GemValue;
    public PlayerHealth PH;
    public MainMenuScript MMS;
    public bool CallSDK = true;
    public bool CallWarnMessage;
    public bool StopLoading;
    public GameObject[] InitializingText;
    public GameObject[] LoadingText;
    public GameObject[] AdInfoText;

    private void Awake()
    {
        StartCoroutine(CheckInternetConnection(isConnected =>
        {
            if (isConnected)
            {

            }
            else
            {
                if (PlayerPrefs.GetInt("FirstTime") == 1)
                {
                    WarningMessage.gameObject.SetActive(true);
                    WarningText.text = "No Internet Connection Available To Load Ads!!";
                    WarningText.color = Color.red;
                }
            }
        }));
    }

    public void OnInitializationComplete()
    {
        Debug.Log("unity ads initialized");
        LoadAd();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        CallSDK = true;
        WarningMessage.gameObject.SetActive(true);
        WarningText.text = "Ad failed to initialize." + error;
        WarningText.color = Color.red;
        Debug.Log("Unity ads failed to initialize." + error + ": " + message);
        Advertisement.Initialize(_androidGameID, _testMode, this);
        foreach (GameObject InitText in InitializingText)
        {
            InitText.gameObject.SetActive(true);
        }

        foreach (GameObject AdInfo in AdInfoText)
        {
            AdInfo.gameObject.SetActive(false);
        }
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        foreach (GameObject LoadText in LoadingText)
        {
            LoadText.gameObject.SetActive(false);
        }

        foreach (GameObject AdInfo in AdInfoText)
        {
            AdInfo.gameObject.SetActive(true);
        }
        Debug.Log("Unity Ad Loaded correctly");
        if (placementId.Equals(_rewardedVideoID))
        {
            StopLoading = true;
            if (_GemRewardBtn != null)
            {
                _GemRewardBtn.interactable = true;
            }

            if (_EnergyRewardBtn != null)
            {
                if (PlayerPrefs.GetInt("EnergyValue") <= 50)
                {
                    _EnergyRewardBtn.interactable = true;
                }
            }

            if (_ReviveRewardBtn != null)
            {
                _ReviveRewardBtn.interactable = true;
            }
        }
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        StopLoading = false;

        Debug.Log("Unity Ad failed to load." + error + ":" + message);
        Advertisement.Load(_rewardedVideoID, this);
        foreach (GameObject LoadText in LoadingText)
        {
            LoadText.gameObject.SetActive(true);
        }

        foreach (GameObject AdInfo in AdInfoText)
        {
            AdInfo.gameObject.SetActive(false);
        }
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        if (placementId.Equals(_rewardedVideoID) && UnityAdsShowCompletionState.COMPLETED.Equals(showCompletionState))
        {
            if (IsGemReward == true)
            {
                Debug.Log("Ad was finished, Gem reward was given");
                AwardMessage.gameObject.SetActive(true);
                AwardText.text = "Congratulations!!! You Have Been Awarded 10 Gems";
                GemValue = 10;
                PlayerPrefs.SetInt("GemValue", PlayerPrefs.GetInt("GemValue") + GemValue);
            }
            else if (IsEnergyReward == true)
            {
                Debug.Log("Ad was finished, Energy reward was given");
                AwardMessage.gameObject.SetActive(true);
                AwardText.text = "Congratulations!!! You Have Been Awarded 50% Energy";
                EnergyValue = 50;
                PlayerPrefs.SetInt("EnergyValue", PlayerPrefs.GetInt("EnergyValue") + EnergyValue);
                MMS.IsTimerRunning = false;
                MMS.ClearEnergyTimerText();
            }
            else if (IsReviveReward == true)
            {
                Debug.Log("Ad was finished, Revive reward was given");
                PH.AwardedHealth();
            }
            Time.timeScale = 1f;
            Advertisement.Load(_rewardedVideoID, this);
            foreach (GameObject LoadText in LoadingText)
            {
                LoadText.gameObject.SetActive(true);
            }

            foreach (GameObject AdInfo in AdInfoText)
            {
                AdInfo.gameObject.SetActive(false);
            }
        }
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        WarningMessage.gameObject.SetActive(true);
        WarningText.text = "Ad wasn't shown, reward wasn't given." + "" + "ERROR:" + "" + error;
        WarningText.color = Color.red;
        Debug.Log("Ad wasn't shown, reward wasn't given." + error + ":" + message);
        Advertisement.Load(_rewardedVideoID, this);
        foreach (GameObject LoadText in LoadingText)
        {
            LoadText.gameObject.SetActive(true);
        }

        foreach (GameObject AdInfo in AdInfoText)
        {
            AdInfo.gameObject.SetActive(false);
        }
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("Ad Started:" + placementId);
        Time.timeScale = 0f;
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("Ad Clicked:" + placementId);
    }

    public void InitializeAdsSDK()
    {
        foreach (GameObject InitText in InitializingText)
        {
            InitText.gameObject.SetActive(true);
        }

        foreach (GameObject AdInfo in AdInfoText)
        {
            AdInfo.gameObject.SetActive(false);
        }
        Advertisement.Initialize(_androidGameID, _testMode, this);
    }

    public void LoadAd()
    {
        foreach (GameObject InitText in InitializingText)
        {
            InitText.gameObject.SetActive(false);
        }

        foreach (GameObject LoadText in LoadingText)
        {
            LoadText.gameObject.SetActive(true);
        }

        foreach (GameObject AdInfo in AdInfoText)
        {
            AdInfo.gameObject.SetActive(false);
        }
        Debug.Log("Loading Ad: " + _rewardedVideoID);
        Advertisement.Load(_rewardedVideoID, this);
    }

    public void GemShowAd()
    {
        if (_GemRewardBtn.IsInteractable())
        {
            IsGemReward = true;
            IsEnergyReward = false;
            IsReviveReward = false;
            if (_GemRewardBtn != null)
            {
                _GemRewardBtn.interactable = false;
            }

            if (_EnergyRewardBtn != null)
            {
                _EnergyRewardBtn.interactable = false;
            }

            if (_ReviveRewardBtn != null)
            {
                _ReviveRewardBtn.interactable = false;
            }
            Advertisement.Show(_rewardedVideoID, this);
        }
    }

    public void EnergyShowAd()
    {
        IsEnergyReward = true;
        IsReviveReward = false;
        IsGemReward = false;
        if (_GemRewardBtn != null)
        {
            _GemRewardBtn.interactable = false;
        }

        if (_EnergyRewardBtn != null)
        {
            _EnergyRewardBtn.interactable = false;
        }

        if (_ReviveRewardBtn != null)
        {
            _ReviveRewardBtn.interactable = false;
        }
        Advertisement.Show(_rewardedVideoID, this);
    }

    public void ReviveShowAd()
    {
        IsReviveReward = true;
        IsEnergyReward = false;
        IsGemReward = false;
        if (_GemRewardBtn != null)
        {
            _GemRewardBtn.interactable = false;
        }

        if (_EnergyRewardBtn != null)
        {
            _EnergyRewardBtn.interactable = false;
        }

        if (_ReviveRewardBtn != null)
        {
            _ReviveRewardBtn.interactable = false;
        }
        Advertisement.Show(_rewardedVideoID, this);
    }

    public void CloseErrorMessage()
    {

        WarningMessage.gameObject.SetActive(false);
    }

    public void CloseAwardMessage()
    {
        AwardMessage.gameObject.SetActive(false);
    }

    void Update()
    {
        if (StopLoading == false)
        {
            StartCoroutine(CheckInternetConnection(isConnected =>
            {
                if (isConnected)
                {
                    if (CallSDK == true)
                    {
                        if (PlayerPrefs.GetInt("FirstTime") == 1)
                        {
                            WarningMessage.gameObject.SetActive(true);
                            WarningText.text = "Internet Connection Available To Load Ads!!";
                            WarningText.color = Color.green;
                        }

                        if (Advertisement.isInitialized)
                        {
                            Debug.Log("Ad SDK Has Already Been Initialized");
                            LoadAd();
                        }
                        else
                        {
                            InitializeAdsSDK();
                        }
                        CallSDK = false;
                        CallWarnMessage = true;
                    }
                }
                else
                {
                    CallSDK = true;

                    if (CallWarnMessage == true)
                    {
                        if (PlayerPrefs.GetInt("FirstTime") == 1)
                        {
                            WarningMessage.gameObject.SetActive(true);
                            WarningText.text = "No Internet Connection Available To Load Ads!!";
                            WarningText.color = Color.red;
                        }
                        CallWarnMessage = false;
                    }
                }
            }));
        }
    }

    private IEnumerator CheckInternetConnection(Action<bool> action)
    {
        UnityWebRequest request = new UnityWebRequest("https://www.google.com");
        request.certificateHandler = new CustomCertificateHandler();
        yield return request.SendWebRequest();
        if (request.error != null)
        {

            action(false);
        }
        else
        {

            action(true);
        }
    }
}
