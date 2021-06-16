using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<UIManager>().AddScore();
        SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.scoreSFX);
    }

}
