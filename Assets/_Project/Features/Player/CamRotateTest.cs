using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotateTest : MonoBehaviour
{
    private Quaternion from;
    private Quaternion to;
    private float t;
    public bool Die = false;

    void Start()
    {
        from = Quaternion.Euler(0, 0, 0);
        to = Quaternion.Euler(0, 0, 90);
    }

    void Update()
    {
        if (Die == true)
        {
            if (t < 1.0f)
            {
                t += Time.deltaTime;
                transform.rotation = Quaternion.Slerp(from, to, t);
            }
        }
    }
}
