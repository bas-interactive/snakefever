using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snakefever
{
    public class EmitEventAwaitResponse : GameState
    {
        private string _emitEvent;
        private string _awaitEvent;
        private object[] _arguments;
        public EmitEventAwaitResponse(GameStateMachine stateMachine, string emitEvent, string awaitEvent, GameState transitionTo, params object[] arguments) : base(stateMachine)
        {

        }

        public override void Enter()
        {
            GameManager.Instance.SocketIOManager.Emit(_emitEvent);
        }

        public override void Exit()
        {
            
        }
    }
}
