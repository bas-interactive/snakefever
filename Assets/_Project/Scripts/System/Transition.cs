public class Transition : GameState
{
    private GameState _transitionTo;
    private IFadeOutCompleteCallback _fadeOutCompleteCallback = null;

    public Transition(FSM fsm, GameState transitionTo) : base(fsm)
    {
        _transitionTo = transitionTo;
    }

    public Transition(FSM fsm, GameState transitionTo, IFadeOutCompleteCallback callback) : base(fsm)
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
        _fadeOutCompleteCallback?.FadeOutComplete();
    }

    protected void EndTransition()
    {
        GameManager.Instance.TransitionManager.FadeIn();
        _fsm.SetState(_transitionTo);
    }
}
