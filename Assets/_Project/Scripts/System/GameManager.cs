using UnityEngine;

namespace snakefever
{
    [RequireComponent(typeof(GameStateMachine))]
    public class GameManager : Singleton<GameManager>
    {
        public static GameStateMachine GameStateMachine { get; private set; }

        public override void Init()
        {
            GameStateMachine = GetComponent<GameStateMachine>();

            InitStateMachine();
        }

        private void InitStateMachine()
        {
            GameStateMachine.Init();
        }
    }
}
