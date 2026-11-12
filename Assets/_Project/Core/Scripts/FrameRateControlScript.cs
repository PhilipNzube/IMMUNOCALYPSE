using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRateControlScript : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        int highFPSRate = Screen.currentResolution.refreshRate;

        highFPSRate = Mathf.Clamp(highFPSRate, 60, 300);
        Application.targetFrameRate = highFPSRate;
    }
}
