using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.Mirror.Scripts
{
    public class MultiplayerNetworkGamePlayerLobby : NetworkBehaviour
    {

        public MultiplayerEnemySpawnScript MESS;
        [SyncVar]
        private string displayName = "Loading...";

        private ImmunocalypseNetworkManager room;

        private ImmunocalypseNetworkManager Room
        {
            get
            {
                if (room != null) { return room; }
                return room = NetworkManager.singleton as ImmunocalypseNetworkManager;
            }
        }

        public void MissionComplete()
        {
            NetworkClient.Shutdown();
            NetworkClient.Disconnect();
            NetworkServer.Shutdown();
            Transport.activeTransport.ServerStop();
            room.OnStopServer();

        }

        public void MissionNotCompleted()
        {

            if (NetworkServer.active && NetworkClient.isConnected)
            {
                NetworkManager.singleton.StopHost();
            }

            else if (NetworkClient.isConnected)
            {
                NetworkManager.singleton.StopClient();
            }

            else if (NetworkServer.active)
            {
                NetworkManager.singleton.StopServer();
            }

            Room.OnStopServer();
            Transport.activeTransport.ServerStop();
            NetworkClient.Disconnect();

        }

        public override void OnStartClient()
        {
            DontDestroyOnLoad(gameObject);
            Room.GamePlayers.Add(this);
        }

        public override void OnStopClient()
        {

            Room.GamePlayers.Remove(this);
        }

        public override void OnStopServer()
        {

        }

        [Server]
        public void SetDisplayName(string displayName)
        {
            this.displayName = displayName;
        }

    }
}
