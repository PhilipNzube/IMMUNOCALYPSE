using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class QueenEnemyChaseScript : MonoBehaviour
{
    public GameObject Player;
    Vector3 destination;
    public NavMeshAgent agent;
    public bool Chase = true;
    public Animator anim;
    public QueenDropDeadWaveDetection QDDWD;
    public ReverseTest RT;
    public AudioSource Roar;

    void Start()
    {
        QDDWD = GameObject.FindWithTag("Player").GetComponent<QueenDropDeadWaveDetection>();
        RT = GetComponent<ReverseTest>();
        destination = agent.destination;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Chase == true)
        {

            if (Vector3.Distance(destination, Player.transform.position) < 75.0f)
            {
                Roar.Play();
                destination = Player.transform.position;
                agent.destination = destination;
                Debug.Log("Run");
                anim.SetBool("Run", true);
                if (Vector3.Distance(destination, Player.transform.position) < 0.2f)
                {
                    Debug.Log("RTBackwards");
                    RT.backwards();
                }

            }
            else if (Vector3.Distance(destination, Player.transform.position) > 75.0f)
            {
                Debug.Log("Idle");
                anim.SetBool("Idle", true);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            Debug.Log("Player Collided with Queenenemy collider");

        }
    }
    public void Disable()
    {
        Chase = false;
        agent.speed = 0;
        anim.SetBool("Attack", false);
        anim.SetBool("Run", false);
        anim.SetBool("Idle", true);
        StartCoroutine(End());
        Debug.Log("Disabled");
    }

    public void Death()
    {
        agent.enabled = false;
        anim.SetBool("Die", true);
        Destroy(gameObject, 6.0f);
        QDDWD.Die = false;

    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(5.0f);
        Chase = true;
        agent.speed = 10;

        Debug.Log("Ended");
    }
}
