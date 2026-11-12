using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DummyCountdownTimer : MonoBehaviour
{
	public float timeRemaining=10.0f;
	public bool timerIsRunning=false;
	public Text timeText;

	public DummyWaveDetection DWD;
	public GameObject DummyPanel;

    void Start()
    {

DWD=GetComponent<DummyWaveDetection>();
    }

    void Update()
    {
    if(timerIsRunning){
if(timeRemaining>0){
timeRemaining-=Time.deltaTime;
Displaytime(timeRemaining);
DummyPanel.gameObject.SetActive(true);
}else{
DummyPanel.gameObject.SetActive(false);
timeText.text="DUMMY";
timeRemaining=10.0f;
timerIsRunning=false;
}
	}

    }

	public void DummyTime(){

timerIsRunning=true;
DWD.Dummy=true;
}
	void Displaytime(float timeToDisplay){
		timeToDisplay+=1;

		float seconds=Mathf.FloorToInt(timeToDisplay%60);
		float milliSeconds=Mathf.FloorToInt(timeToDisplay%1)*1000;
	timeText.text=string.Format("{0:00}:{1:00}",seconds,milliSeconds);
	}

}
