using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0f;
        FindObjectOfType<UIManager>().ActivateLostMenu();
        SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.crashSFX);
    }
}
