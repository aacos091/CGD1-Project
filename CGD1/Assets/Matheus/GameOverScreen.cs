using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadScoresMenu()
    {
        SceneManager.LoadScene("ScoresMenu");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("KitchenLevel");
    }
    public void SewerLevel()
    {
        SceneManager.LoadScene("SewerLevel");
    }
}
