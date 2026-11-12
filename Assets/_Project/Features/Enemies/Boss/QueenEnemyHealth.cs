using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenEnemyHealth : MonoBehaviour
{
    public QueenEnemyChaseScript QECS;
    public float Health = 20.0f;
    public Animator anim;
    public UnityEngine.AI.NavMeshAgent agent;
    public QueenDropDeadWaveDetection QDDWD;
    public ReverseTest RT;
    public PlayerControllers PLC;
    public PlayerCollision PCL;
    public DroidCollisionDetection DCD;
    public int No = 0;
    public AudioSource SpiderDeath;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Die();
        }

    }
    public void Die()
    {
        SpiderDeath.Play();
        DCD.SpiderAlive = false;
        PCL.SpiderAlive = false;
        RT.StopR();
        RT.speed = 0;
        agent.enabled = false;
        anim.SetBool("Die", true);

        No++;
        if (No == 1)
        {

        }
        Destroy(gameObject, 6.0f);

    }
}
