using System;
public class MainScreenController : IUIState
{
    private readonly MainScreenView _view;
    private readonly Action _onOpen;

    public MainScreenController(MainScreenView view, Action onOpen)
    {
        _view = view;
        _onOpen = onOpen;
    }

    public void Enter()
    {
        _view.SubscribeOnOpen(_onOpen);
        _view.SetInteractable(true);
    }

    public void Exit()
    {
        _view.UnsubscribeOnOpen(_onOpen);
        _view.SetInteractable(false);
    }
}