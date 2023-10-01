using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventScript : MonoBehaviour
{
    public AudioSource wallSFX;

    public void PlayGame(int difficultySelected)
    {
        Options.difficulty = difficultySelected;
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit(); 
    }
}
