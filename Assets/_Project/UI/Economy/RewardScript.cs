using System.Collections;
using System;
using UnityEngine.UI;
#if UNITY_ANDROID
using Unity.Notifications.Android;
#endif
using UnityEngine;

public class RewardScript : MonoBehaviour
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

    public bool IsReallyTime = false;

    public bool STFN = false;

    public int NextTime = 0;

    public bool Day1Ready = false;

    public RewardPopupHandler RPH;
    public int NotificationTimerValue;
    #if UNITY_ANDROID
    public AndroidNotification notification;
    #endif

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
        if (FirstDay == true)
        {
            lastOpenReward = (ulong)DateTime.Now.Ticks;
            PlayerPrefs.SetString("LastOpenReward", lastOpenReward.ToString());
            IsTimerRunning = true;

            PlayerPrefs.SetInt("RewardDays", 1);

        }
        else if (FirstDay == false)
        {
            if (PlayerPrefs.GetInt("RewardDays") == 1)
            {
                IsTimerRunning = true;

                IsDay1 = true;
                IsDay2 = false;
                IsDay3 = false;
                IsDay4 = false;
                IsDay5 = false;
                IsDay6 = false;
                IsDay7 = false;

            }
            else if (PlayerPrefs.GetInt("RewardDays") == 2)
            {
                IsTimerRunning = true;

                IsDay1 = false;
                IsDay2 = true;
                IsDay3 = false;
                IsDay4 = false;
                IsDay5 = false;
                IsDay6 = false;
                IsDay7 = false;

            }
            else if (PlayerPrefs.GetInt("RewardDays") == 3)
            {
                IsTimerRunning = true;

                IsDay1 = false;
                IsDay2 = false;
                IsDay3 = true;
                IsDay4 = false;
                IsDay5 = false;
                IsDay6 = false;
                IsDay7 = false;

            }
            else if (PlayerPrefs.GetInt("RewardDays") == 4)
            {
                IsTimerRunning = true;

                IsDay1 = false;
                IsDay2 = false;
                IsDay3 = false;
                IsDay4 = true;
                IsDay5 = false;
                IsDay6 = false;
                IsDay7 = false;

            }
            else if (PlayerPrefs.GetInt("RewardDays") == 5)
            {
                IsTimerRunning = true;

                IsDay1 = false;
                IsDay2 = false;
                IsDay3 = false;
                IsDay4 = false;
                IsDay5 = true;
                IsDay6 = false;
                IsDay7 = false;

            }
            else if (PlayerPrefs.GetInt("RewardDays") == 6)
            {
                IsTimerRunning = true;

                IsDay1 = false;
                IsDay2 = false;
                IsDay3 = false;
                IsDay4 = false;
                IsDay5 = false;
                IsDay6 = true;
                IsDay7 = false;

            }
            else if (PlayerPrefs.GetInt("RewardDays") == 7)
            {
                IsTimerRunning = true;

                IsDay1 = false;
                IsDay2 = false;
                IsDay3 = false;
                IsDay4 = false;
                IsDay5 = false;
                IsDay6 = false;
                IsDay7 = true;

            }
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
                    RewardButton7.interactable = true;
                }
            }

        }
        if (STFN == true)
        {
            RewardTimer.text = "Loading";
        }

        if (IsTimerRunning == true)
        {
            ulong diff = ((ulong)DateTime.Now.Ticks - lastOpenReward);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
            float secondsLeft = (float)(msToWait - m) / 1000.0f;

            string r = "";

            r += ((int)secondsLeft / 3600).ToString() + "h ";
            secondsLeft -= ((int)secondsLeft / 3600) * 3600;

            r += ((int)secondsLeft / 60).ToString("00") + "m ";

            r += (secondsLeft % 60).ToString("00") + "s ";
            RewardTimer.text = r;
            if (secondsLeft < 0)
            {

                MMS.ActivateDailyRewards();
                if (PlayerPrefs.GetInt("RewardDays") == 1)
                {
                    ActivateRewards();
                }
                else if (PlayerPrefs.GetInt("RewardDays") == 2)
                {
                    ActivateRewards();
                }
                else if (PlayerPrefs.GetInt("RewardDays") == 3)
                {
                    ActivateRewards();
                }
                else if (PlayerPrefs.GetInt("RewardDays") == 4)
                {
                    ActivateRewards();
                }
                else if (PlayerPrefs.GetInt("RewardDays") == 5)
                {
                    ActivateRewards();
                }
                else if (PlayerPrefs.GetInt("RewardDays") == 6)
                {
                    ActivateRewards();
                }
                else if (PlayerPrefs.GetInt("RewardDays") == 7)
                {
                    ActivateRewards();
                }
            }
        }
        else if (IsTimerRunning == false)
        {
            RewardTimer.text = "";
        }

    }
    public void RewardClick()
    {
        lastOpenReward = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("LastOpenReward", lastOpenReward.ToString());
        if (PlayerPrefs.GetInt("RewardDays") == 1)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + 100);
            STFN = false;
            IsTimerRunning = true;

            CollectRewardPanel1.gameObject.SetActive(false);
            RewardButton1.interactable = false;
            PlayerPrefs.SetInt("RewardDays", 2);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 2)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + 200);
            IsTimerRunning = true;

            CollectRewardPanel2.gameObject.SetActive(false);
            RewardButton2.interactable = false;
            PlayerPrefs.SetInt("RewardDays", 3);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 3)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + 500);
            IsTimerRunning = true;

            CollectRewardPanel3.gameObject.SetActive(false);
            RewardButton3.interactable = false;
            PlayerPrefs.SetInt("RewardDays", 4);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 4)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + 1000);
            IsTimerRunning = true;

            CollectRewardPanel4.gameObject.SetActive(false);
            RewardButton4.interactable = false;
            PlayerPrefs.SetInt("RewardDays", 5);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 5)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + 1500);
            IsTimerRunning = true;

            CollectRewardPanel5.gameObject.SetActive(false);
            RewardButton5.interactable = false;
            PlayerPrefs.SetInt("RewardDays", 6);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 6)
        {
            PlayerPrefs.SetInt("CoinValue", PlayerPrefs.GetInt("CoinValue") + 2000);
            IsTimerRunning = true;

            CollectRewardPanel6.gameObject.SetActive(false);
            RewardButton6.interactable = false;
            PlayerPrefs.SetInt("RewardDays", 7);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 7)
        {
            PlayerPrefs.SetInt("EnergyValue", PlayerPrefs.GetInt("GemValue") + 800);
            IsTimerRunning = true;

            CollectRewardPanel7.gameObject.SetActive(false);
            RewardButton7.interactable = false;
            PlayerPrefs.SetInt("RewardDays", 1);
        }

    }
    public void ActivateTimer()
    {

        IsTimerRunning = true;
        RewardButton1.interactable = false;
        PlayerPrefs.SetInt("RewardDays", 1);
    }
    private IEnumerator Time()
    {
        yield return new WaitForSeconds(1.0f);
        FirstDay = false;
    }

    private IEnumerator StopTimerForNow()
    {
        yield return new WaitForSeconds(3.0f);
        STFN = false;
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
    public void ActivateRewards()
    {
        if (PlayerPrefs.GetInt("RewardDays") == 1)
        {
            IsTimerRunning = false;
            RewardTimer.text = "Ready!";
            CollectRewardPanel1.gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 2)
        {
            IsTimerRunning = false;

            RewardTimer.text = "Ready!";
            CollectRewardPanel2.gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 3)
        {
            IsTimerRunning = false;

            RewardTimer.text = "Ready!";
            CollectRewardPanel3.gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 4)
        {
            IsTimerRunning = false;

            RewardTimer.text = "Ready!";
            CollectRewardPanel4.gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 5)
        {
            IsTimerRunning = false;

            RewardTimer.text = "Ready!";
            CollectRewardPanel5.gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 6)
        {
            IsTimerRunning = false;

            RewardTimer.text = "Ready!";
            CollectRewardPanel6.gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("RewardDays") == 7)
        {
            IsTimerRunning = false;

            RewardTimer.text = "Ready!";
            CollectRewardPanel7.gameObject.SetActive(true);
        }
    }

}
