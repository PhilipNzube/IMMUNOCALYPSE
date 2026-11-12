using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
public class MenuScript : MonoBehaviour
{
    public ParticleSystem Explode;
    public ParticleSystem Burn;
    public ParticleSystem Blow;
    public ParticleSystem Blow2;
    public ParticleSystem Blow3;
    public AudioSource ExplodeSound;
    public GameObject PlayButton;
    public bool blink = false;
    public bool blow = false;
    public bool ActivateScene = false;
    public bool Delete = false;
    AsyncOperation async;
    public Slider MySlider;

    public bool OpenAllMissions;
    private bool DoneLoading;
    public bool TestCurrentEpisode;
    public int MissionNo;

    public GameObject SelectLanguage;

    public Button English;
    public Button Spanish;
    public Button Chinese;
    public Button French;
    public Button Arabic;
    public Button German;
    public Button Italian;
    public Button Japanese;
    public Button Korean;
    public Button Portuguese;
    public Button Russian;

    void Start()
    {
        Debug.Log(SystemInfo.graphicsDeviceName);
        Debug.Log(SystemInfo.graphicsDeviceVersion);
        Debug.Log(SystemInfo.graphicsDeviceType);
        if(TestCurrentEpisode == true)
        {
            PlayerPrefs.SetInt("CurrentLevel", MissionNo);
        }
        if (Application.isEditor == false)
        {
            if (Delete == true)
            {
                PlayerPrefs.DeleteAll();
            }
        }
        if(OpenAllMissions == true){
            PlayerPrefs.SetInt("GameComplete", 1);
        }

        if (!PlayerPrefs.HasKey("CurrentLevel"))
        {
            if (!PlayerPrefs.HasKey("English"))
            {
            PlayerPrefs.SetInt("English", 1);
            }
            SelectLanguage.gameObject.SetActive(true);
        }
        else
        if (PlayerPrefs.HasKey("CurrentLevel"))
        {
        StartCoroutine(GameLoad());
        }

        if (PlayerPrefs.GetInt("English") == 1)
        {
            English.interactable = false;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Spanish") == 1)
        {
            English.interactable = true;
            Spanish.interactable = false;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Chinese") == 1)
        {
            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = false;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("French") == 1)
        {
            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = false;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Arabic") == 1)
        {
            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = false;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("German") == 1)
        {
            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = false;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Italian") == 1)
        {
            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = false;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Japanese") == 1)
        {
            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = false;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Korean") == 1)
        {
            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = false;
            Portuguese.interactable = true;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Portuguese") == 1)
        {
            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = false;
            Russian.interactable = true;
        }
        else
        if (PlayerPrefs.GetInt("Russian") == 1)
        {
            English.interactable = true;
            Spanish.interactable = true;
            Chinese.interactable = true;
            French.interactable = true;
            Arabic.interactable = true;
            German.interactable = true;
            Italian.interactable = true;
            Japanese.interactable = true;
            Korean.interactable = true;
            Portuguese.interactable = true;
            Russian.interactable = false;
        }

    }

    public void ChangeLangToEnglish()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("English");
        English.interactable = false;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 1);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToSpanish()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Spanish");
        English.interactable = true;
        Spanish.interactable = false;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 1);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToChinese()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Chinese");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = false;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 1);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToFrench()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("French");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = false;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 1);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToArabic()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Arabic");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = false;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 1);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToGerman()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("German");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = false;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 1);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToItalian()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Italian");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = false;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 1);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToJapanese()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Japanese");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = false;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 1);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToKorean()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Korean");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = false;
        Portuguese.interactable = true;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 1);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToPortuguese()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Portuguese");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = false;
        Russian.interactable = true;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 1);
        PlayerPrefs.SetInt("Russian", 0);
    }

    public void ChangeLangToRussian()
    {
        Lean.Localization.LeanLocalization.SetCurrentLanguageAll("Russian");
        English.interactable = true;
        Spanish.interactable = true;
        Chinese.interactable = true;
        French.interactable = true;
        Arabic.interactable = true;
        German.interactable = true;
        Italian.interactable = true;
        Japanese.interactable = true;
        Korean.interactable = true;
        Portuguese.interactable = true;
        Russian.interactable = false;
        PlayerPrefs.SetInt("English", 0);
        PlayerPrefs.SetInt("Spanish", 0);
        PlayerPrefs.SetInt("Chinese", 0);
        PlayerPrefs.SetInt("French", 0);
        PlayerPrefs.SetInt("Arabic", 0);
        PlayerPrefs.SetInt("German", 0);
        PlayerPrefs.SetInt("Italian", 0);
        PlayerPrefs.SetInt("Japanese", 0);
        PlayerPrefs.SetInt("Korean", 0);
        PlayerPrefs.SetInt("Portuguese", 0);
        PlayerPrefs.SetInt("Russian", 1);
    }

    public void CloseSelectLanguage()
    {
        SelectLanguage.gameObject.SetActive(false);
        StartCoroutine(GameLoad());
    }

    public void Load()
    {
        if (DoneLoading == true)
        {
            ActivateScene = true;
            blow = true;
            blink = false;
            PlayButton.gameObject.SetActive(false);

        }
    }
    public IEnumerator Blink()
    {
        while (blink == true)
        {
            PlayButton.gameObject.SetActive(false);
            yield return new WaitForSeconds(1f);
            MySlider.gameObject.SetActive(false);
            PlayButton.gameObject.SetActive(true);
            yield return new WaitForSeconds(1f);
        }
    }
    public IEnumerator BlowUp()
    {
        while (blow == true)
        {
            Blow.Play();
            yield return new WaitForSeconds(0.1f);
            Blow2.Play();
            yield return new WaitForSeconds(0.1f);
            Blow3.Play();
            yield return new WaitForSeconds(4.0f);
        }
    }
    public IEnumerator GameLoad()
    {

        async = SceneManager.LoadSceneAsync("MissionsScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            yield return new WaitForSeconds(2.0f);
            MySlider.value = async.progress * 100;
            if (async.progress >= 0.9f)
            {
                yield return new WaitForSeconds(2.0f);
                GameObject fill = MySlider.transform.GetChild(1).GetChild(0).gameObject;
                Image fillImage = fill.GetComponent<Image>();
                fillImage.color = Color.red;
                MySlider.value = 100.0f;

                PlayButton.gameObject.SetActive(true);
                DoneLoading = true;
                StartCoroutine(Blink());
                if (ActivateScene == true)
                {
                    async.allowSceneActivation = true;
                }
            }
            yield return null;
        }
    }

    public IEnumerator GameLoad2()
    {

        async = SceneManager.LoadSceneAsync("MissionsScene");
        async.allowSceneActivation = true;

        yield return null;
    }

}
