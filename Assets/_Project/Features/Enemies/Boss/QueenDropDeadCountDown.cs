using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QueenDropDeadCountDown : MonoBehaviour
{
	public float timeRemaining=10.0f;
	public bool timerIsRunning=false;
	public Text timeText;
	public Button button;
	public QueenDropDeadWaveDetection QDDWD;

    void Start()
    {

QDDWD=GetComponent<QueenDropDeadWaveDetection>();
    }

    void Update()
    {
    if(timerIsRunning){
if(timeRemaining>0){
timeRemaining-=Time.deltaTime;
Displaytime(timeRemaining);
}else{
timeText.text="DropDead";
timeRemaining=10.0f;
timerIsRunning=false;
}
	}

    }

	 public void DeathTime(){
  timerIsRunning=true;
QDDWD.Die=true;
}
	void Displaytime(float timeToDisplay){
		timeToDisplay+=1;

		float seconds=Mathf.FloorToInt(timeToDisplay%60);
		float milliSeconds=Mathf.FloorToInt(timeToDisplay%1)*1000;
	timeText.text=string.Format("{0:00}:{1:00}",seconds,milliSeconds);
	}

}
