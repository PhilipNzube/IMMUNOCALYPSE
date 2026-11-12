using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenHeadShot : MonoBehaviour
{
    public QueenEnemyHealth QEH;
    public QueenEnemyChaseScript QECS;
    public Bullet Bullet;
    public SniperBullet sniperBullet;
    public AK47Bullet akBullet;
    public PistolBullet pistolBullet;
    public Animator anim;
    public ReverseTest RT;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Bullet.Deactivate();
            Debug.Log("Bullet Collided with queenenemyHead collider");
            QEH.TakeDamage(1.0f);
            RT.Shotbackwards();
        }
        else if (col.gameObject.tag == "SniperBullet")
        {
            sniperBullet.Deactivate();
            Debug.Log("SniperBullet Collided with queenenemyHead collider");
            QEH.TakeDamage(10.0f);
            RT.Shotbackwards();
        }
        else if (col.gameObject.tag == "AK47Bullet")
        {
            akBullet.Deactivate();
            Debug.Log("AK47Bullet Collided with queenenemyHead collider");
            QEH.TakeDamage(2.0f);
            RT.Shotbackwards();
        }
        else if (col.gameObject.tag == "PistolBullet")
        {
            pistolBullet.Deactivate();
            Debug.Log("PistolBullet Collided with queenenemyHead collider");
            QEH.TakeDamage(5.0f);
            RT.Shotbackwards();

        }
    }

    void Update()
    {

    }
}
