using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoShoot : NetworkBehaviour
{
    public bool IsAK47U = true;
    public bool IsSniper = false;
    public bool IsPistol = false;

    Vector3 fireDirection;
    Vector3 firePoint;
    public Image crosshair;
    public bool autoshoot = false;

    void Start()
    {

        crosshair = GameObject.FindGameObjectWithTag("CrossHair").GetComponent<Image>();

    }

    void Update()
    {

        if (autoshoot == true)
        {

            Hit();
        }
        else if (autoshoot == false)
        {

            ChangeColor(Color.white);
        }
    }
    void Hit()
    {

        RaycastHit hit;
        fireDirection = transform.TransformDirection(Vector3.forward) * 10;
        firePoint = transform.position;

        if (Physics.Raycast(firePoint, (fireDirection), out hit, 100.0f))
        {

            if (hit.transform.tag == "Player")
            {
                ChangeColor(Color.green);
            }
            else if (hit.transform.tag == "Enemy")
            {
                ChangeColor(Color.red);
                if (IsAK47U == true)
                {

                }
                else if (IsSniper == true)
                {

                }
                else if (IsPistol == true)
                {

                }
            }

        }
        else
        {
            ChangeColor(Color.white);
            if (IsAK47U == true)
            {

            }
            else if (IsSniper == true)
            {

            }
            else if (IsPistol == true)
            {

            }
        }

        Debug.DrawRay(firePoint, fireDirection, Color.green);
    }
    public void ChangeColor(Color color)
    {
        crosshair.color = color;
    }
}
