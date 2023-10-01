using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogicScript : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public TMP_Text player1ScoreText;
    public TMP_Text player2ScoreText;
    public GameObject pauseText;
    public GameObject quitText;
    public BallScript ballScript;
    public AudioSource pauseSFX;
    public AudioSource unPauseSFX;
    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale > 0)
            {
                PauseGame();
            } else
            {
                UnpauseGame();
            }
        }

        if (Input.GetKeyDown(KeyCode.Q) && isPaused)
        {
            Application.Quit();
        }
    }

    public void addToScore(int playerNumber)
    {
        if (playerNumber == 1)
        {
            player1Score++;
            player1ScoreText.text = player1Score.ToString();
        } else
        {
            player2Score++;
            player2ScoreText.text = player2Score.ToString();
        }
    }

    public void PauseGame()
    {
        isPaused = true;

        pauseText.SetActive(true);
        quitText.SetActive(true);

        pauseSFX.Play();
        Time.timeScale = 0;
    }

    public void UnpauseGame()
    {
        isPaused = false;

        pauseText.SetActive(false);
        quitText.SetActive(false);

        unPauseSFX.Play();
        Time.timeScale = 1;
    }
}
