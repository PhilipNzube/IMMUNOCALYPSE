using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDistanceController : MonoBehaviour
{
    public PlayerHealth PH;
    public GameObject Player;

    void Start()
    {

    }

    void Update()
    {
        if (Vector3.Distance(this.transform.position, Player.transform.position) > 200.0f)
        {

        }
    }
}
