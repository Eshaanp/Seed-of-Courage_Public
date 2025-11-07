using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
//using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.AI;
using static Cinemachine.DocumentationSortingAttribute;

public class AI_Test : MonoBehaviour
{
    public GameObject cow;
    public GameObject hitbox;

    public NavMeshAgent agent;

    //attack variables
    public bool canAttack = true;

    private int amountOfAttacks = 0;

    //while likely make new script to manage cow attacks across different types
    public int cowAttack = 5;

    //the plot we wanna go to
    public GameObject target;

    //array containing distances of each plot, inactive plots are 0
    private float[] distances = new float[8];




    //each plot
    public GameObject plot_1;
    public GameObject plot_2;
    public GameObject plot_3;
    public GameObject plot_4;
    public GameObject plot_5;
    public GameObject plot_6;
    public GameObject plot_7;
    public GameObject plot_8;

    //number of closest plot
    private int closestPlotNum = 0;

    
    private void Start()
    {

        int isRandomTarget = Random.Range(1,3);

        //0 = closest plot
        if (isRandomTarget == 0)
        {
            int plotNum = smallestDistance();
            determineTarget(plotNum);

        }
        //random plot
        else
        {


            createDistanceArr();

            List<int> test = new List<int>();
            int counter = 0;
     
            if(plot_1.GetComponent<PlotDamage>().isDead == false)
            {
                test.Add(1);
                counter++;
            }
            if (plot_2.GetComponent<PlotDamage>().isDead == false)
            {
                test.Add(2);
                counter++;
            }
            if (plot_3.GetComponent<PlotDamage>().isDead == false)
            {
                test.Add(3);
                counter++;
            }
            if (plot_4.GetComponent<PlotDamage>().isDead == false)
            {
                test.Add(4);
                counter++;
            }
            if (plot_5.GetComponent<PlotDamage>().isDead == false)
            {
                test.Add(5);
                counter++;
            }
            if (plot_6.GetComponent<PlotDamage>().isDead == false)
            {
                test.Add(6);
                counter++;
            }
            if (plot_7.GetComponent<PlotDamage>().isDead == false)
            {
                test.Add(7);
                counter++;
            }
            if (plot_8.GetComponent<PlotDamage>().isDead == false)
            {
                test.Add(8);
                counter++;
            }

            /*for (int i = 0; i < 8; i++)
            {
                //Debug.Log((1+i) + ": " + distances[i]);
                if (distances[i] != 0)
                {
                    test.Add(i+1);
                    
                    counter++;
                }
            }*/


            int ranPlot = (int) test[Random.Range(0, counter)];
            determineTarget(ranPlot);

        }
        //Debug.Log("Target: " + target.name.ToString());

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 point = new Vector3(target.transform.position.x + 58, target.transform.position.y, target.transform.position.z + 17);

        agent.SetDestination(point);

        

        if(agent.remainingDistance <= agent.stoppingDistance-10 && canAttack == true)
        {
            Debug.Log("Stoped");
            canAttack = false;

            StartCoroutine(CowAttack());
            //stop completely
            //play animation plus damage
        }

        //kills cow if plot dies
        if(target.GetComponent<PlotDamage>().isDead == true)
        {
            hitbox.GetComponent<EnemyStats>().Death();
        }
        
    }


    IEnumerator CowAttack()
    {

        cow.GetComponent<Animator>().Play("CowAttack_1");

        yield return new WaitForSeconds(2f);

        if (amountOfAttacks > 0)
        {
            target.GetComponent<PlotDamage>().takeDamage(cowAttack);
        }
        amountOfAttacks++;
        canAttack = true;
        cow.GetComponent<Animator>().Play("New State");
    }


    private float distance(GameObject cow, GameObject plot)
    {
        float x = (plot.transform.position.x - cow.transform.position.x) * (plot.transform.position.x - cow.transform.position.x);
        float z = (plot.transform.position.z - cow.transform.position.z) * (plot.transform.position.z - cow.transform.position.z);
        float dis = Mathf.Sqrt(x + z);
        return dis;
    }


    private void createDistanceArr()
    {
        if (plot_1.active == true)
        {
            distances[0] = distance(cow, plot_1);
        }
        if (plot_2.active == true)
        {
            distances[1] = distance(cow, plot_2);
        }
        if (plot_3.active == true)
        {
            distances[2] = distance(cow, plot_3);
        }
        if (plot_4.active == true)
        {
            distances[3] = distance(cow, plot_4);
        }
        if (plot_5.active == true)
        {
            distances[4] = distance(cow, plot_5);
        }
        if (plot_6.active == true)
        {
            distances[5] = distance(cow, plot_6);
        }
        if (plot_7.active == true)
        {
            distances[6] = distance(cow, plot_7);
        }
        if (plot_8.active == true)
        {
            distances[7] = distance(cow, plot_8);
        }
    }

    private int smallestDistance()
    {

        createDistanceArr();
        //if active, adds does distance formula for each plot
        /*
        if (plot_1.active == true)
        {
            distances[0] = distance(cow, plot_1);
        }
        if (plot_2.active == true)
        {
            distances[1] = distance(cow, plot_2);
        }
        if (plot_3.active == true)
        {
            distances[2] = distance(cow, plot_3);
        }
        if (plot_4.active == true)
        {
            distances[3] = distance(cow, plot_4);
        }
        if (plot_5.active == true)
        {
            distances[4] = distance(cow, plot_5);
        }
        if (plot_6.active == true)
        {
            distances[5] = distance(cow, plot_6);
        }
        if (plot_7.active == true)
        {
            distances[6] = distance(cow, plot_7);
        }
        if (plot_8.active == true)
        {
            distances[7] = distance(cow, plot_8);
        }
        */
        
        float currentDis = int.MaxValue;

        //determines closest active plot number
        for(int i = 0; i < 8; i++)
        {
            if (distances[i] < currentDis && !(distances[i] == null))
            {
                currentDis = distances[i];
                closestPlotNum = i;
                Debug.Log((i + 1) + "distance: " + distances[i]);
            }

        }

        return closestPlotNum;
    }



    private void determineTarget(int targetNum)
    {
        switch (targetNum)
        {
            case 1:
                target = plot_1;
                break;
            case 2:
                target = plot_2;
                break;
            case 3:
                target = plot_3;
                break;
            case 4:
                target = plot_4;
                break;
            case 5:
                target = plot_5;
                break;
            case 6:
                target = plot_6;
                break;
            case 7:
                target = plot_7;
                break;
            case 8:
                target = plot_8;
                break;


        }

     /* Might be useful
    float distance_1 = distance(cow, plot_1);
    float distance_2 = distance(cow, plot_2);
    float distance_3 = distance(cow, plot_3);
    float distance_4 = distance(cow, plot_4);
    float distance_5 = distance(cow, plot_5);
    float distance_6 = distance(cow, plot_6);
    float distance_7 = distance(cow, plot_7);
    float distance_8 = distance(cow, plot_8);
    */
    }

}
