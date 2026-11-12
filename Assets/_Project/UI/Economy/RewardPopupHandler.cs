using System;
using UnityEngine.UI;
using UnityEngine;

public class RewardPopupHandler : MonoBehaviour
{

    public Button RewardButton1;
    public Button RewardButton2;
    public Button RewardButton3;
    public Button RewardButton4;
    public Button RewardButton5;
    public Button RewardButton6;
    public Button RewardButton7;
    private ulong lastOpenReward;
    public float msToWait = 86400000;
    public Text RewardTimer;
    public GameObject CollectRewardPanel1;
    public GameObject CollectRewardPanel2;
    public GameObject CollectRewardPanel3;
    public GameObject CollectRewardPanel4;
    public GameObject CollectRewardPanel5;
    public GameObject CollectRewardPanel6;
    public GameObject CollectRewardPanel7;

    public bool IsDay1 = false;
    public bool IsDay2 = false;
    public bool IsDay3 = false;
    public bool IsDay4 = false;
    public bool IsDay5 = false;
    public bool IsDay6 = false;
    public bool IsDay7 = false;

    public bool FirstDay = true;

    public GameObject RewardPanel;

    public bool IsTimerRunning = false;

    public MainMenuScript MMS;

    private void Start()
    {
        if (PlayerPrefs.GetInt("RewardDays") == 1)
        {
            FirstDay = false;
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 2)
        {
            FirstDay = false;
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 3)
        {
            FirstDay = false;
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 4)
        {
            FirstDay = false;
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 5)
        {
            FirstDay = false;
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 6)
        {
            FirstDay = false;
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 7)
        {
            FirstDay = false;
        }

        lastOpenReward = ulong.Parse(PlayerPrefs.GetString("LastOpenReward"));

        if (!IsRewardReady())
        {
            if (PlayerPrefs.GetInt("RewardDays") == 1)
            {
                RewardButton2.interactable = false;
            }
            else if (PlayerPrefs.GetInt("RewardDays") == 2)
            {
                RewardButton3.interactable = false;
            }
            else if (PlayerPrefs.GetInt("RewardDays") == 3)
            {
                RewardButton4.interactable = false;
            }
            else if (PlayerPrefs.GetInt("RewardDays") == 4)
            {
                RewardButton5.interactable = false;
            }
            else if (PlayerPrefs.GetInt("RewardDays") == 5)
            {
                RewardButton6.interactable = false;
            }
            else if (PlayerPrefs.GetInt("RewardDays") == 6)
            {
                RewardButton7.interactable = false;
            }
            else if (PlayerPrefs.GetInt("RewardDays") == 7)
            {
                RewardButton1.interactable = false;
            }
        }

    }

    private void Update()
    {

        if (PlayerPrefs.GetInt("RewardDays") == 1)
        {
            if (!RewardButton1.IsInteractable())
            {
                if (IsRewardReady())
                {
                    MMS.ActivateDailyRewards();
                    RewardButton1.interactable = true;
                }
            }
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 2)
        {
            if (!RewardButton2.IsInteractable())
            {
                if (IsRewardReady())
                {
                    MMS.ActivateDailyRewards();
                    RewardButton2.interactable = true;
                }
            }
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 3)
        {
            if (!RewardButton3.IsInteractable())
            {
                if (IsRewardReady())
                {
                    MMS.ActivateDailyRewards();
                    RewardButton3.interactable = true;
                }
            }
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 4)
        {
            if (!RewardButton4.IsInteractable())
            {
                if (IsRewardReady())
                {
                    MMS.ActivateDailyRewards();
                    RewardButton4.interactable = true;
                }
            }
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 5)
        {
            if (!RewardButton5.IsInteractable())
            {
                if (IsRewardReady())
                {
                    MMS.ActivateDailyRewards();
                    RewardButton5.interactable = true;
                }
            }
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 6)
        {
            if (!RewardButton6.IsInteractable())
            {
                if (IsRewardReady())
                {
                    MMS.ActivateDailyRewards();
                    RewardButton6.interactable = true;
                }
            }
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 7)
        {
            if (!RewardButton7.IsInteractable())
            {
                if (IsRewardReady())
                {
                    MMS.ActivateDailyRewards();
                    RewardButton7.interactable = true;
                }
            }
        }

        if (IsTimerRunning == true)
        {
            ulong diff = ((ulong)DateTime.Now.Ticks - lastOpenReward);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
            float secondsLeft = (float)(msToWait - m) / 1000.0f;
            if (secondsLeft < 0)
            {

            }
        }
    }

    private bool IsRewardReady()
    {

        ulong diff = ((ulong)DateTime.Now.Ticks - lastOpenReward);
        ulong m = diff / TimeSpan.TicksPerMillisecond;
        float secondsLeft = (float)(msToWait - m) / 1000.0f;
        if (secondsLeft < 0)
        {

            return true;
        }
        else
        {
            return false;
        }
    }
}
