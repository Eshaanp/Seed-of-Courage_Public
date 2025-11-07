using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour
{
    public GameObject player;



    public TextMeshProUGUI displayText;

    public int counter;

    // Update is called once per frame
    void Update()
    {
        int counter = player.GetComponent<PlayerStats>().money;
        // counterText.text = "$" + counter.ToString();
       displayText.text = "$" + counter.ToString();
    }
}
