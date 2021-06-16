using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip flySFX;
    public AudioClip crashSFX;
    public AudioClip scoreSFX;
    public AudioClip playButtonSFX;
    public AudioClip selectArrowsSFX;
    public GameObject muteOnButton;
    public GameObject muteOffButton;


    public static SFXManager sfxInstance;


    private void Awake()
    {
        sfxInstance = this;
    }

    public void PlaySelectArrowsSFX()
    {
        SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.selectArrowsSFX);
    }

    public void PlayPlayButtonSFX()
    {
        SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.playButtonSFX);
    }

    public void MuteAndUnmute()
    {
        if (audioSource.mute == true)
        {
            audioSource.mute = false;
            muteOnButton.SetActive(true);
            muteOffButton.SetActive(false);
            return;
        }
        if (audioSource.mute == false)
        {
            audioSource.mute = true;
            muteOnButton.SetActive(false);
            muteOffButton.SetActive(true);
            return;
        }
    }

}
