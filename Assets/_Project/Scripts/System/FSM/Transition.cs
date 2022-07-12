namespace snakefever
{
    public class Transition : GameState
    {
        private GameState _transitionTo;
        private ITransitionCompleteCallback _fadeOutCompleteCallback = null;

        public Transition(GameStateMachine fsm, GameState transitionTo) : base(fsm)
        {
            _transitionTo = transitionTo;
        }

        public Transition(GameStateMachine fsm, GameState transitionTo, ITransitionCompleteCallback callback) : base(fsm)
        {
            _transitionTo = transitionTo;
            _fadeOutCompleteCallback = callback;
        }

        public override void Enter()
        {
            GameManager.Instance.TransitionManager.OnFadeOutComplete += FadeOutComplete;
            GameManager.Instance.TransitionManager.FadeOut();
        }

        protected virtual void FadeOutComplete()
        {
            DeRegister();
            Callback();

            EndTransition();
        }

        protected void DeRegister()
        {
            GameManager.Instance.TransitionManager.OnFadeOutComplete -= FadeOutComplete;
        }

        protected void Callback()
        {
            _fadeOutCompleteCallback?.OnTransitionComplete();
        }

        protected void EndTransition()
        {
            GameManager.Instance.TransitionManager.FadeIn();
            _stateMachine.SetState(_transitionTo);
        }
    }
}
