using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;

public class PlantBehavior : MonoBehaviour
{

    public GameObject plant;
    Vector3 scale;
    int plantSize = 0;
    public int plantLevel = 0;
    public int plantHealth = 10;

    public bool isGrowing = false;


    public GameObject DayManager;

    public int firstDay;
    public int currentDay;

    private void Start()
    {
        firstDay = DayManager.GetComponent<DayManager>().day;
    }

    // Update is called once per frame
    void Update()
    {
        currentDay = DayManager.GetComponent<DayManager>().day;

        if(currentDay - firstDay != 0)
        {
            firstDay = currentDay;
            isGrowing = true;
        }

        if (isGrowing == true)
        {
            if (plantSize < 3)
            {
                grow();
                isGrowing = false;
            }
            plantSize++;
        } 
    }



    private void grow()
    {
        scale = transform.localScale;
        scale.x += .3f;
        scale.y += .3f;
        scale.z += .3f;
        transform.localScale = scale;

        plantLevel++;
    }





        












}
