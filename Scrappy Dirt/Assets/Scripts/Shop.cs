using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public GameObject canBuy;
    public GameObject bought;
    public GameObject canPlay;
    public GameObject cannotPlay;
    public TMP_Text priceText;


    int selectedCharacterPrice;
    int moneyPlayerHas;



    private void Update()
    {
        CheckIfIsPurchased();
        priceText.text = selectedCharacterPrice.ToString();
    }

    public void CheckIfIsPurchased()
    {
        selectedCharacterPrice = FindObjectOfType<OwnedOrNot>().ReturnPrice();
        if (FindObjectOfType<OwnedOrNot>().CheckIfIsPurchased() == true)
        {
            canBuy.SetActive(false);
            bought.SetActive(true);
            cannotPlay.SetActive(false);
            canPlay.SetActive(true);
        }
        if (FindObjectOfType<OwnedOrNot>().CheckIfIsPurchased() == false)
        {
            canBuy.SetActive(true);
            bought.SetActive(false);
            cannotPlay.SetActive(true);
            canPlay.SetActive(false);
        }
    }

    public void BuyIfYouCanAffordIt()
    {
        moneyPlayerHas = FindObjectOfType<UIManager>().ReturnDollarAmount();
        selectedCharacterPrice = FindObjectOfType<OwnedOrNot>().ReturnPrice();
        if (moneyPlayerHas >= selectedCharacterPrice)
        {
            FindObjectOfType<OwnedOrNot>().PurchaseACharacter();
            FindObjectOfType<OwnedOrNot>().SaveDataPurchasedCharacter();
            FindObjectOfType<UIManager>().SpendDollarsForNewCharacter();
            canBuy.SetActive(false);
            bought.SetActive(true);
            cannotPlay.SetActive(false);
            canPlay.SetActive(true);
            SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.playButtonSFX);
        }
        else
        {
            SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.crashSFX);
            FindObjectOfType<ToolTipText>().PopOutMessage();
            FindObjectOfType<ToolTipBG>().PopOutMessage();
        }

    }

}
