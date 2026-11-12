using System;
using UnityEngine.UI;
using UnityEngine;

public class DailyTaskTimer : MonoBehaviour
{
    private ulong lastDailyTask;
    public float msToWait = 86400000;
    public Text DailyTaskTime;

    public bool IsTimerRunning = false;

    public MainMenuScript MMS;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("LastDailyTask"))
        {
            lastDailyTask = (ulong)DateTime.Now.Ticks;
            PlayerPrefs.SetString("LastDailyTask", lastDailyTask.ToString());
            lastDailyTask = ulong.Parse(PlayerPrefs.GetString("LastDailyTask"));
            IsTimerRunning = true;
        }
        else
            if (PlayerPrefs.HasKey("LastDailyTask"))
        {
            lastDailyTask = ulong.Parse(PlayerPrefs.GetString("LastDailyTask"));
            IsTimerRunning = true;
        }
    }
    private void Update()
    {

        if (IsTimerRunning == true)
        {
            ulong diff = ((ulong)DateTime.Now.Ticks - lastDailyTask);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
            float secondsLeft = (float)(msToWait - m) / 1000.0f;

            string r = "";

            r += ((int)secondsLeft / 3600).ToString() + "h ";
            secondsLeft -= ((int)secondsLeft / 3600) * 3600;

            r += ((int)secondsLeft / 60).ToString("00") + "m ";

            r += (secondsLeft % 60).ToString("00") + "s ";
            DailyTaskTime.text = "Ends In: " + r;
            if (secondsLeft < 0)
            {
                MMS.ActivateDailyTaskPanel();
                IsTimerRunning = false;
                MMS.ResetDailyTask();
            }
        }
        else if (IsTimerRunning == false)
        {
            lastDailyTask = (ulong)DateTime.Now.Ticks;
            PlayerPrefs.SetString("LastDailyTask", lastDailyTask.ToString());
            DailyTaskTime.text = "";
            IsTimerRunning = true;
        }

    }

}
