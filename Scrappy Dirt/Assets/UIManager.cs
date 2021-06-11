using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreTextTop;
    public TMP_Text scoreTextLostMenu;
    public TMP_Text scoreTextBest;
    public GameObject mainManu;
    public GameObject lostMenu;
    public GameObject tapToStart;
    public GameObject player;
    int score = 0;
    int bestScoreInt = 0;
    Vector2 playerStartPos;



    private void Start()
    {
        Time.timeScale = 0f;
        playerStartPos = player.transform.position;
        score = 0;
    }

    public int ReturnScore()
    {
        return score;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

    public void ActivateMainMenu()
    {
        mainManu.gameObject.SetActive(true);
    }

    public void DeactivateMainMenu()
    {
        mainManu.gameObject.SetActive(false);
    }

    public void ActivateLostMenu()
    {
        lostMenu.gameObject.SetActive(true);
    }

    public void DeactivateLostMenu()
    {
        lostMenu.gameObject.SetActive(false);
    }
    public void ActivateTapToStart()
    {
        tapToStart.gameObject.SetActive(true);
    }
    public void DeactivateTapToStart()
    {
        Time.timeScale = 1f;
        tapToStart.gameObject.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (score > bestScoreInt)
        {
            bestScoreInt = score;
        }
        scoreTextTop.text = score.ToString();
        scoreTextLostMenu.text = score.ToString();
        scoreTextBest.text = bestScoreInt.ToString();

    }

    public void AddScore()
    {
        score++;
    }


}
