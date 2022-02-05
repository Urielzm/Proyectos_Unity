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
            if (Time.time > shotReateTime)
            {
                GameObject newBullet;
                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                //Toma la bala que hemos instanciado comprueba que tenemos Rigidbody y le damos fuerza
                //Le damos un vector hacia adelante desde nuestro punto spawnPoint
                //Y lo multiplicamos por nuestra fuerza.
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

                shotReateTime = Time.time + shotRate;


                /*
                 Para destruir las balas
                 */
                Destroy(newBullet, 5);

            }
        }
        
    }
}
