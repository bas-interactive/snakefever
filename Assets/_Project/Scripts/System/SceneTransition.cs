using UnityEngine.SceneManagement;

namespace snakefever
{
    public class SceneTransition : Transition
    {
        private int _nextScene;
        private readonly int _sceneToUnload = -1;
        private ITransitionCompleteCallback _sceneLoadedCallback = null;

        public SceneTransition(GameStateMachine fsm, GameState transitionTo, int nextScene) : base(fsm, transitionTo)
        {
            _nextScene = nextScene;
        }

        public SceneTransition(GameStateMachine fsm, GameState transitionTo, int nextScene, int sceneToUnload) : base(fsm, transitionTo)
        {
            _nextScene = nextScene;
            _sceneToUnload = sceneToUnload;
        }

        public SceneTransition(GameStateMachine fsm, GameState transitionTo, int nextScene, int sceneToUnload, ITransitionCompleteCallback sceneLoadedCallback) : base(fsm, transitionTo)
        {
            _nextScene = nextScene;
            _sceneToUnload = sceneToUnload;
            _sceneLoadedCallback = sceneLoadedCallback;
        }

        protected override void FadeOutComplete()
        {
            DeRegister();
            Callback();

            SceneManager.LoadSceneAsync(_nextScene, LoadSceneMode.Additive).completed += _ => SceneLoadComplete();
        }

        private void SceneLoadComplete()
        {
            _sceneLoadedCallback.OnTransitionComplete();

            if (_sceneToUnload != -1)
            {
                SceneManager.UnloadSceneAsync(_sceneToUnload);
            }

            EndTransition();
        }
    }
}
