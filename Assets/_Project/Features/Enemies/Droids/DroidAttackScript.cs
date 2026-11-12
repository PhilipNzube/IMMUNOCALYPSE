using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class DroidAttackScript : MonoBehaviour
{
    public GameObject[] Enemies;
    Vector3 destination;
    public NavMeshAgent agent;
    public Animator anim;
    public DroidReverseTest DRT;
    public AudioSource MoveSound;

    void Start()
    {
        DRT = GetComponent<DroidReverseTest>();
        destination = agent.destination;
    }

    void Update()
    {
        foreach (GameObject EnemyGO in Enemies)
        {
            if (Vector3.Distance(destination, EnemyGO.transform.position) < 130.0f)
            {
                MoveSound.Play();
                destination = EnemyGO.transform.position;
                agent.destination = destination;
                anim.SetBool("Run", true);
                if (Vector3.Distance(destination, EnemyGO.transform.position) < 0.2f)
                {
                    DRT.backwards();
                }

            }
            else if (Vector3.Distance(destination, EnemyGO.transform.position) > 130.0f)
            {
                anim.SetBool("Idle", true);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        }
    }
    public void Disable()
    {
        agent.speed = 0;
        anim.SetBool("Attack", false);
        anim.SetBool("Run", false);
        anim.SetBool("Idle", true);
        StartCoroutine(End());
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(5.0f);
        agent.speed = 10;
    }
}
