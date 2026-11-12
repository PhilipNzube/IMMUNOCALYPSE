using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUIControlsSettings : MonoBehaviour
{

    public GameObject ShootButton;
    public GameObject ReloadButton;
    public GameObject AimButton;
    public GameObject JumpButton;
    public GameObject GrenadeButton;
    public GameObject ControlsSettingsPanel;
    public bool EnableDelete;
    public GameObject SlideButton;
    public GameObject CrouchButton;
    public GameObject ProneButton;

    void Start()
    {
        if (EnableDelete == true)
        {
            PlayerPrefs.DeleteKey("ShootScaleX");
            PlayerPrefs.DeleteKey("ShootScaleY");
            PlayerPrefs.DeleteKey("ReloadScaleX");
            PlayerPrefs.DeleteKey("ReloadScaleY");
            PlayerPrefs.DeleteKey("AimScaleX");
            PlayerPrefs.DeleteKey("AimScaleY");
            PlayerPrefs.DeleteKey("JumpScaleX");
            PlayerPrefs.DeleteKey("JumpScaleY");

            PlayerPrefs.DeleteKey("CrouchScaleX");
            PlayerPrefs.DeleteKey("CrouchScaleY");
            PlayerPrefs.DeleteKey("ProneScaleX");
            PlayerPrefs.DeleteKey("ProneScaleY");
            PlayerPrefs.DeleteKey("GrenadeScaleX");
            PlayerPrefs.DeleteKey("GrenadeScaleX");
            PlayerPrefs.DeleteKey("ShootX");
            PlayerPrefs.DeleteKey("ShootY");
            PlayerPrefs.DeleteKey("ShootZ");
            PlayerPrefs.DeleteKey("ReloadX");
            PlayerPrefs.DeleteKey("ReloadY");
            PlayerPrefs.DeleteKey("ReloadZ");
            PlayerPrefs.DeleteKey("AimX");
            PlayerPrefs.DeleteKey("AimY");
            PlayerPrefs.DeleteKey("AimZ");
            PlayerPrefs.DeleteKey("JumpX");
            PlayerPrefs.DeleteKey("JumpY");
            PlayerPrefs.DeleteKey("JumpZ");

            PlayerPrefs.DeleteKey("CrouchX");
            PlayerPrefs.DeleteKey("CrouchY");
            PlayerPrefs.DeleteKey("CrouchZ");
            PlayerPrefs.DeleteKey("ProneX");
            PlayerPrefs.DeleteKey("ProneY");
            PlayerPrefs.DeleteKey("ProneZ");
            PlayerPrefs.DeleteKey("GrenadeX");
            PlayerPrefs.DeleteKey("GrenadeY");
            PlayerPrefs.DeleteKey("GrenadeZ");
        }
        if (PlayerPrefs.HasKey("ShootScaleX") && PlayerPrefs.HasKey("ShootScaleY"))
        {
            ShootButton.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(PlayerPrefs.GetFloat("ShootScaleX"), PlayerPrefs.GetFloat("ShootScaleY"));
        }

        if (PlayerPrefs.HasKey("ReloadScaleX") && PlayerPrefs.HasKey("ReloadScaleY"))
        {
            ReloadButton.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(PlayerPrefs.GetFloat("ReloadScaleX"), PlayerPrefs.GetFloat("ReloadScaleY"));
        }

        if (PlayerPrefs.HasKey("AimScaleX") && PlayerPrefs.HasKey("AimScaleY"))
        {
            AimButton.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(PlayerPrefs.GetFloat("AimScaleX"), PlayerPrefs.GetFloat("AimScaleY"));
        }

        if (PlayerPrefs.HasKey("JumpScaleX") && PlayerPrefs.HasKey("JumpScaleY"))
        {
            JumpButton.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(PlayerPrefs.GetFloat("JumpScaleX"), PlayerPrefs.GetFloat("JumpScaleY"));
        }

        if (PlayerPrefs.HasKey("CrouchScaleX") && PlayerPrefs.HasKey("CrouchScaleY") && PlayerPrefs.HasKey("CrouchScaleZ"))
        {
            CrouchButton.transform.position = new Vector3(PlayerPrefs.GetFloat("CrouchScaleX"), PlayerPrefs.GetFloat("CrouchScaleY"), PlayerPrefs.GetFloat("CrouchScaleZ"));
        }
        if (PlayerPrefs.HasKey("ProneScaleX") && PlayerPrefs.HasKey("ProneScaleY") && PlayerPrefs.HasKey("ProneScaleZ"))
        {
            ProneButton.transform.position = new Vector3(PlayerPrefs.GetFloat("ProneScaleX"), PlayerPrefs.GetFloat("ProneScaleY"), PlayerPrefs.GetFloat("ProneScaleZ"));
        }

        if (PlayerPrefs.HasKey("GrenadeScaleX") && PlayerPrefs.HasKey("GrenadeScaleY"))
        {
            GrenadeButton.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(PlayerPrefs.GetFloat("GrenadeScaleX"), PlayerPrefs.GetFloat("GrenadeScaleY"));
        }

        if (PlayerPrefs.HasKey("ShootX") && PlayerPrefs.HasKey("ShootY") && PlayerPrefs.HasKey("ShootZ"))
        {
            ShootButton.transform.position = new Vector3(PlayerPrefs.GetFloat("ShootX"), PlayerPrefs.GetFloat("ShootY"), PlayerPrefs.GetFloat("ShootZ"));
        }
        if (PlayerPrefs.HasKey("ReloadX") && PlayerPrefs.HasKey("ReloadY") && PlayerPrefs.HasKey("ReloadZ"))
        {
            ReloadButton.transform.position = new Vector3(PlayerPrefs.GetFloat("ReloadX"), PlayerPrefs.GetFloat("ReloadY"), PlayerPrefs.GetFloat("ReloadZ"));
        }
        if (PlayerPrefs.HasKey("AimX") && PlayerPrefs.HasKey("AimY") && PlayerPrefs.HasKey("AimZ"))
        {
            AimButton.transform.position = new Vector3(PlayerPrefs.GetFloat("AimX"), PlayerPrefs.GetFloat("AimY"), PlayerPrefs.GetFloat("AimZ"));
        }
        if (PlayerPrefs.HasKey("JumpX") && PlayerPrefs.HasKey("JumpY") && PlayerPrefs.HasKey("JumpZ"))
        {
            JumpButton.transform.position = new Vector3(PlayerPrefs.GetFloat("JumpX"), PlayerPrefs.GetFloat("JumpY"), PlayerPrefs.GetFloat("JumpZ"));
        }

        if (PlayerPrefs.HasKey("CrouchX") && PlayerPrefs.HasKey("CrouchY") && PlayerPrefs.HasKey("CrouchZ"))
        {
            CrouchButton.transform.position = new Vector3(PlayerPrefs.GetFloat("CrouchX"), PlayerPrefs.GetFloat("CrouchY"), PlayerPrefs.GetFloat("CrouchZ"));
        }
        if (PlayerPrefs.HasKey("ProneX") && PlayerPrefs.HasKey("ProneY") && PlayerPrefs.HasKey("ProneZ"))
        {
            ProneButton.transform.position = new Vector3(PlayerPrefs.GetFloat("ProneX"), PlayerPrefs.GetFloat("ProneY"), PlayerPrefs.GetFloat("ProneZ"));
        }
        if (PlayerPrefs.HasKey("GrenadeX") && PlayerPrefs.HasKey("GrenadeY") && PlayerPrefs.HasKey("GrenadeZ"))
        {
            GrenadeButton.transform.position = new Vector3(PlayerPrefs.GetFloat("GrenadeX"), PlayerPrefs.GetFloat("GrenadeY"), PlayerPrefs.GetFloat("GrenadeZ"));
        }
    }

    public void Save()
    {

        PlayerPrefs.SetFloat("ShootScaleX", ShootButton.transform.GetComponent<RectTransform>().sizeDelta.x);
        PlayerPrefs.SetFloat("ShootScaleY", ShootButton.transform.GetComponent<RectTransform>().sizeDelta.y);

        PlayerPrefs.SetFloat("ReloadScaleX", ReloadButton.transform.GetComponent<RectTransform>().sizeDelta.x);
        PlayerPrefs.SetFloat("ReloadScaleY", ReloadButton.transform.GetComponent<RectTransform>().sizeDelta.y);

        PlayerPrefs.SetFloat("AimScaleX", AimButton.transform.GetComponent<RectTransform>().sizeDelta.x);
        PlayerPrefs.SetFloat("AimScaleY", AimButton.transform.GetComponent<RectTransform>().sizeDelta.y);

        PlayerPrefs.SetFloat("JumpScaleX", JumpButton.transform.GetComponent<RectTransform>().sizeDelta.x);
        PlayerPrefs.SetFloat("JumpScaleY", JumpButton.transform.GetComponent<RectTransform>().sizeDelta.y);

        PlayerPrefs.SetFloat("CrouchScaleX", CrouchButton.transform.GetComponent<RectTransform>().sizeDelta.x);
        PlayerPrefs.SetFloat("CrouchScaleY", CrouchButton.transform.GetComponent<RectTransform>().sizeDelta.y);

        PlayerPrefs.SetFloat("ProneScaleX", ProneButton.transform.GetComponent<RectTransform>().sizeDelta.x);
        PlayerPrefs.SetFloat("ProneScaleY", ProneButton.transform.GetComponent<RectTransform>().sizeDelta.y);

        PlayerPrefs.SetFloat("GrenadeScaleX", GrenadeButton.transform.GetComponent<RectTransform>().sizeDelta.x);
        PlayerPrefs.SetFloat("GrenadeScaleY", GrenadeButton.transform.GetComponent<RectTransform>().sizeDelta.y);

        PlayerPrefs.SetFloat("ShootX", ShootButton.transform.position.x);
        PlayerPrefs.SetFloat("ShootY", ShootButton.transform.position.y);
        PlayerPrefs.SetFloat("ShootZ", ShootButton.transform.position.z);

        PlayerPrefs.SetFloat("ReloadX", ReloadButton.transform.position.x);
        PlayerPrefs.SetFloat("ReloadY", ReloadButton.transform.position.y);
        PlayerPrefs.SetFloat("ReloadZ", ReloadButton.transform.position.z);

        PlayerPrefs.SetFloat("AimX", AimButton.transform.position.x);
        PlayerPrefs.SetFloat("AimY", AimButton.transform.position.y);
        PlayerPrefs.SetFloat("AimZ", AimButton.transform.position.z);

        PlayerPrefs.SetFloat("JumpX", JumpButton.transform.position.x);
        PlayerPrefs.SetFloat("JumpY", JumpButton.transform.position.y);
        PlayerPrefs.SetFloat("JumpZ", JumpButton.transform.position.z);

        PlayerPrefs.SetFloat("CrouchX", CrouchButton.transform.position.x);
        PlayerPrefs.SetFloat("CrouchY", CrouchButton.transform.position.y);
        PlayerPrefs.SetFloat("CrouchZ", CrouchButton.transform.position.z);

        PlayerPrefs.SetFloat("ProneX", ProneButton.transform.position.x);
        PlayerPrefs.SetFloat("ProneY", ProneButton.transform.position.y);
        PlayerPrefs.SetFloat("ProneZ", ProneButton.transform.position.z);

        PlayerPrefs.SetFloat("GrenadeX", GrenadeButton.transform.position.x);
        PlayerPrefs.SetFloat("GrenadeY", GrenadeButton.transform.position.y);
        PlayerPrefs.SetFloat("GrenadeZ", GrenadeButton.transform.position.z);

        ControlsSettingsPanel.gameObject.SetActive(false);
    }
}
