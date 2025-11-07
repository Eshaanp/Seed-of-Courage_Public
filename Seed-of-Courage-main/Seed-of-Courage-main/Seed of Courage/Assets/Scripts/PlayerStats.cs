using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Stats for player, can include
    //weapon levels, money, item count, etc

    public GameObject Axe;
    public GameObject Bullet;

    public int money;

    public int amo = 30;
    public int amoPrice = 5;

    public bool inPlantUI = false;

    //Plant Price Variables

    public int seedPrice1 = 5;

    public int seedPrice2 = 5;

    public int seedPrice3 = 5;

    public int seedPrice4 = 5;



    //Amount of each type of plant
    public int plantAmount_1 = 0;

    public int plantAmount_2 = 0;

    public int plantAmount_3 = 0;

    public int plantAmount_4 = 0;

    //Weapon Varibles
    public int weaponUpgradePrice = 10;

    public int weaponLevel = 0;


    //other
    public int numOfPlants = 0;


    //damage upgrades
    public int axeUpgradeLevel = 0;
    public int crossUpgradeLevel = 0;


    //num of plants harvested + planted
    public int harvested = 0;
    public int planted = 0;

    //cows killed
    public int cowsDead = 0;


    public void UpdateAxe()
    {
        
        if (axeUpgradeLevel < 4)
        {
            Axe.GetComponent<AxeDamage>().axeDamage = 8;
        }
        else if (axeUpgradeLevel >= 4 && axeUpgradeLevel < 8)
        {
            Axe.GetComponent<AxeDamage>().axeDamage = 12;
        }
        else if (axeUpgradeLevel >= 8)
        {
            Axe.GetComponent<AxeDamage>().axeDamage = 16;
        } 
    }
    public void UpdateCross()
    {
        if (axeUpgradeLevel < 4)
        {
            Bullet.GetComponent<ArrowScript>().arrowDamage = 2;
        }
        else if (axeUpgradeLevel >= 4 && axeUpgradeLevel < 8)
        {
            Bullet.GetComponent<ArrowScript>().arrowDamage = 4;
        }
        else if (axeUpgradeLevel >= 8)
        {
            Bullet.GetComponent<ArrowScript>().arrowDamage = 6;
        }
    }



}
