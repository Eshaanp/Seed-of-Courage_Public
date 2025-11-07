using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine;

public class AxeAnimation : MonoBehaviour
{
    
    public GameObject Axe;
    public GameObject chestTrigger;


    public int axedamage = 5;

    public bool isSwinging = false;

    public bool isUpgraded = false;
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && Axe.active == true)
        {
            isSwinging = true;
            StartCoroutine(AxeSwing());
        }
        if (isUpgraded == true && Input.GetKeyDown("e") && Axe.active == true)
        {
            isSwinging = true;
            StartCoroutine(AxeThrow());
        }
    }

    IEnumerator AxeSwing()
    {
        Axe.GetComponent<Animator>().Play("AxeTest_1");
        yield return new WaitForSeconds(.5f);
        isSwinging = false;
        Axe.GetComponent<Animator>().Play("New State");
        
    }
    IEnumerator AxeThrow()
    {
        Axe.GetComponent<Animator>().Play("AxeThrow");
        yield return new WaitForSeconds(.5f);
        isSwinging = false;
        Axe.GetComponent<Animator>().Play("New State");

    }




}
