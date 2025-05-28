public class UISwitcher
{
    private IUIState _currentState;

    public void SwitchState(IUIState newState)
    {
        _currentState?.Exit();
        _currentState = newState;
        _currentState.Enter();
    }
}