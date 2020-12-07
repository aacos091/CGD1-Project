using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoresMenu : MonoBehaviour
{
    public Text scoreText;

    void Update() 
    {
        scoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
