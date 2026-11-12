using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WeaponRotateScript : MonoBehaviour
{
    public Camera cam;
    public Quaternion defaultAvatarRotation;
    public float slowSpeedRotation = 0.03f;
    public float speedRotation = 0.03f;
    public const string AVATAR_TAG = "AK47UAssultRifle";
    public bool isRotating = false;
    public RaycastHit hit;
    public bool UNITYEDITOR = true;

    void Awake()
    {
        Camera[] cameraList = FindObjectsOfType(typeof(Camera)) as Camera[];
        foreach (Camera camObj in cameraList)
        {
            if (camObj && camObj.tag == "Untagged")
            {
                cam = camObj;
            }
        }
        defaultAvatarRotation.y = 180.0f;
    }

    void Start()
    {

    }

    void Update()
    {
        MouseButtonDown();
        MouseButtonUp();

        if (Input.GetMouseButton(0) && isRotating)
        {
            RaycastHit dragingHit;
            if (UNITYEDITOR == true)
            {
                Debug.Log("RotatingWeaponScriptOn");
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out dragingHit) && dragingHit.collider.gameObject == hit.collider.gameObject)
                {
                    if (hit.collider.tag == AVATAR_TAG && transform == hit.collider.transform)
                    {
                        if (UNITYEDITOR == true)
                        {
                            float x = -Input.GetAxis("MouseX");
                            transform.rotation *= Quaternion.AngleAxis(x * speedRotation, Vector3.up);
                        }
                        else if (UNITYEDITOR == false)
                        {
                            float x = -Input.touches[0].deltaPosition.x;
                            transform.rotation *= Quaternion.AngleAxis(x * speedRotation, Vector3.up);
                        }
                    }
                }
            }
            else if (UNITYEDITOR == false)
            {
                Ray ray = cam.ScreenPointToRay(Input.touches[0].position);
                if (Physics.Raycast(ray, out dragingHit) && dragingHit.collider.gameObject == hit.collider.gameObject)
                {
                    if (hit.collider.tag == AVATAR_TAG && transform == hit.collider.transform)
                    {
                        if (UNITYEDITOR == true)
                        {
                            float x = -Input.GetAxis("MouseX");
                            transform.rotation *= Quaternion.AngleAxis(x * speedRotation, Vector3.up);
                        }
                        else if (UNITYEDITOR == false)
                        {
                            float x = -Input.touches[0].deltaPosition.x;
                            transform.rotation *= Quaternion.AngleAxis(x * speedRotation, Vector3.up);
                        }
                    }
                }
            }
        }
        else
        {
            if (transform.rotation.y != defaultAvatarRotation.y)
            {
                SlowRotation();
            }
        }
    }
    public void MouseButtonDown()
    {
        if (Input.GetMouseButton(0))
        {
            if (UNITYEDITOR == true)
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.tag == AVATAR_TAG && transform == hit.collider.transform)
                    {
                        Debug.Log("RotatingWeapon");
                        isRotating = true;
                    }
                }
            }
            else if (UNITYEDITOR == false)
            {
                Ray ray = cam.ScreenPointToRay(Input.touches[0].position);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.tag == AVATAR_TAG && transform == hit.collider.transform)
                    {
                        isRotating = true;
                    }
                }
            }
        }
    }
    public void MouseButtonUp()
    {
        if (Input.GetMouseButton(0))
        {
            isRotating = false;
            hit = new RaycastHit();
        }
    }
    public void SlowRotation()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, defaultAvatarRotation, slowSpeedRotation * Time.deltaTime);
    }
}
