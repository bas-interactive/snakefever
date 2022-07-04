using System;
using UnityEngine;

namespace snakefever
{
    public class LoadingScreen : GameState
    {
        public static event Action OnStateEnter;
        public static event Action OnStateExit;

        private GameState _transitionTo;

        public LoadingScreen(GameStateMachine stateMachine, GameState transitionTo) : base(stateMachine)
        {
            _transitionTo = transitionTo;
        }

        public override void Enter()
        {
            OnStateEnter?.Invoke();
        }

        public override void Exit()
        {
            OnStateExit?.Invoke();
        }

        public override void EndLoading()
        {
            _stateMachine.SetState(new Transition(_stateMachine, _transitionTo));
        }
    }
}
