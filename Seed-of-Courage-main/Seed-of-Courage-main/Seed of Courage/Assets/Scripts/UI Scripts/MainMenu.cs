using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject rulesUI;
    public bool inRulesUi = false;

    public void PlayGame()
    {   
        if(inRulesUi == false) { 
            SceneManager.LoadScene("Level 1"); 
        }
       
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openRules()
    {
        rulesUI.SetActive(true);
        mainMenu.SetActive(false);
        inRulesUi = true;

    }
    public void closeRules()
    {
        rulesUI.SetActive(false);
        mainMenu.SetActive(true);
        inRulesUi = false;

    }

}
