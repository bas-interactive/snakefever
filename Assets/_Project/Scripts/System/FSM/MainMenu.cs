using UnityEngine;
using System;

namespace snakefever
{
    public class MainMenu : GameState
    {
        public static event Action OnStateEnter;
        public static event Action OnStateExit;

        public MainMenu(GameStateMachine stateMachine) : base(stateMachine)
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

        public override void EnterCreateLobbyMenu()
        {
            Debug.Log("Create Lobby");
        }

        public override void EnterJoinLobbyMenu()
        {
            _stateMachine.SetState(new Transition(_stateMachine, new JoinLobbyMenu(_stateMachine)));
        }

        public override void Quit()
        {
            QuitManager.QuitGame();
        }
    }
}
