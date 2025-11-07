using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSpawn : MonoBehaviour
{
    
    public Transform spawnPos;

    public GameObject player;


    //plants
    public GameObject plant1;
    public GameObject plant2;
    public GameObject plant3;
    public GameObject plant4;

    public GameObject plantingUI;

    //own plot
    public GameObject plot;
    //plot set
    public GameObject plotSet;

    public GameObject currentPlant;

    public bool isInPlantUi = false; 
    public bool isPlanted = false;
    public bool isCollide = false;
    public int plantType = 0;

    private int harvestAmount;

    public GameObject checkIfDay;

    public void Start()
    {
        plantingUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("f") && isPlanted == false && isCollide == true && checkIfDay.GetComponent<DayManager>().isDay == true)
        {
            OpenPlantUI();


        }
        if (Input.GetKeyDown("f") && isPlanted == true && isCollide == true && checkIfDay.GetComponent<DayManager>().isDay == true)
        {

            Destroy(currentPlant);
            isPlanted = false;
            player.GetComponent<PlayerStats>().money = player.GetComponent<PlayerStats>().money + harvest();
            player.GetComponent<PlayerStats>().numOfPlants--;
            player.GetComponent<PlayerStats>().harvested++;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        isCollide = true;

    }

    private void OnTriggerExit(Collider other)
    {
        isCollide = false;
    }

    public void OpenPlantUI()
    {
        plantingUI.SetActive(true);
        Time.timeScale = 0;
        isInPlantUi = true;
        player.GetComponent<PlayerStats>().inPlantUI = true;
    }
    public void ClosePlantUI()
    {
        Debug.Log("close ui");
        plantingUI.SetActive(false);
        Time.timeScale = 1;
        isInPlantUi = false;
        player.GetComponent<PlayerStats>().inPlantUI = false;
    }


    //harvesting Plants
    public int harvest()
    {
        int level = currentPlant.GetComponent<PlantBehavior>().plantLevel;
        

        switch (level)
        {
            case 0:
                harvestAmount = 0;
                break;
            case 1:
                harvestAmount = 5;
                break;
            case 2:
                harvestAmount = 10;
                break;
            case 3:
                harvestAmount = 15;
                break;
        }

        return harvestAmount;
    }

    public void planting1()
    {
        int amount = player.GetComponent<PlayerStats>().plantAmount_1;

        if (amount - 1 >= 0)
        {
            currentPlant = (GameObject) Instantiate(plant1, spawnPos.position, spawnPos.rotation);
            currentPlant.SetActive(true);
            isPlanted = true;
            player.GetComponent<PlayerStats>().numOfPlants++;
            player.GetComponent<PlayerStats>().plantAmount_1--;

            player.GetComponent<PlayerStats>().planted++;

            //axe
            player.GetComponent<PlayerStats>().axeUpgradeLevel++;
            player.GetComponent<PlayerStats>().UpdateAxe();
        }
        else
        {
            //Print "Not Enough!" or smth
        }

        ClosePlantUI();
    }
    public void planting2()
    {
        int amount = player.GetComponent<PlayerStats>().plantAmount_2;

        if (amount - 1 >= 0)
        {
            currentPlant = (GameObject)Instantiate(plant2, spawnPos.position, spawnPos.rotation);
            currentPlant.SetActive(true);
            isPlanted = true;
            player.GetComponent<PlayerStats>().numOfPlants++;
            player.GetComponent<PlayerStats>().plantAmount_2--;

            player.GetComponent<PlayerStats>().planted++;
            //speed
            if (player.GetComponent<FirstMovement>().speed < 60)
            {
                player.GetComponent<FirstMovement>().speed += 3;
            }
        }
        else
        {
            //Print "Not Enough!" or smth
        }
        ClosePlantUI();

    }

    public void planting3()
    {
        Debug.Log("plant1 3");
        int amount = player.GetComponent<PlayerStats>().plantAmount_3;

        if (amount - 1 >= 0)
        {
            currentPlant = (GameObject)Instantiate(plant3, spawnPos.position, spawnPos.rotation);
            currentPlant.SetActive(true);
            isPlanted = true;
  
            player.GetComponent<PlayerStats>().numOfPlants++;
            player.GetComponent<PlayerStats>().plantAmount_3--;

            player.GetComponent<PlayerStats>().planted++;
            //plot health increase +10
            plotSet.GetComponent<PlotDamage>().healPLot(10);

        }
        else
        {
            //Print "Not Enough!" or smth
        }
        ClosePlantUI();

    }

    public void planting4()
    {
        int amount = player.GetComponent<PlayerStats>().plantAmount_4;

        if (amount - 1 >= 0)
        {
            currentPlant = (GameObject)Instantiate(plant4, spawnPos.position, spawnPos.rotation);
            currentPlant.SetActive(true);
            isPlanted = true;
            player.GetComponent<PlayerStats>().numOfPlants++;
            player.GetComponent<PlayerStats>().plantAmount_4--;

            player.GetComponent<PlayerStats>().planted++;
            //cross bow
            player.GetComponent<PlayerStats>().crossUpgradeLevel++;
            player.GetComponent<PlayerStats>().UpdateCross();
        }
        else
        {
            //Print "Not Enough!" or smth
        }
        ClosePlantUI();

    }


}
