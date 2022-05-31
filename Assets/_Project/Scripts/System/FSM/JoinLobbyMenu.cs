using UnityEngine;
using System;

namespace snakefever
{
    public class JoinLobbyMenu : GameState
    {
        public static event Action OnJoinLobbyMenuEnter;
        public static event Action OnJoinLobbyMenuExit;


        public JoinLobbyMenu(GameStateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            OnJoinLobbyMenuEnter?.Invoke();
        }

        public override void Exit()
        {
            OnJoinLobbyMenuExit?.Invoke();
        }
    }
}
