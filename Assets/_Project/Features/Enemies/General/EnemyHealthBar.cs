using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{

    public Text Compass;
    public RectTransform WayPointPrefab;
    private RectTransform WayPoint;
    public GameObject Player;
    public Vector3 OffSet = new Vector3(0, 10.0f, 0);
    public bool Disable = true;
    public Transform WPC;
    public Vector3 SP;

    public Slider Health;
    public EnemyHealth EH;

    void Update()
    {
        if (Player == null)
        {
            var WayPointCanvas = GameObject.Find("CompassCanvas").transform;
            WPC = WayPointCanvas;
            Player = GameObject.FindGameObjectWithTag("Player");
            WayPoint = Instantiate(WayPointPrefab, WayPointCanvas);

            Health = WayPoint.GetComponentInChildren<Slider>();
        }
        Health.value = EH.Health;
        var ScreenPos = Camera.main.WorldToScreenPoint(transform.position + OffSet);
        SP = ScreenPos;

        if (Mathf.Approximately(ScreenPos.z, 0))
        {
            return;
        }
        Vector3 halfScreen = new Vector3(Screen.width, Screen.height) / 2;
        Vector3 screenPosNoZ = ScreenPos;
        screenPosNoZ.z = 0;
        Vector3 screenCenterPos = screenPosNoZ - halfScreen;

        if (ScreenPos.z < 0)
        {
            screenCenterPos *= -1;
        }
        if (ScreenPos.z < 0 || ScreenPos.x > Screen.width || ScreenPos.x < 0 || ScreenPos.y > Screen.height || ScreenPos.y < 0)
        {

            Vector3 norSCP = screenCenterPos.normalized;
            if (norSCP.x == 0)
            {
                norSCP.x = 0.01f;
            }
            if (norSCP.y == 0)
            {
                norSCP.y = 0.01f;
            }
            Vector3 xScreenCP = norSCP * (halfScreen.x / Mathf.Abs(norSCP.x));
            Vector3 yScreenCP = norSCP * (halfScreen.y / Mathf.Abs(norSCP.y));
            if (xScreenCP.sqrMagnitude < yScreenCP.sqrMagnitude)
            {
                ScreenPos = halfScreen + xScreenCP;
            }
            else
            {
                ScreenPos = halfScreen + yScreenCP;
            }
        }
        else
        {

        }
        float margin = 70;
        ScreenPos.z = 0;
        ScreenPos.x = Mathf.Clamp(ScreenPos.x, margin, Screen.width - margin);
        ScreenPos.y = Mathf.Clamp(ScreenPos.y, margin, Screen.height - margin);
        WayPoint.position = ScreenPos;
        if (Disable == true)
        {
            WayPoint.gameObject.SetActive(false);
        }
        else
        {
            WayPoint.gameObject.SetActive(true);
        }

    }
}
