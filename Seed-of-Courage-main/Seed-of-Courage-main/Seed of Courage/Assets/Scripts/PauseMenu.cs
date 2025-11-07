using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool isGamePaused = false;
    public GameObject pauseMenu;
    public GameObject rulesUI;

    public bool inRulesUi = false;

    public void Start()
    {
        pauseMenu.SetActive(false);
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isGamePaused = true;

    }
    public void ContinueGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isGamePaused = false;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && inRulesUi == false)
        {
            if (isGamePaused)
            {
                ContinueGame();
                Debug.Log("Game should NOT be paused rn");
            }
            else
            {
                PauseGame();
                Debug.Log("Game should be paused rn");
            }
        }
    }


    public void openRules()
    {
        rulesUI.SetActive(true);
        inRulesUi = true;

    }
    public void closeRules()
    {
        rulesUI.SetActive(false);
        inRulesUi = false;

    }
}
