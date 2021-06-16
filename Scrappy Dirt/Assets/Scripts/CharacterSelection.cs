using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int characterSelected;

    

    private void Start()
    {
        characters[characterSelected].SetActive(false);
        characterSelected = PlayerPrefs.GetInt("selected character");
        characters[characterSelected].SetActive(true);
    }

    public void NextCharacter()
    {
        characters[characterSelected].SetActive(false);
        characterSelected = (characterSelected + 1) % characters.Length;
        characters[characterSelected].SetActive(true);
        PlayerPrefs.SetInt("selected character", characterSelected);
    }

    public void PreviousCharacter()
    {
        characters[characterSelected].SetActive(false);
        characterSelected--;
        if (characterSelected < 0)
        {
            characterSelected += characters.Length;
        }
        characters[characterSelected].SetActive(true);
        PlayerPrefs.SetInt("selected character", characterSelected);
    }


    public int ReturnSelectedCharacterIndex()
    {
        return characterSelected;
    }

}
