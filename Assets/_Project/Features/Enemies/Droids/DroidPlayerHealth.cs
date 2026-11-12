using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DroidPlayerHealth : MonoBehaviour
{
    public Slider DroidPlayerHealthBar;
    public AudioSource DeathSound;
    public float Health = 100.0f;
    private float CurrentHealth;
    public float timeRemaining = 10.0f;
    public bool timerIsRunning = false;
    public Text DroidtimeText;
    public Text DroidReviveText;
    public bool blink = false;
    public PlayerHealth PH;
    public Animator anim;
    public bool Tappable = false;
    public DetectionC2 DC;
    public PlayerCollision PC;
    public WASDMovementScript WASD;
    public Look2 L;
    public Text ReviveDroidText;
    public bool Charge = false;
    public bool AlmostDead = false;

    void Awake()
    {
        anim = GetComponent<Animator>();
        CurrentHealth = Health;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                Displaytime(timeRemaining);
            }
            else
            {
                DroidReviveText.text = "SHIT!!!";
                timeRemaining = 0.0f;
                timerIsRunning = false;
                Death();
            }
        }
        if (AlmostDead == true)
        {
            Tappable = true;
            ReviveDroidText.text = "+";
            blink = true;
            StartCoroutine(HBlink());
        }

    }
    public void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        DroidPlayerHealthBar.value = CurrentHealth;
        StartCoroutine(Recharge());
        Charge = true;
        if (CurrentHealth <= 0)
        {
            Charge = false;
            AlmostDead = true;
            anim.SetBool("Idle", true);
            DroidReviveText.text = "ReviveMe!!!";
            timerIsRunning = true;
            blink = true;
            StartCoroutine(Blink());
        }
    }
    public void Death()
    {
        anim.SetBool("Die", true);
        DroidReviveText.text = "";
        DroidtimeText.text = "";
        DeathSound.Play();
        PH.OriginalPlayer = false;
        PH.Death();
    }
    void Displaytime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        DroidtimeText.text = string.Format("{0:00}", seconds);
    }
    public void Revive()
    {
        if (Tappable == true)
        {
            AlmostDead = false;
            timeRemaining = 10.0f;
            timerIsRunning = false;
            CurrentHealth = Health;
            DroidReviveText.text = "";
            DroidtimeText.text = "";
            ReviveDroidText.text = "";
        }
    }
    public void OnSliderWasChanged()
    {
        GameObject fill = DroidPlayerHealthBar.transform.GetChild(1).GetChild(0).gameObject;
        Image fillImage = fill.GetComponent<Image>();
        Color newColour = new Color(1f - (DroidPlayerHealthBar.value / DroidPlayerHealthBar.maxValue), DroidPlayerHealthBar.value / DroidPlayerHealthBar.maxValue, 0f);
        fillImage.color = newColour;
    }
    public IEnumerator HBlink()
    {
        while (blink == true)
        {
            ReviveDroidText.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.05f);
            ReviveDroidText.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.05f);
        }
    }
    public IEnumerator Blink()
    {
        while (blink == true)
        {
            DroidReviveText.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.05f);
            DroidReviveText.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.05f);
        }
    }
    private IEnumerator Recharge()
    {
        while (Charge == true)
        {
            yield return new WaitForSeconds(0.001f);
            if (CurrentHealth < 100)
            {
                CurrentHealth += 1.0f;
            }
            else if (CurrentHealth == 100)
            {
                CurrentHealth = Health;
                Charge = false;
                yield return new WaitForSeconds(0.001f);
            }
        }
    }
}
