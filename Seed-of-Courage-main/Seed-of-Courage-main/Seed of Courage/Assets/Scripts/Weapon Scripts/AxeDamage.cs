using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle;

public class AxeDamage : MonoBehaviour
{

    public GameObject axeAnimation;

    public int axeDamage = 2;

    

    public bool isTouch = false;

    public bool isDealingDamage = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && axeAnimation.GetComponent<AxeAnimation>().isSwinging == true)
        {
            if (isDealingDamage)
            {

                isDealingDamage = false;
                Debug.Log(axeDamage);

                isTouch = true;
                collision.gameObject.GetComponent<EnemyStats>().takeDamage(axeDamage);

                StartCoroutine(DamageWait());
            }
        }
    } 

    /*
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Enemy" && axeAnimation.GetComponent<AxeAnimation>().isSwinging == true)
        {
            if (isDealingDamage)
            {

                isDealingDamage = false;
                Debug.Log(axeDamage);

                isTouch = true;
                other.GetComponent<EnemyStats>().takeDamage(axeDamage);

                StartCoroutine(DamageWait());
            }
        }
    }
    */

    IEnumerator DamageWait()
    {
        
        yield return new WaitForSeconds(.5f);
        isDealingDamage = true;
        

    }

    private void OnTriggerExit(Collider other)
    {
        
    }

}
