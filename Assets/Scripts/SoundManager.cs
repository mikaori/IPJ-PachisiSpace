using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip startPlayerAudioClip;
    public AudioClip hitPlayerAudioClip;
    public AudioClip gameCompletedAudioClip;
    public AudioClip selectionOptionMenuAudioClip;
    public AudioClip gameMusicAudioClip;
    public AudioClip jumpAudioClip;

    public static AudioSource startPlayerAudioSource;
    public static AudioSource hitPlayerAudioSource;
    public static AudioSource gameCompletedAudioSource;
    public static AudioSource selectionOptionMenuAudioSource;
    public static AudioSource gameMusicAudioSource;
    public static AudioSource jumpAudioAudioSource;

    AudioSource AddAudio(AudioClip clip, bool playOnAwake, bool loop, float volume)
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.playOnAwake = playOnAwake;
        audioSource.loop = loop;
        audioSource.volume = volume;

        return audioSource;
    }


    // Start is called before the first frame update
    void Start()
    {
        startPlayerAudioSource = AddAudio(startPlayerAudioClip, false, false, 1.0f);
        hitPlayerAudioSource = AddAudio(hitPlayerAudioClip, false, false, 1.0f);
        gameCompletedAudioSource = AddAudio(gameCompletedAudioClip, false, false, 1.0f);
        selectionOptionMenuAudioSource = AddAudio(selectionOptionMenuAudioClip, false, false, 1.0f);
        gameMusicAudioSource = AddAudio(gameMusicAudioClip, false, true, 1.0f);
        jumpAudioAudioSource = AddAudio(jumpAudioClip, false, false, 1.0f);
    }

}
