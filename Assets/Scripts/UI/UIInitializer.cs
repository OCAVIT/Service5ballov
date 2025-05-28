using UnityEngine;

public class UIInitializer : MonoBehaviour
{
    [SerializeField] private MainScreenView mainScreenView;
    [SerializeField] private PanelScreenView panelScreenView;

    private UISwitcher _uiSwitcher;
    private Score _score;

    private void Start()
    {
        var locator = ServiceLocatorProvider.Locator;
        var fadeService = locator.GetService<IFadeService>();
        var soundPlayer = locator.GetService<ISoundPlayer>();
        var saver = locator.GetService<ISaver>();

        _score = new Score();

        MainScreenController mainController = null;
        PanelScreenController panelController = null;

        mainController = new MainScreenController(mainScreenView, () => _uiSwitcher.SwitchState(panelController));
        panelController = new PanelScreenController(panelScreenView, fadeService, soundPlayer, saver, _score, () => _uiSwitcher.SwitchState(mainController));

        _uiSwitcher = new UISwitcher();
        _uiSwitcher.SwitchState(mainController);
    }
}