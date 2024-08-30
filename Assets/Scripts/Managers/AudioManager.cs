using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }

    [SerializeField] Audio[] sounds;
    [SerializeField] Audio[] musics;

    public void PlaySound(string id)
    {
        Audio sound = Array.Find(sounds, sound => sound.id == id);

        if (sound == null)
        {
            Debug.LogError($"Sound \"{id}\" not found!");

            return;
        }

        sound.source.Play();
    }

    public bool IsSoundPlaying(string id)
    {
        Audio sound = Array.Find(sounds, sound => sound.id == id);

        if (sound == null)
        {
            Debug.LogError($"Sound \"{id}\" not found!");

            return false;
        }

        return sound.source.isPlaying;
    }

    public void PlayMusic(string id, bool hasToPlay = true)
    {
        Audio music = Array.Find(musics, music => music.id == id);

        if (music == null)
        {
            Debug.LogError($"Music \"{id}\" not found!");

            return;
        }

        if (hasToPlay) music.source.Play();
        else music.source.Stop();
    }

    public bool IsMusicPlaying(string id)
    {
        Audio music = Array.Find(musics, music => music.id == id);

        if (music == null)
        {
            Debug.LogError($"Music \"{id}\" not found!");

            return false;
        }

        return music.source.isPlaying;
    }
}
