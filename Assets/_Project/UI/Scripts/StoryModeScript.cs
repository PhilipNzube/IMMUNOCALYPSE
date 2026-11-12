using System.Collections;
using Lean.Localization;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StoryModeScript : MonoBehaviour
{
    public Text txt;
    public Text txta;
    public Text txtb;
    public Text txtc;
    public Text txt2;
    public Text txt2a;
    public Text txt2b;
    public Text txt2c;
    public Text txt3;
    public Text txt3a;
    public Text txt3b;
    public Text txt3c;
    public string story;
    public string storya;
    public string storyb;
    public string storyc;
    public string story2;
    public string story2a;
    public string story2b;
    public string story2c;
    public string story3;
    public string story3a;
    public string story3b;
    public string story3c;
    AsyncOperation async;
    public AudioSource TypingSound;
    public Text Cursor;
    public Text Cursora;
    public Text Cursorb;
    public Text Cursorc;
    public Text Cursor2;
    public Text Cursor2a;
    public Text Cursor2b;
    public Text Cursor2c;
    public Text Cursor3;
    public Text Cursor3a;
    public Text Cursor3b;
    public Text Cursor3c;

    public Text Subtitle1;
    public string Subtitlestory;
    public GameObject Tag;

    public Text Subtitle2No;
    public string Subtitle2Nostory;
    public GameObject Tag2No;

    public Text Subtitle2No2;
    public string Subtitle2Nostory2;
    public GameObject Tag2No2;

    public Text Subtitle2No3;
    public string Subtitle2Nostory3;
    public GameObject Tag2No3;

    public Text Subtitle2No4;
    public string Subtitle2Nostory4;
    public GameObject Tag2No4;

    public Text Subtitle2Yes;
    public string Subtitle2Yesstory;
    public GameObject Tag2Yes;

    public Text Subtitle2Yes2;
    public string Subtitle2Yesstory2;
    public GameObject Tag2Yes2;

    public bool blink = false;

    public GameObject MessageGO;

    public bool CanSee = false;

    public bool Continue = false;

    public GameObject PleaseWaitUI;

    public LeanLocalizedText Subtitle1Localization;
    public LeanLocalizedText Subtitle2NoLocalization;
    public LeanLocalizedText Subtitle2No2Localization;
    public LeanLocalizedText Subtitle2No3Localization;
    public LeanLocalizedText Subtitle2No4Localization;
    public LeanLocalizedText Subtitle2YesLocalization;
    public LeanLocalizedText Subtitle2Yes2Localization;

    public LeanLocalizedText txtLocalization;
    public LeanLocalizedText txtaLocalization;
    public LeanLocalizedText txtbLocalization;
    public LeanLocalizedText txtcLocalization;
    public LeanLocalizedText txt2Localization;
    public LeanLocalizedText txt2aLocalization;
    public LeanLocalizedText txt2bLocalization;
    public LeanLocalizedText txt2cLocalization;
    public LeanLocalizedText txt3Localization;
    public LeanLocalizedText txt3aLocalization;
    public LeanLocalizedText txt3bLocalization;
    public LeanLocalizedText txt3cLocalization;

    void Start()
    {
        story = txt.text;
        storya = txta.text;
        storyb = txtb.text;
        storyc = txtc.text;
        story2 = txt2.text;
        story2a = txt2a.text;
        story2b = txt2b.text;
        story2c = txt2c.text;
        story3 = txt3.text;
        story3a = txt3a.text;
        story3b = txt3b.text;
        story3c = txt3c.text;
        Subtitlestory = Subtitle1.text;
        Subtitle2Nostory = Subtitle2No.text;
        Subtitle2Nostory2 = Subtitle2No2.text;
        Subtitle2Nostory3 = Subtitle2No3.text;
        Subtitle2Nostory4 = Subtitle2No4.text;
        Subtitle2Yesstory = Subtitle2Yes.text;
        Subtitle2Yesstory2 = Subtitle2Yes2.text;
        Subtitle1Localization.enabled = false;
        Subtitle2NoLocalization.enabled = false;
        Subtitle2No2Localization.enabled = false;
        Subtitle2No3Localization.enabled = false;
        Subtitle2No4Localization.enabled = false;
        Subtitle2YesLocalization.enabled = false;
        Subtitle2Yes2Localization.enabled = false;

        txtLocalization.enabled = false;
        txtaLocalization.enabled = false;
        txtbLocalization.enabled = false;
        txtcLocalization.enabled = false;
        txt2Localization.enabled = false;
        txt2aLocalization.enabled = false;
        txt2bLocalization.enabled = false;
        txt2cLocalization.enabled = false;
        txt3Localization.enabled = false;
        txt3aLocalization.enabled = false;
        txt3bLocalization.enabled = false;
        txt3cLocalization.enabled = false;
        txt3.text = "";
        txt3a.text = "";
        txt3b.text = "";
        txt3c.text = "";
        txt2.text = "";
        txt2a.text = "";
        txt2b.text = "";
        txt2c.text = "";
        txt.text = "";
        txta.text = "";
        txtb.text = "";
        txtc.text = "";
        Subtitle1.text = "";
        Subtitle2No.text = "";
        Subtitle2No2.text = "";
        Subtitle2No3.text = "";
        Subtitle2No4.text = "";
        Subtitle2Yes.text = "";
        Subtitle2Yes2.text = "";
        StartCoroutine(PlayText());
    }

    IEnumerator PlayText()
    {
        Tag.gameObject.SetActive(true);
        TypingSound.Stop();
        foreach (char letters in Subtitlestory.ToCharArray())
        {
            Subtitle1.text += letters;
            yield return new WaitForSeconds(0.125f);
        }
        yield return new WaitForSeconds(3.0f);
        TypingSound.Play();
        foreach (char letters in story.ToCharArray())
        {
            Tag.gameObject.SetActive(false);
            Subtitle1.gameObject.SetActive(false);
            txt.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursor.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursor.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.08f);
            Cursor.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.08f);
            Cursor.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.08f);
            Cursor.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.08f);
            Cursor.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.08f);
            blink = false;
        }
        yield return new WaitForSeconds(.8f);

        TypingSound.Play();
        foreach (char letters in storya.ToCharArray())
        {
            txta.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursora.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursora.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.08f);
            Cursora.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.08f);
            Cursora.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.08f);
            Cursora.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.08f);
            Cursora.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.08f);
            blink = false;
        }
        yield return new WaitForSeconds(.8f);
        TypingSound.Play();
        foreach (char letters in storyb.ToCharArray())
        {
            txtb.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursorb.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursorb.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.08f);
            Cursorb.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.08f);
            Cursorb.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.08f);
            Cursorb.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.08f);
            Cursorb.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.08f);
            blink = false;
        }

        yield return new WaitForSeconds(.8f);
        TypingSound.Play();

        foreach (char letters in storyc.ToCharArray())
        {
            txtc.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursorc.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursorc.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursorc.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursorc.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursorc.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursorc.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursorc.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursorc.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursorc.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursorc.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursorc.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            blink = false;
        }
        yield return new WaitForSeconds(2.0f);
        MessageGO.gameObject.SetActive(true);
    }

    IEnumerator PlayText2()
    {
        Tag2Yes.gameObject.SetActive(true);
        foreach (char letters in Subtitle2Yesstory.ToCharArray())
        {
            Subtitle2Yes.text += letters;
            yield return new WaitForSeconds(0.125f);
        }
        TypingSound.Stop();
        yield return new WaitForSeconds(3.0f);
        TypingSound.Play();
        foreach (char letters in story2.ToCharArray())
        {
            Tag2Yes.gameObject.SetActive(false);
            Subtitle2Yes.gameObject.SetActive(false);
            txt.gameObject.SetActive(false);
            txta.gameObject.SetActive(false);
            txtb.gameObject.SetActive(false);
            txtc.gameObject.SetActive(false);
            txt2.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursor2.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursor2.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor2.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor2.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor2.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor2.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            blink = false;
        }
        yield return new WaitForSeconds(.8f);
        TypingSound.Play();

        foreach (char letters in story2a.ToCharArray())
        {
            txt2a.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursor2a.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursor2a.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor2a.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor2a.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor2a.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor2a.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            blink = false;
        }

        yield return new WaitForSeconds(2.0f);
        TypingSound.Play();

        foreach (char letters in story2b.ToCharArray())
        {
            txt2b.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursor2b.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursor2b.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.08f);
            Cursor2b.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor2b.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor2b.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor2b.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            blink = false;
        }

        yield return new WaitForSeconds(2.0f);
        TypingSound.Play();

        foreach (char letters in story2c.ToCharArray())
        {
            txt2c.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursor2c.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursor2c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor2c.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor2c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor2c.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor2c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor2c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor2c.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor2c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor2c.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor2c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            blink = false;
        }

        yield return new WaitForSeconds(2.0f);
        TypingSound.Play();

        foreach (char letters in story3.ToCharArray())
        {
            txt2.gameObject.SetActive(false);
            txt2a.gameObject.SetActive(false);
            txt2b.gameObject.SetActive(false);
            txt2c.gameObject.SetActive(false);
            txt3.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursor3.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursor3.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor3.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor3.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor3.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor3.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            blink = false;
        }

        yield return new WaitForSeconds(2.0f);
        TypingSound.Play();
        foreach (char letters in story3a.ToCharArray())
        {
            txt3a.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursor3a.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursor3a.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor3a.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor3a.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor3a.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor3a.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            blink = false;
        }

        yield return new WaitForSeconds(2.0f);
        TypingSound.Play();

        foreach (char letters in story3b.ToCharArray())
        {
            txt3b.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursor3b.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursor3b.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor3b.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor3b.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor3b.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor3b.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            blink = false;
        }

        yield return new WaitForSeconds(2.0f);
        TypingSound.Play();

        foreach (char letters in story3c.ToCharArray())
        {
            txt3c.text += letters;
            yield return new WaitForSeconds(0.00005f);
        }
        Cursor3c.text = "|";
        blink = true;
        TypingSound.Stop();
        while (blink == true)
        {
            Cursor3c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor3c.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor3c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor3c.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor3c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor3c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor3c.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor3c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            Cursor3c.gameObject.SetActive(true);
            yield return new WaitForSeconds(.08f);
            Cursor3c.gameObject.SetActive(false);
            yield return new WaitForSeconds(.08f);
            blink = false;
        }

        yield return new WaitForSeconds(2.0f);

        Tag2Yes.gameObject.SetActive(false);
        Subtitle2Yes.gameObject.SetActive(false);

        Tag2Yes2.gameObject.SetActive(true);
        foreach (char letters in Subtitle2Yesstory2.ToCharArray())
        {
            Subtitle2Yes2.text += letters;
            yield return new WaitForSeconds(0.125f);
        }

        yield return new WaitForSeconds(3.0f);
        PleaseWaitUI.gameObject.SetActive(true);
        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (async.progress >= 0.9f)
            {
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    IEnumerator PlayNoSubtitles()
    {
        Tag2No.gameObject.SetActive(true);

        foreach (char letters in Subtitle2Nostory.ToCharArray())
        {
            Subtitle2No.text += letters;
            yield return new WaitForSeconds(0.125f);
        }

        yield return new WaitForSeconds(3.0f);
        txt.gameObject.SetActive(false);
        txta.gameObject.SetActive(false);
        txtb.gameObject.SetActive(false);
        txtc.gameObject.SetActive(false);

        foreach (char letters in Subtitle2Nostory2.ToCharArray())
        {
            Tag2No.gameObject.SetActive(false);
            Subtitle2No.gameObject.SetActive(false);
            Tag2No2.gameObject.SetActive(true);
            Subtitle2No2.text += letters;
            yield return new WaitForSeconds(0.125f);
        }

        yield return new WaitForSeconds(3.0f);

        foreach (char letters in Subtitle2Nostory3.ToCharArray())
        {
            Tag2No2.gameObject.SetActive(false);
            Subtitle2No2.gameObject.SetActive(false);
            Tag2No3.gameObject.SetActive(true);
            Subtitle2No3.text += letters;
            yield return new WaitForSeconds(0.125f);
        }

        yield return new WaitForSeconds(3.0f);

        foreach (char letters in Subtitle2Nostory4.ToCharArray())
        {
            Tag2No3.gameObject.SetActive(false);
            Subtitle2No3.gameObject.SetActive(false);
            Tag2No4.gameObject.SetActive(true);
            Subtitle2No4.text += letters;
            yield return new WaitForSeconds(0.125f);
        }

        yield return new WaitForSeconds(3.0f);
        PleaseWaitUI.gameObject.SetActive(true);
        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (async.progress >= 0.9f)
            {
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    public void Skip()
    {
        TypingSound.Stop();
        PleaseWaitUI.gameObject.SetActive(true);
        SceneManager.LoadScene("ImmunocalypseGameLobbyScene");

    }

    public IEnumerator Skipper()
    {
        PleaseWaitUI.gameObject.SetActive(true);
        async = SceneManager.LoadSceneAsync("ImmunocalypseGameLobbyScene");
        async.allowSceneActivation = false;
        while (async.isDone == false)
        {
            if (async.progress >= 0.9f)
            {
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    public void Yes()
    {
        MessageGO.gameObject.SetActive(false);
        StartCoroutine(PlayText2());
        CanSee = true;
    }

    public void No()
    {
        MessageGO.gameObject.SetActive(false);
        StartCoroutine(PlayNoSubtitles());
        CanSee = false;
    }

}
