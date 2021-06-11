using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCactuses : MonoBehaviour
{
    [SerializeField] float speed = 2f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
