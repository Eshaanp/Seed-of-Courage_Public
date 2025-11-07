using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SeedHotbar : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public TextMeshProUGUI strength;
    [SerializeField] public TextMeshProUGUI speed;
    [SerializeField] public TextMeshProUGUI health;
    [SerializeField] public TextMeshProUGUI bullet;
    public PlayerStats playerStats;

    void Start()
    {
        // strength.text = "1";
    }

    // Update is called once per frame
    void Update()
    {
        strength.text = "" + playerStats.plantAmount_1;
        speed.text = "" + playerStats.plantAmount_2;
        health.text = "" + playerStats.plantAmount_3;
        bullet.text = "" + playerStats.plantAmount_4;
    }
}
