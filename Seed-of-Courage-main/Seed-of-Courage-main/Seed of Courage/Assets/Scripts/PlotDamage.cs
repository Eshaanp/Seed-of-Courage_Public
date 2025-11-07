using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
//using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlotDamage : MonoBehaviour
{
    [SerializeField] public int plotSetNum;

    //day manager for plot amount
    public GameObject dayManager;

    //health of Plot
    public int MaxPlotHealth = 100;
    public int plotHealth = 100;

    //healthbar of Plot
    public HealthBar healthbar;

    //plots in this set
    public GameObject plot_1;
    public GameObject plot_2;
    public GameObject plot_3;
    public GameObject plot_4;

    //plot shop ui
    public GameObject plotShop;

    public bool isDead;
  

    // Update is called once per frame
    void Update()
    {

    }

    public void takeDamage(int damage)
    {
        plotHealth = plotHealth - damage;
        updateHealthBar();
        destroyPlot();
    }

    public void healPLot(int heal)
    {
        plotHealth = plotHealth + heal;

    }

    public void updateHealthBar()
    {
        healthbar.updateHealth(plotHealth, MaxPlotHealth);
    }
    public void destroyPlot()
    {
        if (plotHealth <= 0)
        {
            //destroy plants on plots
            if(plot_1.GetComponent<PlantSpawn>().currentPlant != null)
            {
                Destroy(plot_1.GetComponent<PlantSpawn>().currentPlant);
            }
            if (plot_2.GetComponent<PlantSpawn>().currentPlant != null)
            {
                Destroy(plot_2.GetComponent<PlantSpawn>().currentPlant);
            }
            if (plot_3.GetComponent<PlantSpawn>().currentPlant != null)
            {
                Destroy(plot_3.GetComponent<PlantSpawn>().currentPlant);
            }
            if (plot_4.GetComponent<PlantSpawn>().currentPlant != null)
            {
                Destroy(plot_4.GetComponent<PlantSpawn>().currentPlant);
            }
            
            //set plot inactive, decrease plot amount, restore button in plotShop

            gameObject.SetActive(false);
            dayManager.GetComponent<DayManager>().plotAmount--;

            gameObject.GetComponent<PlotDamage>().healthbar.GetComponent<Slider>().value = 1;

            isDead = true;
            resetHealth();
            plotShop.GetComponent<PlotShop>().restoreButton(plotSetNum);

            

            
        }

        //destroy all plants on the plot
        //deactive plot
        //make it possible to buy again
    }

    public void resetHealth()
    {
        int max = MaxPlotHealth;
        plotHealth = max;
    }

}
