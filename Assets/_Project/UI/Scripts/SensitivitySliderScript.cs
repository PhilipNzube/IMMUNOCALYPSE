using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SensitivitySliderScript : MonoBehaviour
{
    public Slider SensitivitySlider;
    public Slider ScopeSensitivitySlider;
    public PlayerAiming PA;
    public FirstPersonControls FPC;

    public bool NewPlayer;

    public CameraController CC;

    public float AimSensitivty;

    Color lowColor = Color.green;

    Color highColor = Color.red;

    void Start()
    {
        if (NewPlayer == false)
        {
            FPC = GetComponent<FirstPersonControls>();
            PA = GetComponent<PlayerAiming>();
        }
        if(PlayerPrefs.HasKey("SensitivityLevel"))
        {
        SensitivitySlider.value = PlayerPrefs.GetFloat("SensitivityLevel");
        SetSensitivity();
        }

        if(PlayerPrefs.HasKey("ScopeSensitivityLevel"))
        {
        ScopeSensitivitySlider.value = PlayerPrefs.GetFloat("ScopeSensitivityLevel");
        SetSensitivity2();
        }
    }
    public void SetSensitivity()
    {
        float sliderValue = SensitivitySlider.value;
        PlayerPrefs.SetFloat("SensitivityLevel", sliderValue);
        if (NewPlayer == false)
        {
            PA.speedH = sliderValue;
            PA.speedV = sliderValue;
            FPC.cameraSensitivity = sliderValue;
        }
        else
        {
            CC.Sensitivity = sliderValue;
        }
        float normalizedValue = Mathf.InverseLerp(SensitivitySlider.minValue, SensitivitySlider.maxValue, SensitivitySlider.value);
        GameObject fill = SensitivitySlider.transform.GetChild(1).GetChild(0).gameObject;
        Image fillImage = fill.GetComponent<Image>();
        Color newColour = Color.Lerp(lowColor, highColor, normalizedValue);
        fillImage.color = newColour;
    }

    public void SetSensitivity2()
    {
        float sliderValue = ScopeSensitivitySlider.value;
        PlayerPrefs.SetFloat("ScopeSensitivityLevel", sliderValue);
        AimSensitivty = sliderValue;
        float normalizedValue = Mathf.InverseLerp(ScopeSensitivitySlider.minValue, ScopeSensitivitySlider.maxValue, ScopeSensitivitySlider.value);
        GameObject fill = ScopeSensitivitySlider.transform.GetChild(1).GetChild(0).gameObject;
        Image fillImage = fill.GetComponent<Image>();
        Color newColour = Color.Lerp(lowColor, highColor, normalizedValue);
        fillImage.color = newColour;
    }

}
