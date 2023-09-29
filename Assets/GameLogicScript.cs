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
    public BallScript ballScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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
}
