using System;
using UnityEngine.SocialPlatforms.Impl;

public class PanelScreenController : IUIState
{
    private readonly PanelScreenView _view;
    private readonly IFadeService _fadeService;
    private readonly ISoundPlayer _soundPlayer;
    private readonly ISaver _saver;
    private readonly Score _score;
    private readonly Action _onClose;

    public PanelScreenController(
        PanelScreenView view,
        IFadeService fadeService,
        ISoundPlayer soundPlayer,
        ISaver saver,
        Score score,
        Action onClose)
    {
        _view = view;
        _fadeService = fadeService;
        _soundPlayer = soundPlayer;
        _saver = saver;
        _score = score;
        _onClose = onClose;
    }

    public void Enter()
    {
        _view.SubscribeOnClose(OnClose);
        _view.SubscribeOnCollect(OnCollect);
        _view.SetScore(_score.Value);
        _fadeService.FadeIn(_view.PanelImage, 0.3f);
        _soundPlayer.PlayOpenSound();
    }

    public void Exit()
    {
        _view.UnsubscribeOnClose(OnClose);
        _view.UnsubscribeOnCollect(OnCollect);
        _fadeService.FadeOut(_view.PanelImage, 0.3f);
        _soundPlayer.PlayCloseSound();
        _saver.SaveScore(_score.Value);
    }

    private void OnClose() => _onClose?.Invoke();

    private void OnCollect()
    {
        _score.Increment();
        _view.SetScore(_score.Value);
    }
}