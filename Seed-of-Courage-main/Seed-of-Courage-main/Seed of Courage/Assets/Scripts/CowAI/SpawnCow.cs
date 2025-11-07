using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;



public class SpawnCow : MonoBehaviour
{
    //potential spawn positions
    /*
    public GameObject spawnPoint_1;
    public GameObject spawnPoint_2;
    public GameObject spawnPoint_3;
    public GameObject spawnPoint_4;
    public GameObject spawnPoint_5;
    public GameObject spawnPoint_6;
    */

    public GameObject spawnCenter;

    public GameObject DayManager;

    //Cow types
    

    //Wave type scripts 
    public GameObject waveTypeObj;

    //will interact with deathperWave in Cow Stats (Prob usless now)
    //public int numPerWave = 0;
    //public int deathPerWave = 0;


    //list of things to spawn for particular wave 
    private List<GameObject> cowlist;

    

    public bool twoWave = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawningCows(int day)
    {

        if (day < 7)
        {
            //1 easy
            twoWave = false;

            //cowlist.Clear();

            Debug.Log("day = x<7---" + day);
            easySpawns();
            //waveTypeObj.GetComponent<EnemyWaveTypes>().wave1();
            /*for(int i = 0; i < cowlist.Count; i++)
            {
                spawnPosition(cowlist[i]);
                cowlist[i].SetActive(true);
                numPerWave++;
            }*/
        }
        if (7 < day && day < 14)
        {
            twoWave = false;
            Debug.Log("day = 7<x<14");
            hardSpawns();

        }
        if (14 < day && day < 21)
        {
            twoWave = true;
            Debug.Log("day = 14<x<21");
            int ran = Random.Range(1, 11);

            if(ran <= 3)
            {
                easySpawns();
            }
            else
            {
                hardSpawns();
            }

            // 1 easy + 1 hard; 30/70 chance
        }

        if (21 < day && day < 28)
        {
            // 2 hard
            twoWave = true; ;
            
            hardSpawns();
        }
        if (day == 7)
        {
            twoWave = false;
            waveTypeObj.GetComponent<EnemyWaveTypes>().wave9();
        }
        if (day == 14)
        {
            twoWave = false;
            waveTypeObj.GetComponent<EnemyWaveTypes>().wave10();
        }
        if (day == 21)
        {
            twoWave = false;
            waveTypeObj.GetComponent<EnemyWaveTypes>().wave11();
        }
        if (day == 28)
        {
            twoWave = false;
            waveTypeObj.GetComponent<EnemyWaveTypes>().wave12();
        }

    }


    /*
    //call the moment when i wanna spawn cow in code
    public void spawnPosition(GameObject cow)
    {

        int spawnPoint = Random.Range(1, 7);

        

        if(spawnPoint == 1)
        {
            spawnCenter = spawnPoint_1;
        } 
        else if( spawnPoint == 2)
        {
            spawnCenter = spawnPoint_2;
        }
        else if (spawnPoint == 3)
        {
            spawnCenter = spawnPoint_3;
        }
        else if (spawnPoint == 4)
        {
            spawnCenter = spawnPoint_4;
        }
        else if (spawnPoint == 5)
        {
            spawnCenter = spawnPoint_5;
        }
        else if (spawnPoint == 6)
        {
            spawnCenter = spawnPoint_6;
        }

        float x_Offset = Random.Range(-70, 70);
        float z_Offset = Random.Range(-70, 70);

        Vector3 spawnHere = new Vector3(spawnCenter.transform.position.x + x_Offset, spawnCenter.transform.position.z + z_Offset);


        Instantiate(cow, spawnHere, spawnCenter.transform.rotation);



    }*/


    public void endWave(int day)
    {
        Debug.Log("end wave");
        Debug.Log("twoWave: " + twoWave + "---day: " + day);
        if (twoWave == true)
        {
            Debug.Log("end wave; day: " + day);
            twoWave = false;
            SpawningCowsPart_2(day);
        }
        else
        {
            DayManager.GetComponent<DayManager>().isDay = true;
        }



    }

    private void SpawningCowsPart_2(int day)
    {
        if (14 < day && day < 21)
        {
            //cowlist.Clear();
            int ran = Random.Range(1, 11);

            if (ran <= 3)
            {
                easySpawns();

            }
            else
            {
                hardSpawns();
            }
        }

        if (21 < day && day < 28)
        {

            //cowlist.Clear(); 
            hardSpawns();
            /*
            for (int i = 0; i < cowlist.Count; i++)
            {
                spawnPosition(cowlist[i]);
                numPerWave++;
            }*/
        }

    }



    //cows for days 1-6
    public void easySpawns()
    {
        int randomWave = Random.RandomRange(1, 5);

        switch (randomWave)
        {
            case 1:
                waveTypeObj.GetComponent<EnemyWaveTypes>().wave1();
                break;

            case 2:

               waveTypeObj.GetComponent<EnemyWaveTypes>().wave2();
                break;

            case 3:
                waveTypeObj.GetComponent<EnemyWaveTypes>().wave3();
                break;

            case 4:
                waveTypeObj.GetComponent<EnemyWaveTypes>().wave4();
                break;

        }


    }

    //cows for days 8-13
    public void hardSpawns()
    {
        int randomWave = Random.RandomRange(1, 5);

        switch (randomWave)
        {
            case 1:
                waveTypeObj.GetComponent<EnemyWaveTypes>().wave5();
                break;

            case 2:
                waveTypeObj.GetComponent<EnemyWaveTypes>().wave6();
                break;

            case 3:
                waveTypeObj.GetComponent<EnemyWaveTypes>().wave7();
                break;

            case 4:
                waveTypeObj.GetComponent<EnemyWaveTypes>().wave8();
                break;

        }

    }
}
