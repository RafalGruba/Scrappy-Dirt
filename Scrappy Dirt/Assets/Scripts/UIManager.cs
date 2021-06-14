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
    public TMP_Text dollarText;
    public GameObject mainManu;
    public GameObject lostMenu;
    public GameObject tapToStart;
    public GameObject player;
    int score;
    int dollarAmount;


    private void Start()
    {
        Time.timeScale = 0f;
        score = 0;
        dollarAmount = PlayerPrefs.GetInt("player dollars");
        scoreTextBest.text = PlayerPrefs.GetInt("best score").ToString();
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
        ScoreAndCurrencyDisplay();
    }

    public void AddScore()
    {
        score++;
        PlayerPrefs.SetInt("player dollars", dollarAmount);
    }

    public void AddDollar()
    {
        dollarAmount++;
    }

    public void ScoreAndCurrencyDisplay()
    {
        scoreTextTop.text = score.ToString();
        scoreTextLostMenu.text = score.ToString();
        dollarText.text = dollarAmount.ToString();

        if (score > PlayerPrefs.GetInt("best score", 0))
        {
            PlayerPrefs.SetInt("best score", score);
            scoreTextBest.text = score.ToString();
        }
    }

}
