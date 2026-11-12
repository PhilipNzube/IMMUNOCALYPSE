using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseTest : MonoBehaviour
{
    public float speed = 3.0f;
    public UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {

    }
    public void Shotbackwards()
    {

        StartCoroutine("ShootReverseMove");

    }
    public void backwards()
    {

        StartCoroutine("ReverseMove");

    }
    public void StopR()
    {
        StopAllCoroutines();
    }
    IEnumerator ReverseMove()
    {

        yield return new WaitForSeconds(3.0f);

        gameObject.transform.Translate(Vector3.back * Time.deltaTime * speed, Space.World);
        yield return new WaitForSeconds(3.0f);
        agent.speed = 10;
    }

    IEnumerator ShootReverseMove()
    {

        yield return new WaitForSeconds(8.0f);

        gameObject.transform.Translate(Vector3.back * Time.deltaTime * speed, Space.World);
        yield return new WaitForSeconds(3.0f);
        agent.speed = 10;
    }

}
