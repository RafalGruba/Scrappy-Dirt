using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTipBG : MonoBehaviour
{
    Image myImage;
    [SerializeField] [Range(0f, 1f)] float lerpTime;
    [SerializeField] Color myColor;

    private void Start()
    {
        myImage = GetComponent<Image>();
        myImage.color = Color.clear;
    }

    private void Update()
    {
        myImage.color = Color.Lerp(myImage.color, myColor, lerpTime);
    }

    public void PopOutMessage()
    {
        myImage.color = Color.white;
    }
}
