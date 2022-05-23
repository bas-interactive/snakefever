using UnityEngine;

namespace snakefever
{
    [RequireComponent(typeof(GameStateMachine))]
    public class GameManager : Singleton<GameManager>
    {
        public GameStateMachine GameStateMachine { get; private set; }
        public TransitionManager TransitionManager  { get; private set; }

        public override void Init()
        {
            GameStateMachine = GetComponent<GameStateMachine>();
            TransitionManager = GetComponent<TransitionManager>();

            InitStateMachine();
        }

        private void InitStateMachine()
        {
            GameStateMachine.Init();
        }
    }
}
