using UnityEngine;
using System;

namespace snakefever
{
    public class JoinLobbyMenu : GameState
    {

        public JoinLobbyMenu(GameStateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void EnterMainMenu()
        {
            _stateMachine.SetState(new Transition(_stateMachine, new MainMenu(_stateMachine)));
        }
    }
}
