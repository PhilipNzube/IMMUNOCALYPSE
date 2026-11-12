using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : NetworkBehaviour
{
    public Rigidbody rbody;
    public float lifeTime;
    public GameObject[] EnemyGO;
    public GameObject[] QueenEnemyGO;
    public ParticleSystem SandyBulletHolePrefab;
    public ParticleSystem ConcreteBulletHolePrefab;
    public ParticleSystem MetallicBulletHolePrefab;
    public ParticleSystem WoodenBulletHolePrefab;
    public ParticleSystem ImpactPrefab;
    public GameObject ImpactPoint;
    public Collider BulCol;
    public Vector3 PlayerGO;

    void Start()
    {
        EnemyGO = GameObject.FindGameObjectsWithTag("Enemy");

        QueenEnemyGO = GameObject.FindGameObjectsWithTag("Spider");

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MetalObstacle")
        {
            SpawnBulletHoles1();
            if (hasAuthority == true)
            {
                if (isServer)
                {
                    RpcSpawnBulletHoles1();
                }
                else if (isClient)
                {
                    CmdSpawnBulletHoles1();
                }
            }
        }
        else if (other.gameObject.tag == "ConcreteGround")
        {
            SpawnBulletHoles2();
            if (hasAuthority == true)
            {
                if (isServer)
                {
                    RpcSpawnBulletHoles2();
                }
                else if (isClient)
                {
                    CmdSpawnBulletHoles2();
                }
            }
        }
        else if (other.gameObject.tag == "ConcreteObstacle")
        {
            SpawnBulletHoles3();
            if (hasAuthority == true)
            {
                if (isServer)
                {

                    RpcSpawnBulletHoles3();
                }
                else if (isClient)
                {
                    CmdSpawnBulletHoles3();
                }
            }
        }
        else if (other.gameObject.tag == "Trees")
        {
            SpawnBulletHoles4();
            if (hasAuthority == true)
            {
                if (isServer)
                {
                    RpcSpawnBulletHoles4();
                }
                else if (isClient)
                {
                    CmdSpawnBulletHoles4();
                }
            }
        }
        else if (other.gameObject.tag == "GPD")
        {
            SpawnBulletHoles5();
            if (hasAuthority == true)
            {
                if (isServer)
                {
                    RpcSpawnBulletHoles5();
                }
                else if (isClient)
                {
                    CmdSpawnBulletHoles5();
                }
            }
        }
        else if (other.gameObject.tag == "Enemy")
        {
            Deactivate();
            if (hasAuthority == true)
            {
                if (isServer)
                {
                    RpcSpawnBulletDeactivate();
                }
                else if (isClient)
                {
                    CmdSpawnBulletDeactivate();
                }
            }
        }
    }
    [Command]
    public void CmdSpawnBulletHoles1()
    {
        RpcSpawnBulletHoles1();
    }
    [Command]
    public void CmdSpawnBulletHoles2()
    {
        RpcSpawnBulletHoles2();
    }
    [Command]
    public void CmdSpawnBulletHoles3()
    {
        RpcSpawnBulletHoles3();
    }
    [Command]
    public void CmdSpawnBulletHoles4()
    {
        RpcSpawnBulletHoles4();
    }
    [Command]
    public void CmdSpawnBulletHoles5()
    {
        RpcSpawnBulletHoles5();
    }

    [Command]
    public void CmdSpawnBulletDeactivate()
    {
        RpcSpawnBulletDeactivate();
    }

    [ClientRpc]
    public void RpcSpawnBulletHoles1()
    {

        Instantiate(MetallicBulletHolePrefab,
            ImpactPoint.transform.position,
            ImpactPoint.transform.rotation);
        Deactivate();
    }
    [ClientRpc]
    public void RpcSpawnBulletHoles2()
    {
        Instantiate(ConcreteBulletHolePrefab,
            ImpactPoint.transform.position,
            ImpactPoint.transform.rotation);
        Deactivate();
    }
    [ClientRpc]
    public void RpcSpawnBulletHoles3()
    {
        Instantiate(ConcreteBulletHolePrefab,
            ImpactPoint.transform.position,
            ImpactPoint.transform.rotation);
        Deactivate();
    }
    [ClientRpc]
    public void RpcSpawnBulletHoles4()
    {
        Instantiate(WoodenBulletHolePrefab,
            ImpactPoint.transform.position,
            ImpactPoint.transform.rotation);
        Deactivate();
    }
    [ClientRpc]
    public void RpcSpawnBulletHoles5()
    {
        Instantiate(WoodenBulletHolePrefab,
            ImpactPoint.transform.position,
            ImpactPoint.transform.rotation);
        Deactivate();
    }

    [ClientRpc]
    public void RpcSpawnBulletDeactivate()
    {
        Deactivate();
    }

    public void SpawnBulletHoles1()
    {

        Instantiate(MetallicBulletHolePrefab,
            ImpactPoint.transform.position,
            ImpactPoint.transform.rotation);
        Deactivate();
    }

    public void SpawnBulletHoles2()
    {
        Instantiate(ConcreteBulletHolePrefab,
            ImpactPoint.transform.position,
            ImpactPoint.transform.rotation);
        Deactivate();
    }

    public void SpawnBulletHoles3()
    {
        Instantiate(ConcreteBulletHolePrefab,
            ImpactPoint.transform.position,
            ImpactPoint.transform.rotation);
        Deactivate();
    }

    public void SpawnBulletHoles4()
    {
        Instantiate(WoodenBulletHolePrefab,
            ImpactPoint.transform.position,
            ImpactPoint.transform.rotation);
        Deactivate();
    }
    public void SpawnBulletHoles5()
    {
        Instantiate(WoodenBulletHolePrefab,
            ImpactPoint.transform.position,
            ImpactPoint.transform.rotation);
        Deactivate();
    }
    public void Activate(Vector3 position, Vector3 velocity, Vector3 playerpos)
    {
        PlayerGO = playerpos;
        transform.position = position;
        rbody.velocity = velocity;
        gameObject.SetActive(true);
        StartCoroutine("Decay");
    }
    private IEnumerator Decay()
    {
        yield return new WaitForSeconds(lifeTime);
        Deactivate();
    }
    public void Deactivate()
    {

        BulletPool.main.AddToPool(this);
        StopAllCoroutines();
        this.gameObject.SetActive(false);

    }

    void Update()
    {

    }
}
