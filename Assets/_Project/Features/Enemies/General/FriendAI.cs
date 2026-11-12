using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class FriendAI : MonoBehaviour
{
    public GameObject[] Enemy;
    public GameObject Player;
    public GameObject HeliGO;
    Vector3 destination;
    public NavMeshAgent agent;
    public bool Chase = false;
    public Animator anim;
    public bool Captain = false;
    public typewriter2 TW2;
    public AK74UFlashBulletCaseSpawnScript AK74UFlash;
    public GameObject AK74UFlashGO;
    public Vector3 PlayerVelocity;
    public bool groundedPlayer;
    public float gravityValue = -9.8f;
    public CharacterController CC;
    public bool AlreadyCollided = false;
    public MiniMapComponent MMC;
    public PlayerCompass2 PC2;
    public bool STOP = false;
    public PlayerHealth PH;
    public GameObject FriendGO;

    void Start()
    {
        destination = agent.destination;
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        Player = GameObject.FindGameObjectWithTag("Player");
        HeliGO = GameObject.FindGameObjectWithTag("HELI");
        PH = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        TW2 = GameObject.FindGameObjectWithTag("Player").GetComponent<typewriter2>();

        AK74UFlash = AK74UFlashGO.GetComponent<AK74UFlashBulletCaseSpawnScript>();
        MMC = GetComponent<MiniMapComponent>();

    }

    void Update()
    {
        if (Captain == false)
        {
            anim.SetBool("Run", true);
            destination = HeliGO.transform.position;

            agent.SetDestination(destination);
        }
        else if (Captain == true)
        {
            if (STOP == false)
            {
                anim.SetBool("Walk", true);
                destination = Player.transform.position;

                agent.SetDestination(destination);
            }
            else if (STOP == true)
            {
                anim.SetBool("Walk", false);
                anim.SetBool("Idle", true);
            }
        }
        if (Vector3.Distance(destination, Player.transform.position) < 15f)
        {
            if (STOP == true)
            {
                anim.SetBool("Walk", false);
                anim.SetBool("Idle", true);
                anim.SetBool("Run", false);
            }
        }

    }

    IEnumerator MMCDisable()
    {
        FriendGO.gameObject.SetActive(false);
        yield return new WaitForSeconds(50f);
        MMC.enabled = false;
        yield return new WaitForSeconds(5f);
        Destroy(FriendGO);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "body")
        {
            if (AlreadyCollided == false)
            {
                if (Captain == true)
                {
                    STOP = true;
                    MMC.enabled = false;
                    anim.SetBool("Idle", true);
                    if (!PlayerPrefs.HasKey("CurrentLevel"))
                    {
                        TW2.PS3();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 3)
                    {
                        TW2.PS3();
                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 4)
                    {

                    }
                    else if (PlayerPrefs.GetInt("CurrentLevel") == 5)
                    {
                        TW2.PS8();
                    }
                    PH.RemoveGUIS();
                    PH.DontPlay = false;
                }
            }
        }
        else if (other.gameObject.tag == "HELIBODY")
        {
            FriendGO.gameObject.SetActive(false);
        }
    }

}
