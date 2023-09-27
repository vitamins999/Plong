using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2GoalScript : MonoBehaviour
{
    public GameLogicScript GameLogicScript;
    public BallScript BallScript;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        GameLogicScript.addToScore(2);
        BallScript.ResetPosition();
    }
}
