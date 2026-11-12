using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBoxScript : NetworkBehaviour
{

    public bool IsAK47UActive = false;
    public bool IsAK47Active = false;
    public bool IsPistolActive = false;
    public bool IsSniperActive = false;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

        }
    }
}
