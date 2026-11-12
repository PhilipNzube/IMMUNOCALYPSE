using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.Mirror.Scripts
{
    public class MultiplayerPlayerController2 : NetworkBehaviour
    {
        public GameObject CameraMountPoint;
        public Transform cameraTransform;
        public GameObject Cam;
        public GameObject GrenadeObjects;
        public GameObject BgUI;

        public Text BgUIText;

        public Animator FadeBG;

        public GameObject Day1GO;
        public GameObject Day2GO;
        public GameObject Day3GO;
        public GameObject Day4GO;
        public GameObject Day5GO;
        public GameObject Day6GO;
        public GameObject Day7GO;
        public GameObject Day8GO;
        public GameObject Day9GO;
        public GameObject Day10GO;
        public GameObject Day11GO;
        public GameObject Day12GO;
        public GameObject Day13GO;
        public GameObject Day14GO;
        public GameObject Day15GO;
        public GameObject Day16GO;
        public GameObject Day17GO;
        public GameObject Day18GO;
        public GameObject Day19GO;
        public GameObject Day20GO;
        public GameObject Day21GO;
        public GameObject Day22GO;
        public GameObject Day23GO;
        public GameObject Day24GO;
        public GameObject Day25GO;
        public GameObject Day26GO;
        public GameObject Day27GO;
        public GameObject Day28GO;

        void Start()
        {

        }

        public override void OnStartAuthority()
        {
            BgUI = GameObject.FindGameObjectWithTag("BGCanvas");

            Cam.gameObject.SetActive(true);

            StartCoroutine(Deactivate());
        }

        private IEnumerator Deactivate()
        {
            yield return new WaitForSeconds(4.0f);
            BgUI.gameObject.SetActive(false);

        }

        public void Switch()
        {
            if (isServer)
            {
                Debug.Log("Server o!!!");

            }
            else
            {
                Debug.Log("Not Server o!!!");

            }
        }

        void Update()
        {

        }
    }
}
