using GenericStateMachine;

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

        public virtual void EnterCreateLobbyMenu()
        {
        }

        public virtual void EnterJoinLobbyMenu()
        {
        }

        public virtual void JoinRoom(string roomID)
        {
        }

        public virtual void StartQuickplay()
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
