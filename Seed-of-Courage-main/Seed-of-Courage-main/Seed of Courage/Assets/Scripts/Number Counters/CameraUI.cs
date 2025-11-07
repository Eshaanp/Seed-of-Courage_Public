using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraUI : MonoBehaviour
{



    public TextMeshProUGUI dayText;
    public TextMeshProUGUI plotNumText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI axeText;
    public TextMeshProUGUI crossText;
    public TextMeshProUGUI amoText;

    public TextMeshProUGUI seedText_1;
    public TextMeshProUGUI seedText_2;
    public TextMeshProUGUI seedText_3;
    public TextMeshProUGUI seedText_4;

    //day, plot #, 
    public GameObject dayManager;

    //amo, money
    public GameObject player;

    //damage
    public GameObject axe;
    public GameObject bullet;



    // Update is called once per frame
    void Update()
    {

        dayText.text = "Day: " + dayManager.GetComponent<DayManager>().day;

        plotNumText.text = dayManager.GetComponent<DayManager>().plotAmount + " plots Remaining";

        moneyText.text = "$" + player.GetComponent<PlayerStats>().money;

        amoText.text = "Amo: " + player.GetComponent<PlayerStats>().amo;

        axeText.text = "Axe Damage: " + axe.GetComponent<AxeDamage>().axeDamage;

        crossText.text = "Bow Damage: " + bullet.GetComponent<ArrowScript>().arrowDamage;

        //seeds
        seedText_1.text = "" + player.GetComponent<PlayerStats>().plantAmount_1;
        seedText_2.text = "" + player.GetComponent<PlayerStats>().plantAmount_2;
        seedText_3.text = "" + player.GetComponent<PlayerStats>().plantAmount_3;
        seedText_4.text = "" + player.GetComponent<PlayerStats>().plantAmount_4;


    }
}
