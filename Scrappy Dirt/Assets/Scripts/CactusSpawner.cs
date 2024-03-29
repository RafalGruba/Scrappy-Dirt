using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
    float maxTimer = 2f;
    float timer = 0f;
    public GameObject cactuses;
    public GameObject dollarObject;
    int cactusCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnCactus();
        timer += Time.deltaTime;
    }

    private void SpawnCactus()
    {
        if (timer > maxTimer)
        {
            GameObject cactusClone = Instantiate(cactuses, (new Vector2(5f, Random.Range(-3f, -8f))), transform.rotation) as GameObject;
            Destroy(cactusClone, 10);
            timer = 0;
            cactusCounter++;
            if (cactusCounter % 10 == 0)
            {
                GameObject dollarClone = Instantiate(dollarObject, cactusClone.transform) as GameObject;
            }
        }
    }
}
