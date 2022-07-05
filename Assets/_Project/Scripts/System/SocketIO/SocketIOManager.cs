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
        public const string URI_SNAKEFEVER = "http://snakefever.glitch.me";

        [Header("Settings")]
        [SerializeField] private SocketIOMode _socketIOMode = SocketIOMode.Release;
        public static SocketIOUnity Socket  { get; private set; }
        private Uri _uri;

        public void Init()
        {
            string addon = (_socketIOMode == SocketIOMode.Inactive) ? ".inactive" : "";
            _uri = new Uri(URI_SNAKEFEVER + addon);

            Socket = new SocketIOUnity(_uri, new SocketIOOptions{
                EIO = 4,
                ExtraHeaders = new Dictionary<string, string>() {
                    {"User-Agent", "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/102.0.5005.115 Safari/537.36 OPR/88.0.4412.53"}
                }
            });

            Socket.JsonSerializer = new NewtonsoftJsonSerializer();

            Socket.unityThreadScope = SocketIOUnity.UnityThreadScope.Update; 

            Socket.OnConnected += (sender, e) =>
            {
                OnConnect();
            };

            Socket.Connect();
        }

        private void OnConnect()
        {
            if (_socketIOMode != SocketIOMode.Release)
            {
                LogDebug("SocketIO Connected Successfully");
            }

            UnityThread.executeInUpdate(() => {
                GameManager.Instance.GameStateMachine.CurrentState.EndLoading();
            });
        }

        public void Disconnect()
        {
            Socket.Disconnect();

            if (_socketIOMode != SocketIOMode.Release)
            {
                LogDebug("SocketIO Disconnected");
            }
        }

        private void LogDebug(string message)
        {
#if UNITY_EDITOR
            Debug.Log($"<color=cyan>{message}</color>");
#endif
        }
    }

    public enum SocketIOMode
    {
        Inactive,
        Development,
        Release
    }
}
