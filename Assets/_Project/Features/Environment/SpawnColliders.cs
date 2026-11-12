using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Mirror;

namespace Scenes.Mirror.Scripts
{

    public class SpawnColliders : NetworkBehaviour
    {
        public GameObject ESS;
        public MultiplayerEnemySpawnScript MESS;
        public BoxCollider col;
        public MultiplayerNetworkGamePlayerLobby MNGPL;
        public TimerScript TS;

        void Start()
        {
            ESS = GameObject.FindGameObjectWithTag("ESS");
            MESS = ESS.GetComponent<MultiplayerEnemySpawnScript>();
            MNGPL = GameObject.FindGameObjectWithTag("NGP").GetComponent<MultiplayerNetworkGamePlayerLobby>();
            TS = GameObject.FindGameObjectWithTag("Player").GetComponent<TimerScript>();
            col.enabled = false;
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {

                other.GetComponent<TimerScript>().timerIsRunning = false;
                other.GetComponent<PlayerHealth>().timerIsRunning = false;
                if (other.GetComponentInChildren<ThirdPersonCharacter>())
                {
                    other.GetComponentInChildren<ThirdPersonCharacter>().m_ForwardAmount = 0;
                }

                if (other.GetComponentInChildren<ThirdPersonUserControl>())
                {
                    other.GetComponentInChildren<ThirdPersonUserControl>().Walk = false;
                    other.GetComponentInChildren<ThirdPersonUserControl>().forwards = false;
                    other.GetComponentInChildren<ThirdPersonUserControl>().backwards = false;
                    other.GetComponentInChildren<ThirdPersonUserControl>().strafe = false;
                    other.GetComponentInChildren<ThirdPersonUserControl>().v = 0;
                    other.GetComponentInChildren<ThirdPersonUserControl>().h = 0;
                }
                MESS.LM();
            }
        }

    }
}
