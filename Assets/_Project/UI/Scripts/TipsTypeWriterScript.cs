using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
public class TipsTypeWriterScript : MonoBehaviour
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
    public string story;
    public string story2;
    public string story3;
    public string story4;
    public string story5;
    public string story6;
    public string story7;
    public string story8;
    public string story9;
    public string story10;
    public string story11;
    public string story12;
    AsyncOperation async;
    public Slider MySlider;
    public Text LoadingText;
    public GameObject NM;
    public bool blink = false;
    public bool ActivateScene = false;

    void Start()
    {
        NM = GameObject.FindGameObjectWithTag("NM");

        if (NM != null)
        {
            Destroy(NM);
        }

        story = txt.text;
        story2 = txt2.text;
        story3 = txt3.text;
        story4 = txt4.text;
        story5 = txt5.text;
        story6 = txt6.text;
        story7 = txt7.text;
        story8 = txt8.text;
        story9 = txt9.text;
        story10 = txt10.text;
        story11 = txt11.text;
        story12 = txt12.text;
        txt4.text = "";
        txt3.text = "";
        txt2.text = "";
        txt.text = "";
        txt5.text = "";
        txt6.text = "";
        txt7.text = "";
        txt8.text = "";
        txt9.text = "";
        txt10.text = "";
        txt11.text = "";
        txt12.text = "";

        int activeScene = PlayerPrefs.GetInt("CurrentLevel");
        if (!PlayerPrefs.HasKey("CurrentLevel"))
        {
            Debug.Log("mission1");
            StartCoroutine(PlayText());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 3)
        {
            Debug.Log("mission1");
            StartCoroutine(PlayText());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
        {
            Debug.Log("mission2");
            StartCoroutine(PlayText2());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
        {
            Debug.Log("mission3");
            StartCoroutine(PlayText3());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 6)
        {
            Debug.Log("mission4");
            StartCoroutine(PlayText4());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 7)
        {
            Debug.Log("mission5");
            StartCoroutine(PlayText5());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 8)
        {
            Debug.Log("mission6");
            StartCoroutine(PlayText6());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 9)
        {
            Debug.Log("mission7");
            StartCoroutine(PlayText7());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 10)
        {
            Debug.Log("mission8");
            StartCoroutine(PlayText8());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 11)
        {
            Debug.Log("mission9");
            StartCoroutine(PlayText9());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 12)
        {
            Debug.Log("mission10");
            StartCoroutine(PlayText10());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 13)
        {
            Debug.Log("mission11");
            StartCoroutine(PlayText11());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 14)
        {
            Debug.Log("mission12");
            StartCoroutine(PlayText12());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 15)
        {
            Debug.Log("mission13");
            StartCoroutine(PlayText13());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 16)
        {
            Debug.Log("mission14");
            StartCoroutine(PlayText14());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 17)
        {
            Debug.Log("mission15");
            StartCoroutine(PlayText15());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 18)
        {
            Debug.Log("mission16");
            StartCoroutine(PlayText16());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 19)
        {
            Debug.Log("mission17");
            StartCoroutine(PlayText17());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 20)
        {
            Debug.Log("mission18");
            StartCoroutine(PlayText18());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 21)
        {
            Debug.Log("mission19");
            StartCoroutine(PlayText19());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 22)
        {
            Debug.Log("mission20");
            StartCoroutine(PlayText20());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 23)
        {
            Debug.Log("mission21");
            StartCoroutine(PlayText21());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 24)
        {
            Debug.Log("mission22");
            StartCoroutine(PlayText22());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 25)
        {
            Debug.Log("mission23");
            StartCoroutine(PlayText23());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 26)
        {
            Debug.Log("mission24");
            StartCoroutine(PlayText24());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 27)
        {
            Debug.Log("mission25");
            StartCoroutine(PlayText25());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 28)
        {
            Debug.Log("mission26");
            StartCoroutine(PlayText26());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 29)
        {
            Debug.Log("mission27");
            StartCoroutine(PlayText27());
        }
        else if (PlayerPrefs.GetInt("CurrentLevel") == 30)
        {
            Debug.Log("mission28");
            StartCoroutine(PlayText28());
        }
    }

    public void Load()
    {
        ActivateScene = true;
    }
    public IEnumerator Blink()
    {
        while (blink == true)
        {
            LoadingText.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.6f);
            LoadingText.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.6f);
        }
    }
    IEnumerator PlayText()
    {
        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            MySlider.value = async.progress * 100;
            if (async.progress >= 0.9f)
            {
                MySlider.value = 100.0f;
                MySlider.gameObject.SetActive(false);
                LoadingText.text = "TAP TO CONTINUE";
                StartCoroutine(Blink());
                if (ActivateScene == true)
                {
                    async.allowSceneActivation = true;
                }
            }
                yield return null;

        }
    }
    IEnumerator PlayText2()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            MySlider.value = async.progress;

            LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
            if (PlayerPrefs.GetInt("LoadedTipBefore1") == 0)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    MySlider.value = 35.0f;

                    LoadingText.text = "LOADING..." + 35 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 65.0f;

                LoadingText.text = "LOADING..." + 65 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    MySlider.value = 85.0f;

                    LoadingText.text = "LOADING..." + 85 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore1", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 8.0f;

                LoadingText.text = "LOADING..." + 9 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 15.0f;

                LoadingText.text = "LOADING..." + 15 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    MySlider.value = 70.0f;

                    LoadingText.text = "LOADING..." + 70 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore1", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore1") == 2)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 16.0f;

                LoadingText.text = "LOADING..." + 16 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    MySlider.value = 30.0f;

                    LoadingText.text = "LOADING..." + 30 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 45.0f;

                LoadingText.text = "LOADING..." + 45 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    MySlider.value = 65.0f;
                    LoadingText.text = "LOADING..." + 65 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore1", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText3()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore2") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 6.0f;

                LoadingText.text = "LOADING..." + 6 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    MySlider.value = 10.0f;
                    LoadingText.text = "LOADING..." + 10 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 35.0f;
                LoadingText.text = "LOADING..." + 35 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    MySlider.value = 75.0f;
                    LoadingText.text = "LOADING..." + 75 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore2", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore2") == 1)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 9.0f;

                LoadingText.text = "LOADING..." + 9 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 20.0f;
                LoadingText.text = "LOADING..." + 20 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    MySlider.value = 60.0f;
                    LoadingText.text = "LOADING..." + 60 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore2", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore2") == 2)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 31.0f;

                LoadingText.text = "LOADING..." + 31 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    MySlider.value = 45.0f;
                    LoadingText.text = "LOADING..." + 45 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    MySlider.value = 70.0f;
                    LoadingText.text = "LOADING..." + 70 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore2", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText4()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore3") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 22.0f;

                LoadingText.text = "LOADING..." + 22 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 25.0f;
                LoadingText.text = "LOADING..." + 25 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    MySlider.value = 45.0f;
                    LoadingText.text = "LOADING..." + 45 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore3", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore3") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 4.0f;

                LoadingText.text = "LOADING..." + 4 + "%";
                yield return new WaitForSeconds(2.0f);
                MySlider.value = 5.0f;
                LoadingText.text = "LOADING..." + 5 + "%";
                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    MySlider.value = 15.0f;
                    LoadingText.text = "LOADING..." + 15 + "%";
                    yield return new WaitForSeconds(0.125f);
                }

                MySlider.value = 30.0f;
                LoadingText.text = "LOADING..." + 30 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 55.0f;
                LoadingText.text = "LOADING..." + 55 + "%";
                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;

                    MySlider.value = 75.0f;
                    LoadingText.text = "LOADING..." + 75 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore3", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore3") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 8.0f;

                LoadingText.text = "LOADING..." + 9 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 15.0f;
                LoadingText.text = "LOADING..." + 15 + "%";
                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 65.0f;
                LoadingText.text = "LOADING..." + 65 + "%";
                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore3", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;
                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText5()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore4") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 10.0f;

                LoadingText.text = "LOADING..." + 10 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 15.0f;
                LoadingText.text = "LOADING..." + 15 + "%";
                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 65.0f;
                LoadingText.text = "LOADING..." + 65 + "%";
                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore4", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore4") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 10.0f;
                LoadingText.text = "LOADING..." + 10 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 20.0f;
                LoadingText.text = "LOADING..." + 20 + "%";
                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 65.0f;
                LoadingText.text = "LOADING..." + 65 + "%";
                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;

                    MySlider.value = 85.0f;
                    LoadingText.text = "LOADING..." + 85 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore4", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore4") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 8.0f;
                LoadingText.text = "LOADING..." + 8 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;

                    MySlider.value = 23.0f;
                    LoadingText.text = "LOADING..." + 23 + "%";
                    yield return new WaitForSeconds(0.125f);
                }

                MySlider.value = 41.0f;
                LoadingText.text = "LOADING..." + 41 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;

                    MySlider.value = 65.0f;
                    LoadingText.text = "LOADING..." + 65 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore4", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText6()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore5") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 37.0f;

                LoadingText.text = "LOADING..." + 37 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore5", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore5") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 37.0f;

                LoadingText.text = "LOADING..." + 37 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore5", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore5") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 27.0f;

                LoadingText.text = "LOADING..." + 27 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore5", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText7()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore6") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 20.0f;
                LoadingText.text = "LOADING..." + 20 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;

                    MySlider.value = 48.0f;
                    LoadingText.text = "LOADING..." + 48 + "%";
                    yield return new WaitForSeconds(0.125f);
                }

                MySlider.value = 65.0f;
                LoadingText.text = "LOADING..." + 65 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;

                    MySlider.value = 90.0f;
                    LoadingText.text = "LOADING..." + 90 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore6", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore6") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 40.0f;
                LoadingText.text = "LOADING..." + 40 + "%";

                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;

                    MySlider.value = 85.0f;
                    LoadingText.text = "LOADING..." + 85 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";

                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore6", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore6") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 17.0f;

                LoadingText.text = "LOADING..." + 17 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore6", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText8()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore7") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 5.0f;
                LoadingText.text = "LOADING..." + 5 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 15.0f;
                LoadingText.text = "LOADING..." + 15 + "%";
                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;

                    MySlider.value = 59.0f;
                    LoadingText.text = "LOADING..." + 59 + "%";
                    yield return new WaitForSeconds(0.125f);
                }

                MySlider.value = 66.0f;
                LoadingText.text = "LOADING..." + 66 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 78.0f;
                LoadingText.text = "LOADING..." + 78 + "%";
                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;

                    MySlider.value = 85.0f;
                    LoadingText.text = "LOADING..." + 85 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore7", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore7") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 37.0f;

                LoadingText.text = "LOADING..." + 37 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore7", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore7") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 25.0f;
                LoadingText.text = "LOADING..." + 25 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;

                    MySlider.value = 65.0f;
                    LoadingText.text = "LOADING..." + 65 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore7", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText9()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore8") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 57.0f;

                LoadingText.text = "LOADING..." + 57 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore8", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore8") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 27.0f;

                LoadingText.text = "LOADING..." + 27 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 65.0f;
                LoadingText.text = "LOADING..." + 65 + "%";
                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 80.0f;
                LoadingText.text = "LOADING..." + 80 + "%";
                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore6", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore8") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 67.0f;

                LoadingText.text = "LOADING..." + 67 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;

                    MySlider.value = 45.0f;
                    LoadingText.text = "LOADING..." + 45 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;

                    MySlider.value = 60.0f;
                    LoadingText.text = "LOADING..." + 60 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore8", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText10()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore9") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 47.0f;

                LoadingText.text = "LOADING..." + 47 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore9", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore9") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 47.0f;

                LoadingText.text = "LOADING..." + 47 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore9", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore9") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 37.0f;

                LoadingText.text = "LOADING..." + 37 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore9", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText11()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore10") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 28.0f;
                LoadingText.text = "LOADING..." + 28 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;

                    MySlider.value = 35.0f;
                    LoadingText.text = "LOADING..." + 35 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 55.0f;
                LoadingText.text = "LOADING..." + 55 + "%";
                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;

                    MySlider.value = 65.0f;
                    LoadingText.text = "LOADING..." + 65 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore10", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore10") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 27.0f;

                LoadingText.text = "LOADING..." + 27 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;

                    MySlider.value = 70.0f;
                    LoadingText.text = "LOADING..." + 70 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore10", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore10") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 77.0f;

                LoadingText.text = "LOADING..." + 77 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore10", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText12()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore11") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 57.0f;

                LoadingText.text = "LOADING..." + 57 + "%";

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore11", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore11") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 8.0f;
                LoadingText.text = "LOADING..." + 8 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 25.0f;
                LoadingText.text = "LOADING..." + 25 + "%";
                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;

                    MySlider.value = 30.0f;
                    LoadingText.text = "LOADING..." + 30 + "%";
                    yield return new WaitForSeconds(0.125f);
                }

                MySlider.value = 70.0f;
                LoadingText.text = "LOADING..." + 70 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 85.0f;
                LoadingText.text = "LOADING..." + 85 + "%";
                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore11", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore11") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 37.0f;

                LoadingText.text = "LOADING..." + 37 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore11", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText13()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore12") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 27.0f;

                LoadingText.text = "LOADING..." + 27 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore12", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore12") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 57.0f;

                LoadingText.text = "LOADING..." + 57 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore12", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore12") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 67.0f;

                LoadingText.text = "LOADING..." + 67 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore12", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    IEnumerator PlayText14()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore13") == 0)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 20.0f;

                LoadingText.text = "LOADING..." + 20 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 47.0f;
                LoadingText.text = "LOADING..." + 47 + "%";
                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    MySlider.value = 40.0f;

                    LoadingText.text = "LOADING..." + 40 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 70.0f;

                LoadingText.text = "LOADING..." + 70 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 86.0f;
                LoadingText.text = "LOADING..." + 86 + "%";
                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;

                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;

                    yield return new WaitForSeconds(0.125f);
                }
                PlayerPrefs.SetInt("LoadedTipBefore13", 1);
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore13") == 1)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 35.0f;

                LoadingText.text = "LOADING..." + 35 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    MySlider.value = 50.0f;

                    LoadingText.text = "LOADING..." + 50 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 60.0f;

                LoadingText.text = "LOADING..." + 60 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    MySlider.value = 85.0f;

                    LoadingText.text = "LOADING..." + 85 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;

                    yield return new WaitForSeconds(0.125f);

                }
                PlayerPrefs.SetInt("LoadedTipBefore13", 2);
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore13") == 2)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 10.0f;

                LoadingText.text = "LOADING..." + 10 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;

                    MySlider.value = 45.0f;
                    LoadingText.text = "LOADING..." + 45 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 65.0f;

                LoadingText.text = "LOADING..." + 65 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;

                    MySlider.value = 79.0f;
                    LoadingText.text = "LOADING..." + 79 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;

                    yield return new WaitForSeconds(0.125f);

                }
                PlayerPrefs.SetInt("LoadedTipBefore13", 0);
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
        }
    }
    IEnumerator PlayText15()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            MySlider.value = async.progress;

            LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
            if (PlayerPrefs.GetInt("LoadedTipBefore14") == 0)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    MySlider.value = 35.0f;

                    LoadingText.text = "LOADING..." + 35 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 65.0f;

                LoadingText.text = "LOADING..." + 65 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    MySlider.value = 85.0f;

                    LoadingText.text = "LOADING..." + 85 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore14", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore14") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 8.0f;

                LoadingText.text = "LOADING..." + 9 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 15.0f;

                LoadingText.text = "LOADING..." + 15 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    MySlider.value = 70.0f;

                    LoadingText.text = "LOADING..." + 70 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore14", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore14") == 2)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 16.0f;

                LoadingText.text = "LOADING..." + 16 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    MySlider.value = 30.0f;

                    LoadingText.text = "LOADING..." + 30 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 45.0f;

                LoadingText.text = "LOADING..." + 45 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    MySlider.value = 65.0f;
                    LoadingText.text = "LOADING..." + 65 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore14", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText16()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore15") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 6.0f;

                LoadingText.text = "LOADING..." + 6 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    MySlider.value = 10.0f;
                    LoadingText.text = "LOADING..." + 10 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 35.0f;
                LoadingText.text = "LOADING..." + 35 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    MySlider.value = 75.0f;
                    LoadingText.text = "LOADING..." + 75 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore15", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore15") == 1)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 9.0f;

                LoadingText.text = "LOADING..." + 9 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 20.0f;
                LoadingText.text = "LOADING..." + 20 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    MySlider.value = 60.0f;
                    LoadingText.text = "LOADING..." + 60 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore15", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore15") == 2)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 31.0f;

                LoadingText.text = "LOADING..." + 31 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    MySlider.value = 45.0f;
                    LoadingText.text = "LOADING..." + 45 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    MySlider.value = 70.0f;
                    LoadingText.text = "LOADING..." + 70 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore15", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText17()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore16") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 22.0f;

                LoadingText.text = "LOADING..." + 22 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 25.0f;
                LoadingText.text = "LOADING..." + 25 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    MySlider.value = 45.0f;
                    LoadingText.text = "LOADING..." + 45 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore16", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore16") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 4.0f;

                LoadingText.text = "LOADING..." + 4 + "%";
                yield return new WaitForSeconds(2.0f);
                MySlider.value = 5.0f;
                LoadingText.text = "LOADING..." + 5 + "%";
                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    MySlider.value = 15.0f;
                    LoadingText.text = "LOADING..." + 15 + "%";
                    yield return new WaitForSeconds(0.125f);
                }

                MySlider.value = 30.0f;
                LoadingText.text = "LOADING..." + 30 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 55.0f;
                LoadingText.text = "LOADING..." + 55 + "%";
                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;

                    MySlider.value = 75.0f;
                    LoadingText.text = "LOADING..." + 75 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore16", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore16") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 8.0f;

                LoadingText.text = "LOADING..." + 9 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 15.0f;
                LoadingText.text = "LOADING..." + 15 + "%";
                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 65.0f;
                LoadingText.text = "LOADING..." + 65 + "%";
                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore16", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;
                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText18()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore17") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 10.0f;

                LoadingText.text = "LOADING..." + 10 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 15.0f;
                LoadingText.text = "LOADING..." + 15 + "%";
                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 65.0f;
                LoadingText.text = "LOADING..." + 65 + "%";
                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore17", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore17") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 7.0f;

                LoadingText.text = "LOADING..." + 7 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 20.0f;
                LoadingText.text = "LOADING..." + 20 + "%";
                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 65.0f;
                LoadingText.text = "LOADING..." + 65 + "%";
                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;

                    MySlider.value = 85.0f;
                    LoadingText.text = "LOADING..." + 85 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore17", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore17") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 47.0f;

                LoadingText.text = "LOADING..." + 47 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;

                    MySlider.value = 23.0f;
                    LoadingText.text = "LOADING..." + 23 + "%";
                    yield return new WaitForSeconds(0.125f);
                }

                MySlider.value = 41.0f;
                LoadingText.text = "LOADING..." + 41 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;

                    MySlider.value = 65.0f;
                    LoadingText.text = "LOADING..." + 65 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore17", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText19()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore18") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 7.0f;

                LoadingText.text = "LOADING..." + 7 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore18", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore18") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 57.0f;

                LoadingText.text = "LOADING..." + 57 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore18", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore18") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 37.0f;

                LoadingText.text = "LOADING..." + 37 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore18", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText20()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore19") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 8.0f;
                LoadingText.text = "LOADING..." + 8 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;

                    MySlider.value = 48.0f;
                    LoadingText.text = "LOADING..." + 48 + "%";
                    yield return new WaitForSeconds(0.125f);
                }

                MySlider.value = 65.0f;
                LoadingText.text = "LOADING..." + 65 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;

                    MySlider.value = 90.0f;
                    LoadingText.text = "LOADING..." + 90 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore19", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore19") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 40.0f;
                LoadingText.text = "LOADING..." + 40 + "%";

                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;

                    MySlider.value = 85.0f;
                    LoadingText.text = "LOADING..." + 85 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";

                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore19", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore19") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 18.0f;
                LoadingText.text = "LOADING..." + 18 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore19", 0);
                }
            }
            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText21()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore20") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 8.0f;
                LoadingText.text = "LOADING..." + 8 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 15.0f;
                LoadingText.text = "LOADING..." + 15 + "%";
                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;

                    MySlider.value = 59.0f;
                    LoadingText.text = "LOADING..." + 59 + "%";
                    yield return new WaitForSeconds(0.125f);
                }

                MySlider.value = 66.0f;
                LoadingText.text = "LOADING..." + 66 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 78.0f;
                LoadingText.text = "LOADING..." + 78 + "%";
                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;

                    MySlider.value = 85.0f;
                    LoadingText.text = "LOADING..." + 85 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore20", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore20") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 57.0f;

                LoadingText.text = "LOADING..." + 57 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore20", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore20") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 48.0f;
                LoadingText.text = "LOADING..." + 48 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;

                    MySlider.value = 65.0f;
                    LoadingText.text = "LOADING..." + 65 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore20", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText22()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore21") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 27.0f;

                LoadingText.text = "LOADING..." + 27 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore21", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore21") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 40.0f;
                LoadingText.text = "LOADING..." + 40 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 65.0f;
                LoadingText.text = "LOADING..." + 65 + "%";
                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 80.0f;
                LoadingText.text = "LOADING..." + 80 + "%";
                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore21", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore21") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 38.0f;
                LoadingText.text = "LOADING..." + 38 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;

                    MySlider.value = 45.0f;
                    LoadingText.text = "LOADING..." + 45 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;

                    MySlider.value = 60.0f;
                    LoadingText.text = "LOADING..." + 60 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore21", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText23()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore22") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 7.0f;

                LoadingText.text = "LOADING..." + 7 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore22", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore22") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 57.0f;

                LoadingText.text = "LOADING..." + 57 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore22", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore22") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 47.0f;

                LoadingText.text = "LOADING..." + 47 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore22", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText24()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore23") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 28.0f;
                LoadingText.text = "LOADING..." + 28 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;

                    MySlider.value = 35.0f;
                    LoadingText.text = "LOADING..." + 35 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 55.0f;
                LoadingText.text = "LOADING..." + 55 + "%";
                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;

                    MySlider.value = 65.0f;
                    LoadingText.text = "LOADING..." + 65 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore23", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore23") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 48.0f;
                LoadingText.text = "LOADING..." + 48 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;

                    MySlider.value = 70.0f;
                    LoadingText.text = "LOADING..." + 70 + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore23", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore23") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 37.0f;

                LoadingText.text = "LOADING..." + 37 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore23", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText25()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore24") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 27.0f;

                LoadingText.text = "LOADING..." + 27 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore24", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore24") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 10.0f;
                LoadingText.text = "LOADING..." + 10 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 25.0f;
                LoadingText.text = "LOADING..." + 25 + "%";
                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;

                    MySlider.value = 30.0f;
                    LoadingText.text = "LOADING..." + 30 + "%";
                    yield return new WaitForSeconds(0.125f);
                }

                MySlider.value = 70.0f;
                LoadingText.text = "LOADING..." + 70 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 85.0f;
                LoadingText.text = "LOADING..." + 85 + "%";
                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore24", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore24") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 57.0f;

                LoadingText.text = "LOADING..." + 57 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore24", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText26()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore25") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 47.0f;

                LoadingText.text = "LOADING..." + 47 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore25", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore25") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 37.0f;

                LoadingText.text = "LOADING..." + 37 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore25", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore25") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 27.0f;

                LoadingText.text = "LOADING..." + 27 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore25", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    IEnumerator PlayText27()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore26") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 70.0f;

                LoadingText.text = "LOADING..." + 70 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore26", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore26") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 8.0f;
                LoadingText.text = "LOADING..." + 8 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 25.0f;
                LoadingText.text = "LOADING..." + 25 + "%";
                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;

                    MySlider.value = 30.0f;
                    LoadingText.text = "LOADING..." + 30 + "%";
                    yield return new WaitForSeconds(0.125f);
                }

                MySlider.value = 70.0f;
                LoadingText.text = "LOADING..." + 70 + "%";
                yield return new WaitForSeconds(2.0f);

                MySlider.value = 85.0f;
                LoadingText.text = "LOADING..." + 85 + "%";
                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore26", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore26") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 20.0f;

                LoadingText.text = "LOADING..." + 20 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore26", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
    IEnumerator PlayText28()
    {

        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (PlayerPrefs.GetInt("LoadedTipBefore27") == 0)
            {
                foreach (char letters in story9.ToCharArray())
                {
                    txt9.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 7.0f;

                LoadingText.text = "LOADING..." + 7 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story10.ToCharArray())
                {
                    txt9.gameObject.SetActive(false);
                    txt10.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story11.ToCharArray())
                {
                    txt10.gameObject.SetActive(false);
                    txt11.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story12.ToCharArray())
                {
                    txt11.gameObject.SetActive(false);
                    txt12.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore27", 1);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore27") == 1)
            {
                foreach (char letters in story.ToCharArray())
                {
                    txt.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 10.0f;

                LoadingText.text = "LOADING..." + 10 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story2.ToCharArray())
                {
                    txt.gameObject.SetActive(false);
                    txt2.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story3.ToCharArray())
                {
                    txt2.gameObject.SetActive(false);
                    txt3.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story4.ToCharArray())
                {
                    txt3.gameObject.SetActive(false);
                    txt4.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore27", 2);
                }
                if (async.progress >= 0.9f)
                {

                    MySlider.value = 100.0f;

                    LoadingText.text = "LOADING COMPLETE...";

                    async.allowSceneActivation = true;
                }
                yield return null;
            }
            else if (PlayerPrefs.GetInt("LoadedTipBefore27") == 2)
            {
                foreach (char letters in story5.ToCharArray())
                {
                    txt5.text += letters;
                    MySlider.value = 3.0f;

                    LoadingText.text = "LOADING..." + Mathf.Clamp01(async.progress * 100) + "%";
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = 8.0f;

                LoadingText.text = "LOADING..." + 8 + "%";
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story6.ToCharArray())
                {
                    txt5.gameObject.SetActive(false);
                    txt6.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                yield return new WaitForSeconds(2.0f);

                foreach (char letters in story7.ToCharArray())
                {
                    txt6.gameObject.SetActive(false);
                    txt7.text += letters;
                    yield return new WaitForSeconds(0.125f);
                }
                MySlider.value = async.progress * 100;

                LoadingText.text = "LOADING..." + (async.progress * 100) + "%";
                yield return new WaitForSeconds(2.0f);
                foreach (char letters in story8.ToCharArray())
                {
                    txt7.gameObject.SetActive(false);
                    txt8.text += letters;
                    yield return new WaitForSeconds(0.125f);
                    PlayerPrefs.SetInt("LoadedTipBefore27", 0);
                }
            }

            if (async.progress >= 0.9f)
            {

                MySlider.value = 100.0f;

                LoadingText.text = "LOADING COMPLETE...";

                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    void Update()
    {
        NM = GameObject.FindGameObjectWithTag("NM");
        if (NM != null)
        {
            Destroy(NM);
        }
    }

}
