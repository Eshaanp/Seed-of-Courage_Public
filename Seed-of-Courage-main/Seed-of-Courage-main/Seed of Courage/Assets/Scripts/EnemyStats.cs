using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    //This script should be attached to the HITBOX object, not the enemy model
    public GameObject Player;

    public GameObject dayMananger;

    public GameObject enemy;

    public GameObject enemyModel;

    public GameObject spawnCowScript;

    public HealthBar healthbar;

    public bool isHit = false;

    public GameObject soundEffects;

    //basic cow stats
    public int MaxHealth = 20;
    public int Health = 20;

    
    

    // Start is called before the first frame update
    void Start()
    {
        //enemyModel.GetComponent<Outline>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damage)
    {
        soundEffects.GetComponent<SoundEffects>().play(1);
        Health = Health - damage;
        
        //StartCoroutine(outline());

        updateHealthBar();
        if (Health <= 0)
        {
            Death();
        }
        
    }

    public void updateHealthBar()
    {
        healthbar.updateHealth(Health, MaxHealth);
    }

    public void Death()
    {
        StartCoroutine(death());
        //increase a counter here
        //spawnCowScript.GetComponent<EnemyWaveTypes>().deathPerWave++;
        /*
        if(spawnCowScript.GetComponent<EnemyWaveTypes>().deathPerWave == spawnCowScript.GetComponent<EnemyWaveTypes>().amountPerWave)
        {
            spawnCowScript.GetComponent<EnemyWaveTypes>().deathPerWave = 0;
            spawnCowScript.GetComponent<EnemyWaveTypes>().amountPerWave = 0;

            //get day counter later
            spawnCowScript.GetComponent<SpawnCow>().endWave(dayMananger.GetComponent<DayManager>().day);
        }*/

    }

    IEnumerator death()
    {
        soundEffects.GetComponent<SoundEffects>().play(0);
        enemy.GetComponent<Animator>().Play("deathAnimation");

        yield return new WaitForSeconds(.5f);
        Destroy(enemy);

        //yield for cows
        Player.GetComponent<PlayerStats>().money += 20;

        enemy.GetComponent<Animator>().Play("New State");

        spawnCowScript.GetComponent<EnemyWaveTypes>().deathPerWave++;

        Player.GetComponent<PlayerStats>().cowsDead++;

        //enemy.GetComponent<Animator>().Play("New State");
        if (spawnCowScript.GetComponent<EnemyWaveTypes>().deathPerWave == spawnCowScript.GetComponent<EnemyWaveTypes>().amountPerWave)
        {
            spawnCowScript.GetComponent<EnemyWaveTypes>().deathPerWave = 0;
            spawnCowScript.GetComponent<EnemyWaveTypes>().amountPerWave = 0;

            //get day counter later
            spawnCowScript.GetComponent<SpawnCow>().endWave(dayMananger.GetComponent<DayManager>().day);
        }

    }




    /*IEnumerator outline()
    {
        enemyModel.GetComponent<Outline>().enabled = true;
        yield return new WaitForSeconds(.5f);
        enemyModel.GetComponent<Outline>().enabled = false;
        */



}
