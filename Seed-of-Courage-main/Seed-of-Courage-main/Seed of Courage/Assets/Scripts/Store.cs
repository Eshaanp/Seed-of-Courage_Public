using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public GameObject player;

    public bool isInShop = false;

    public bool isTrig = false;

    public GameObject shop;

    public GameObject plotShop;

    //Day manager
    public GameObject checkIfDay;

    //weapons
    public GameObject crossbow;
    private int crossLvl = 0;

    public GameObject axe;
    private int axeLvl = 0;

    //weapon upgrade buttons
    public Button weapon1_button;
    public Button weapon2_button;


    public void Start()
    {
        shop.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown("b") && checkIfDay.GetComponent<DayManager>().isDay == true)
        {
            // OpenShop();

            if (isTrig)
            {
                OpenShop();

            }
            else
            {
                CloseShop();

            }

        }
    }


    private void OnTriggerEnter(Collider other)
    {

        isTrig = true;

    }
    private void OnTriggerExit(Collider other)
    {

        isTrig = false;

    }



    public void OpenShop()
    {
        shop.SetActive(true);
        Time.timeScale = 0;
        isInShop = true;

    }
    public void CloseShop()
    {
        shop.SetActive(false);
        Time.timeScale = 1;
        isInShop = false;
    }

    //if weapon increases level, upgrade weapon damage probably 
    public void upgradeWeapon1()
    {
        int weaponLevel = player.GetComponent<PlayerStats>().weaponLevel;
        int weaponPrice = player.GetComponent<PlayerStats>().weaponUpgradePrice;
        int playerMoney = player.GetComponent<PlayerStats>().money;

        int difference = playerMoney - weaponPrice;

        if(difference >= 0)
        {
            player.GetComponent<PlayerStats>().money = difference;
            player.GetComponent<PlayerStats>().weaponLevel++;
            player.GetComponent<AxeAnimation>().isUpgraded = true;
            weapon1_button.interactable = false;
            
        }
        else
        {
            //add "unable to purchase" text later
        }

    }

    public void upgradeWeapon2()
    {
        int weaponLevel = player.GetComponent<PlayerStats>().weaponLevel;
        int weaponPrice = player.GetComponent<PlayerStats>().weaponUpgradePrice;
        int playerMoney = player.GetComponent<PlayerStats>().money;

        int difference = playerMoney - weaponPrice;

        if (difference >= 0)
        {

            if (crossLvl < 2)
            {
                player.GetComponent<PlayerStats>().money = difference;
                player.GetComponent<PlayerStats>().weaponLevel++;
                crossbow.GetComponent<Crossbow>().bulletTime -= .2f;
                crossLvl++;
            }
            if (crossLvl >= 2)
            {
                weapon2_button.interactable = false;
            }
        }
        else
        {
            //add "unable to purchase" text later
        }
    }

        //no mechanism to show seeds yet, the seeds go to inventory ideally 
    public void buySeed1()
    {
        int seedPrice = player.GetComponent<PlayerStats>().seedPrice1;
        int playerMoney = player.GetComponent<PlayerStats>().money;

        int difference = playerMoney - seedPrice;

        if (difference >= 0)
        {
            player.GetComponent<PlayerStats>().money = difference;
            player.GetComponent<PlayerStats>().plantAmount_1++;


            
        }
        else
        {
            //add "unable to purchase" text later
        }

    }

    public void buySeed2()
    {
        int seedPrice = player.GetComponent<PlayerStats>().seedPrice2;
        int playerMoney = player.GetComponent<PlayerStats>().money;

        int difference = playerMoney - seedPrice;

        if (difference >= 0)
        {
            player.GetComponent<PlayerStats>().money = difference;
            player.GetComponent<PlayerStats>().plantAmount_2++;

        }
        else
        {
            //add "unable to purchase" text later
        }

    }


    public void buySeed3()
    {
        int seedPrice = player.GetComponent<PlayerStats>().seedPrice3;
        int playerMoney = player.GetComponent<PlayerStats>().money;

        int difference = playerMoney - seedPrice;

        if (difference >= 0)
        {
            player.GetComponent<PlayerStats>().money = difference;
            player.GetComponent<PlayerStats>().plantAmount_3++;

        }
        else
        {
            //add "unable to purchase" text later
        }
    }

    public void buySeed4()
    {
        int seedPrice = player.GetComponent<PlayerStats>().seedPrice4;
        int playerMoney = player.GetComponent<PlayerStats>().money;

        int difference = playerMoney - seedPrice;

        if (difference >= 0)
        {
            player.GetComponent<PlayerStats>().money = difference;
            player.GetComponent<PlayerStats>().plantAmount_4++;

        }
        else
        {
            //add "unable to purchase" text later
        }

    }

    public void buyAmo()
    {
        int amoPrice = player.GetComponent<PlayerStats>().amoPrice;
        int playerMoney = player.GetComponent<PlayerStats>().money;

        int difference = playerMoney - amoPrice;

        if (difference >= 0)
        {
            player.GetComponent<PlayerStats>().money = difference;
            player.GetComponent<PlayerStats>().amo += 30;

        }
        else
        {
            //add "unable to purchase" text later
        }

    }

    public void OpenPlotShop()
    {
        shop.SetActive(false);
        plotShop.SetActive(true);
    }



}
