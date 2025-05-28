using UnityEngine;

public class SoundPlayer : ISoundPlayer
{
    private readonly AudioSource _audioSource;
    private readonly AudioClip _openClip;
    private readonly AudioClip _closeClip;

    public SoundPlayer(AudioSource audioSource, AudioClip openClip, AudioClip closeClip)
    {
        _audioSource = audioSource;
        _openClip = openClip;
        _closeClip = closeClip;
    }

    public void PlayOpenSound()
    {
        _audioSource.PlayOneShot(_openClip);
    }

    public void PlayCloseSound()
    {
        _audioSource.PlayOneShot(_closeClip);
    }
}