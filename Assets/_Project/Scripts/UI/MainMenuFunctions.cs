using UnityEngine;

namespace snakefever
{
    public class MainMenuFunctions : MenuFunctions
    {
        public void JoinLobby()
        {
            GameManager.Instance.GameStateMachine.CurrentState.JoinLobby();
        }

        public void CreateLobby()
        {
            GameManager.Instance.GameStateMachine.CurrentState.CreateLobby();
        }

        public void Quit()
        {
            GameManager.Instance.GameStateMachine.CurrentState.Quit();
        }
    }
}
