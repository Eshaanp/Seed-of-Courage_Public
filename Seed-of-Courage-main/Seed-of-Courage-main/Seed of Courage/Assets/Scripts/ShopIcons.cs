using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopIcons : MonoBehaviour
{

    public GameObject barnTrig;

    private void Start()
    {
        gameObject.SetActive(false);
    }
    
    void Update()
    {
        if(barnTrig.GetComponent<Store>().isInShop == true)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }



    }
}
