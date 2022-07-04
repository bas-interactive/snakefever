using UnityEngine;
using GenericStateMachine;
using System;

namespace snakefever
{
    public class GameState : State<GameStateMachine>
    {
        public GameState(GameStateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            
        }

        public override void Exit()
        {
            
        }

        public virtual void Quit()
        {
        }

        public virtual void Pause()
        {
        }

        public virtual void Resume()
        {
        }

        public virtual void CreateLobby()
        {
        }

        public virtual void JoinLobby()
        {
        }

        public virtual void EnterMainMenu()
        {
        }

        public virtual void EnterSettingsMenu()
        {
        }

        public virtual void EnterPauseMenu()
        {
        }

        public virtual void EndLoading()
        {
        }
    }
}
