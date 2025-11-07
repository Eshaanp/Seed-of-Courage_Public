using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class PlotShop : MonoBehaviour
{
    public GameObject dayManager;
    public GameObject plotShop;
    public GameObject generalShop;
    public GameObject player;
    //public GameObject plotHealth;

    //1
    public Button plot1Button;
    public GameObject plot_1;
    //2
    public Button plot2Button;
    public GameObject plot_2;
    //3
    public Button plot3Button;
    public GameObject plot_3;
    //4
    public Button plot4Button;
    public GameObject plot_4;
    //5
    public Button plot5Button;
    public GameObject plot_5;
    //6
    public Button plot6Button;
    public GameObject plot_6;
    //7
    public Button plot7Button;
    public GameObject plot_7;
    //8
    public Button plot8Button;
    public GameObject plot_8;




    public int plotPrice = 20;



    // Start is called before the first frame update
    void Start()
    {
        //plot_1.SetActive(true);
        
    }


    public void ClosePlotShop()
    {
        plotShop.SetActive(false);
        generalShop.SetActive(true);

    }
    public void buyPlot1()
    {
        int playerMoney = player.GetComponent<PlayerStats>().money;

        if (playerMoney - plotPrice >= 0)
        {
            player.GetComponent<PlayerStats>().money = playerMoney - plotPrice;

            if (plotPrice < 100)
            {
                plotPrice = plotPrice + 20;
            }
            plot_1.SetActive(true);
            plot_1.GetComponent<PlotDamage>().isDead = false;
           // plot_1.GetComponent<PlotDamage>().resetHealth();

            plot1Button.interactable = false;
            dayManager.GetComponent<DayManager>().plotAmount++;

        }
        else
        {
            //Print "Not Enough!" or smth
        }

    }
    public void buyPlot2()
    {
        int playerMoney = player.GetComponent<PlayerStats>().money;
       
        if (playerMoney - plotPrice >= 0)
        {
            player.GetComponent<PlayerStats>().money = playerMoney - plotPrice;

            if (plotPrice < 100)
            {
                plotPrice = plotPrice + 20;
            }
            plot_2.SetActive(true);
            plot_2.GetComponent<PlotDamage>().isDead = false;
            //plot_2.GetComponent<PlotDamage>().resetHealth();
            plot2Button.interactable = false;
            dayManager.GetComponent<DayManager>().plotAmount++;
        }
        else
        {
            //Print "Not Enough!" or smth
        }

    }
    public void buyPlot3()
    {
        int playerMoney = player.GetComponent<PlayerStats>().money;

        if (playerMoney - plotPrice >= 0)
        {
            player.GetComponent<PlayerStats>().money = playerMoney - plotPrice;

            plotPrice = plotPrice + 20;

            plot_3.SetActive(true);
            plot_3.GetComponent<PlotDamage>().isDead = false;
            //  plot_3.GetComponent<PlotDamage>().resetHealth();
            plot3Button.interactable = false;
            dayManager.GetComponent<DayManager>().plotAmount++;
        }
        else
        {
            //Print "Not Enough!" or smth
        }
    }
    public void buyPlot4()
    {
        int playerMoney = player.GetComponent<PlayerStats>().money;

        if (playerMoney - plotPrice >= 0)
        {
            player.GetComponent<PlayerStats>().money = playerMoney - plotPrice;

            plotPrice = plotPrice + 20;

            plot_4.SetActive(true);
            plot_4.GetComponent<PlotDamage>().isDead = false;
            //plot_4.GetComponent<PlotDamage>().resetHealth();

            plot4Button.interactable = false;
            dayManager.GetComponent<DayManager>().plotAmount++;
        }
        else
        {
            //Print "Not Enough!" or smth
        }
    }
    public void buyPlot5()
    {
        int playerMoney = player.GetComponent<PlayerStats>().money;

        if (playerMoney - plotPrice >= 0)
        {
            player.GetComponent<PlayerStats>().money = playerMoney - plotPrice;

            plotPrice = plotPrice + 20;

            plot_5.SetActive(true);
            plot_5.GetComponent<PlotDamage>().isDead = false;
            //plot_5.GetComponent<PlotDamage>().resetHealth();
            plot5Button.interactable = false;
            dayManager.GetComponent<DayManager>().plotAmount++;
        }
        else
        {
            //Print "Not Enough!" or smth
        }
    }
    public void buyPlot6()
    {
        int playerMoney = player.GetComponent<PlayerStats>().money;

        if (playerMoney - plotPrice >= 0)
        {
            player.GetComponent<PlayerStats>().money = playerMoney - plotPrice;

            plotPrice = plotPrice + 20;

            plot_6.SetActive(true);
            plot_6.GetComponent<PlotDamage>().isDead = false;
            //plot_6.GetComponent<PlotDamage>().resetHealth();
            plot6Button.interactable = false;
            dayManager.GetComponent<DayManager>().plotAmount++;
        }
        else
        {
            //Print "Not Enough!" or smth
        }
    }
    public void buyPlot7()
    {
        int playerMoney = player.GetComponent<PlayerStats>().money;

        if (playerMoney - plotPrice >= 0)
        {
            player.GetComponent<PlayerStats>().money = playerMoney - plotPrice;

            plotPrice = plotPrice + 20;

            plot_7.SetActive(true);
            plot_7.GetComponent<PlotDamage>().isDead = false;
            //plot_7.GetComponent<PlotDamage>().plotHealth = plot_7.GetComponent<PlotDamage>().MaxPlotHealth;
            plot7Button.interactable = false;
            dayManager.GetComponent<DayManager>().plotAmount++;
        }
        else
        {
            //Print "Not Enough!" or smth
        }
    }
    public void buyPlot8()
    {
        int playerMoney = player.GetComponent<PlayerStats>().money;

        if (playerMoney - plotPrice >= 0)
        {
            player.GetComponent<PlayerStats>().money = playerMoney - plotPrice;

            plotPrice = plotPrice + 20;

            plot_8.SetActive(true);
            plot_8.GetComponent<PlotDamage>().isDead = false;
            // plot_8.GetComponent<PlotDamage>().resetHealth();
            plot8Button.interactable = false;
            dayManager.GetComponent<DayManager>().plotAmount++;
        }
        else
        {
            //Print "Not Enough!" or smth
        }
    }


    public void restoreButton(int plotSetNum)
    {
        switch (plotSetNum)
        {
            case 1:
                plot1Button.interactable = true;
                break;
            case 2:
                plot2Button.interactable = true;
                break;
            case 3:
                plot3Button.interactable = true;
                break;
            case 4:
                plot4Button.interactable = true;
                break;
            case 5:
                plot5Button.interactable = true;
                break;
            case 6:
                plot6Button.interactable = true;
                break;
            case 7:
                plot7Button.interactable = true;
                break;
            case 8:
                plot8Button.interactable = true;
                break;

        }
    }
}
