using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyChaseScript : NetworkBehaviour
{
    public GameObject PlayerGO;
    Vector3 destination;
    public NavMeshAgent agent;
    public bool Chase = false;
    public Animator anim;
    public DropDeadWaveDetection DDWD;
    public PlayerControllers PC;
    public DroidCollisionDetection DCD;
    public PlayerCollision PLC;
    public int No = 0;
    public AudioSource Roar;
    public AudioSource IntenseMusic;
    public bool IsDead = false;
    public int IMusic = 0;
    public AudioSource music;
    public ParticleSystem RFire;
    public ParticleSystem LFire;
    public ParticleSystem HFire;
    public bool Lock = false;
    public bool Lockb = false;
    public bool BulletLock = true;
    public bool Jump;
    public float m_Thrust = 100f;
    public Rigidbody Rb;
    public float startWaitTime = 4;
    public float timeToRotate = 2;
    public float speedWalk = 6;
    public float speedRun = 9;

    public float viewRadius = 35;
    public float viewAngle = 90;
    public LayerMask playerMask;
    public LayerMask obstacleMask;
    public float meshResolution = 1f;
    public int edgeIterations = 4;
    public float edgeDistance = 0.5f;

    public GameObject[] waypoints;
    public int m_CurrentWaypointIndex;

    public Vector3 playerLastPosition = Vector3.zero;
    public Vector3 m_PlayerPosition;
    public Vector3 m_EnemyLastPosition;

    public float m_WaitTime;
    public float m_TimeToRotate;
    public bool m_PlayerInRange;
    public bool m_PlayerNear;
    public bool m_IsPatrol;
    public bool m_CaughtPlayer;

    Vector3 target;
    float DefaultStoppingDist;

    public bool DodgeGrenade;

    Vector3 targetGrenade;

    public GameObject[] waypointsGrenade;
    public int m_CurrentWaypointIndexGrenade;

    public bool MainBossEnemy;
    public bool RC;
    public bool PauseChaseAtTheBeginning;

    void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("Point");

        waypointsGrenade = GameObject.FindGameObjectsWithTag("PointGrenade");

        m_PlayerPosition = Vector3.zero;
        m_CaughtPlayer = false;
        m_PlayerInRange = false;
        m_WaitTime = startWaitTime;
        m_TimeToRotate = timeToRotate;

        m_CurrentWaypointIndex = 0;

        m_CurrentWaypointIndexGrenade = 0;

        agent.isStopped = false;
        agent.speed = speedWalk;
        if (MainBossEnemy == true)
        {

            anim.SetBool("Run", false);
            anim.SetBool("Attack", false);
            anim.SetBool("Idle", true);
        }
        else if (MainBossEnemy == false)
        {
            m_IsPatrol = true;
            UpdateDestination();

        }

        PlayerGO = GameObject.FindGameObjectWithTag("Player");
        Rb = GetComponent<Rigidbody>();
        DefaultStoppingDist = agent.stoppingDistance;

    }

    void Update()
    {

        if (hasAuthority == true)
        {
            if (Vector3.Distance(transform.position, PlayerGO.transform.position) > 15.5f)
            {
                m_CaughtPlayer = false;
            }

            if (MainBossEnemy == true)
            {
                if (Lock == false)
                {
                    EnvironmentView();
                }

                if (DodgeGrenade == true)
                {
                    if (IsDead == false)
                    {
                        Roar.Stop();
                        RFire.Stop();
                        LFire.Stop();
                        HFire.Stop();
                    }
                    Chase = false;
                    m_IsPatrol = false;
                    m_CaughtPlayer = false;
                    agent.stoppingDistance = 0;
                    UpdateDestinationGrenade();
                    StartCoroutine(DodgeTimeOut());
                    if (Vector3.Distance(transform.position, targetGrenade) < 10)
                    {
                        m_IsPatrol = true;
                        Chase = true;
                        IterateWaypointIndexGrenade();
                        DodgeGrenade = false;
                    }
                }

                if (!m_IsPatrol)
                {
                    if (Chase == true)
                    {
                        agent.stoppingDistance = DefaultStoppingDist;
                        Chasing();
                    }
                }
                else
                {
                    if (IsDead == false)
                    {
                        Roar.Stop();
                        RFire.Stop();
                        LFire.Stop();
                        HFire.Stop();
                    }
                    Lock = false;
                    m_CaughtPlayer = false;
                    agent.stoppingDistance = 0;
                    if (Vector3.Distance(transform.position, target) < 10)
                    {
                        IterateWaypointIndex();
                        UpdateDestination();
                    }
                }

            }
            else if (MainBossEnemy == false)
            {
                if (Lock == false)
                {
                    EnvironmentView();
                }

                if (DodgeGrenade == true)
                {
                    if (IsDead == false)
                    {
                        Roar.Stop();
                        RFire.Stop();
                        LFire.Stop();
                        HFire.Stop();
                    }
                    Chase = false;
                    m_IsPatrol = false;
                    m_CaughtPlayer = false;
                    agent.stoppingDistance = 0;
                    UpdateDestinationGrenade();
                    StartCoroutine(DodgeTimeOut());
                    if (Vector3.Distance(transform.position, targetGrenade) < 10)
                    {
                        m_IsPatrol = true;
                        Chase = true;
                        IterateWaypointIndexGrenade();
                        DodgeGrenade = false;
                    }
                }

                if (!m_IsPatrol)
                {
                    if (Chase == true)
                    {
                        agent.stoppingDistance = DefaultStoppingDist;
                        Chasing();
                    }
                }
                else
                {
                    if (IsDead == false)
                    {
                        Roar.Stop();
                        RFire.Stop();
                        LFire.Stop();
                        HFire.Stop();
                    }
                    Lock = false;
                    m_CaughtPlayer = false;
                    agent.stoppingDistance = 0;

                    if (Vector3.Distance(transform.position, target) < 10)
                    {
                        IterateWaypointIndex();
                        UpdateDestination();
                    }
                }

            }

        }
    }

    public void FalsefyCaughtPlayer()
    {
        StartCoroutine(FCP());
    }

    private IEnumerator FCP()
    {
        yield return new WaitForSeconds(1.0f);
        m_CaughtPlayer = false;
    }

    public void UpdateDestination()
    {
        anim.SetBool("Run", true);
        anim.SetBool("Idle", false);
        anim.SetBool("Attack", false);
        target = waypoints[m_CurrentWaypointIndex].transform.position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        m_CurrentWaypointIndex++;
        if (m_CurrentWaypointIndex == waypoints.Length)
        {
            m_CurrentWaypointIndex = 0;
        }
    }

    public void UpdateDestinationGrenade()
    {
        anim.SetBool("Run", true);
        anim.SetBool("Idle", false);
        anim.SetBool("Attack", false);
        targetGrenade = waypointsGrenade[m_CurrentWaypointIndexGrenade].transform.position;
        agent.SetDestination(targetGrenade);
    }

    void IterateWaypointIndexGrenade()
    {
        m_CurrentWaypointIndexGrenade++;
        if (m_CurrentWaypointIndexGrenade == waypointsGrenade.Length)
        {
            m_CurrentWaypointIndexGrenade = 0;
        }
    }

    private void Chasing()
    {
        m_PlayerNear = false;
        playerLastPosition = Vector3.zero;

        if (!m_CaughtPlayer)
        {
            if (Lock == true)
            {
                if (MainBossEnemy == false)
                {
                    Collider[] playerInRange = Physics.OverlapSphere(transform.position, 200, playerMask);
                    for (int i = 0; i < playerInRange.Length; i++)
                    {
                        Transform player = playerInRange[i].transform;

                        m_PlayerPosition = player.transform.position;
                    }
                    Lock = false;
                }
                else if (MainBossEnemy == true)
                {
                    Collider[] playerInRange = Physics.OverlapSphere(transform.position, 1000, playerMask);
                    for (int i = 0; i < playerInRange.Length; i++)
                    {
                        Transform player = playerInRange[i].transform;

                        m_PlayerPosition = player.transform.position;
                    }
                    Lock = false;
                }

            }
            Move(speedRun);
            agent.SetDestination(m_PlayerPosition);
        }
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            if (m_WaitTime <= 0 && !m_CaughtPlayer && Vector3.Distance(transform.position, PlayerGO.transform.position) >= 16f)
            {
                m_CaughtPlayer = false;
                m_IsPatrol = true;
                m_PlayerNear = false;
                m_PlayerInRange = false;
                Move(speedWalk);
                m_TimeToRotate = timeToRotate;
                m_WaitTime = startWaitTime;
                agent.SetDestination(waypoints[m_CurrentWaypointIndex].transform.position);
            }
            else
            {
                if (Vector3.Distance(transform.position, PlayerGO.transform.position) > 15.5f)
                {
                    m_CaughtPlayer = false;

                    Stop();
                    m_WaitTime -= Time.smoothDeltaTime;
                }
                else if (Vector3.Distance(transform.position, PlayerGO.transform.position) <= 15.5f)
                {
                    CaughtPlayer();
                    if (hasAuthority == true)
                    {
                        if (isServer)
                        {
                            RpcCaughtPlayer();
                        }
                        else if (isClient)
                        {
                            CmdCaughtPlayer();
                        }
                    }
                }
            }
        }
        else
        {

        }
    }

    private void Patroling()
    {
        if (m_PlayerNear)
        {
            if (m_TimeToRotate <= 0)
            {
                Move(speedWalk);
                LookingPlayer(playerLastPosition);
            }
            else
            {
                Stop();
                m_TimeToRotate -= Time.smoothDeltaTime;
            }
        }
        else
        {
            anim.SetBool("Run", true);
            anim.SetBool("Idle", false);
            anim.SetBool("Attack", false);
            m_PlayerNear = false;
            playerLastPosition = Vector3.zero;
            agent.SetDestination(waypoints[m_CurrentWaypointIndex].transform.position);
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (m_WaitTime <= 0)
                {
                    NextPoint();
                    Move(speedWalk);
                    m_WaitTime = startWaitTime;
                }
                else
                {
                    Stop();
                    m_WaitTime = Time.smoothDeltaTime;
                }
            }
        }
    }

    void Move(float speed)
    {
        if (IsDead == false)
        {
            Roar.Play();
            RFire.Play();
            LFire.Play();
            HFire.Play();
        }
        anim.SetBool("Run", true);
        anim.SetBool("Idle", false);
        anim.SetBool("Attack", false);
        agent.isStopped = false;
        agent.speed = speed;
    }

    void Stop()
    {
        anim.SetBool("Run", false);
        anim.SetBool("Attack", false);
        anim.SetBool("Idle", true);
        agent.isStopped = true;
        agent.speed = 0;
    }

    public void NextPoint()
    {
        anim.SetBool("Run", true);
        anim.SetBool("Idle", false);
        anim.SetBool("Attack", false);
        m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
        agent.SetDestination(waypoints[m_CurrentWaypointIndex].transform.position);
    }

    void CaughtPlayer()
    {
        Vector3 targetPos = new Vector3(PlayerGO.transform.position.x, transform.position.y, PlayerGO.transform.position.z);
        transform.LookAt(targetPos);
        anim.SetBool("Run", false);
        anim.SetBool("Attack", true);
        m_CaughtPlayer = true;
        agent.isStopped = true;
        agent.speed = 0;
    }

    public IEnumerator DodgeTimeOut()
    {
        yield return new WaitForSeconds(6.0f);
        DodgeGrenade = false;
        Lock = true;
        m_IsPatrol = false;
        Chase = true;
    }

    [ClientRpc]
    public void RpcCaughtPlayer()
    {
        if (hasAuthority == false)
        {
            anim.SetBool("Run", false);
            anim.SetBool("Attack", true);
            m_CaughtPlayer = true;
            agent.isStopped = true;
            agent.speed = 0;
        }
    }

    [Command]
    public void CmdCaughtPlayer()
    {
        RpcCaughtPlayer();
    }

    void LookingPlayer(Vector3 player)
    {
        agent.SetDestination(player);
        if (Vector3.Distance(transform.position, player) <= 0.3)
        {
            if (m_WaitTime <= 0)
            {
                m_PlayerNear = false;
                Move(speedWalk);
                agent.SetDestination(waypoints[m_CurrentWaypointIndex].transform.position);
                m_WaitTime = startWaitTime;
                m_TimeToRotate = timeToRotate;
            }
            else
            {
                Stop();
                m_WaitTime -= Time.smoothDeltaTime;
            }
        }
    }

    void EnvironmentView()
    {
        Collider[] playerInRange = Physics.OverlapSphere(transform.position, viewRadius, playerMask);
        for (int i = 0; i < playerInRange.Length; i++)
        {
            Transform player = playerInRange[i].transform;
            Vector3 dirToPlayer = (player.position - transform.position).normalized;
            if (Vector3.Angle(transform.forward, dirToPlayer) < viewAngle / 2)
            {
                float dstToPlayer = Vector3.Distance(transform.position, player.position);
                if (!Physics.Raycast(transform.position, dirToPlayer, dstToPlayer, obstacleMask))
                {
                    m_PlayerInRange = true;
                    m_IsPatrol = false;
                    DodgeGrenade = false;
                    if (PauseChaseAtTheBeginning == false)
                    {
                    Chase = true;
                    }
                }
                else
                {
                    m_PlayerInRange = false;
                }
            }

            if (Vector3.Distance(transform.position, player.position) > viewRadius)
            {
                m_PlayerInRange = false;
            }
            if (m_PlayerInRange)
            {
                m_PlayerPosition = player.transform.position;
            }
        }
    }
}
