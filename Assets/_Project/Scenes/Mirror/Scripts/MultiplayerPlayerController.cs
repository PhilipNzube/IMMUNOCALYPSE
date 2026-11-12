using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Scenes.Mirror.Scripts
{
    public class MultiplayerPlayerController : NetworkBehaviour
    {
        public GameObject CameraMountPoint;
        public Transform cameraTransform;
        public GameObject CamObjects;
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

        public bool NewPlayer;

        void Start()
        {
            if (NewPlayer == false)
            {

            }

			if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                Day1GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                Day2GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                Day3GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                Day4GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                Day5GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 8)
            {
                Day6GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                Day7GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                Day8GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 11)
            {
                Day9GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 12)
            {
                Day10GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 13)
            {
                Day11GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 14)
            {
                Day12GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 15)
            {
                Day13GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 16)
            {
                Day14GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 17)
            {
                Day15GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 18)
            {
                Day16GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 19)
            {
                Day17GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 20)
            {
                Day18GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 21)
            {
                Day19GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 22)
            {
                Day20GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 23)
            {
                Day21GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 24)
            {
                Day22GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 25)
            {
                Day23GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 26)
            {
                Day24GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 27)
            {
                Day25GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 28)
            {
                Day26GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 29)
            {
                Day27GO.gameObject.SetActive(true);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 30)
            {
                Day28GO.gameObject.SetActive(true);
            }
        }

        public override void OnStartAuthority()
        {
            BgUI = GameObject.FindGameObjectWithTag("BGCanvas");

            CamObjects.gameObject.SetActive(true);
            GrenadeObjects.gameObject.SetActive(true);
            if (NewPlayer == false)
            {
                cameraTransform = Camera.main.gameObject.transform;
                cameraTransform.parent = CameraMountPoint.transform;
                cameraTransform.position = CameraMountPoint.transform.position;
                cameraTransform.rotation = CameraMountPoint.transform.rotation;
            }
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
