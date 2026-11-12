using UnityEngine;

public class PlayerAudioCoordinator
{
    public void PlayMusic(AudioSource musicSource)
    {
        if (musicSource != null && !musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }

    public void StopMusic(AudioSource musicSource)
    {
        if (musicSource != null && musicSource.isPlaying)
        {
            musicSource.Stop();
        }
    }

    public void TriggerEngagementVoice(AudioSource voiceSource)
    {
        if (voiceSource != null && !voiceSource.isPlaying)
        {
            voiceSource.Play();
        }
    }
}
