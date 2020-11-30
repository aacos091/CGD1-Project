using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicManager>().playMenuMusic();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void LoadScoresMenu()
    {
        SceneManager.LoadScene("ScoresMenu");
    }
}
