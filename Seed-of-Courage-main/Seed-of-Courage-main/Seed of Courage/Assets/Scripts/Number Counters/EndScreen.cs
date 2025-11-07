using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{

    //Fun Stats
    public TextMeshProUGUI dayText;
    public TextMeshProUGUI plotNumText;
    public TextMeshProUGUI cowDeath;
    public TextMeshProUGUI harvestText;
    public TextMeshProUGUI plantedText;
    public TextMeshProUGUI gradeLetter;


    //day, plotNum
    public GameObject dayManager;

    public GameObject player;

    private string grade;



    // Update is called once per frame
    void Update()
    {
        dayText.text = "Days Survived: " + dayManager.GetComponent<DayManager>().day;

        plotNumText.text = "Plots Remaining: " + dayManager.GetComponent<DayManager>().plotAmount;

        cowDeath.text = "Cows Killed: " + player.GetComponent<PlayerStats>().cowsDead;

        harvestText.text = "Crops Harvested: " + + player.GetComponent<PlayerStats>().harvested;

        plantedText.text = "Crops Planted: " + player.GetComponent<PlayerStats>().planted;



        gradeLetter.text = Grade();



    }


    public string Grade()
    {
        
        int plotNum = dayManager.GetComponent<DayManager>().plotAmount;

        if(plotNum >= 7)
        {
            grade = "A";
        }
        else if(plotNum == 6 || plotNum == 5)
        {
            grade = "B";
        }
        else if (plotNum == 3 || plotNum == 4)
        {
            grade = "C";
        }
        else if (plotNum == 1 || plotNum == 2)
        {
            grade = "D";
        }
        else if (plotNum == 0)
        {
            grade = "F";
        }

        return grade;

    }

    public void GoToTitle()
    {
        Time.timeScale = 1;
        gameObject.SetActive(true);
        SceneManager.LoadScene("MainMenu");
    }

}
