using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource _audioSource;
    public AudioClip menuMusic;
    public AudioClip gameplayMusic;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void playGameplayMusic() 
    {
        _audioSource.Stop();
        _audioSource.clip = gameplayMusic;
        _audioSource.Play();
    }

    public void playMenuMusic() 
    {
        _audioSource.Stop();
        _audioSource.clip = menuMusic;
        _audioSource.Play();
    }
}
