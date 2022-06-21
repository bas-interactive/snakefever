using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIOClient;
using System;

namespace snakefever
{
    public class SocketIOManager : MonoBehaviour
    {
        // https://github.com/itisnajim/SocketIOUnity
        private Uri Uri = new Uri("https://www.example.com");

        private static SocketIOUnity Socket;
    }
}
