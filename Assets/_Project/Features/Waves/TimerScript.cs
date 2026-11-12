using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class TimerScript : NetworkBehaviour
{
    public float timeRemaining = 120.0f;
    public bool timerIsRunning = false;
    public Text timeText;
    public Text ReviveText;
    public Transform TimeOut;
    public Transform GameOver;
    public AudioSource DeathSound;
    public PlayerHealth PH;
    public GameObject RevivePanel;
    public bool Warn = false;

    void Start()
    {
        TimeOut.gameObject.SetActive(false);
        GameOver.gameObject.SetActive(false);
        timeText.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("CurrentLevel") == 3)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 7)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 8)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 9)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 10)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 11)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 12)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 13)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 14)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 15)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 16)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 17)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 18)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 19)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 20)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 21)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 22)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 23)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 24)
        {
            timeRemaining = 120.0f;

        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 25)
        {
            timeRemaining = 120.0f;

        }
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.smoothDeltaTime;
                Displaytime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                RevivePanel.gameObject.SetActive(true);
                ReviveText.text = "Out Of Time!!!";
                PH.TimerLow = true;
                PH.timerIsRunning = true;

            }
        }
    }

    public void RUN()
    {
        timeText.gameObject.SetActive(true);
        timerIsRunning = true;
    }

    public void STOP()
    {
        timerIsRunning = false;
    }

    void Displaytime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = Mathf.FloorToInt(timeToDisplay % 1) * 1000;
        timeText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliSeconds);
    }

    public IEnumerator Restart()
    {
        yield return new WaitForSeconds(0.5f);
        TimeOut.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        TimeOut.gameObject.SetActive(false);
        GameOver.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
