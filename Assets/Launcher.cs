using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;



namespace Com.MyCompany.MyGame
    {

    

    public class Launcher : MonoBehaviour
    {

        [SerializeField]
        private byte maxPlayerPerRoom = 4;

        // Start is called before the first frame update
        #region Private Serializable

        #endregion

        #region Private Variables

        string _gameVersion = "1";

        #endregion

        #region MonoBehaviour Callbacks

        void Awake()
        {
            PhotonNetwork.AutomaticallySyncScene = true;
        }
        void Start()
        {
            Connect();
        }

        #endregion

        #region MonoBehaviourPunCallbacks Callbacks

        //public override void OnConnectedToMaster()
        //{
        //    Debug.Log("OnConnectedToMaster() was called");
        //}

        //public override void OnDisconnected(DisconnectCause cause)
        //{
        //    Debug.LogWarningFormat("OnDisconnected() was called by reason {0}", cause);
        //}

        #endregion


        #region Public Methods

        // Update is called once per frame
        public void Connect()
        {
            if(PhotonNetwork.IsConnected)
            {
                PhotonNetwork.JoinRandomRoom();
            }
            else
            {
                PhotonNetwork.ConnectUsingSettings();
                PhotonNetwork.GameVersion = _gameVersion;
            }
        }

        #endregion

    }
}
