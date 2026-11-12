using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Lean.Localization;

public class IntroTextFader : MonoBehaviour
{
    public string story;

    public Text textToUse;
	public LeanLocalizedText textToUseLocalization;

    private float timeMultiplier = 1.0f;

    void Start()
    {
        story = textToUse.text;
		textToUseLocalization.enabled = false;

        textToUse.text = "";

        StartCoroutine(FadeInText(timeMultiplier, textToUse));

    }

    private IEnumerator FadeInText(float timeSpeed, Text text)
    {
        foreach (char letters in story.ToCharArray())
        {
            text.text += letters;
            yield return new WaitForSeconds(0.125f);
        }
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        while (text.color.a < 1.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a + (Time.smoothDeltaTime * timeSpeed));
        }
        yield return new WaitForSeconds(8.0f);
        text.color = new Color(text.color.r, text.color.g, text.color.b, 1);
        while (text.color.a > 0.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - (Time.smoothDeltaTime * timeSpeed));
            yield return null;
        }
    }

}
