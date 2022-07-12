using UnityEngine;

namespace snakefever
{
    public class MainMenuFunctions : MenuFunctions
    {
        public void JoinLobby()
        {
            GameManager.Instance.GameStateMachine.CurrentState.EnterJoinLobbyMenu();
        }

        public void CreateLobby()
        {
            GameManager.Instance.GameStateMachine.CurrentState.EnterCreateLobbyMenu();
        }

        public void Quit()
        {
            GameManager.Instance.GameStateMachine.CurrentState.Quit();
        }
    }
}
