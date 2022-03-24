using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField]
    private SoundAndMusicSO gameSoundData;
    [SerializeField]
    private AudioSource musicAudioSource;


    private void Start()
    {
        if (gameSoundData.Level1Music != null)
        {
            musicAudioSource.clip = gameSoundData.Level1Music;
            musicAudioSource.Play();
        }
    }

}
