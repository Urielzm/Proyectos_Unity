using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform spawnPoint;

    public GameObject bullet;

    public float shotForce = 1500f;
    public float shotRate = 0.5f;

    private float shotReateTime = 0f;

    // Update is called once per frame
    void Update()
    {
        //Input.GetKeyDown(KeyCode.)
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet;
            newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        }
        
    }
}
