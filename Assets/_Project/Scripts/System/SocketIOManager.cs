using System.Collections.Generic;
using UnityEngine;
using SocketIOClient;
using System;
using SocketIOClient.Newtonsoft.Json;

namespace snakefever
{
    public class SocketIOManager : MonoBehaviour
    {
        // https://github.com/itisnajim/SocketIOUnity
        private Uri Uri = new Uri("http://snakefever.glitch.me");

        public static SocketIOUnity Socket;

        public void Init()
        {
            Socket = new SocketIOUnity(Uri, new SocketIOOptions{
                EIO = 4,
                ExtraHeaders = new Dictionary<string, string>() {
                    {"User-Agent", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/102.0.5005.115 Safari/537.36 OPR/88.0.4412.53"}
                }
            });

            Socket.JsonSerializer = new NewtonsoftJsonSerializer();

            Socket.unityThreadScope = SocketIOUnity.UnityThreadScope.Update; 

            Socket.OnConnected += (sender, e) =>
            {
                UnityThread.executeInUpdate(() => {
                    GameManager.Instance.GameStateMachine.CurrentState.EndLoading();
                });
            };

            Socket.Connect();
        }

        bool sent=  ! true;

        void Update()
        {
            if (Socket.Connected && sent  ==false)
            {
                Send();
                sent =true;
            }
        }

        public void Send()
        {
            Debug.Log("send");
            Socket.Emit("player_set_name", "Uwe");
        }
    }
}
