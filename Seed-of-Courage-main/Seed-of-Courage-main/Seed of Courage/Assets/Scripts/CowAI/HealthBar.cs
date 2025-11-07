using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    [SerializeField] private Slider bar;
    [SerializeField] private Camera cam;
    [SerializeField] private Transform target;


    // Update is called once per frame
    void Update()
    {
        transform.rotation = cam.transform.rotation;
    }

    public void updateHealth(float currentValue, float maxValue)
    {
        bar.value = currentValue / maxValue;
    }


}
