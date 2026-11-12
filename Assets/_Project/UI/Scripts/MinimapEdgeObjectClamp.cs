using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapEdgeObjectClamp : MonoBehaviour
{
    public Transform MinimapCam;
    public float MinimapSize = 10.0f;
    public float Offsets = 10.0f;
    public GameObject MyEnemy;
    Vector3 TempV3;
    public bool Search = true;
    void Update()
    {
        if (Vector3.Distance(MinimapCam.position, transform.position) > 70.0f)
        {
            Vector3 targetPos = new Vector3(MyEnemy.transform.position.x, MyEnemy.transform.position.y, Offsets + (MinimapCam.transform.position.z));
            Vector3 targetPos2 = transform.position - MinimapCam.position;
            transform.position = targetPos;
        }
        else if (Vector3.Distance(MinimapCam.position, MyEnemy.transform.position) < 70.0f)
        {
            transform.position = MyEnemy.transform.position;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyHands")
        {
            Search = false;
            transform.position = MyEnemy.transform.position;
        }
    }

}

