using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlotPricing : MonoBehaviour
{

    public GameObject plotUi;

    public TextMeshProUGUI displayText;

    private int price;

    // Update is called once per frame
    void Update()
    {
        int price = plotUi.GetComponent<PlotShop>().plotPrice;
        // counterText.text = "$" + counter.ToString();
        displayText.text = "Price of Next Plot Purchase: $" + price.ToString();

    }
}
