using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{

    public NavMeshAgent naveMeshAgent;

    public GameObject destination1;

    public GameObject destination2;

    // Start is called before the first frame update
    void Start()
    {
       naveMeshAgent.destination = destination1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //naveMeshAgent.destination = destination1.transform.position;
        float distance = Vector3.Distance(transform.position, destination1.transform.position);

        if (distance < 2 )
        {
            naveMeshAgent.destination = destination2.transform.position;
        }

    }
}
