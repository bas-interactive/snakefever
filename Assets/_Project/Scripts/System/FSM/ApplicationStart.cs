using UnityEngine;
using UnityEngine.SceneManagement;

namespace snakefever
{
    public class ApplicationStart : GameState
    {
        public ApplicationStart(GameStateMachine stateMachine) : base(stateMachine)
        {
        }

        // Handle startscene loading, UI loading and player preferences loading here.
        public override void Enter()
        {
            SceneManager.LoadSceneAsync(Scenes.USER_INTERFACE, LoadSceneMode.Single).completed += _ => UISceneLoaded();
        }

        private void UISceneLoaded()
        {
            SceneManager.LoadSceneAsync(Scenes.START_MENU, LoadSceneMode.Additive).completed += _ => MainMenuLoaded(); 
        }

        private void MainMenuLoaded()
        {
            _stateMachine.SetState(new MainMenu(_stateMachine));
        }
    }
}
