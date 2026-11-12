using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using Mirror;

public class FlankScript : NetworkBehaviour
{
    public ParticleSystem explosionPrefab;
    public AudioSource impactSound;
    private float countDown;
    private bool hasExploded;
    public float Delay = 3f;
    public float GrenadeRadius = 5f;
    public float ExplosionForce = 5.0f;
    public float DamageRate = 90f;
    [Header("Throw Force")]
    [Tooltip("Minimum throw force")]
    public float minimumForce = 1500.0f;
    [Tooltip("Maximum throw force")]
    public float maximumForce = 2500.0f;
    private float throwForce;
    public AudioSource ExplodeSound;
    public GameObject[] enemies;
    public AudioSource thud;
    public GameObject[] PlayerGO;
    public int GK;
    public GameObject TitanGO;
    [Tooltip("Maximum stress the effect can inflict upon objects Range([0,1])")]
    public float MaximumStress = 0.6f;
    [Tooltip("Maximum distance in which objects are affected by this TraumaInducer")]
    public float Range = 45;

    private void Awake()
    {

        thud = GetComponent<AudioSource>();

        ExplodeSound = GameObject.FindGameObjectWithTag("FlankExplosion").GetComponent<AudioSource>();

        GetComponent<Rigidbody>().AddRelativeTorque
           (Random.Range(500, 1500),
            Random.Range(0, 0),
            Random.Range(0, 0)
            * Time.smoothDeltaTime * 5000);

    }

    private void Start()
    {

        EXPLODE();
    }

    public void EXPLODE()
    {
        Boom();
        if (hasAuthority == true)
        {
            if (isServer)
            {
                RpcBoom();
            }
            else if (isClient)
            {
                CmdBoom();
            }
        }
    }

    public void Boom()
    {
        StartCoroutine(GrenadeExplodeTimer());
    }

    [Command]
    public void CmdBoom()
    {
        RpcBoom();
    }

    [ClientRpc]
    public void RpcBoom()
    {
        if (hasAuthority == false)
        {
            StartCoroutine(GrenadeExplodeTimer());
        }
    }

    void OnCollisionEnter(Collision col)
    {
        thud.Play();
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject Enemies in enemies)
        {
            if (Vector3.Distance(Enemies.transform.position, transform.position) < 40.0f)
            {
                Enemies.GetComponent<EnemyChaseScript>().DodgeGrenade = true;
            }

        }
    }
    private IEnumerator GrenadeExplodeTimer()
    {
        yield return new WaitForSeconds(6.0f);
        PlayerGO = GameObject.FindGameObjectsWithTag("Player");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        ParticleSystem Explode = Instantiate(explosionPrefab, this.transform.position, explosionPrefab.transform.rotation);

        explosionPrefab.Play();
        ExplodeSound.Play();

        Collider[] colliders = Physics.OverlapSphere(transform.position, GrenadeRadius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                foreach (GameObject Player in PlayerGO)
                {
                    if (Vector3.Distance(Player.transform.position, transform.position) < 20.0f)
                    {
                        Player.GetComponent<PlayerHealth>().TakeDamage(30.0f);
                        Player.GetComponent<PlayerCollision>().PlayerHit.Play();
                        if (Player.GetComponent<PlayerHealth>().Health <= 0)
                        {
                            Player.GetComponent<Rigidbody>().AddExplosionForce(ExplosionForce, transform.position, GrenadeRadius, 1.0f);
                        }
                    }
                }
                foreach (GameObject Enemies in enemies)
                {
                    if (Vector3.Distance(Enemies.transform.position, transform.position) < 20.0f)
                    {
                        Enemies.GetComponent<EnemyHealth>().GK = true;
                        if (SceneManager.GetActiveScene().buildIndex == 29 || SceneManager.GetActiveScene().buildIndex == 30)
                        {
                            Enemies.GetComponent<EnemyHealth>().TakeDamage(50.0f);
                        }
                        else
                        {
                            Enemies.GetComponent<EnemyHealth>().TakeDamage(DamageRate);
                        }
                        if (Enemies.GetComponent<EnemyHealth>().Health <= 0)
                        {

                            Enemies.GetComponent<Rigidbody>().AddExplosionForce(ExplosionForce, transform.position, GrenadeRadius, 1.0f);
                        }

                    }

                }

            }

            Destroy(gameObject);
        }
    }
}
