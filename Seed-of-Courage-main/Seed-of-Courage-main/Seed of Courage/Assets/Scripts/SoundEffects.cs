using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.LowLevel.InputStateHistory;

public class SoundEffects : MonoBehaviour
{

    public GameObject moo;          //0
    public GameObject cowDamage;    //1
    public GameObject harvest;      //2

    private void Start()
    {
        moo.GetComponent<AudioSource>().enabled = false;
        cowDamage.GetComponent<AudioSource>().enabled = false;
        harvest.GetComponent<AudioSource>().enabled = false;
    }
    public void play(int type)
    {
        if(type == 0)
        {
            StartCoroutine(playCow());
        }
        if (type == 1)
        {
            StartCoroutine(playCowDamage());
        }
        if (type == 2)
        {
            StartCoroutine(playHarvest());
        }
    }

    IEnumerator playCow()
    {
        moo.GetComponent<AudioSource>().enabled = true;
        yield return new WaitForSeconds(1);
        moo.GetComponent<AudioSource>().enabled = false;
    }
    
    IEnumerator playCowDamage()
    {
        cowDamage.GetComponent<AudioSource>().enabled = true;
        yield return new WaitForSeconds(1);
        cowDamage.GetComponent<AudioSource>().enabled = false;
    }
    IEnumerator playHarvest()
    {
        harvest.GetComponent<AudioSource>().enabled = true;
        yield return new WaitForSeconds(1);
        harvest.GetComponent<AudioSource>().enabled = false;
    }


}
