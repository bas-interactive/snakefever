using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snakefever
{
    public class JoinLobbyMenuFunctions : MonoBehaviour
    {
        public void Quit()
        {
            GameManager.Instance.GameStateMachine.CurrentState.EnterMainMenu();
        }
    }
}
