using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

    //make it so pressing 'c' cycles the sky to day/night

    //store light source
    [SerializeField] private Light sun;

    //store time of day
    [SerializeField, Range(0,24)] private float timeOfDay = 12f;

    //variable to store the speed of rotation
    [SerializeField] private float sunRotationSpeed;

    //lighting presets
    [Header("LightingPresent")]
    [SerializeField] private Gradient skyColor;
    [SerializeField] private Gradient equatorColor;
    [SerializeField] private Gradient sunColor;

    private bool isCycle = false;

    private void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            Debug.Log("c key was pressed");
            //isCycle = true;
        }
        if (isCycle == true)
        {
            Debug.Log(" testing  ");

            changeSky();
            /*
            timeOfDay += Time.deltaTime * sunRotationSpeed;
            if (timeOfDay >= 24)
            {

                timeOfDay = 0;

            }
            UpdateSunRotation();
            UpdateLighting();
            
            //switches between night and day
            if (timeOfDay == 0) 
            {
                isCycle = false;
            }
            if(timeOfDay > 11 && timeOfDay < 12)
            {
                timeOfDay = 12;
                isCycle = false;
            }
            */
        }

    }


    //change sky
    public void changeSky()
    {
        timeOfDay += Time.deltaTime * sunRotationSpeed;
        if (timeOfDay >= 24)
        {

            timeOfDay = 0;

        }
        UpdateSunRotation();
        UpdateLighting();

        //switches between night and day
        if (timeOfDay == 0)
        {
            isCycle = false;
        }
        if (timeOfDay > 11 && timeOfDay < 12)
        {
            timeOfDay = 12;
            isCycle = false;
        }
    }

    public void cycle()
    {
        isCycle = true;
    } 

    private void OnValidate()
    {
       // UpdateSunRotation();
       // UpdateLighting();
    }

    //sun rotation update
    private void UpdateSunRotation()
    {
        float sunRotation = Mathf.Lerp(-90, 270, timeOfDay / 24);
        sun.transform.rotation = Quaternion.Euler(sunRotation, sun.transform.rotation.y, sun.transform.rotation.z);

    }

    private void UpdateLighting()
    {
        float timeFraction = timeOfDay / 24;

        RenderSettings.ambientEquatorColor = equatorColor.Evaluate(timeFraction);
        RenderSettings.ambientSkyColor = skyColor.Evaluate(timeFraction);
        sun.color = sunColor.Evaluate(timeFraction);





    }





}
