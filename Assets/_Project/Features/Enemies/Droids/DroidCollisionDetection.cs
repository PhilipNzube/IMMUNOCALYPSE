using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DroidCollisionDetection : MonoBehaviour
{
    public PlayerHealth PH;
    public Animator anim;
    public GameObject[] EnemyGO;
    public DroidPlayerHealth DPH;
    public Text ReviveDroidText;
    public bool EnemyAlive = true;
    public bool SpiderAlive = true;

    void Start()
    {
        DPH = GetComponent<DroidPlayerHealth>();
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyHands")
        {
            if (EnemyAlive == true)
            {
                DPH.TakeDamage(2.0f);
            }
        }
        else if (other.gameObject.tag == "SpiderLegs")
        {
            if (SpiderAlive == true)
            {
                DPH.TakeDamage(20.0f);
            }
        }
    }

    public void EAttack()
    {
        foreach (GameObject Enemy in EnemyGO)
        {
            anim.SetBool("Run", false);
            anim.SetBool("Attack", true);
        }
    }

}
