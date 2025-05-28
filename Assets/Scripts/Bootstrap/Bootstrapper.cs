using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip openClip;
    public AudioClip closeClip;

    private void Awake()
    {
        var fadeService = new FadeService();
        var soundPlayer = new SoundPlayer(audioSource, openClip, closeClip);
        var playerPrefsSaver = new PlayerPrefsSaver();
        var jsonSaver = new JsonSaver();

        var locator = new ServiceLocator();
        locator.Register<IFadeService>(fadeService);
        locator.Register<ISoundPlayer>(soundPlayer);
        locator.Register<ISaver>(playerPrefsSaver);

        ServiceLocatorProvider.SetLocator(locator);
    }
}

