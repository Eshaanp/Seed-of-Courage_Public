using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeTextBox : MonoBehaviour
{

    public bool isCollision = false;

    public GameObject plot;

    public GameObject destroyText;
    public GameObject plantText;
    public GameObject currentText;
   

    public void Start()
    {
        plantText.SetActive(false);
        destroyText.SetActive(false);
        
    }


    private void OnTriggerEnter(Collider other)
    {

            isCollision = true;
            

    }

    private void OnTriggerStay(Collider other)
    {
        currentText.SetActive(false);
        if (plot.GetComponent<PlantSpawn>().isPlanted == false)
        {
            
            currentText = plantText;
            //currentText.SetActive(true);
        }
        if (plot.GetComponent<PlantSpawn>().isPlanted == true)
        {
            
            currentText = destroyText;
            //currentText.SetActive(true);
        }
        currentText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        isCollision = false;
        currentText.SetActive(false);
        
    }


}
