using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestScoreRecorder : MonoBehaviour
{

    public static BestScoreRecorder scoreRecorder;

    private void Awake()
    {
        if (scoreRecorder != null && scoreRecorder != this)
        {
            Destroy(this.gameObject);
            return;
        }

        scoreRecorder = this;
        DontDestroyOnLoad(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
