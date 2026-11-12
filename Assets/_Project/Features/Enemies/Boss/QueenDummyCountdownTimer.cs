using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QueenDummyCountdownTimer : MonoBehaviour
{
	public float timeRemaining=10.0f;
	public bool timerIsRunning=false;
	public Text timeText;

	public QueenDummyWaveDetection QDWD;

    void Start()
    {

QDWD=GetComponent<QueenDummyWaveDetection>();
    }

    void Update()
    {
    if(timerIsRunning){
if(timeRemaining>0){
timeRemaining-=Time.deltaTime;
Displaytime(timeRemaining);
}else{
timeText.text="DUMMY";
timeRemaining=10.0f;
timerIsRunning=false;
}
	}

    }

	public void DummyTime(){

timerIsRunning=true;
QDWD.Dummy=true;
}
	void Displaytime(float timeToDisplay){
		timeToDisplay+=1;

		float seconds=Mathf.FloorToInt(timeToDisplay%60);
		float milliSeconds=Mathf.FloorToInt(timeToDisplay%1)*1000;
	timeText.text=string.Format("{0:00}:{1:00}",seconds,milliSeconds);
	}

}
