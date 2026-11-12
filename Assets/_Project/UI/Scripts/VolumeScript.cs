using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class VolumeScript : MonoBehaviour
{
    public Slider BGSlider;
    public Slider MasterSlider;
    public Slider SFXSlider;
    public AudioMixer MasterAudio;

    void Start()
    {
        MasterSlider.value = PlayerPrefs.GetFloat("MasterVolume", 0.75f);
        BGSlider.value = PlayerPrefs.GetFloat("BGMVolume", 0.75f);
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume", 0.75f);

    }
    public void MasterSetLevel()
    {
        float sliderValue = MasterSlider.value;
        MasterAudio.SetFloat("MasterVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MasterVolume", sliderValue);
    }
    public void BGSetLevel()
    {
        float sliderValue = BGSlider.value;
        MasterAudio.SetFloat("BGM", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("BGMVolume", sliderValue);
    }
    public void SFXSetLevel()
    {
        float sliderValue = SFXSlider.value;
        MasterAudio.SetFloat("SFX", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("SFXVolume", sliderValue);
    }

}
