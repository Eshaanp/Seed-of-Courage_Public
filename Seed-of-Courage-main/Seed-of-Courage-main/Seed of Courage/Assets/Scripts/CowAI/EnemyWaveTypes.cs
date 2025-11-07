
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaveTypes : MonoBehaviour
{
    //cow types
    public GameObject basicCow;
    public GameObject Cower;
    public GameObject giantCow;
    public GameObject flyingCow;
    public GameObject Cowch;

    //spawnpoints
    public GameObject spawnPoint_1;
    public GameObject spawnPoint_2;
    public GameObject spawnPoint_3;
    public GameObject spawnPoint_4;
    public GameObject spawnPoint_5;
    public GameObject spawnPoint_6;

    public GameObject spawnCenter;

    //list of things to spawn for particular wave 
    //private List<GameObject> spawnList;

    public int amountPerWave = 0;
    public int deathPerWave = 0;


    // Update is called once per frame
    void Update()
    {

    }

    //list of 5-7 basic cows
    public void wave1()
    {
        //clearList();
        int ranSpawn = Random.Range(5, 8); //max exclusive


        for (int i = 0; i < ranSpawn; i++)
        {
            Vector3 v = spawnPosition();
            //spawnList.Add(basicCow);
            GameObject c = Instantiate(basicCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }


        //return spawnList;
    }


    //list of 2-3 basic cows + 2-3 flying cows 
    public void wave2()
    {
        //clearList();

        int basicCowAmount = Random.Range(2, 4);
        int flyingCowAmount = Random.Range(2, 4);

        for (int i = 0; i < basicCowAmount; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(basicCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }
        for (int i = 0; i < flyingCowAmount; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(flyingCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }

        //return spawnList;

    }

    //list of 2 Giant cows
    public void wave3()
    {
        //clearList();
        for (int i = 0; i < 2; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(giantCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }

        //return spawnList;

    }

    //3 cowers (shocking)
    public void wave4()
    {
        //clearList();
        for (int i = 0; i < 3; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(Cower, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }
      

    }

    //HARDER WAVES LVL 2 -------------------------------------

    //1 giant; 2 cowers (shocking), 2-4 flying cows
    public void wave5()
    {
        
        //1 giant
        Vector3 g = spawnPosition();
        GameObject giant = Instantiate(giantCow, g, spawnCenter.transform.rotation);
        giant.SetActive(true);
        amountPerWave++;

        //2 Cowers
        for (int i = 0; i < 2; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(Cower, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }

        //2-4 flying cows
        int flyingCowAmount = Random.Range(2, 5);
        for (int i = 0; i < flyingCowAmount; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(flyingCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }


        

    }

    //2-3 basic cows, 2-3 flying cows, 2-3 cowers
    public void wave6()
    {
        

        int basicCowAmount = Random.Range(2, 4);
        int flyingCowAmount = Random.Range(2, 4);
        int cowerAmount = Random.Range(2, 4);

        //2-4 basic
        for (int i = 0; i < basicCowAmount; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(basicCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }
        //2-4 flying
        for (int i = 0; i < flyingCowAmount; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(flyingCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }
        //2-4 cower
        for (int i = 0; i < cowerAmount; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(Cower, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }


    }


    //3-4 Giants
    public void wave7()
    {
        
        int giantCowAmount = Random.Range(3, 5);

        for (int i = 0; i < giantCowAmount; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(giantCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }

    }

    //4-6 basic and flying
    public void wave8()
    {
        

        int basicCowAmount = Random.Range(4, 7);
        int flyingCowAmount = Random.Range(4, 7);

        for (int i = 0; i < basicCowAmount; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(basicCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }
        for (int i = 0; i < flyingCowAmount; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(flyingCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }

        


    }

    //BOSS WAVES FROM HERE

    //1 cowch
    public void wave9()
    {
        spawnCenter = spawnPoint_2;
        Vector3 v = new Vector3(spawnPoint_2.transform.position.x, 0, spawnPoint_2.transform.position.z);
        GameObject c = Instantiate(Cowch, v, spawnCenter.transform.rotation);
        c.SetActive(true);
        amountPerWave++;


    }

    //1 cowch + 4 flying Cows 
    public void wave10()
    {

        for (int i = 0; i < 4; i++)
        {

            Vector3 v = spawnPosition();
            GameObject c = Instantiate(flyingCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }
        spawnCenter = spawnPoint_2;
        Vector3 b = new Vector3(spawnPoint_2.transform.position.x, 0, spawnPoint_2.transform.position.z);
        GameObject g = Instantiate(Cowch, b, spawnCenter.transform.rotation);
        g.SetActive(true);
        amountPerWave++;

    }

    //20 basics
    public void wave11()
    {

        for (int i = 0; i < 20; i++)
        {
            Vector3 v = spawnPosition();
            GameObject c = Instantiate(basicCow, v, spawnCenter.transform.rotation);
            c.SetActive(true);
            amountPerWave++;
        }

    }

    //4 couch
    public void wave12()
    {

        for (int i = 0; i < 4; i++)
        {
            Vector3 b = spawnPosition();
            GameObject g = Instantiate(Cowch, b, spawnCenter.transform.rotation);
            g.SetActive(true);
            amountPerWave++;
        }

    }






    public Vector3 spawnPosition()
    {

        int spawnPoint = Random.Range(1, 7);



        if (spawnPoint == 1)
        {
            spawnCenter = spawnPoint_1;
        }
        else if (spawnPoint == 2)
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

        float x_Offset = Random.Range(-35, 35);
        float z_Offset = Random.Range(-35, 35);

        Vector3 spawnHere = new Vector3(spawnCenter.transform.position.x + x_Offset, 0, spawnCenter.transform.position.z + z_Offset);

        return spawnHere;
        //Instantiate(cow, spawnHere, spawnCenter.transform.rotation);



    }


}
