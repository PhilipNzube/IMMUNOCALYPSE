using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class IntroSceneLoader : MonoBehaviour
{
    public Slider MySlider;
    AsyncOperation async;
    public Text LoadingText;

    void Start()
    {
        int activeScene = PlayerPrefs.GetInt("CurrentLevel");
        LoadingText.text = "LOADING...";
        StartCoroutine(LoadStoryScene(activeScene));
    }

    IEnumerator LoadStoryScene(int LoadScenes)
    {
        yield return new WaitForSeconds(1.0f);
        async = SceneManager.LoadSceneAsync(LoadScenes);
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            MySlider.value = async.progress;
            LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
            if (async.progress >= 0.9f)
            {
                MySlider.value = 1f;

                LoadingText.text = "LOADING COMPLETE...";
                async.allowSceneActivation = true;

            }
            yield return null;
        }
    }
}
