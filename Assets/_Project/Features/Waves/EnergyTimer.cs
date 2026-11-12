using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class EnergyTimer : MonoBehaviour
{
    private ulong lastOpenReward;
    public float msToWait = 120;
    public Text EnergyTime;

    public bool FirstDay = true;

    public GameObject RewardPanel;

    public bool IsTimerRunning = false;

    public MainMenuScript MMS;

    public bool IsReallyTime = false;

    public bool STFN = false;

    public int NextTime = 0;

    public bool Day1Ready = false;

    void Awake()
    {
    }
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
        }

        lastOpenReward = ulong.Parse(PlayerPrefs.GetString("LastOpenReward"));
    }

    private void Update()
    {
        if (STFN == true)
        {
            EnergyTime.text = "Loading";
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
            EnergyTime.text = r;
            if (secondsLeft < 0)
            {
                IsTimerRunning = false;
            }
        }
        else if (IsTimerRunning == false)
        {
            EnergyTime.text = "";
        }

    }
    public void ActivateRewards()
    {
    }

}
