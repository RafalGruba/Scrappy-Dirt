using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToolTipText : MonoBehaviour
{
    TMP_Text myText;
    [SerializeField] [Range(0f, 1f)] float lerpTime;
    [SerializeField] Color myColor;

    private void Start()
    {
        myText = GetComponent<TMP_Text>();
        myText.color = Color.clear;
    }

    private void Update()
    {
        myText.color = Color.Lerp(myText.color, myColor, lerpTime);
    }

    public void PopOutMessage()
    {
        myText.color = Color.black;
    }
}
