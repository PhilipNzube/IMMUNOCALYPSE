using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Mirror.Scripts
{
    public class PlayerCollision : NetworkBehaviour
    {
        public PlayerHealth PH;
        public GameObject[] EnemyGO;
        public DroidPlayerHealth DPH;
        public Text ReviveDroidText;
        public Transform Player;
        public bool blink = false;
        public bool SpiderAlive = true;
        public bool EnemyAlive = true;
        public AudioSource PlayerHit;
        public bool PlayerAlive = true;
        public bool IsAK47UActive = false;
        public bool IsAK47Active = false;
        public bool IsPistolActive = false;
        public bool IsSniperActive = false;

        public GameObject SpawnedAK47UPoint;

        public Animator SWATAnimator;

        public bool LoadMission = false;

        void Start()
        {

            PH = GetComponent<PlayerHealth>();
            EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");
        }

        public override void OnStartAuthority()
        {
            SpawnedAK47UPoint = GameObject.FindGameObjectWithTag("AK47USpawnPoint");
        }

        void OnTriggerEnter(Collider other)
        {
            if (hasAuthority == true)
            {
                if (other.gameObject.tag == "EnemyHands")
                {
                    Debug.Log("Collided with enemy");
                    if (PlayerAlive == true)
                    {
                        PlayerHit.Play();
                    }

                    PH.TakeDamage(13.0f);
                }
                else if (other.gameObject.tag == "TiTanHands")
                {
                    Debug.Log("Collided with Boss collider");
                    if (PlayerAlive == true)
                    {
                        PlayerHit.Play();
                    }

                    PH.TakeDamage(25.0f);
                }
                else if (other.gameObject.tag == "SP")
                {
                    if (LoadMission == true)
                    {

                        Debug.Log("SpawnPointCollision");
                    }
                }
                else if (other.gameObject.tag == "fireball")
                {
                    PH.TakeDamage(25.0f);
                    Debug.Log("Fireball!!!");
                }
                else if (other.gameObject.tag == "fire")
                {
                    PH.TakeDamage(5.0f);
                    Debug.Log("Fire!!!");
                }
            }
        }

    }
}
