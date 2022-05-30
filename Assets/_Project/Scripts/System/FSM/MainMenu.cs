using UnityEngine;
using System;

namespace snakefever
{
    public class MainMenu : GameState
    {
        public static event Action OnMainMenuEnter;
        public static event Action OnMainMenuExit;

        public MainMenu(GameStateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            OnMainMenuEnter?.Invoke();
            GameManager.Instance.TransitionManager.FadeIn();
        }

        public override void Exit()
        {
            OnMainMenuExit?.Invoke();
        }

        public override void CreateLobby()
        {
            
        }

        public override void JoinLobby()
        {
            
        }

        public override void Quit()
        {
            Application.Quit();
        }
    }
}
