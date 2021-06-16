using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnedOrNot : MonoBehaviour
{
    public bool isPurchased;
    public int price;

    string characterName;

    private void Awake()
    {
        characterName = this.name;
        isPurchased = (PlayerPrefs.GetInt(characterName) != 0);
    }

    public bool CheckIfIsPurchased()
    {
        return isPurchased;
    }

    public void PurchaseACharacter()
    {
        isPurchased = true;
    }

    public int ReturnPrice()
    {
        return price;
    }

    public void SaveDataPurchasedCharacter()
    {
        PlayerPrefs.SetInt(characterName, (isPurchased ? 1 : 0));
    }

}
