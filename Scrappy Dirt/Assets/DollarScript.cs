using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollarScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<UIManager>().AddDollar();
        Destroy(gameObject);
    }

}
