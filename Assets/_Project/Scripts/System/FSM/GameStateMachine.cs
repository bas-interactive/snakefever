using UnityEngine;
using GenericStateMachine;

namespace snakefever
{
    public class GameStateMachine : StateMachine<GameState>
    {
        public void Init()
        {
            SetState(new ApplicationStart(this));
        }
    }
}
