using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{

    public float delay = 3f;

    //Es variable privada por defecto
    float countdown;

    public float radius = 5;
    public float explosionForce = 70;

    bool exploded = false;



    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0 && exploded == false)
        {
            Exploded();
            exploded = true;
        }

    }

    void Exploded()
    {
        //Guardamos todos losobjetos dentro de un array
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        
        /*
         * Por cada objeto del array vamos a seleccionar su RigidBody si no es nulo le 
         * agregamos una fuerza de explosión.
         */
        foreach(var rangeObjects in colliders)
        {
            Rigidbody rb = rangeObjects.GetComponent<Rigidbody>();
            if(rb != null)
            {
                //Agregar una fuerza de impulso desde una explosion, nos puide una fuerza, pocisión y un radio
                rb.AddExplosionForce(explosionForce * 10, transform.position, radius);
            }

        }
        Destroy(gameObject);
    }

}
