using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenEnemyCollisionDetection : MonoBehaviour
{
    public QueenEnemyHealth QEH;
    public QueenEnemyChaseScript QECS;
    public Bullet Bullet;
    public SniperBullet sniperBullet;
    public AK47Bullet akBullet;
    public PistolBullet pistolBullet;

    void Start()
    {
        QEH = GetComponent<QueenEnemyHealth>();
        QECS = GetComponent<QueenEnemyChaseScript>();

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Bullet.Deactivate();
            Debug.Log("Bullet Collided with Queenenemy collider");
            QEH.TakeDamage(.5f);
        }
        else if (other.gameObject.tag == "SniperBullet")
        {
            sniperBullet.Deactivate();
            Debug.Log("SniperBullet Collided with Queenenemy collider");
            QEH.TakeDamage(5.0f);
        }
        else if (other.gameObject.tag == "AK47Bullet")
        {
            akBullet.Deactivate();
            Debug.Log("AK47Bullet Collided with Queenenemy collider");
            QEH.TakeDamage(.8f);
        }
        else if (other.gameObject.tag == "PistolBullet")
        {
            pistolBullet.Deactivate();
            Debug.Log("PistolBullet Collided with Queenenemy collider");
            QEH.TakeDamage(2.0f);
        }
        else if (other.gameObject.tag == "Player2")
        {
            Debug.Log("QueenEnemy Collided with Droid collider");
            QEH.TakeDamage(.1f);
        }
    }

    void Update()
    {

    }
}
