using UnityEngine;
using System;

namespace snakefever
{
    public class JoinLobbyMenu : GameState
    {
        public static event Action OnStateEnter;
        public static event Action OnStateExit;

        public JoinLobbyMenu(GameStateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            OnStateEnter?.Invoke();
        }

        public override void Exit()
        {
            OnStateExit?.Invoke();
        }

        public override void JoinRoom(string roomID)
        {
            // emit event and wait for response
        }

        public override void EnterMainMenu()
        {
            _stateMachine.SetState(new Transition(_stateMachine, new MainMenu(_stateMachine)));
        }
    }
}
