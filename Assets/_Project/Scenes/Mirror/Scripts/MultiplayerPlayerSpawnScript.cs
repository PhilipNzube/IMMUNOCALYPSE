using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Mirror;

namespace Scenes.Mirror.Scripts{
public class MultiplayerPlayerSpawnScript : NetworkBehaviour
{
   [SerializeField] private GameObject playerPrefab=null;
		public PlayerHealth PH;
private static List<Transform> spawnPoints=new List<Transform>();
private int nextIndex=0;
		public int Called=0;
		public float SPAWNCALL=0f;
		public GameObject NM;
		private ImmunocalypseNetworkManager room;
public static void AddSpawnPoint(Transform transform){
spawnPoints.Add(transform);
spawnPoints=spawnPoints.OrderBy(x=> x.GetSiblingIndex()).ToList();
}
public static void RemoveSpawnPoint(Transform transform) =>	spawnPoints.Remove(transform);
public override void OnStartServer(){
	if(room.Loaded==false){
	SPAWNCALL+=1.0f;

			ImmunocalypseNetworkManager.OnServerReadied+=SpawnPlayer;

	}

			}
		public override void OnStopServer(){
			}

		void Awake()
        {
			NM=GameObject.FindGameObjectWithTag("NM");
			room=NM.GetComponent<ImmunocalypseNetworkManager>();
			StartCoroutine(WaitForIM());
        }

		public IEnumerator WaitForIM(){
	yield return new WaitForSeconds(3.0f);
			PH=playerPrefab.GetComponent<PlayerHealth>();

			}

		void Update()
        {
			}

[ServerCallback]
private void OnDestroy()
	{
			ImmunocalypseNetworkManager.OnServerReadied-=SpawnPlayer;
			Debug.Log("MPSSDestroyed");
			}

[Server]
public void SpawnPlayer(NetworkConnection conn){
	if(SPAWNCALL==1.0f){
	Transform spawnPoint=spawnPoints.ElementAtOrDefault(nextIndex);
	if(spawnPoint==null){
		Debug.LogError($"Missing spawn point for player {nextIndex}");
		return;
            }
	GameObject playerInstance=Instantiate(playerPrefab, spawnPoints[nextIndex].position, spawnPoints[nextIndex].rotation);
	NetworkServer.Spawn(playerInstance, conn);

	nextIndex++;
}
}
}
	}
