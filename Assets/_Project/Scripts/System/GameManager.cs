using UnityEngine;

namespace snakefever
{
    [RequireComponent(typeof(GameStateMachine))]
    [RequireComponent(typeof(TransitionManager))]
    [RequireComponent(typeof(SocketIOManager))]
    public class GameManager : Singleton<GameManager>
    {
        public GameStateMachine GameStateMachine { get; private set; }
        public TransitionManager TransitionManager  { get; private set; }
        public SocketIOManager SocketIOManager  { get; private set; }

        public override void Init()
        {
            GameStateMachine = GetComponent<GameStateMachine>();
            TransitionManager = GetComponent<TransitionManager>();
            SocketIOManager = GetComponent<SocketIOManager>();

            InitStateMachine();
        }

        private void InitStateMachine()
        {
            GameStateMachine.Init();
        }
    }
}
