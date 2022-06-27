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
            GameManager.Instance.TransitionManager.FadeIn();
        }

        public override void Exit()
        {
            OnStateExit?.Invoke();
        }
        public override void CreateLobby()
        {
            
        }

        public override void JoinLobby()
        {
            _stateMachine.SetState(new Transition(_stateMachine, new JoinLobbyMenu(_stateMachine)));
        }

        public override void Quit()
        {
            Application.Quit();
        }
    }
}
