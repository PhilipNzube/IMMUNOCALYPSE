using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TipsScript : MonoBehaviour
{
    public Text txt;
    public Text txt2;
    public Text txt3;
    public Text txt4;
    public Text txt5;
    public Text txt6;
    public Text txt7;
    public Text txt8;
    public Text txt9;
    public Text txt10;
    public Text txt11;
    public Text txt12;
    void Start()
    {
        if (PlayerPrefs.GetInt("LoadedTipBefore1") == 0)
        {
            txt.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 1);
            }
        }
        else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 1)
        {
            txt2.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 2);
            }
        }
        else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 2)
        {
            txt3.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 3);
            }
        }
        else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 3)
        {
            txt4.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 4);
            }
        }
        else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 4)
        {
            txt5.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 5);
            }
        }
        else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 5)
        {
            txt6.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 6);
            }
        }
        else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 6)
        {
            txt7.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 7);
            }
        }
        else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 7)
        {
            txt8.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 8);
            }
        }
        else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 8)
        {
            txt9.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 9);
            }
        }
        else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 9)
        {
            txt10.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 10);
            }
        }
        else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 10)
        {
            txt11.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 11);
            }
        }
        else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 11)
        {
            txt12.gameObject.SetActive(true);
            if (SceneManager.GetActiveScene().name == "ImmunocalypseGameLobbyScene")
            {
                PlayerPrefs.SetInt("LoadedTipBefore1", 0);
            }
        }
    }
}
