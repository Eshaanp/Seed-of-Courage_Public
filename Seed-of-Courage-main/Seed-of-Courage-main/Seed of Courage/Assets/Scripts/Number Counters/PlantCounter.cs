using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlantCounter : MonoBehaviour
{
    enum PlantType // your custom enumeration
    {
        Plant1,
        Plant2,
    };

    [SerializeField]
    PlantType type = new PlantType();

    public GameObject player;

    public TextMeshProUGUI displayText;

    public int counter;

    // Update is called once per frame
    void Update()
    {
        /*
        if(type == PlantType.Plant1)
        {
            type1();
        }
        if (type == PlantType.Plant2)
        {
            type2();
        }*/

        int counter1 = player.GetComponent<PlayerStats>().plantAmount_1;
        int counter2 = player.GetComponent<PlayerStats>().plantAmount_2;
        int counter3 = player.GetComponent<PlayerStats>().plantAmount_3;
        int counter4 = player.GetComponent<PlayerStats>().plantAmount_4;

        displayText.text = "Plant 1 Amount: " + counter1.ToString() + " \nPlant 2 Amount: " + counter2.ToString() + " \n" + "Plant 3 Amount: " + counter3.ToString() + "\nPlant 4 Amount: " + counter4.ToString();


    }


    private void type1()
    {
        int counter = player.GetComponent<PlayerStats>().plantAmount_1;
        // counterText.text = "$" + counter.ToString();
        displayText.text = "Plant 1 \n Amount: " + counter.ToString();
    }
    private void type2()
    {
        int counter = player.GetComponent<PlayerStats>().plantAmount_2;
        // counterText.text = "$" + counter.ToString();
        displayText.text = "Plant 2 \n Amount: " + counter.ToString();
    }

    

}
