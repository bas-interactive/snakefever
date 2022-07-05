using UnityEngine;

namespace snakefever
{
    public static class QuitManager
    {
        public static void QuitGame()
        {
            GameManager.Instance.SocketIOManager.Disconnect();
            Application.Quit();

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }
}
