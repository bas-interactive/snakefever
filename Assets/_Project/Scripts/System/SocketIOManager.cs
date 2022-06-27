using System.Collections;
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
            Socket = new SocketIOUnity(Uri, new SocketIOOptions{});

            Socket.JsonSerializer = new NewtonsoftJsonSerializer();

            //Socket.unityThreadScope = SocketIOUnity.UnityThreadScope.Update; 

            Socket.OnConnected += (sender, e) =>
            {
                Debug.Log("socket.OnConnected");
            };

            Socket.Connect();

            Debug.Log(Socket.Connected);

            Send();

            Debug.Log("Init SocketIomanager!");
        }

        private void Update()
        {
            Debug.Log(Socket.Connected);
        }

        public void Send()
        {
            Socket.Emit("eventName");
        }
    }
}
