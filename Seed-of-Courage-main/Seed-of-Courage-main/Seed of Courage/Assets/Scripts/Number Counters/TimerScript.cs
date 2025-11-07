using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TimerScript : MonoBehaviour
{


    public float time = 45;

    //public bool timerOn = true;

    public TextMeshProUGUI timerDisplay;

    public GameObject dayManager;

    void Start()
    {
        
    }

    
    void Update()
    {

        if(dayManager.GetComponent<DayManager>().isDay == true)
        {
            if(time > 0)
            {
                time -= Time.deltaTime;
                updateTime(time);
            }
            else
            {
                
            }
        }
        else if (dayManager.GetComponent<DayManager>().isDay == false)
        {
            timerDisplay.text = " ";
        }

    }

    private void updateTime(float time)
    {
        int seconds = Mathf.FloorToInt(time % 60);
        int minute = Mathf.FloorToInt(time / 60);

        string t = minute + ":" + seconds;

        timerDisplay.text = t;
    }


    public void resetTimer()
    {
        time = 45;
        
        
    }



}
