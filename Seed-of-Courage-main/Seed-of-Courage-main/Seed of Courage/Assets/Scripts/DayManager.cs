using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DayManager : MonoBehaviour
{


    //day num + if day
    public int day = 1;
    public bool isDay = true;

    //amount of active plots
    public int plotAmount;

    //timer and day cycle scripts
    public GameObject spawner;
    public GameObject dayCycleScript;
    public GameObject timer;
    
    //for enemy upgrades
    public GameObject enemy;

    //weapons
    public GameObject Axe; public GameObject cross;
    public bool isChangeWeapon = false;
    public bool axeActive = true;

    //end screen
    public GameObject endscreen;

    //music tracks
    public GameObject dayTheme_1;
    public GameObject dayTheme_2;
    public GameObject battleTheme;

    // plot 1 
    public Button plot1Button;


    void Start()
    {
        //spawner.GetComponent<SpawnCow>().SpawningCows(day);
       
        Axe.SetActive(true);
        cross.SetActive(true);
    

       plot1Button.interactable = false;
       StartCoroutine(changeDay());
    }

    // Update is called once per frame
    void Update()
    {
        
 

    }

    //main basically
    IEnumerator changeDay()
    {
        Debug.Log("day: " + day);
        
        for (int i = 0; i < 29; i++)
        {
            //2 min for day, isday is True, set day music
            setMusic();
            yield return new WaitForSeconds(45f);
            //setMusic();

            /*
            if (day == 8 || day == 15 || day == 22)
            {
                enemy.GetComponent<CowStatUpGrade>().upgrade();
            }*/

            yield return new WaitForSeconds(2f);
            
            
            isDay = false;

            switchSky();
            yield return new WaitForSeconds(2f);
            setMusic();

            //isDay should be false
            yield return new WaitForSeconds(3f);
            Debug.Log("end wait");
            spawner.GetComponent<SpawnCow>().SpawningCows(day);

            //condition to be met b4 switching to day
            //yield return new WaitUntil(() => isDay == true);
       

            if (isDay == false)
            {
                yield return new WaitUntil(() => isDay == true);
            }

            //isday should be true
            if(isDay == true)
            {
                yield return new WaitForSeconds(2f);
                switchSky();
                
                timer.GetComponent<TimerScript>().resetTimer();
            }
            day++;

            //if 0 plots or day = 29
            if(plotAmount <= 0 || day >= 29)
            {
                yield return new WaitForSeconds(3);
                break;
            }



     

        }
        //noMusic();
        Time.timeScale = 0;
        endscreen.SetActive(true);
        //Cursor.lockState = CursorLockMode.Confined;


    }

    public void setMusic()
    {
        if(isDay == true)
        {
            int ran = Random.Range(0, 2);
            if(ran == 0)
            {
                dayTheme_1.GetComponent<AudioSource>().enabled = false;
                dayTheme_2.GetComponent<AudioSource>().enabled = true;
                battleTheme.GetComponent<AudioSource>().enabled = false;
            }
            else
            {
                dayTheme_1.GetComponent<AudioSource>().enabled = true;
                dayTheme_2.GetComponent<AudioSource>().enabled = false;
                battleTheme.GetComponent<AudioSource>().enabled = false;
            }
   
        }
        else if (isDay == false)
        {
            dayTheme_1.GetComponent<AudioSource>().enabled = false;
            dayTheme_2.GetComponent<AudioSource>().enabled = false;
            battleTheme.GetComponent<AudioSource>().enabled = true;
        }

    }
    public void noMusic()
    {
        dayTheme_1.GetComponent<AudioSource>().enabled = false;
        dayTheme_2.GetComponent<AudioSource>().enabled = false;
        battleTheme.GetComponent<AudioSource>().enabled = false;
    }


    IEnumerator nightDuration(float second)
    {

        yield return new WaitForSeconds(second);

    }


    IEnumerator wait(float second)
    {

        yield return new WaitForSeconds(second);
        
    }
    IEnumerator weaponChange()
    {
        isChangeWeapon = true;
        
        yield return new WaitForSeconds(1f);

        if(axeActive == true)
        {
            axeActive = false;
            Axe.SetActive(false);
            //Axe.GetComponent<Animator>().enabled = false;

            cross.SetActive(true);
            //cross.GetComponent<Animator>().enabled = true;
        }
        else if(axeActive == false)
        {
            axeActive = true;
            Axe.SetActive(true);
            //Axe.GetComponent<Animator>().enabled = true;
            cross.SetActive(false);
            //cross.GetComponent<Animator>().enabled = false;
        }
        isChangeWeapon = false;



    }
    private void switchSky()
    {
        dayCycleScript.GetComponent<DayNightCycle>().cycle();
    }

    



}
