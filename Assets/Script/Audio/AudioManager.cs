using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The audio manager
/// </summary>
public static class AudioManager
{
    static bool initialized = false;
    static AudioSource audioSource;
    static Dictionary<AudioClipName, AudioClip> audioClips =
        new Dictionary<AudioClipName, AudioClip>();

    /// <summary>
    /// Gets whether or not the audio manager has been initialized
    /// </summary>
    public static bool Initialized
    {
        get { return initialized; }
    }

    /// <summary>
    /// Initializes the audio manager
    /// </summary>
    /// <param name="source">audio source</param>
    public static void Initialize(AudioSource source)
    {
        initialized = true;
        audioSource = source;
        audioClips.Add(AudioClipName.ArrowTowerShoot,
            Resources.Load<AudioClip>("ArrowTowerShoot"));
        audioClips.Add(AudioClipName.BackGround,
            Resources.Load<AudioClip>("BackGround"));
        audioClips.Add(AudioClipName.ButtonClick,
            Resources.Load<AudioClip>("ButtonClick"));
        audioClips.Add(AudioClipName.Death,
             Resources.Load<AudioClip>("Death"));
        audioClips.Add(AudioClipName.GameOver,
             Resources.Load<AudioClip>("GameOver"));
        audioClips.Add(AudioClipName.HomeExplosion,
              Resources.Load<AudioClip>("HomeExplosion"));
        audioClips.Add(AudioClipName.KnightTowerShoot,
            Resources.Load<AudioClip>("KnightTowerShoot"));
        audioClips.Add(AudioClipName.MagicianTowerShootShoot,
            Resources.Load<AudioClip>("MagicianTowerShootShoot"));
        audioClips.Add(AudioClipName.StartWave,
            Resources.Load<AudioClip>("StartWave"));
        audioClips.Add(AudioClipName.SubtractCoin,
            Resources.Load<AudioClip>("SubtractCoin"));
    }

    /// <summary>
    /// Plays the audio clip with the given name
    /// </summary>
    /// <param name="name">name of the audio clip to play</param>
    public static void Play(AudioClipName name)
    {
        audioSource.PlayOneShot(audioClips[name]);
    }
}
