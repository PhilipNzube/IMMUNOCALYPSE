using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader1 : MonoBehaviour
{
    public Button Play;
    AsyncOperation async;
    public Text LoadingText;
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;

    public Button M1;
    public Button M2;
    public Button M3;
    public Button M4;
    public Button M5;
    public Button M6;
    public Button M7;
    public Button M8;
    public Button M9;
    public Button M10;
    public Button M11;
    public Button M12;
    public Button M13;
    public Button M14;
    public Button M15;
    public Button M16;
    public Button M17;
    public Button M18;
    public Button M19;
    public Button M20;
    public Button M21;
    public Button M22;
    public Button M23;
    public Button M24;
    public Button M25;
    public Button M26;
    public Button M27;
    public Button M28;

    public Transform QuitGamePanel;
    public bool QuitGamePanelVisible;

    public bool AllMissionsActivated = false;

    public GameObject NM;

    public GameObject PleaseWaitMessage;

    void Start()
    {
        NM = GameObject.FindGameObjectWithTag("NM");

        if (NM != null)
        {
            Destroy(NM);
        }

        if (!PlayerPrefs.HasKey("GameComplete"))
        {
            if (!PlayerPrefs.HasKey("CurrentLevel"))
            {
                M1.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }

            if (PlayerPrefs.GetInt("CurrentLevel") == 3)
            {
                M1.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
            {
                M2.interactable = true;
                M1.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
            {
                M3.interactable = true;
                M2.interactable = false;
                M1.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
            {
                M4.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M1.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 7)
            {
                M5.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M1.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 8)
            {
                M6.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M1.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 9)
            {
                M7.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M1.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 10)
            {
                RightNextMission();
                M8.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M1.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 11)
            {
                RightNextMission();
                M9.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M1.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 12)
            {
                RightNextMission();
                M10.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M1.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 13)
            {
                RightNextMission();
                M11.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M1.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 14)
            {
                RightNextMission();
                M12.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M1.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 15)
            {
                RightNextMission();
                M13.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M1.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 16)
            {
                RightNextMission();
                M14.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M1.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 17)
            {
                RightNextMission2();
                M15.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M1.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 18)
            {
                RightNextMission2();
                M16.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M1.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 19)
            {
                RightNextMission2();
                M17.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M1.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 20)
            {
                RightNextMission2();
                M18.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M1.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 21)
            {
                RightNextMission2();
                M19.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M1.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 22)
            {
                RightNextMission2();
                M20.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M1.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 23)
            {
                RightNextMission2();
                M21.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M1.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 24)
            {
                RightNextMission3();
                M22.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M1.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 25)
            {
                RightNextMission3();
                M23.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M1.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 26)
            {
                RightNextMission3();
                M24.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M1.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 27)
            {
                RightNextMission3();
                M25.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M1.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 28)
            {
                RightNextMission3();
                M26.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M1.interactable = false;
                M27.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 29)
            {
                RightNextMission3();
                M27.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M1.interactable = false;
                M28.interactable = false;
            }
            else if (PlayerPrefs.GetInt("CurrentLevel") == 30)
            {
                RightNextMission3();
                M28.interactable = true;
                M2.interactable = false;
                M3.interactable = false;
                M4.interactable = false;
                M5.interactable = false;
                M6.interactable = false;
                M7.interactable = false;
                M8.interactable = false;
                M9.interactable = false;
                M10.interactable = false;
                M11.interactable = false;
                M12.interactable = false;
                M13.interactable = false;
                M14.interactable = false;
                M15.interactable = false;
                M16.interactable = false;
                M17.interactable = false;
                M18.interactable = false;
                M19.interactable = false;
                M20.interactable = false;
                M21.interactable = false;
                M22.interactable = false;
                M23.interactable = false;
                M24.interactable = false;
                M25.interactable = false;
                M26.interactable = false;
                M27.interactable = false;
                M1.interactable = false;
            }
        }
        else if (PlayerPrefs.GetInt("GameComplete") == 1)
        {
            AllMissionsActivated = true;
            M1.interactable = true;
            M2.interactable = true;
            M3.interactable = true;
            M4.interactable = true;
            M5.interactable = true;
            M6.interactable = true;
            M7.interactable = true;
            M8.interactable = true;
            M9.interactable = true;
            M10.interactable = true;
            M11.interactable = true;
            M12.interactable = true;
            M13.interactable = true;
            M14.interactable = true;
            M15.interactable = true;
            M16.interactable = true;
            M17.interactable = true;
            M18.interactable = true;
            M19.interactable = true;
            M20.interactable = true;
            M21.interactable = true;
            M22.interactable = true;
            M23.interactable = true;
            M24.interactable = true;
            M25.interactable = true;
            M26.interactable = true;
            M27.interactable = true;
            M28.interactable = true;
        }
    }

    public void LeftNextMission()
    {
        C2.gameObject.SetActive(false);
        C1.gameObject.SetActive(true);
    }
    public void LeftNextMission2()
    {
        C3.gameObject.SetActive(false);
        C2.gameObject.SetActive(true);
    }
    public void LeftNextMission3()
    {
        C4.gameObject.SetActive(false);
        C3.gameObject.SetActive(true);
    }

    public void RightNextMission()
    {
        C1.gameObject.SetActive(false);
        C2.gameObject.SetActive(true);
    }

    public void RightNextMission2()
    {
        C1.gameObject.SetActive(false);
        C2.gameObject.SetActive(false);
        C3.gameObject.SetActive(true);
    }

    public void RightNextMission3()
    {
        C1.gameObject.SetActive(false);
        C2.gameObject.SetActive(false);
        C3.gameObject.SetActive(false);
        C4.gameObject.SetActive(true);
    }

    public void LoadGame()
    {

        SceneManager.LoadScene("MainMenu 1");
    }

    public void LoadGame2()
    {

        if (PlayerPrefs.HasKey("StartFirstTime"))
        {
            SceneManager.LoadScene("ImmunocalypseGameLobbyScene");
        }
        else
        {
            PlayerPrefs.SetInt("StartFirstTime",1);
            SceneManager.LoadScene("IntroScene");
        }
    }

    public void QuitGame()
    {
        if (QuitGamePanelVisible == false)
        {
            QuitGamePanelVisible = true;
            QuitGamePanel.gameObject.SetActive(true);
        }
        else if (QuitGamePanelVisible == true)
        {
            QuitGamePanelVisible = false;
            QuitGamePanel.gameObject.SetActive(false);
        }
    }

    public void Quit()
    {
        QuitGame();
    }

    public void ConfirmQuit()
    {
        PleaseWaitMessage.gameObject.SetActive(true);
        Application.Quit();
    }

    public void LoadMission1()
    {
        PlayerPrefs.SetInt("CurrentLevel", 3);
    }

    public void LoadMission2()
    {
        PlayerPrefs.SetInt("CurrentLevel", 4);
    }

    public void LoadMission3()
    {
        PlayerPrefs.SetInt("CurrentLevel", 5);
    }

    public void LoadMission4()
    {
        PlayerPrefs.SetInt("CurrentLevel", 6);
    }

    public void LoadMission5()
    {
        PlayerPrefs.SetInt("CurrentLevel", 7);
    }

    public void LoadMission6()
    {
        PlayerPrefs.SetInt("CurrentLevel", 8);
    }

    public void LoadMission7()
    {
        PlayerPrefs.SetInt("CurrentLevel", 9);
    }

    public void LoadMission8()
    {
        PlayerPrefs.SetInt("CurrentLevel", 10);
    }

    public void LoadMission9()
    {
        PlayerPrefs.SetInt("CurrentLevel", 11);
    }

    public void LoadMission10()
    {
        PlayerPrefs.SetInt("CurrentLevel", 12);
    }

    public void LoadMission11()
    {
        PlayerPrefs.SetInt("CurrentLevel", 13);
    }

    public void LoadMission12()
    {
        PlayerPrefs.SetInt("CurrentLevel", 14);
    }

    public void LoadMission13()
    {
        PlayerPrefs.SetInt("CurrentLevel", 15);
    }

    public void LoadMission14()
    {
        PlayerPrefs.SetInt("CurrentLevel", 16);
    }

    public void LoadMission15()
    {
        PlayerPrefs.SetInt("CurrentLevel", 17);
    }

    public void LoadMission16()
    {
        PlayerPrefs.SetInt("CurrentLevel", 18);
    }

    public void LoadMission17()
    {
        PlayerPrefs.SetInt("CurrentLevel", 19);
    }

    public void LoadMission18()
    {
        PlayerPrefs.SetInt("CurrentLevel", 20);
    }

    public void LoadMission19()
    {
        PlayerPrefs.SetInt("CurrentLevel", 21);
    }

    public void LoadMission20()
    {
        PlayerPrefs.SetInt("CurrentLevel", 22);
    }

    public void LoadMission21()
    {
        PlayerPrefs.SetInt("CurrentLevel", 23);
    }
    public void LoadMission22()
    {
        PlayerPrefs.SetInt("CurrentLevel", 24);
    }
    public void LoadMission23()
    {
        PlayerPrefs.SetInt("CurrentLevel", 25);
    }
    public void LoadMission24()
    {
        PlayerPrefs.SetInt("CurrentLevel", 26);
    }
    public void LoadMission25()
    {
        PlayerPrefs.SetInt("CurrentLevel", 27);
    }
    public void LoadMission26()
    {
        PlayerPrefs.SetInt("CurrentLevel", 28);
    }
    public void LoadMission27()
    {
        PlayerPrefs.SetInt("CurrentLevel", 29);
    }
    public void LoadMission28()
    {
        PlayerPrefs.SetInt("CurrentLevel", 30);
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Quit();
            }
        }

    }

}

