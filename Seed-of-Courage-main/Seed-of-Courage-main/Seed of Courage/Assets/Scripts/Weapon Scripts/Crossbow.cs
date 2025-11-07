using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle;

public class Crossbow : MonoBehaviour
{
    public GameObject bow;

    public GameObject player;

    public Transform bulletSpawnPoint;
    public GameObject bullet;
    public float bulletSpeed = 10;

    public bool isOnCooldown = false;

    public float bulletTime = .5f;

    public GameObject soundEffect;

    //public int bulletAmount = 30;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && bow.active == true && isOnCooldown == false && player.GetComponent<PlayerStats>().amo > 0)
        {
            player.GetComponent<PlayerStats>().amo--;

            isOnCooldown = true;

            var arrow = Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            arrow.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.up * bulletSpeed;
            

            StartCoroutine(Shoot());

            Destroy(arrow, 3.5f);
        }
    }

    private void shootBullet()
    {
    }

    IEnumerator Shoot()
    {
        soundEffect.GetComponent<SoundEffects>().play(2);
        bow.GetComponent<Animator>().Play("crossbow2");
        yield return new WaitForSeconds(bulletTime);
        //var arrow = Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        //arrow.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.up * bulletSpeed;
        isOnCooldown = false;
        
        bow.GetComponent<Animator>().Play("New State");

    }



}
