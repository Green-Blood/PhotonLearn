using System;
using Photon.Pun;
using UnityEngine;

namespace Networking
{
    public class NetworkService : MonoBehaviourPunCallbacks
    {
        #region Singleton

        public static NetworkService Instance;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        #endregion

        private void Start()
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        public override void OnConnectedToMaster()
        {
            Debug.Log("Connected to Master");
            CreateRoom("TestRoom");
        }

        public override void OnCreatedRoom()
        {
            Debug.Log("Created Room: " + PhotonNetwork.CurrentRoom.Name);
        }

        public void CreateRoom(string roomName)
        {
            PhotonNetwork.CreateRoom(roomName);
        }

        public void JoinRoom(string roomName)
        {
            PhotonNetwork.JoinRoom(roomName);
        }

        public void ChangeScene(string sceneName)
        {
            PhotonNetwork.LoadLevel(sceneName);
        }
    }
}