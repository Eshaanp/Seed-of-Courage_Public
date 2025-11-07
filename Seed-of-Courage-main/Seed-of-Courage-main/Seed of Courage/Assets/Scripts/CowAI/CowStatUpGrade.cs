using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowStatUpGrade : MonoBehaviour
{
    public GameObject dayManager;

    public GameObject basicCow;
    public GameObject Cower;
    public GameObject giantCow;
    public GameObject flyingCow;
    public GameObject Cowch;


    public GameObject basicCow_Hitbox;
    public GameObject Cower_Hitbox;
    public GameObject giantCow_Hitbox;
    public GameObject flyingCow_Hitbox;
    public GameObject Cowch_Hitbox;

    public bool firstUpgrade = false;
    public bool secondUpgrade = false;
    public bool thridUpgrade = false;


    private void Update()
    {
        if (dayManager.GetComponent<DayManager>().day == 8 && firstUpgrade == false)  
        {
            upgrade();
            firstUpgrade = true;
        }
        if (dayManager.GetComponent<DayManager>().day == 15 && secondUpgrade == false)
        {
            upgrade();
            secondUpgrade = true;
        }
        if (dayManager.GetComponent<DayManager>().day == 22 && thridUpgrade == false)
        {
            upgrade();
            thridUpgrade = true;
        }
    }

    public void upgrade()
    {
        basicCow.GetComponent<AI_Test>().cowAttack += 1;
        basicCow_Hitbox.GetComponent<EnemyStats>().Health += 5;
        basicCow_Hitbox.GetComponent<EnemyStats>().MaxHealth += 5;

        Cower.GetComponent<AI_Test>().cowAttack += 4;
        basicCow_Hitbox.GetComponent<EnemyStats>().Health += 5;
        basicCow_Hitbox.GetComponent<EnemyStats>().MaxHealth += 5;

        giantCow.GetComponent<AI_Test>().cowAttack += 5;
        giantCow_Hitbox.GetComponent<EnemyStats>().Health += 6;
        giantCow_Hitbox.GetComponent<EnemyStats>().MaxHealth += 6;

        flyingCow.GetComponent<AI_Test>().cowAttack += 5;
        flyingCow_Hitbox.GetComponent<EnemyStats>().Health += 2;
        flyingCow_Hitbox.GetComponent<EnemyStats>().MaxHealth += 2;

        Cowch.GetComponent<AI_Test>().cowAttack += 2;
        Cowch_Hitbox.GetComponent<EnemyStats>().Health += 5;
        Cowch_Hitbox.GetComponent<EnemyStats>().MaxHealth += 5;
    }




}
